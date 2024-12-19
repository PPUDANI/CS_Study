namespace _026_partial
{
    internal class Program
    {
        // partial : 분할해서 Class를 선언할 때 사용하는 키워드
        partial class MyClass
        {
            public void Foo1() { }
            public void Foo2() { }
            public void Foo3() { }
        }

        partial class MyClass
        {
            public void Foo4() { }
            public void Foo5() { }
            public void Foo6() { }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
