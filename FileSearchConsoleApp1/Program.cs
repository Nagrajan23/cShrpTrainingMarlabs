using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileSearch;
using System.Threading;

namespace FileSearchConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Directory");
            string strdir = Console.ReadLine();
            FileSearch.File fileobj = new FileSearch.File();
            fileobj.sendFileName += sendFileName;
            Thread thread = new Thread(() => fileobj.Search(strdir));
            thread.Start();
        }

        private static void sendFileName(string file)
        {
            Console.WriteLine(file);
        }
    }
}
