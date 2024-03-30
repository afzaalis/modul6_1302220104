// See https://aka.ms/new-console-template for more information
using System;
using modul6_1302220104;

class Program
{
    static void Main(string[] args)
    {
        SayaTubeVideo vid1 = new SayaTubeVideo("jujutsu kaisen");
        SayaTubeVideo vid2 = new SayaTubeVideo("naruto");
        SayaTubeVideo vid3 = new SayaTubeVideo("one pis");
        SayaTubeVideo vid4 = new SayaTubeVideo("overflow");
        SayaTubeVideo vid5 = new SayaTubeVideo("secret class");
        SayaTubeVideo vid6 = new SayaTubeVideo("86");
        SayaTubeVideo vid7 = new SayaTubeVideo("evolution revole");
        SayaTubeVideo vid8 = new SayaTubeVideo("991");
        SayaTubeVideo vid9 = new SayaTubeVideo("shounen gakuen");
        SayaTubeVideo vid10 = new SayaTubeVideo("MILF hunting");

        //user
        SayaTubeUser nama = new SayaTubeUser("afzaal");

     
        nama.addVideo(vid4);
        nama.addVideo(vid10);
        nama.addVideo(vid5);

        vid4.PrintVideosDetails();
        vid10.PrintVideosDetails();
        vid5.PrintVideosDetails();




    }

}