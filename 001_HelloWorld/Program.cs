// using : C++과 같이 System이라는 형식 지정자를 안쓰겠다는 뜻.
// 
using System;
using static System.Console;

namespace _001_HelloWorld
{
    class MainApp
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                WriteLine("사용법 : HelloWorld.exe <이름>");
                return;
            }

            WriteLine("Hello, {0}!", args[1]);
        }
    }
}
