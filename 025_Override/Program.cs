namespace _025_Override
{
    class Base
    {
        public virtual void Func()
        {
            Console.WriteLine("Base: Func()");
        }

        public void NewFunc()
        {
            Console.WriteLine("Base: NewFunc()");
        }

        public virtual void SealFunc()
        {
            Console.WriteLine("Base: SealFunc()");
        }
    }

    class Derived : Base
    {
        // 기본 재정의
        public override void Func()
        {
            // 부모 함수도 수행해야한다면 base 키워드를 사용.
            base.Func(); 
            Console.WriteLine("Derived: Func()");
        }

        // 메소드 숨기기: new를 붙이면 부모의 NewFunc() 함수를 숨길 수 있음.
        // 부모 함수의 동작을 무시하기 위해 사용되는 키워드
        public new void NewFunc()
        {
            Console.WriteLine("Derived: NewFunc()");
        }

        // virtual로 선언된 함수를 overried 했을 때 sealed 키워드를 붙이면 이후에 overried를 봉인할 수 있음.
        public sealed override void SealFunc()
        {
            Console.WriteLine("Derived: SealFunc()");
        }
    }

    class Child : Derived
    {
        // 기본 재정의
        public override void Func()
        {
            // 부모 함수도 수행해야한다면 base 키워드를 사용.
            base.Func();
            Console.WriteLine("Child: Func()");
        }

        // 봉인되었다는 문구가 나옴.
        public override void SealFunc() // ERROR!
        {
            Console.WriteLine("Child: SealFunc()");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Base Base1 = new Base();
            Derived Derived1 = new Derived();
            Child Child1 = new Child();
            Base1.Func();
            Console.WriteLine();
            Derived1.Func();
            Console.WriteLine();
            Child1.Func();
            Console.WriteLine();


            Base Base2 = new Derived();
            Base2.Func(); // Derived.Func() 호출
            Console.WriteLine();
            Derived1.NewFunc(); // Derived.NewFunc() 호출
            Console.WriteLine();
            Base2.NewFunc(); // Base.NewFunc() 호출


        }
    }
}
