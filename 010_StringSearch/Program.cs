using static System.Console;

namespace _010_StringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine("Index Of 'Good' : {0}", greeting.IndexOf("Good"));
            WriteLine("Index Of 'o' : {0}", greeting.IndexOf('o'));

            // LastIndexOf()
            WriteLine("Last Index Of 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("Last Index Of 'o' : {0}", greeting.LastIndexOf('o'));

            // StartsWith()
            WriteLine("Starts With 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("Starts With 'Morning' : {0}", greeting.StartsWith("Morning"));

            // EndsWith()
            WriteLine("Ends With 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("Ends With 'Morning' : {0}", greeting.EndsWith("Morning"));

            // Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}", greeting.Contains("Morning"));

            // Replace()
            WriteLine("Eveninged 'Morning' with 'Evening' : {0}", greeting.Replace("Morning", "Evening"));
        }
    }
}
