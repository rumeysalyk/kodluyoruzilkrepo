using System;

namespace _7_switch_case
{
    public class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;
            
            Console.WriteLine(month);
            switch(month)
            {
                case 1:
                    Console.WriteLine("It is January");
                    break;
                case 2:
                    Console.WriteLine("It is February");
                    break;
                case 4:
                    Console.WriteLine("It is April");
                    break;
                case 3:
                    Console.WriteLine("It is March");
                    break;
                default:
                    Console.WriteLine("Wrong number");
                    break;
                

            }

            switch(month)
            {
                case 12:
                case 1:
                case 7:
                default: //default her zaman aşağıda olmak zorunda değil.
                    Console.WriteLine("Default");
                    break;
                case 3:
                    Console.WriteLine("It is March");
                    break;
                case 5:
                    Console.WriteLine("It belongs to spring");
                    break;
                case 4:
                    break;

            }
        }
    }
}
