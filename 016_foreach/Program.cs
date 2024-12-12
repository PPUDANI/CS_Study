namespace _016_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#에서 foreach는 Enumerator 패턴을 사용한다고 힘.
            // IEnumerable 인터페이스를 통해 IEnumerator를 사용하여 컬렉션의 요소를 순차적으로 반환함.
            // 이 과정은 런타임에서 수행됨.
            // 박싱/언박싱(특히 값 타입(int, float))이나 가비지 컬렉션과 같은 오버헤드가 발생할 수 있음.
            // var이나 object를 사용안하면 박싱 안일어나서 오버헤드는 없음.
            // 참조 타입(string, class)은 이런 문제가 없음.

            // Q) 참조 타입을 Object로 받으면 참조 타입도 박싱 일어나는거 아님?
            // A) 참조 타입은 애초에 힙에 있기 때문에 박싱/언박싱이 일어나지 않음.

            int[] arr = new int[] { 0, 1, 2, 3, 4 };
            foreach (int item in arr)
            {   
                Console.WriteLine(item);
            }

            // 이럴 경우 Object로 받을 수 있음.(이렇게 쓰긴 할까)
            Object[] arr2 = new Object[] { 0, 1.12f, 1.5m, "안녕"}; // Object 배열 선언
            foreach (Object item in arr2)
            {
                Console.WriteLine(item);
            }

            // 루프 중 객체가 생성, 해제되면 가비지 컬렉터가 이를 관리해야 하므로 성능 저하가 발생할 수 있음.
        }
    }
}
