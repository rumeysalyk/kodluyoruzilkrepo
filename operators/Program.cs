using System;

namespace operators
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("******************Assignment Operators****************");
            int x = 5;
            int y= 9;

            y = y +2;
            Console.WriteLine(y);

            y += 2;
            Console.WriteLine(y);
            
            y /= 2;
            Console.WriteLine(y);

            x +=2;
            Console.WriteLine(x);

            Console.WriteLine("**************Logical Operators*************");
            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");
            if(isCompleted || isSuccess)
                Console.WriteLine("Great");
            if(!isCompleted && isSuccess)
                Console.WriteLine("Fine");
            
            
            
            Console.WriteLine("**************Relational Operators*************");

            int a=3,b=4;
            bool result = a<b;

            Console.WriteLine(result);
            result = a>b;
            Console.WriteLine(result);
            result = a>=b;
            Console.WriteLine(result);
            result = a<=b;
            Console.WriteLine(result);
            result = a==b;
            Console.WriteLine(result);
            result = a!=b;
            Console.WriteLine(result);


            Console.WriteLine("******************Aritmetic Operators****************");

            int sayi1=10,sayi2=5;

            int result2 =sayi1/sayi2;
            Console.WriteLine(result2);
            result2 = sayi1*sayi2;
            Console.WriteLine(result2);
            result2 = sayi1+sayi2;
            Console.WriteLine(result2);
            result2 = sayi1++;
            Console.WriteLine(result2);

            //% mod alır
            result2 = 20%3;
            Console.WriteLine(result2);
            

        }
    }
}
