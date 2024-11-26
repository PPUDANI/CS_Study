using System;
using static System.Console;

namespace _002_Variable
{
    class MainApp
    {
        static void Main(string[] args)
        {
            // Integer Variables

            // 1Byte Integer
            sbyte Signed_Byte = -10;
            byte Unsigned_Byte = 40;
            Console.WriteLine($"Signed_Byte={Signed_Byte}, Unsigned_Byte={Unsigned_Byte}");

            // 2Byte Integer
            short Signed_Short = -30000;
            ushort Unsigned_Short = 60000;
            Console.WriteLine($"Signed_Short={Signed_Short}, Unsigned_Short={Unsigned_Short}");

            // 4Byte Integer
            int Int1 = -10_000_000;
            int Int2 = 300_000_000;
            Console.WriteLine($"Int1={Int1}, Int2={Int2}");

            // 8Byte Integer
            long Long1 = -500_000_000_000;
            long Long2 = 2_000_000_000_000_000_000;
            Console.WriteLine($"Long1={Long1}, Long2={Long2}");
        }
    }
}
