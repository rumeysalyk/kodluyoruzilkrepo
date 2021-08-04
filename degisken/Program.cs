using System;

namespace degisken
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            byte b = 5;         //1 byte
            sbyte c =5;         //1 byte
            short s = 5;        //2 byte
            ushort us = 5;      //2 byte
            Int16 i16 = 2;      //2 byte
            int i = 2;          //4 byte
            Int32 i32 = 2;      //4 byte
            Int64 i64 = 2;      //8 byte

            uint ui = 2;        //4 byte
            long l = 4;         //8 byte
            ulong ul = 4;       //8 byte

            //Reel sayılar için kullanılır
            float f = 5;        //4 byte
            double d = 5;       //8 byte
            decimal de = 5;     //16 byte

            char ch = '2';               //2 byte
            string str = "Rumeysa";     //Sınırsız

            bool b1 = false;
            bool b2 = true;

            DateTime dt = DateTime.Now;
            Console.WriteLine(dt);

            object o1 = "x";
            object o2 = 'y';
            object o3 = 4;
            object o4 = 4.3;

            string str1 = string.Empty;
            str1 = "Rumeysa Layık";
            string ad = "Rumeysa";
            string soyad = "Layık";
            string tamAd= ad + " " + soyad;

            Console.WriteLine(tamAd);

            int integer1 = 5;
            int integer2 = 6;
            int integer3 = integer1 + integer2;

            bool compare = 10<5;

            //Değişken Dönüşümleri:
            string str20 = "20";
            int int20 = 20;
            string newValue = str20 + int20.ToString();

            Console.WriteLine(newValue);

            int int21 = int20 + Convert.ToInt32(str20);
            Console.WriteLine(int21);

            int int22 = int20 + int.Parse(str20);

            //datetime dönüşümleri 
            string today = DateTime.Now.ToString("dd.MM.yy"); //Formatı bu şekilde yazmak önemli 
            Console.WriteLine(today);

            string today2 = DateTime.Now.ToString("dd/MM/yy"); 
            Console.WriteLine(today2);
        
            string hour = DateTime.Now.ToString("HH:mm"); 
            Console.WriteLine(hour);
        }
    }
}
