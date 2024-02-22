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

        Computer myComputer=new Computer()
        {
            MotherBoard="Z690",
            HasWifi=true,
            HasLTE=false,
            ReleaseDate=DateTime.Now,
            VideoCard="RTX 2060"
        };
        // string sqlCommand="SELECT GETDATE()";
        // DateTime rightNow=dbConnection.QuerySingle<DateTime>(sqlCommand);
        // Console.WriteLine(rightNow);string sqlCommand="SELECT GETDATE()";
        // DateTime rightNow=dbConnection.QuerySingle<DateTime>(sqlCommand);
        // Console.WriteLine(rightNow);

        //Inserting data in to table
        string sql=@"INSERT INTO TutorialAppSchema.Computer(
            Motherboard,
            HasWifi,
            HasLTE,
            ReleaseDate,
            VideoCard
            ) 
            VALUES(
                ' "+myComputer.MotherBoard+" ',' "+myComputer.HasWifi+" ',' "+myComputer.HasLTE+" ',' "+myComputer.ReleaseDate+"',' "+myComputer.VideoCard+"')";

        int result=dbConnection.Execute(sql);
        Console.WriteLine(sql);

        //getting data from table

        string sqlSelect=@"SELECT * from TutorialAppSchema.Computer";

        IEnumerable<Computer> computers=dbConnection.Query<Computer>(sqlSelect);

      foreach (Computer comp in computers)
{
    Console.WriteLine(
        "Motherboard: " + comp.MotherBoard + ", " +
        "HasWifi: " + comp.HasWifi + ", " +
        "HasLTE: " + comp.HasLTE + ", " +
        "ReleaseDate: " + comp.ReleaseDate + ", " +
        "VideoCard: " + comp.VideoCard
    );
}



        // Console.WriteLine(myComputer.MotherBoard);
        // Console.WriteLine(myComputer.HasLTE);
        // Console.WriteLine(myComputer.VideoCard);
    }
}


 
}