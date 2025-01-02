using System.Collections;

namespace _032_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ArrayList는 비제네릭 컬렉션으로 구분없이 데이터를 저장할 수 있음. 
            // 값을 잘못 읽을 수도 있어 타입 안정성이 떨어지고, 공통 상속인 object로 받아야 하는데 형변환(박싱) 오버헤드가 큼.
            // 비제네릭 컬렉션은 매우 위험하고 퍼포먼스도 떨어지므로 제네릭 컬렉션인 List<T> 사용이 더 적합함.
            ArrayList Ar = new ArrayList();
            
            Console.WriteLine($"Empty -> length: {Ar.Count} Capacity: {Ar.Capacity}");
            Ar.Add(256);
            Console.WriteLine($"Add 314 -> length: {Ar.Count} Capacity: {Ar.Capacity}");
            Ar.Add(1.23f);
            Console.WriteLine($"Add 3.14f -> length: {Ar.Count} Capacity: {Ar.Capacity}");
            Ar.Add(3.14m);
            Console.WriteLine($"Add 3.14m -> length: {Ar.Count} Capacity: {Ar.Capacity}");
            Ar.Add("Hello");
            Console.WriteLine($"Add Hello -> length: {Ar.Count} Capacity: {Ar.Capacity}");
            Ar.Add("World!");
            Console.WriteLine($"Add World! -> length: {Ar.Count} Capacity: {Ar.Capacity}\n");

            foreach (object i in Ar)
            {
                Console.WriteLine(i);
            }

            Ar.RemoveAt(0);
            Ar.RemoveAt(Ar.Count - 1);
            Console.WriteLine($"\nRemoveAt 0 and Last -> length: {Ar.Count} Capacity: {Ar.Capacity}");

            Ar.Insert(0, "Damn it!");
            Console.WriteLine($"Insert Damn it! in 0\n");

            foreach (object i in Ar)
            {
                Console.WriteLine(i);
            }

            Ar.Clear();
            Console.WriteLine($"\nClear -> length: {Ar.Count} Capacity: {Ar.Capacity}");

            // 컬렉션 초기자
            ArrayList Ar_ColectionInit = new ArrayList() { 1, 2, 3 };
        }
    }
}
