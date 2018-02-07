using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWeb2.Models;

namespace TestTConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            calc obj1 = new calc(3, 6, 8);

            Console.WriteLine(obj1.calcSum(3, 8, 7));
            Console.WriteLine(obj1.calcAvg());
            Console.ReadKey();
        }
    }
}
