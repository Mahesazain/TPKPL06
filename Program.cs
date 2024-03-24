using TP06_1302220105;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program;

class Program
{
    public static void Main(string[] args)
    {
        SayaTubeVideo video = new SayaTubeVideo("Tutorial Design By Contract - [MAHESA]");
        video.PrintVideoDetails();

        for (int i = 0; i < 10000000; i++)
        {
            video.IncreasePlayCount(1);
        }

        video.PrintVideoDetails();
    }
}