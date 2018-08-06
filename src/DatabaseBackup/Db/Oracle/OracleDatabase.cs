using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Afx.Data;
using Oracle.ManagedDataAccess.Client;

namespace DatabaseBackup.Oracle
{
    public class OracleDatabase : Database
    {
        public OracleDatabase(string connectionString)
            :base(connectionString, OracleClientFactory.Instance)
        {

        }

        public override string EncodeColumn(string column)
        {
            if (string.IsNullOrEmpty(column)) throw new ArgumentNullException(nameof(column));
            return $"\"{column}\"";
        }

        public override string EncodeParameterName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            return $":{name}";
        }
    }
}
