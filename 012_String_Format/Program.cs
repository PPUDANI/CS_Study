using System.Globalization;
using static System.Console;

namespace _012_String_Format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Format()
            // {1, 2: 3}
            // 1 : 인자 순서[첨자]
            // 2 : 맞춤(-는 왼쪽맞춤 + 는 오른쪽 맞춤)
            // 3 : 변환 서식 지정 문자열
            string fmt = "{0, -8}| {1, -10}| {2, -7}| {3, -7}| {4, -5}";

            WriteLine(fmt, "Name", "Line", "Kill", "Death", "Assist");
            WriteLine("-----------------------------------------------");
            WriteLine(fmt, "Garen", "Top", "6", "7", "8");
            WriteLine(fmt, "Lux", "Mid", "2", "4", "6");
            WriteLine(fmt, "Gragas", "Jungle", "10", "5", "15");
            WriteLine(fmt, "Varus", "AD", "1", "108", "0");
            WriteLine(fmt, "Leona", "Suport", "128", "0", "3");
            WriteLine();

            // 변환 서식 지정 문자열
            WriteLine("Binary(-2100000000): {0:B}", -2100000000); // B : 2진수
            WriteLine("Binary(4): {0:B}", 4);
            WriteLine("Decimal: {0:D}", 0b0010000000); // Decimal : 10진수
            WriteLine("HexaDecimal: {0:X}\n", 255); // Hexa Decimal : 16진수

            WriteLine("Comma: {0:N}", 100000000); // N : 콤마 구분(123456-> 123,456.00)
            WriteLine("Comma: {0:N0}\n", 100000000); // N0 : 콤마 구분(123456-> 123,456.00)

            float Point = 123.45f;
            WriteLine("Percision: {0:F}", Point); // Percision : 고정소수점(123.45 -> 123.45)
            WriteLine("Exponential: {0:E}\n", Point); // Exponential : 지수(123.456789 -> 1.234568E+002)

            int Bill = 1200000000;
            WriteLine("Culture: {0:C}\n", Bill);

            // 날짜값
            DateTime dt = DateTime.Now;

            // 문화권 정보로 언어별 포맷 가능
            CultureInfo ciKO = new CultureInfo("ko-KR");
            CultureInfo ciUS = new CultureInfo("en-US");

            WriteLine(dt.ToString("yyyy-MM-dd tt HH:mm:ss (dddd)", ciKO));
            WriteLine(dt.ToString("yyyy-MM-dd tt HH:mm:ss (dddd)", ciUS));

            // ddd(3) dddd(full)
            WriteLine(dt.ToString("ddd, dddd", ciKO));
            WriteLine(dt.ToString("ddd, dddd", ciUS));

            // HH(24) hh(12)
            WriteLine("{0:HH:mm:ss}", dt);
            WriteLine("{0:hh:mm:ss}", dt);

            int? a = 0;

        }
    }
}
