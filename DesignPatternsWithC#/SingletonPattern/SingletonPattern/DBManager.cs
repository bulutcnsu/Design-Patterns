using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonPattern
{
    public class DBManager
    {
        private DBManager(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        private static DBManager _manager;
      
        public static DBManager CreateDbManager(string connectionString)
        {
            if (_manager == null)
            {
                _manager = new DBManager(connectionString);
            }

           
                return _manager;
            
        }

        public string ConnectionString { get; set; }
        public string StateMessage { get; set; }

    }
}
