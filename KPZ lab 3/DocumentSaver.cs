using System;
using System.IO;

namespace SingletonLibrary
{
    public sealed class DocumentSaver
    {
        private static DocumentSaver instance;
        private static readonly object _lock = new object();
        private string storagePath;

        private DocumentSaver()
        {
            storagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "DocumentsStorage");
            if (!Directory.Exists(storagePath))
            {
                Directory.CreateDirectory(storagePath);
            }
        }

        public static DocumentSaver getInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new DocumentSaver();
                    }
                }
            }
            return instance;
        }

        public bool saveDocument(string docName, byte[] content)
        {
            try
            {
                string fullPath = Path.Combine(storagePath, docName);
                File.WriteAllBytes(fullPath, content);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public byte[] getDocument(string docName)
        {
            string fullPath = Path.Combine(storagePath, docName);
            if (File.Exists(fullPath))
            {
                return File.ReadAllBytes(fullPath);
            }
            return Array.Empty<byte>();
        }
    }
}