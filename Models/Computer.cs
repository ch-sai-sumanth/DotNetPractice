namespace dotnetProject_1.Models
{
    public class Computer
    {

    public string MotherBoard{get; set;}

    public int CPUCores{get; set;}

    public bool HasWifi{get;set;}

    public bool HasLTE{get; set;}

    public DateTime ReleaseDate{get; set;}

    public string VideoCard{get; set;}


        public Computer()   //constructor
        {
            if(MotherBoard==null)
            {
                MotherBoard="";
            }
            if(VideoCard==null)
            {
                VideoCard="";
            }
        }
    }
}