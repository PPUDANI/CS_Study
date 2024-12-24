namespace TestCode
{
    interface a
    {
        void Run();
    }

    interface b : a
    {
        void Fly();
    }

    interface c : a
    {
        void crouch();
    }

    interface d : b, c
    {
        void drouch();
    }

    class Fuck : d
    {
        public void Run()
        {

        }

        public void crouch()
        {

        }

        public void Fly()
        {

        }

        public void drouch()
        {

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Fuck fuck = new Fuck();
            fuck.Run();
        }
    }
}
