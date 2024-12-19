namespace _023_sealed
{
    // sealed 키워드를 붙이면 상속이 불가능해짐.
    sealed class A
    {

    }

    class B : A // ERROR!
    {

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}
