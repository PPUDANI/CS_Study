namespace _029_Abstract
{
    abstract class AbstractBase
    {
        public abstract string Func1();
        protected abstract string Func2();
        private abstract string Func3(); // 숨길거면 왜 추상으로 지정함? ERROR!
        abstract string Func4(); // 기본 private -> 숨길거면 왜 추상으로 지정함? ERROR!
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
