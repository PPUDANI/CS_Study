namespace _028_Interface
{
    class Actor()
    {

    }

    class Bullet : Actor
    {
        public void CollisionCheck(Actor? _Object)
        {
            IHitBulletInterface? Inter = _Object as IHitBulletInterface;
            
            if (Inter != null)
            {
                Inter.HitInteraction();
            }
        }
    }

    interface IHitBulletInterface
    {
        void HitInteraction();
    }

    class Human : Actor, IHitBulletInterface
    {
        public void HitInteraction()
        {
            Console.WriteLine("윽!");
        }
    }

    class Dog : Actor, IHitBulletInterface
    {
        public void HitInteraction()
        {
            Console.WriteLine("깨갱!");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Bullet bullet = new Bullet();
            Human human = new Human();
            Dog dog = new Dog();

            bullet.CollisionCheck(human);
            bullet.CollisionCheck(dog);
        }
    }
}
