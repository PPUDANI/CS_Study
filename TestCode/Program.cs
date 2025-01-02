namespace MyApp
{
    internal class Program
    {
        static IEnumerable<int> GenericTest()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
        }

        static void Main(string[] args)
        {
            foreach (int number in GenericTest())
            {
                Console.WriteLine(number);
            }
        }
    }
}
