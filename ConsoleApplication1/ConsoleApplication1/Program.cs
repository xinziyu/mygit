using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            method1();
            dev1();
        }

        private static void method1()
        {
            Console.WriteLine("dev1");
        }
        public static void dev1()
        {
            Console.WriteLine("dev11");
        }
        public static void release()
        {
            Console.WriteLine("release");
        }
    }
}
