using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace dotnetProject_1.Data;

public class DataContextDapper
{
    private string _connectionString =
        "Server=172.17.0.2;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=SA;Password=Test123!";


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

    public bool ExecuteSql(String sql)
    {
        IDbConnection dbConnection = new SqlConnection(_connectionString);
        return dbConnection.Execute(sql)>0?true:false;
    }
}