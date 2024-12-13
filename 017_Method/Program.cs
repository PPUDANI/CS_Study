namespace _017_Method
{
    class Calculator
    {
        private static int Plus(int a, int b)
        {
            int Result = a + b;
            Console.WriteLine("{0} + {1} = {2}", a, b, Result);
            return Result;
        }

        public static int Plus2(int a, int b)
        {
            return Plus(a, b);
        }

        public static int Minus(int a, int b)
        {
            int Result = a - b;
            Console.WriteLine("{0} - {1} = {2}", a, b, Result);
            return Result;
        }
    }

    internal class Program
    {
        static int Fibonacci(int Num)
        {
            if(Num < 2)
            {
                return 1;
            }

            return Fibonacci(Num - 1) + Fibonacci(Num - 2);
        }

        static void Main(string[] args)
        {
            Calculator.Plus2(3, 4);
            Calculator.Plus2(5, 6);

            Calculator.Minus(6, 4);
            Calculator.Minus(4, 1);

            int FiboResult = Fibonacci(5);
            Console.WriteLine(FiboResult);

        }
    }
}
