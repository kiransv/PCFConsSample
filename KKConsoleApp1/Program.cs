using System;

namespace KKConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To PCF Sample Console App :: ");

            Console.WriteLine("**********Started**********");
            int i = 1;

            while (true)
            {
                Console.WriteLine("Loop # {0}", i);
                System.Threading.Thread.Sleep(5000);
                i++;
            }
        }
    }
}
