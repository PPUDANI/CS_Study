

// 아래와 같이 한 인터페이스에 기능을 몰아두면 확장성이 떨어짐.
namespace BadCode
{
    public interface IUnitStats
    {
        public float Health { get; set; }
        public int Defense { get; set; }
        public void Die();
        public void TakeDamage();
        public void RestoreHealth();
        public float MoveSpeed { get; set; }
        public float Acceleration { get; set; }
        public void GoForward();
        public void Reverse();
        public void TurnLeft();
        public void TurnRight();
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
    }
}
