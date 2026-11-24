using System;
using System.Text;

namespace SingletonLibrary
{
    public sealed class Logger
    {
        private static Logger instance;
        private static readonly object _lock = new object();

        private string logFilePath;
        private DocumentSaver documentSaver;

        private Logger()
        {
            logFilePath = "system_logs.txt";
            documentSaver = DocumentSaver.getInstance();
        }

        public static Logger getInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new Logger();
                    }
                }
            }
            return instance;
        }

        public void logAction(string userId, string action)
        {
            byte[] existingBytes = documentSaver.getDocument(logFilePath);
            string currentLogs = Encoding.UTF8.GetString(existingBytes);

            string newEntry = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] [User: {userId}] {action}{Environment.NewLine}";
            byte[] updatedBytes = Encoding.UTF8.GetBytes(currentLogs + newEntry);

            documentSaver.saveDocument(logFilePath, updatedBytes);
        }

        public void clearLogs()
        {
            documentSaver.saveDocument(logFilePath, Array.Empty<byte>());
        }

        public string readLogsText()
        {
            byte[] bytes = documentSaver.getDocument(logFilePath);
            return Encoding.UTF8.GetString(bytes);
        }
    }
}