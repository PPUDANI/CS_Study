namespace _034_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Stack<int> TestStack = new Stack<int>();

            // Arr 초기화 가능
            // 1 2 3의 순서대로 들어가기 때문에
            // pop을 하게되면 3 2 1 순으로 빠짐.
            int[] Arr = { 1, 2, 3 };
            Stack<int> Stack_Arr = new Stack<int>(Arr);
            // 1 0 0 0
            TestStack.Push(1);

            // 1 2 0 0  
            TestStack.Push(2);

            // 1 2 3 0
            TestStack.Push(3);

            // 1 2 3 4
            TestStack.Push(4);

            // 1 2 3 4 5 0 0 0
            TestStack.Push(5); 

            int Eliment = TestStack.Peek(); // 마지막에 push된 값 4
            int ElementAt = TestStack.ElementAt(1); // 1이 저장된 index = 3
            bool Contains = TestStack.Contains(1); // true

            int Sum = TestStack.Sum(); // 1 + 2 + 3 + 4 = 10
            int TestStackMax = TestStack.Max(); // 4
            int TestStackMin = TestStack.Min(); // 1

            foreach (int e in TestStack)
            {
                Console.Write("{0} ", e);
            }

            TestStack.Pop(); // 1 2 3 4 5 0 0 0
        }
    }
}
