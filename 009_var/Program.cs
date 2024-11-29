namespace _009_var
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var 키워드로 모든 자료형을 받을 수 있음.
            // 컴파일러와 인터프리터가 해당 변수에 담는 데이터를 보고 자동으로 형식을 지정해줌.
            // 단 지역변수로만 선언 가능. 클래스 멤버변수 등은 컴파일중 메모리의 크기를 알아야 함으로
            // 꼭 자료형을 명시해서 사용해야함.

            var a = 3;
            var b = 4.5f;
            var c = "Hello";
            var arr = new int[] { 0, 1, 2, 3 };

            Console.WriteLine("Type:{0},   a = {1}", a.GetType(), a);
            Console.WriteLine("Type:{0},  b = {1}", b.GetType(), b);
            Console.WriteLine("Type:{0},  c = {1}", c.GetType(), c);

            Console.Write("Type:{0}, arr = ", arr.GetType());
            foreach(var e in arr)
            {
                Console.Write("{0} ", e);
            }
        }
    }
}
