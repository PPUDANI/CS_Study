namespace _016_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C#에서 foreach는 Enumerator 패턴을 사용한다.
            // - IEnumerable 인터페이스를 통해 IEnumerator를 사용하여 컬렉션의 요소를 순차적으로 반환한다.
            // - 이 과정은 런타임에서 수행된다.

            // foreach 사용 시 주의할 점:
            // 1. 박싱/언박싱 문제:
            //    - 값 타입(int, float 등)을 object로 받을 경우 박싱이 발생할 수 있다.
            //    - 박싱은 성능에 부정적인 영향을 미치며, 메모리 할당과 GC(가비지 컬렉션)의 부담을 초래한다.
            //    - var이나 object를 사용하지 않고 명시적으로 타입을 지정하면 박싱을 방지할 수 있다.
            //
            // 2. 참조 타입:
            //    - 참조 타입(string, class 등)은 힙에 저장되므로 박싱/언박싱이 발생하지 않는다.
            //    - 따라서 참조 타입을 object로 받을 경우에도 박싱 문제는 없다.

            // 값 타입을 foreach로 순회 (박싱 없음)
            int[] arr = new int[] { 0, 1, 2, 3, 4 };
            foreach (int item in arr)
            {
                Console.WriteLine(item); // 명시적으로 타입을 지정했으므로 박싱 없음
            }

            // Object로 값을 받을 경우 박싱 발생 (권장되지 않음)
            Object[] arr2 = new Object[] { 0, 1.12f, 1.5m, "안녕" }; // Object 배열 선언
            foreach (Object item in arr2)
            {
                Console.WriteLine(item); // 값 타입(0, 1.12f, 1.5m)은 박싱된 상태로 처리
            }

            // 주의: 루프 중 객체가 생성, 해제되면 가비지 컬렉터가 이를 관리해야 하므로 성능 저하가 발생할 수 있다.
        }
    }
}
