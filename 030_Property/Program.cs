using System.Xml.Linq;

namespace _030_Property
{
    // 프로퍼티란 변수의 get set 함수를 만들기 편하기 위해 사용되는 문법임.
    class Human
    {
        // >> 프로퍼티 기본 구현 방식
        //   Q: 이럴거면 private을 왜씀?
        //   A: 아래는 기본 구현이고 get, set에 조건부 추가가 가능함.
        private string name = "엄준식";
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        // 프로퍼티인 내부적으로 get set을 해줄 필드인 "백킹 필드(backing Field)"가 필요함.
        // Name 프로퍼티에서는 name이 그 백킹 필드임.
        // Q: 그냥 아래와 같이 Name을 필드 이름으로 사용할순 없음?
        // A: 실행해보면 계속적으로 프로퍼티를 찾기 때문에 스택 오버플로우 발생하므로 ㄴㄴ
        //public string Name2
        //{
        //    get
        //    {
        //        return Name2;
        //    }
        //    set
        //    {
        //        Name2 = value;
        //    }
        //}

        // 아래와 같이 구현도 가능함.

        // >> 프로퍼티 자동 구현
        // 암시적으로 내부에서 get, set 할 필드를 선언해서 사용되므로 간편함.
        // 암시적으로 구현된 필드는 private임.
        // 암시적이라 추가 조건을 못만듦.
        public int Age { get; set; } = 40;

        // get만 할수도 있음.
        public DateTime Birth { get;} = DateTime.MinValue;

        public char sex;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // 프로퍼티 생성자
            // 원하는 값만 초기화 가능함.
            Human adult = new Human()
            {
                Name = "젊음의상징",
                Age = 20,
                sex = 'M' // 필드도 가능한듯
            };

            char a = adult.sex;
            // adult.Name2 = "젊음의상징2"; -> Stackoverflow Exception!

            // adult.Birth = new DateTime(2000, 10, 4); -> get만 있으므로 ERROR!
        }
    }
}
