using System;

namespace _9_donguler_while_foreach
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number: ");
            int number = int.Parse(Console.ReadLine());
            int counter=1, sum=0;

            while(counter<number)
            {
                sum += counter;
                counter++;
            }

            Console.WriteLine(sum/counter);

            char c = 'a';
            while(c<'z')
            {
                Console.WriteLine(c);
                c++;
            }

            Console.WriteLine("*************** Foreach ***************");

            string[] cars = {"BMV","Ford","Toyota","Nissan"};

            foreach(var item in cars)
            {
                Console.WriteLine(item);
            }
        }
    }
}
