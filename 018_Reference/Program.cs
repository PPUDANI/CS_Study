namespace _018_Reference
{
    internal class Program
    {
        // ref라는 키워드로 참조를 넘겨줄 수 있음.
        static void Swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        // ref로 결과값을 다수로 받는 방법.
        static void Divide1(int a, int b, ref int _Quotient, ref int _remainder)
        {
            _Quotient = a / b;
            _remainder = a % b;
        }
        
        // ref와 같은 out이라는 키워드가 있음.
        // ref와 다른점은 out으로 받는 인자를 초기화 하지 않으면 컴파일러가 오류를 발생시킴.
        static void Divide2(int a, int b, out int _Quotient, out int _remainder)
        {
            _Quotient = a / b;  
            _remainder = a % b;
        }

        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            Swap(ref a, ref b);


            //int Quotient1;
            //int remainder1;
            Divide2(12, 5, out int Quotient1, out int remainder1);
            

            int Quotient2;
            int remainder2;
            Divide2(12, 5, out Quotient2, out remainder2);
        }
    }
}
