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

        // Optional parameter
        public static int GetVolumeOfCube(int length = 1, int width = 1, int height = 1)
        {
            int Result = length * width * height;
            Console.WriteLine("{0} * {1} * {2} = {3}", length, width, height, Result);
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

            // Named Parameter : 특정 매개변수에 값을 집어넣을 수 있음.
            // 이는 가독성이 좋아지며 아래코드는 GetVolumeOfCube(3, 5, 7)과 같음.
            // 런타임이 아니라 컴파일 타임에 처리되기 때문에 성능 오버헤드가 없음.
            Calculator.GetVolumeOfCube(length: 3, width: 5, height: 7);

            // 순서가 바뀌어도 됨.
            Calculator.GetVolumeOfCube( height: 7, width: 5, length: 3);
        }
    }
}
