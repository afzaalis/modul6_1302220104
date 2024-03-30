using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul6_1302220104
{
    internal class SayaTubeUser
    {
        private int id;
        private List<SayaTubeVideo> uploadVideos;
        public string username;

        public SayaTubeUser(string username)
        {
            this.username = username;
            this.uploadVideos = new List<SayaTubeVideo>();

            this.id = new Random().Next(10000, 100000);
        }
        public int GetTotalVideoPlayCount()
        {
            int total = 0;

            for (int i = 0; i < this.uploadVideos.Count;)
            {
                total += uploadVideos.ElementAt(i).getPlayCount();
                
            }
            return total;

        }
        public void addVideo(SayaTubeVideo vid)
        {

            this.uploadVideos.Add(vid);


        }
        public void printAllVideoPlaycount()
        {

            Console.WriteLine("user:" + this.username);
            for (int i = 0; i < 7;)
            {
                
                Console.WriteLine("video ke:" + i + uploadVideos[i]);


            }
        }
    }
}
