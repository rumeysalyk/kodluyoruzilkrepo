using System;

namespace diziler_array_sinifi_metotlari
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] sayiDizisi = {23,12,4,86,72,3,11,17};

            Console.WriteLine("******Sırasız Dizi******");
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            Console.WriteLine("******Sırali Dizi******");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);

            //Clear
            Console.WriteLine("****** Clear ******");
            Array.Clear(sayiDizisi,2,2); //2.indexten başlayarak 2 elemanı 0layacaktır
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);
            
            //Reverse
            Console.WriteLine("****** Reverse ******");
            Array.Reverse(sayiDizisi);
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);            

            //indexof
            Console.WriteLine("****** Indexof  ******");
            Console.WriteLine(Array.IndexOf(sayiDizisi,23));

            //Resize
            Console.WriteLine("****** Resize ******");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 99;
            foreach (var sayi in sayiDizisi)
                Console.WriteLine(sayi);             


        }
    }
}
