using System;
using static System.Console;

namespace _005_Floating
{
    class MainApp
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"\n<Float>");
            float Float_val = 3.141592653589793238462643383279f; // 4Byte
            double Double_val = 3.141592653589793238462643383279; // 8Byte
            decimal Decimal_val = 3.141592653589793238462643383279m; // 16Byte

            Console.WriteLine($"Float_val = {Float_val}"); // 3.1415927
            Console.WriteLine($"Double_val = {Double_val}"); // 3.141592653589793
            Console.WriteLine($"Decimal_val = {Decimal_val}"); // 3.1415926535897932384626433833


            float float_num = 0.1f;
            double double_num = 0.1;
            decimal decimal_num = 0.1m;
            for (int i = 0; i < 2000; ++i)
            {
                float_num += 0.5f;
                double_num += 0.5;
                decimal_num += 0.5m;
            }

            Console.WriteLine($"<Float>");
            if (float_num == 1000.1f)
            {
                Console.WriteLine($"{float_num} == {1000.1}");
            }
            else
            {
                Console.WriteLine($"{float_num} != {1000.1}");
            }

            Console.WriteLine($"<Double>");
            if (double_num == 1000.1)
            {
                Console.WriteLine($"{double_num} == {1000.1}");
            }
            else
            {
                Console.WriteLine($"{double_num} != {1000.1}");
            }

            Console.WriteLine($"<Decimal>");
            if (decimal_num == 1000.1m)
            {
                Console.WriteLine($"{decimal_num} == {1000.1}");
            }
            else
            {
                Console.WriteLine($"{decimal_num} != {1000.1}");
            }
        }
    }
}
