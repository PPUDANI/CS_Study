using System;

namespace _014_Parse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Parse
            // 1. null일 시 FormatException 발생
            // 2. 유효한 변환이 아니면 FormatException 발생
            Console.Write("Parse 변환 : ");
            string Input1 = Console.ReadLine();
            int Output1 = Int32.Parse(Input1);
            Console.WriteLine(Output1);



            // Convert
            // 1. null이면 0 반환
            Console.Write("Convert 변환(null) : ");
            int OutputNull = Convert.ToInt32(null);
            Console.WriteLine(OutputNull);

            // 2. 유효한 변환이 아니면 FormatException 발생
            Console.Write("Convert 변환 : ");
            string Input2 = Console.ReadLine();
            int Output2 = Convert.ToInt32(Input2);
            Console.WriteLine(Output2);



            // TryParse : 예외처리를 안하고 bool값 반환함.
            // 1. null일 시 false 반환
            // 2. 유효한 변환이 아니면 false 반환
            Console.Write("TryParse 변환 : ");
            string Input3 = Console.ReadLine();

            if (int.TryParse(Input2, out int Output3))
            {
                Console.WriteLine(Output3);
            }
            else
            {
                Console.WriteLine("유효한 변환이 아닙니다.");
            }
        }
    }
}
