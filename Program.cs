using System.Dynamic;
using System.Data;
using dotnetProject_1.Models;
using Microsoft.Data.SqlClient;
using Dapper;
using dotnetProject_1.Data;

namespace dotnetProject_1
{
internal class Program
{
    static void Main(string[] args)
    {
        DataContextDapper dapper = new DataContextDapper();

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
        string sql = @"INSERT INTO TutorialAppSchema.Computer(Motherboard,HasWifi,HasLTE,ReleaseDate,VideoCard) 
                    VALUES('ABC','true','false','2024-02-23','NVidea')";

        dapper.ExecuteSql(sql);
        Console.WriteLine(sql);

        //getting data from table

        string sqlSelect=@"SELECT * from TutorialAppSchema.Computer";

        IEnumerable<Computer> computers=dapper.LoadData<Computer>(sqlSelect);

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
    }
}


 
}