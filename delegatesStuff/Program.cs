using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using factorialLibrary;
using System.Threading;

namespace delegatesStuff
{
    class Program
    {
        static void Main(string[] args)
        {
            //Small Factorial Calculation
            /*Factorial obj = new Factorial();
            BigInteger result = obj.Calculate(5);
            Console.WriteLine(result); //*/

            //Big Number Calculation - Synchronous call
            /*Console.WriteLine("Started Calculation");
            result = obj.Calculate(100000);
            Console.WriteLine(result);
            Console.WriteLine("Finished"); //*/

            //Big Number Calculation - Asynchronous call, broadcast
            Factorial obj = new Factorial();
            obj.WhereToSend += DisplayFactorial;
            obj.WhereToSend += DisplayFactorialGreater10k;
            //obj.WhereToSend(100);
            Console.WriteLine("Started Calculation");
            Thread t1 = new Thread(() => obj.Calculate(100));
            t1.Start();
            Console.WriteLine("Finished");

            Console.ReadKey();
        }

        static void DisplayFactorial(BigInteger result)
        {
            Console.WriteLine(result);
        }

        static void DisplayFactorialGreater10k(BigInteger result)
        {
            if(result > 10000)
            {
                Console.WriteLine("Greater Than 10k");
            }
            else
            {
                Console.WriteLine("Less Than 10k");
            }
        }
    }
}
