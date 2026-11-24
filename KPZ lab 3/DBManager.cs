using System;
using System.Collections.Generic;

namespace SingletonLibrary
{
    public sealed class DBManager
    {
        private static DBManager instance;
        private static readonly object _lock = new object();

        private string connectionString;
        private Logger logger;

        private readonly List<string> _executedQueries = new List<string>();
        private bool _isConnected;

        private DBManager()
        {
            connectionString = "Server=localhost;Database=Lab3_DB;Trusted_Connection=True;";
            logger = Logger.getInstance();
            _isConnected = true;

            logger.logAction("SYSTEM", $"DBManager ініціалізовано ({connectionString})");
        }

        public static DBManager getInstance()
        {
            if (instance == null)
            {
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new DBManager();
                    }
                }
            }
            return instance;
        }

        public void executeQuery(string sql)
        {
            if (!_isConnected)
            {
                _isConnected = true;
            }

            string record = $"{DateTime.Now:HH:mm:ss} -> {sql}";
            _executedQueries.Add(record);

            logger.logAction("DBManager", $"Виконано SQL-запит: {sql}");
        }

        public void closeConnection()
        {
            _isConnected = false;
            logger.logAction("DBManager", "З'єднання з базою даних закрито.");
        }

        public IReadOnlyList<string> getQueryHistory()
        {
            return _executedQueries.AsReadOnly();
        }
    }
}