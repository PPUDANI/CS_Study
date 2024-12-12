namespace _015_Switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("메뉴를 선택하세요(돈까스, 제육) : ");
            string? Menu = Console.ReadLine();

            // C# 또한 C++과 마찬가지로 점프 테이블을 생성해서 연속적인 값일 경우 점프 연산을 함.
            // 아래와 같은 경우에는 점프 테이블을 2개 생성함.

            // int a = 0;
            // switch (a)
            // {
            //     case 0: break;
            //     case 1: break;
            //     case 2: break;
            //     case 3: break;
            //     case 4: break;
            //     case 5: break;
            //     case 1050: break;
            //     case 1051: break;
            //     case 1052: break;
            //     case 1053: break;
            //     case 1054: break;
            //     case 1055: break;
            //     case 1056: break;
            //     case 1057: break;
            // }

            // 위 코드와 다르게 연속적이지 않다면 부분적으로 이분탐색을 실행함.(최적화함.)
            // 연속된 값일수록 처리 속도가 뛰어남.


            // C/C++은 switch에 string을 넣을 수 없지만 C#은 가능함.
            // 문자열 switch는 해시 테이블을 사용하여 상수시간에 처리 가능.
            switch (Menu)
            {
                case "돈까스":
                    Console.WriteLine("{0:N0}원 입니다.", 13900);
                    break;
                case "제육":
                    Console.WriteLine("{0:N0}원 입니다.", 9900);
                    break;
                default:
                    Console.WriteLine("그런 음식은 취급하지 않습니다.");
                    break;
            }


            Console.Write("Object를 입력하세요 : ");
            Object? obj = null;
            string? str = Console.ReadLine();

            if(int.TryParse(str, out int Out_i))
            {
                obj = Out_i;
            }
            else if(float.TryParse(str, out float Out_f))
            {
                obj= Out_f;
            }
            else
            {
                obj = str;
            }

            // Object의 타입별로 나눌수도 있음.
            // 타입별 분기하는 경우에는 when을 사용하여 조건을 더 붙일 수도 있음.
            switch (obj)
            {
                case int i when i < 0:
                    Console.WriteLine("{0}는 -1이 아닌 음수 int 형식입니다.", i);
                    break;
                case int i when (i % 2 == 1) && (i != 2):
                    Console.WriteLine("{0}는 2가 아닌 짝수인 양수 int 형식 입니다.", i);
                    break;
                case int i:
                    Console.WriteLine("{0}는 홀수인 양수 int 형식입니다.", i);
                    break;
                case float f when f < 0:
                    Console.WriteLine("{0}는 음수 float 형식입니다.", f);
                    break;
                case float f:
                    Console.WriteLine("{0}는 양수 float 형식입니다.", f);
                    break;
                default:
                    Console.WriteLine("{0}는 알 수 없는 형식입니다.", obj);
                    break;
            }

        }
    }
}
