namespace _020_Class
{
    class Cat
    {
        public Cat(string _Name, int _Age)
        {
            Name = _Name;
            Age = _Age;
        }

        // 소멸자는 가비지콜렉터가 우리보다 똑똑하게 메모리 해제를 관리하기 때문에 안쓰는게 좋음
        ~Cat()
        {
            Console.WriteLine($"{Name} is Dead");
        }

        public Cat Copy()
        {
            Cat NewCalss = new Cat(this.Name, this.Age);
            return NewCalss;
        }

        public string Name;
        public int Age;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Cat Cat1 = new Cat("냥냥이", 5);
            Cat Cat2 = Cat1; // C#에서는 복사가 아닌 참조임.
            
            // 클래스는 기본적으로 참조형이기 때문에 Cat1을 참조하는 Cat2가 되어
            // Cat1의 정보가 바뀌면 Cat2도 바뀜
            Cat1.Age = -1;
            int Cat2_Age = Cat2.Age;


            Cat Cat3 = new Cat("애옹이", 8);
            Cat Cat4 = Cat3.Copy(); // 깊은 복사는 직접 구현해야함.

            // Cat3의 정보가 바뀌어도 Cat4는 그대로.
            Cat1.Age = -1;
            int Cat3_Age = Cat4.Age;
        }
    }
}
