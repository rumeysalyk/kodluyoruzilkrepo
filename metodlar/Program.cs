using System;

namespace metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=3,b=9,sonuc, sonuc2;
            sonuc = Topla(a,b);
            Methodlar ornek = new Methodlar();
            ornek.EkranaYazdir(Convert.ToString(sonuc));
            sonuc2 = ornek.ArttirVeTopla(a,b);
            ornek.EkranaYazdir(Convert.ToString(sonuc2));
            ornek.EkranaYazdir(Convert.ToString(Topla(a,b)));
        }

        static int Topla(int x,int y) //Note : Static bir class içerisinden sadece static methodlar çağırılabilir
        {
            return x+y;
        }
    }
    class Methodlar
    {
        //Bu fonk. statcik tanımladığında ne olacak bir bak
        public void EkranaYazdir(string veri) //Bu method farklı bir class içerisinde yer aldığı için çağırabilmek için öncelikle Methodlar classının bir instance ini yaratıp onun üzerinden bu işlemi yapacağız
        {
            Console.WriteLine(veri);
        }
        public int ArttirVeTopla(int a,int b) //Burda bellekte bir değişim gözlenmiyor. Eğer direkt bellekte bu değişimi görmek istiyorsak ref anahtar kelimesini kullanıyoruz
        {
            a++;
            b++;
            return a+b;
        }

    }
}
