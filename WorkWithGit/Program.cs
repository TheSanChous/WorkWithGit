using System;

namespace WorkWithGit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintHello();
        }

        static void PrintHello(ConsoleColor textColor = ConsoleColor.White)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
