using System;

namespace hata_yonetimi
{
    class Program
    {
        public static void Main(string[] args)
        {
            // try
            // {
            //     Console.WriteLine("Enter a number: ");
            //     int number =Convert.ToInt32(Console.ReadLine());
            //     Console.WriteLine("Taken number: " + number);
            // }
            // catch(Exception ex)
            // {
            //     Console.WriteLine("Hata: "+ ex.Message.ToString());
            // }
            // finally
            // {
            //     Console.WriteLine("It is done");
            // }

            try
            {
                // int a = int.Parse(null);
                // int a = int.Parse("test");
                int a = int.Parse("-200000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Empty Value");
                Console.WriteLine(ex);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("The data type is not suitable");
                Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Not acceptable(too large/small) number is entered");
                Console.WriteLine(ex);
            }
            finally
            {
                Console.WriteLine("It is done");
            }
        }
    }
}
