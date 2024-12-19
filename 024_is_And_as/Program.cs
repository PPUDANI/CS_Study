namespace _024_is_And_as
{
    class Animal
    {
        public string Name;
    }

    class Dog : Animal
    {
        public void Bark()
        {
            Console.WriteLine($"{Name} : Bark");
        }
    }

    class Cat : Animal
    {
        public void Meow()
        {
            Console.WriteLine($"{Name} : Meow");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Animal Ani1 = new Dog();
            Ani1.Name = "Spike";
            if (Ani1 is Dog)
            {
                Dog newDog = (Dog)Ani1;
                newDog.Bark();
            }

            Animal Ani2 = new Cat();
            Ani2.Name = "Tom";
            Cat? Cat1 = Ani2 as Cat;

            if (Cat1 != null)
            {
                Cat1.Meow();
            }
        }
    }
}
