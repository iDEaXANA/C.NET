using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace C.NET.Data
{
    public class DataContextDapper
    {
        private string _connectionString = "Server=localhost;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=true";
        
        // For extracting table values
        public IEnumerable<T> LoadData<T>(string sql) 
        {
        IDbConnection dbConnection = new SqlConnection(_connectionString);
        return dbConnection.Query<T>(sql);  
        }
        public T LoadDataSingle<T>(string sql) 
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.QuerySingle<T>(sql);  
        }

        // For INSERT/UPDATE/DELETE
        public bool ExecuteSql(string sql) 
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return (dbConnection.Execute(sql) > 0);  
        }
        public int ExecuteSqlWithRows(string sql) 
        {
            IDbConnection dbConnection = new SqlConnection(_connectionString);
            return dbConnection.Execute(sql);  
        }
    }
}