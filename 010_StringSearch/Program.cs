using System.Text;
using static System.Console;

namespace _010_StringSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            WriteLine(greeting);
            WriteLine();

            // IndexOf()
            WriteLine("Index Of 'Good' : {0}", greeting.IndexOf("Good")); // 0
            WriteLine("Index Of 'M' : {0}", greeting.IndexOf('M')); // 5
            WriteLine("Index Of 'Morning' : {0}", greeting.IndexOf("Morning")); // 5
            WriteLine("Index Of 'z' : {0}\n", greeting.IndexOf('z')); // -1

            WriteLine("Last Index Of 'Good' : {0}", greeting.LastIndexOf("Good"));
            WriteLine("Last Index Of 'o' : {0}\n", greeting.LastIndexOf('o'));

            // StartsWith()
            WriteLine("Starts With 'Good' : {0}", greeting.StartsWith("Good"));
            WriteLine("Starts With 'Morning' : {0}\n", greeting.StartsWith("Morning"));

            // EndsWith()
            WriteLine("Ends With 'Good' : {0}", greeting.EndsWith("Good"));
            WriteLine("Ends With 'Morning' : {0}\n", greeting.EndsWith("Morning"));

            // Contains()
            WriteLine("Contains 'Evening' : {0}", greeting.Contains("Evening"));
            WriteLine("Contains 'Morning' : {0}\n", greeting.Contains("Morning"));

            // Replace()
            WriteLine("Eveninged 'Morning' with 'Evening' : {0}\n", greeting.Replace("Morning", "Evening"));

            // ToLower() and ToUpper()
            WriteLine("ToLower 'ABC' : {0}", "ABC".ToLower());
            WriteLine("ToUpper 'abc' : {0}\n", "abc".ToUpper());

            // Insert() and Remove()
            WriteLine("Insert 'Sunny' : {0}", "Happy Day!".Insert(5, "Sunny"));
            WriteLine("Remove 'Dont': {0}", "I Dont Love You!\n".Remove(2, 6));

            // Trim()
            WriteLine("Trim ' No Space ': {0}", " No Space ".Trim());
            WriteLine("TrimStart ' No Start Space': {0}", " No Start Space".TrimStart());
            WriteLine("TrimEnd 'No End Space ': {0}\n", "No End Space ".TrimEnd());

            ////////////////////////////////////////////////////////////////////////////////////////

            // String Intern Pool
            // C#은 내부적으로 문자열 상수 풀이 있어 그곳에 리터럴 문자열을 저장하고 관리한다.
            // str1과 str2의 주소를 비교하면 같다는 결과를 볼 수 있음.

            string str1 = "Hello";
            string str2 = "Hello";
            WriteLine(object.ReferenceEquals(str1, str2)); // True

            // str1 += 'A' 를 한다면 새로운 "HelloA" 라는 문자열을 만들어 저장하게 되므로
            // 이런식으로 문자열을 반복 수정할 경우 전체복사가 일어나 O(n^2)의 시간이 들게됨.
            // StringBuilder와 Append()를 이용하여 복사를 방지할 수 있음.

            StringBuilder sb = new StringBuilder("abc");
            sb.Append("d");  // "abcd"로 변경 (메모리 재할당 없음)
            WriteLine(sb.ToString());

            ////////////////////////////////////////////////////////////////////////////////////////





        }
    }
}
