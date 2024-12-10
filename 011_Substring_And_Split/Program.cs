
using static System.Console;

namespace _011_Substring_And_Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Substring()
            string greeting = "Good Morning";
            WriteLine(greeting.Substring(0, 5));
            WriteLine(greeting.Substring(5));
            WriteLine();

            // Split()
            string SplitStr = "ABC, DEF, GHIJ, KL,MNOP";
            string[] arr = SplitStr.Split(new string[] { ", " }, StringSplitOptions.None);
            foreach (string Element in arr)
                WriteLine("{0}", Element);
            WriteLine();
        }
    }
}
