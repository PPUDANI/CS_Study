using System.Diagnostics.Metrics;

namespace _007_Const_And_Enum
{
    class Program
    {
        enum Player_State
        {
            Idle = 0,
            Move,
            Jump = 5,
            Crouch,
        }

        static void Main(string[] args)
        {
            const int Const_Val = 10;
            // Const_Val = 3; <- ERROR!

            Console.WriteLine($"Const_Val = {Const_Val}");

            Player_State StateCheck = Player_State.Idle;

            Console.WriteLine($"Idle = {(int)Player_State.Idle}");
            Console.WriteLine($"Move = {(int)Player_State.Move}");
            Console.WriteLine($"Jump = {(int)Player_State.Jump}");
            Console.WriteLine($"Crouch = {(int)Player_State.Crouch}");
        }
    }
}