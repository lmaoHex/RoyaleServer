using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace RoyaleServer.Data
{
    class Store
    {
        private SQLiteConnection m_dbConnection;

        public Store(string DBName)
        {
            this.m_dbConnection =
                new SQLiteConnection($"Data Source={DBName}.sqlite;Version=3;");
            this.m_dbConnection.Open();
        }

        public void CreateDatabase(string DBName) =>
            SQLiteConnection.CreateFile(DBName + ".sqlite");

        public void CreateTable(string tableName, string columnTypes)
        {
            string sql = $"create table {tableName}({columnTypes})";

            SQLiteCommand createTable = new SQLiteCommand(sql, this.m_dbConnection);
            createTable.ExecuteNonQuery();
        }

        public void Insert(string tableName, string columns, string values)
        {
            string sql = $"insert into {tableName}({columns}) values ({values})";

            SQLiteCommand insertTable = new SQLiteCommand(sql, this.m_dbConnection);
            insertTable.ExecuteNonQuery();
        }

        public SQLiteDataReader SelectFrom(string table, string select, string query = "")
        {
            string sql = $"select {select} from {table}";
            if (query != "")
                sql += " " + query;

            SQLiteCommand dbQuery = new SQLiteCommand(sql, this.m_dbConnection);
            return dbQuery.ExecuteReader();
        }

        public SQLiteDataReader Execute(string query)
        {
            return new SQLiteCommand(query, this.m_dbConnection).ExecuteReader();
        }
    }
}
