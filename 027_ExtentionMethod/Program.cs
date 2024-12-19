using MyExtention;

// this를 붙여서 클래스의 기능을 확장할 수 있음.
namespace MyExtention
{
    public static class IntegerExtention
    {
        // 단순히 제곱하는 함수
        public static int Power(this int myInt, int exponent)
        {
            int result = myInt;
            for (int i = 1; i < exponent; ++i)
            {
                result *= myInt;
            }
            return result;
        }
    }
}

namespace _027_ExtentionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            // int형 변수로 함수를 호출할 수 있게됨.
            int res = a.Power(3);
            string b;
        }
    }
}
