

// 인터페이스 분리 원칙 : 인터페이스를 작게 분리하여, 클라이언트(사용하는 클래스)가 자신에게 필요한 인터페이스만 의존해야 한다.

//   1. 기능 별로 분리하여 필요한 인터페이스만 받음으로써 의존성을 줄이고 유연성을 강화할 수 있음. (확장성 증가)
//   2. 그렇다고 너무 작게 분리하면 코드의 생산성이 떨어짐. (모든건 적당히)

namespace Interface_Segregation
{
    public interface IMovable
    {
        public float MoveSpeed { get; set; }
        public float Acceleration { get; set; }

        public void GoForward();
        public void Reverse();
        public void TurnLeft();
        public void TurnRight();
    }

    public interface IDamageable
    {
        public float Health { get; set; }
        public int Defense { get; set; }

        public void Die();
        public void TakeDamage();
        public void RestoreHealth();
    }

    public interface IUnitStats
    {
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
    }

    public class MonoBehaviour { }

    // EnemyUnit은 IMovable, IDamageable, IUnitStats 인터페이스를 받음.
    public class EnemyUnit : MonoBehaviour, IMovable, IDamageable, IUnitStats
    {
        #region IMoveable
        public float MoveSpeed { get; set; }
        public float Acceleration { get; set; }

        public void GoForward() { }
        public void Reverse() { }
        public void TurnLeft() { }
        public void TurnRight() { }
        #endregion

        #region IDamageable
        public float Health { get; set; }
        public int Defense { get; set; }

        public void Die() { }
        public void TakeDamage() { }
        public void RestoreHealth() { }
        #endregion

        #region IUnitStats
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
        #endregion
    }

    // ImmotalUnit은 죽지 않는 유닛이므로 IDamageable 인터페이스를 받지 않음.
    public class ImmotalUnit : MonoBehaviour, IMovable, IUnitStats
    {
        #region IMoveable
        public float MoveSpeed { get; set; }
        public float Acceleration { get; set; }

        public void GoForward() { }
        public void Reverse() { }
        public void TurnLeft() { }
        public void TurnRight() { }
        #endregion

        #region IUnitStats
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
        #endregion
    }

    // ExplodingBarrel은 움직일 필요 없으므로 IMovable을 받지 않음.
    public class ExplodingBarrel : MonoBehaviour, IDamageable, IUnitStats
    {
        #region IDamageable
        public float Health { get; set; }
        public int Defense { get; set; }

        public void Die() { }
        public void TakeDamage() { }
        public void RestoreHealth() { }
        #endregion

        #region IUnitStats
        public int Strength { get; set; }
        public int Dexterity { get; set; }
        public int Endurance { get; set; }
        #endregion
    }
}

// 정리
// 
// 한 인터페이스에 기능을 응집해두면 쓰지않는 매서드들도 갖게 되는 문제가 생김.
// 기능들을 적절히 분리하여 최대한 필요한 것만 가질 수 있도록 해야함.