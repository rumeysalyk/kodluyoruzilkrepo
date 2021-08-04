using System;

namespace if_elseif
{
    class Program
    {
        public static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;

            if(time>6 && time<=11)
                Console.WriteLine("Günaydin");
            else if(time<18)
                Console.WriteLine("İyi Günler");
            else
                Console.WriteLine("İyi Geceler");

            //***************Second way***************
            string sonuc = time>=6 && time<=11 ? "Günaydın":time <=18 ? "İyi Günler":"İyi Geceler";
            Console.WriteLine(sonuc);

        }
    }
}
