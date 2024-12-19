namespace _019_Overloading
{
    internal class Program
    {
        // Plus 오버로딩
        static int Plus(int Left, int Right)
        {
            return Left + Right;
        }
        static int Plus(int a, int b, int c)
        {
            return a + b + c;
        }
        static double Plus(double Left, double Right)
        {
            return Left + Right;
        }
        static double Plus(int Left, double Right)
        {
            return (double)Left + Right;
        }

        // 가변인자로 받을 수 있음.
        static int Sum(params int[] args)
        {
            int res = 0;
            foreach(int Num in args)
            {
                res += Num;
            }
            return res;
        }

        // Optional Parameter와 Overloading의 괴리.
        // Multiply()를 호출하면 아래 두 함수중 누가 호출되는가?
        // 답은 2번째 함수이지만 알 필요도 없이 이는 0점짜리 코드임.
        static int Multiply(int Left = 0, int Right = 0)
        {
            return Left + Right;
        }

        static int Multiply()
        {
            return 0;
        }

        static void Main(string[] args)
        {
            // Plus Overloading
            int res1 = Plus(3, 4);
            int res2 = Plus(3, 4, 5);
            double res3 = Plus(5, 3.2);
            double res4 = Plus(6.35, 3.2354);

            // Sum
            int res5 = Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);

            // Multiply Overloading
            int res6 = Multiply(3, 6);
            int res7 = Multiply();
        }
    }
}
