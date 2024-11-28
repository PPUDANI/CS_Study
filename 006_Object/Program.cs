

namespace _006_Object
{
    class Class_A // 상속이 없다면 기본적으로 Object를 암시적으로 상속받음
    {
        public Class_A(int _N1, int _N2)
        {
            Num1 = _N1;
            Num2 = _N2;
        }

        public int Num1 = 3;
        public int Num2 = 4;
    }

    class MainApp
    {
        // 모든 value_type은 struct로 구현되어있고, C#에선 struct를 상속받을 수 없음.
        // 모든 값 타입은 System.ValueType을 상속받고있으며, System.ValueType은 System.object를 상속받고 있음.
        // 값 타입의 내부 코드에 상속이 없는건 object가 암시적으로 상속받기 때문.
        static void Main(string[] args)
        {
            int Int_Prev = 123;
            object Obj1 = (object)Int_Prev;
            int Int_Next = (int)Obj1;

            Console.WriteLine($"Int_Prev = {Int_Prev}");
            Console.WriteLine($"Obj1 = {Obj1}");
            Console.WriteLine($"Int_Next = {Int_Next}");

            double Double_Prev = 3.1415926535;
            object Obj2 = (object)Double_Prev;
            double Double_Next = (double)Obj2;

            Console.WriteLine($"Double_Prev = {Double_Prev}");
            Console.WriteLine($"Obj2 = {Obj2}");
            Console.WriteLine($"Double_Next = {Double_Next}");

            Class_A CA1 = new Class_A(1, 2);
            Class_A CA2 = new Class_A(3, 4);
            object Obj3 = (object)CA1;
            object Obj4 = (object)CA2;
            Console.WriteLine($"CA = {CA1.Num1}");
            Console.WriteLine($"Obj4 = {((Class_A)Obj4).Num1}");
        }
    }


}
