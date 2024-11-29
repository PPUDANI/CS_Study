
namespace _008_NullAble
{
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
        }
    }
}
