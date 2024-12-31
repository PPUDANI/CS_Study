namespace TestCode
{
    internal class Object
    {
        public void foo()
        {

        }

        public virtual void noo()
        {
            Console.WriteLine("Object:noo()");
        }

        public int a;
    }

    internal class Actor : Object
    {
        public void poo()
        {

        }

        public override void noo()
        {
            Console.WriteLine("Actor:noo()");
        }

        public int b;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Object obj = new Actor();
            obj.a = 3;
            // obj.b = 3; ERROR!
            obj.foo();
            // obj.poo(); ERROR!

            obj.noo(); // Actor:noo()가 출력됨.
        }
    }
}
