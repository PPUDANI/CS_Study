
using System.Collections;
using System.Runtime.InteropServices;

namespace _008_NullAble
{
    class Foo
    {
        public int member;
        public int? member2 = null;
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            // 자료형이 null값을 가질 수 있게 만들어주는 키워드임.
            // 자료형 오른쪽에 ?만 붙여주면 됨.
            int? Val1 = null;

            Console.WriteLine($"{Val1.HasValue}");
            Console.WriteLine($"Val1 = {Val1}");

            Val1 = 37;

            Console.WriteLine($"{Val1.HasValue}");
            Console.WriteLine($"Val1 = {Val1}");

            Foo? a = null;
            int? b = a?.member; // a?.member : Foo 객체가 null이 아니면 member에 접근하게 해줌.

            if(a != null)
            {
                b = a.member;
            }

            // Null 병합 연산자 ??
            int? a1 = null;
            Console.WriteLine($"{a1 ?? 0}\n"); // a3가 null일 경우 0을 반환

            Foo a2 = new Foo();
            Console.WriteLine($"{a2.member2 ?? 0}"); // a2.member2가 null일 경우 0을 반환

            Foo? a3 = null;
            Console.WriteLine($"{a3?.member2 ?? 0}"); // a1이 null일 경우 0을 반환


            // ?[]
            ArrayList? arr = null;

            arr?.Add(1); // arr가 null이 아닐경우 원소 1을 추가
            arr?.Add(3.52f); // arr가 null이 아닐경우 원소 3.52f를 추가
            arr?.Add("안녕"); // arr가 null이 아닐경우 원소 "안녕"을 추가

            // arr가 null일 경우 
            Console.WriteLine("<arr가 null일 경우>");
            Console.WriteLine($"{arr?[0] ?? 0}\n{arr?[1] ?? 0}\n{arr?[2] ?? 0}\n");

            ArrayList? arr2 = new ArrayList();

            arr2?.Add(1); // arr가 null이 아닐경우 원소 1을 추가
            arr2?.Add(3.52f); // arr가 null이 아닐경우 원소 3.52f를 추가
            arr2?.Add("안녕"); // arr가 null이 아닐경우 원소 "안녕"을 추가

            // arr가 null일 경우 
            Console.WriteLine("<arr2가 null이 아닐 경우>");
            Console.WriteLine($"{arr2?[0] ?? 0}\n{arr2?[1] ?? 0}\n{arr2?[2] ?? 0}\n");
        }
    }
}

