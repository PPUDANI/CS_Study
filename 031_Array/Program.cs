using System.Collections;

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

                // GetType() : []은 System.Array에서 파생됨.
                Console.WriteLine($"Type Of Array: {Arr4.GetType()}");
                Console.WriteLine($"Base type of Array: {Arr4.GetType().BaseType}");

                // 속성(Property)
                Console.WriteLine($"Length: {Arr4.Length,-5:N0}  Rank:{Arr4.Rank,-5:N0}");
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
                foreach (int Num in Number)
                {
                    Console.Write("{0}", Num);
                }
            }

            {
                string[] Champions = { "Garen", "Galio", "Gangplank" };
                Array.ForEach<string>(Champions, new Action<string>(Print));
            }

            {
                // 다차원 배열
                int[,] Arr2D_1 = new int[2, 2];
                int[,] Arr2D_2 = new int[2, 2] { { 1, 2 }, { 3, 4 } };
                int[,] Arr2D_3 = new int[,] { { 1, 2 }, { 3, 4 } };
                int[,] Arr2D_4 = { { 1, 2 }, { 3, 4 } };
                int ss = Arr2D_1.Length;
                Arr2D_1[0, 0] = 1;
                Arr2D_1[0, 1] = 2;
                Arr2D_1[1, 0] = 3;
                Arr2D_1[1, 1] = 4;

                foreach(int OneDementions in Arr2D_1)
                {
                    Console.Write("{0} ", OneDementions);
                }

                int[,,] Arr3D_1 = new int[3, 3, 3];
                int[,,] Arr3D_2 = new int[2, 2, 2] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
                int[,,] Arr3D_3 = new int[,,] { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
                int[,,] Arr3D_4 = { { { 1, 2 }, { 3, 4 } }, { { 5, 6 }, { 7, 8 } } };
            }

            {
                // 가변 배열
                int[][] Jagged = new int[3][];
                Jagged[0] = new int[2];
                Jagged[1] = new int[] {1, 2, 3};
                Jagged[2] = new int[5] {1, 2, 3, 4, 5};

                foreach (int[] arr in Jagged)
                {
                    foreach (int e in arr)
                    {
                        Console.WriteLine(e);
                    }
                }

                // 아래와 같은 초기화 불가능
                // int[][] Jagged3 = new int[3][2];
                // int[][] Jagged4 = new int[3][new int[2]];
                // int[3][3] Jagged6 = new int[3][3];
                
            }
        }
    }
}
