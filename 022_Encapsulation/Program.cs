namespace _022_Encapsulation
{
    class ClassA
    {
        // 접근 지정자를 통해 캡술화할 수 있음.
        // 기본 접근 지정자는 private
        public int a;
        protected int b;
        private int c;
        int Data; // private

        public void SetData(int _Val)
        {
            if(_Val < 0)
            {
                throw new Exception("Out of Number range");
            }

            Data = _Val;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            ClassA inst = new ClassA();
            inst.a = 1;

            try
            {
                inst.SetData(-1);
            }
            catch (Exception e) 
            { 
                Console.WriteLine(e.Message);
            }
        }
    }
}
//internal int c;
//protected internal int d;
//private protected int e;