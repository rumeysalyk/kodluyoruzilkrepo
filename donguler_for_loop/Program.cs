using System;

namespace donguler_for_loop
{
    class Program
    {
        public static void Main(string[] args)
        {

            //Ekrandan girilen sayıya kadar olan tek sayıları ekrana yazdır.
            Console.WriteLine("Lütfen bir sayi giriniz: ");
            int sayac = int.Parse(Console.ReadLine());

            for(int i=0;i<=sayac;i++)
            {
                if(i%2==1)
                    Console.WriteLine(i);
            }
            

            //1 ile 1000 arasındaki tek ve çift sayıların kendi içlerinde toplamlarını ekrana yazdır
            
            int oddSum=0,evenSum=0;
            for(int i=0;i<1000;i++)
            {
                if(i%2==1)
                {
                    oddSum +=i; 
                }
                else
                {
                    evenSum +=i;
                }
                    
            }
            Console.WriteLine("Tek Sayıların Toplamı: " + oddSum);
            Console.WriteLine("Çift Sayıların Toplamı: " + evenSum);

            for (int i = 1 ; i < 10; i++)
            {
                if(i==4)
                    break;
                Console.WriteLine(i);
            }
            for (int i = 1 ; i < 10; i++)
            {
                if(i==4)
                    continue;
                Console.WriteLine(i);
            }
        }
    }
}
