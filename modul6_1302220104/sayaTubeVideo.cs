using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220104
{
    internal class SayaTubeVideo
    {
        private int id;
        private string title;
        private int playCount;

        public SayaTubeVideo(string title)
        {
            this.title = title;
            
            this.playCount = 0;

        }
        public void IncreasePlayCount(int playCount)
        {
            try
            {
                checked
                {
                    this.playCount = playCount;
                    this.playCount += playCount;
                }
              }

            catch(Exception e) { 
                Console.WriteLine(e.Message);
            }
        }
        public void PrintVideosDetails()
        {

            Console.WriteLine("ID:" + this.id);
            Console.WriteLine("TITLE:" + this.title);
            Console.WriteLine("PlayCount:" + this.playCount);
        }
        public int getPlayCount()
        {
            return this.playCount;
        }
    }
}
