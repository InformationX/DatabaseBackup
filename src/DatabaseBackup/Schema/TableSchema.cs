using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DatabaseBackup.Schema
{
    /// <summary>
    /// 表结构接口
    /// </summary>
    public abstract class TableSchema : ITableSchema
    {
        /// <summary>
        /// 执行sql logs
        /// </summary>
        public abstract Action<string> Log { get; set; }

        /// <summary>
        /// 获取数据库所有表名
        /// </summary>
        /// <returns>数据库所有表名</returns>
        public abstract List<string> GetTables();

        /// <summary>
        /// 创建数据库表
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="columns">列信息</param>
        /// <returns>是否成功</returns>
        public abstract bool CreateTable(string table, List<ColumnInfoModel> columns);

        public abstract bool DeleteTable(string table);
        
        /// <summary>
        /// 添加索引
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="indexs">索引列信息</param>
        public abstract void AddIndex(string table, List<IndexModel> indexs);

        /// <summary>
        /// 添加索引
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="indexName">索引名称</param>
        /// <param name="isUnique">是否唯一索引</param>
        /// <param name="columns">列名</param>
        /// <returns>是否成功</returns>
        public abstract bool AddIndex(string table, string indexName, bool isUnique, List<string> columns);

        /// <summary>
        /// 获取表列信息
        /// </summary>
        /// <param name="table">表名</param>
        /// <returns>列信息</returns>
        public abstract List<ColumnInfoModel> GetTableColumns(string table);

        /// <summary>
        /// 释放资源
        /// </summary>
        public virtual void Dispose()
        {
            
        }

        public abstract bool DeleteIndex(string table, string index);
    }
}
