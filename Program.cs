using System.Dynamic;
using System.Data;
using dotnetProject_1.Models;
using Microsoft.Data.SqlClient;
using Dapper;

namespace dotnetProject_1
{
internal class Program
{
    static void Main(string[] args)
    {

        string connectionString="Server=172.17.0.3;Database=DotNetCourseDatabase;TrustServerCertificate=true;Trusted_Connection=false;User Id=SA;Password=Test123!";

        IDbConnection dbConnection=new SqlConnection(connectionString);
        string sqlCommand="SELECT GETDATE()";

        DateTime rightNow=dbConnection.QuerySingle<DateTime>(sqlCommand);

        Console.WriteLine(rightNow);

        Computer myComputer=new Computer()
        {
            MotherBoard="Z690",
            HasWifi=true,
            HasLTE=false,
            ReleaseDate=DateTime.Now,
            VideoCard="RTX 2060"
        };


        // Console.WriteLine(myComputer.MotherBoard);
        // Console.WriteLine(myComputer.HasLTE);
        // Console.WriteLine(myComputer.VideoCard);
    }
}


 
}