using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace DatabaseBackup.Schema
{
    /// <summary>
    /// 表结构接口
    /// </summary>
    public interface ITableSchema : IDisposable
    {
        /// <summary>
        /// 执行的 sql logs
        /// </summary>
        Action<string> Log { get; set; }

        /// <summary>
        /// 获取所有表名
        /// </summary>
        /// <returns></returns>
        List<string> GetTables();

        /// <summary>
        /// 创建表
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="columns">列信息</param>
        /// <returns>是否创建成功</returns>
        bool CreateTable(string table, List<ColumnInfoModel> columns);

        bool DeleteTable(string table);

            /// <summary>
            /// 获取表列信息
            /// </summary>
            /// <param name="table">表名</param>
            /// <returns>列信息</returns>
        List<ColumnInfoModel> GetTableColumns(string table);


        /// <summary>
        /// 添加索引
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="indexs">索引列</param>
        void AddIndex(string table, List<IndexModel> indexs);

        /// <summary>
        /// 添加索引
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="indexName">索引名称</param>
        /// <param name="isUnique">是否唯一索引</param>
        /// <param name="columns">索引列</param>
        /// <returns>是否添加成功</returns>
        bool AddIndex(string table, string indexName, bool isUnique, List<string> columns);

        /// <summary>
        /// 删除索引
        /// </summary>
        /// <param name="table">表名</param>
        /// <param name="index">索引名称</param>
        /// <returns></returns>
        bool DeleteIndex(string table, string index);


    }
}
