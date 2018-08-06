using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using Afx.Data;
using MySql.Data.MySqlClient;

namespace DatabaseBackup.MySQL
{
    public class MySqlDatabase : Database
    {
        public MySqlDatabase(string connectionString)
            :base(connectionString, MySqlClientFactory.Instance)
        {

        }

        public override string EncodeColumn(string column)
        {
            if (string.IsNullOrEmpty(column)) throw new ArgumentNullException(nameof(column));
            return $"`{column}`";
        }

        public override string EncodeParameterName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            return $"?{name}";
        }

        public override DbDataAdapter CreateDataAdapter()
        {
            return new MySqlDataAdapter();
        }
    }
}
