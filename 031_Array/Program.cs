namespace _031_Array
{
    internal class Program
    {
        static void Print(string _Name)
        {
            Console.WriteLine("{0}", _Name);
        }

        static void Main(string[] args)
        {
            {
                // Array 생성: C#의 배열은 CTS에서 System.Array 클래스에 대응됨.
                // 정적 배열이고, 참조형이며 생성 방식은 아래와 같음.

                int[] Arr1 = new int[3]; // 3의 크기로 지정가능
                int[] Arr2 = new int[3] { 1, 2, 3 }; // 값 초기화 가능
                int[] Arr3 = new int[] { 1, 2, 3, 4, 5 }; // 크기가 없다면 생성되는 크기로 정해짐
                int[] Arr4 = { 1, 2, 3, 4, 5 }; // 힙 할당 코드 생략 가능. 성능차이는 없고 간결해짐.

                // GetType()
                Console.WriteLine($"Type Of Array: {Arr4.GetType()}");
                Console.WriteLine($"Base type of Array: {Arr4.GetType().BaseType}");

                // 속성(Property)
                Console.WriteLine($"Length: {Arr4.Length, -5:N0}  Rank:{Arr4.Rank, -5:N0}");
                Array.Resize<int>(ref Arr4, 10);
                Console.WriteLine($"Length: {Arr4.Length,-5:N0}  Rank:{Arr4.Rank,-5:N0}");
                Array.Clear(Arr4);
                Console.WriteLine($"Length: {Arr4.Length,-5:N0}  Rank:{Arr4.Rank,-5:N0}");
                // ?
                //Console.WriteLine($"Base type of Array: {Arr4.GetLength(1)}");


            }

            {
                int[] Number = { 3, 5, 4, 8, 9, 2, 1, 6, 7, 0 };
                Array.Sort(Number);
                foreach(int Num in Number)
                {
                    Console.Write("{0}", Num);
                }
            }

            {
                string[] Champions = { "Garen", "Galio", "Gangplank" };
                Array.ForEach<string>(Champions, new Action<string>(Print));
            }

            {
                
            }
            


        }
    }
}
