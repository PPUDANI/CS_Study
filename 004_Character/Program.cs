using System;
using static System.Console;

namespace _004_Character
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // 유니코드를 공통으로 사용되기 때문에 2Byte임.
            char a = '안';
            char b = '녕';
            char c = '하';
            char d = '세';
            char e = '요';
            Console.Write(a);
            Console.Write(b);
            Console.Write(c);
            Console.Write(d);
            Console.Write(e);

            string str = "안녕하세요";
            Console.Write(str);
        }
    }
}
