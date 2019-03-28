using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("downloading file");
            Console.ReadLine();
        }

        static void Download()
        {
            Thread.Sleep(3000);
            Console.WriteLine("download complete!!@!");
        }
    }
}
