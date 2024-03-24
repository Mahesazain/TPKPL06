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
            if (title == null || title.Length > 100)
            {
                Console.WriteLine("Judul video memiliki panjang maksimal 100 karakter dan tidak berupa null.");
            }
            else {
                this.title = title;
                this.id = new Random().Next(10000, 99999); 
                this.playCount = 0;
            }
        }

        public void IncreasePlayCount(int count)
        {
            if (count < 0 || count > 10000000)
            {
                Console.WriteLine("Count harus diantara 0 sampai 10000000");
            }
            else
            {
                try
                {
                    checked
                    {
                        this.playCount += count;
                    }
                }
                catch (OverflowException)
                {
                    Console.WriteLine("PlayCount sudah maks.");
                }
            }
        }

        public void PrintVideoDetails()
        {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Title: " + title);
            Console.WriteLine("Play Count: " + playCount);
        }
    }
}
