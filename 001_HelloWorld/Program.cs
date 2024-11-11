// See https://aka.ms/new-console-template for more information
using System;
using static System.Console;

namespace _001_HelloWorld
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("사용법 : HelloWorld.exe <이름>");
                return;
            }

            Console.WriteLine("Hello, {0}!", args[1]);
        }
    }
}
