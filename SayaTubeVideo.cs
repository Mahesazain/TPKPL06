using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP06_1302220105
{
    internal class SayaTubeVideo
    {
        int id;
        String title;
        int playCount;

        public SayaTubeVideo(String title)
        {
            this.title = title;
            this.id = new Random().Next(10000, 99999);
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            this.playCount += count;
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
