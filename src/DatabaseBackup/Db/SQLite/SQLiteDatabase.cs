using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Afx.Data;
using System.Data.SQLite;

namespace DatabaseBackup.SQLite
{
    public class SQLiteDatabase : Database
    {
        public SQLiteDatabase(string connectionString)
            :base(connectionString, SQLiteFactory.Instance)
        {

        }

        public override string EncodeColumn(string column)
        {
            if (string.IsNullOrEmpty(column)) throw new ArgumentNullException(nameof(column));
            return $"[{column}]";
        }

        public override string EncodeParameterName(string name)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException(nameof(name));
            return $"@{name}";
        }
    }
}
