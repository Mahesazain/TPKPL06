using TP06_1302220105;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [MAHESA]");
        video.PrintVideoDetails();

        video.IncreasePlayCount(5);
        video.PrintVideoDetails();
    }
}