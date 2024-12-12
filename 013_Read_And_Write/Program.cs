namespace _013_Read_And_Write
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("문자열을 입력해주세요 : ");

            // string을 입력하는 매서드
            string? Str = Console.ReadLine();
            if(string.IsNullOrEmpty(Str))
            {
                Str = null;
            }
            Console.Write(Str); // 기본적인 출력 매서드
            Console.WriteLine(Str);// 출력 후 줄바꿔주는 매서드

            // 한 문자를 입력하는 용도로 사용되는 매서드
            Console.Write("한 문자를 입력해주세요 : ");
            int Character = Console.Read();
            Console.WriteLine((char)Character);

            // 키 입력을 기다리는 매서드
            Console.Write("Key를 입력해주세요 : ");
            System.ConsoleKeyInfo Info2 = Console.ReadKey(true); // overload로 true를 인자로 넣으면 입력한 키를 출력하지 않음.
            Console.WriteLine();

            Console.Write("Key를 입력해주세요 : ");
            System.ConsoleKeyInfo Info = Console.ReadKey();
            Console.WriteLine($"\n입력된 Key: {Info.Key}");
        }
    }
}
