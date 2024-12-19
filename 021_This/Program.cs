using System.Xml.Linq;

namespace _021_This
{
    class Human
    {
        public int a, b, c;

        public Human()
        {
            a = 1234;
        }
        public Human(int _b) : this()
        {
            b = _b;
        }
        public Human(int _b, int _c) : this(_b)
        {
            c = _c;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
