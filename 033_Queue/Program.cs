using System.Collections;
using System.Collections.Generic;

namespace _033_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 비제네릭 컬렉션.
            Queue B_GenericQ = new Queue();

            // C# 2.0부터 제네릭 컬렉션들이 도입되어 가능함.
            Queue<int> GenericQ = new Queue<int>();

            // < Default Enqueue(1) > 배열 기본 크기가 4임
            // h     t
            // 1 0 0 0
            GenericQ.Enqueue(1);

            // < Default Enqueue(2, 3, 4) >
            // h     t
            // 1 2 3 4
            GenericQ.Enqueue(2);
            GenericQ.Enqueue(3);
            GenericQ.Enqueue(4);

            // < Dequeue() x 1 >
            //   h   t
            // 1 2 3 4
            GenericQ.Dequeue();

            // < Enqueue(5) > size는 3인데 크기가 4이므로 "tail += 1" (Array.Count보다 크므로 0)
            // tail은 0이 되서 맨 앞을 가리키고 1이 들어있는 자리를 5로 채움
            // t h     
            // 5 2 3 4
            GenericQ.Enqueue(5);

            // <Enqueue(6)> -> size보다 원소가 많아졌으므로 새로운 곳에 8 크기의 arr 생성해서 모든 요소 Copy()
            // Copy할때 h가 앞으로 오도록 재정렬
            // h       t     
            // 2 3 4 5 6 0 0 0
            GenericQ.Enqueue(6);
        }
    }
}
