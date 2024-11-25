using System;
using static System.Console;

namespace _003_Literals
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"<LiteralChange>");
            byte Decimal  = 240; // 10진수 240
            byte Binary = 0b11110000; // 2진수 240
            byte Hexadecimal = 0xF0; // 16진수 240
            uint Hexadecimal_uint = 0x1234abcd; // 16진수 305441741

            Console.WriteLine($"Decimal = {Decimal}");
            Console.WriteLine($"Binary = {Binary}");
            Console.WriteLine($"Hexadecimal = {Hexadecimal}");
            Console.WriteLine($"Hexadecimal_uint = {Hexadecimal_uint}");


            Console.WriteLine($"\n<TypeChange>");
            byte Byte_val = 0b11111111; // byte의 0b1111111 = 255
            sbyte TypeChange = (sbyte)Byte_val; // sbyte의 0b11111111 = -1
            Console.WriteLine($"Byte_val = {Byte_val}");
            Console.WriteLine($"TypeChange = {TypeChange}"); 


            Console.WriteLine($"\n<Float>");
            float Float_val = 3.141592653589793238462643383279f;
            double Double_val = 3.141592653589793238462643383279;
            decimal Decimal_val = 3.141592653589793238462643383279m;

            Console.WriteLine($"Float_val = {Float_val}"); // 3.1415927
            Console.WriteLine($"Double_val = {Double_val}"); // 3.141592653589793
            Console.WriteLine($"Decimal_val = {Decimal_val}"); // 3.1415926535897932384626433833
        }

    }
}
