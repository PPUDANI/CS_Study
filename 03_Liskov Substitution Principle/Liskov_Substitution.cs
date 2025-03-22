

// 리스코프 치환 원칙 : 하위 클래스는 상위 클래스를 대체할 수 있어야 한다.

//   1. 즉, 기존 코드를 수정하지 않고도 하위 클래스를 상위 클래스처럼 사용할 수 있어야 한다
//   2. is a, has a 관계와 연관되어있음.

namespace Liskov_Substitution
{
    public interface IMovable
    {
        void GoFoward() { }
        void Reverse() { }
    }

    public interface ITurnable
    {
        void TurnLeft() { }
        void TurnRight() { }
    }

    public class MonoBehaviour { }
    public class RoadVehicle : MonoBehaviour, IMovable, ITurnable
    {
        float speed = 100f;
        float turnSpeed = 5f;

        public virtual void GoFoward()
        {
            Console.WriteLine("RoadVehicle : GoFoward");
        }

        public virtual void Reverse()
        {
            Console.WriteLine("RoadVehicle : Reverse");
        }

        public virtual void TurnLeft()
        {
            Console.WriteLine("RoadVehicle : TurnLeft");
        }

        public virtual void TurnRight()
        {
            Console.WriteLine("RoadVehicle : TurnRight");
        }
    };

    public class RailVehicle : MonoBehaviour, IMovable
    {
        float speed = 100f;

        public virtual void GoFoward()
        {
            Console.WriteLine("RailVehicle : GoFoward");
        }

        public virtual void Reverse()
        {
            Console.WriteLine("RailVehicle : Reverse");
        }
    };

    public class Navigator
    {
        public void Move(IMovable vehicle)
        {
            vehicle.GoFoward();
            vehicle.Reverse();
        }

        public void Turn(ITurnable turnable)
        {
            turnable.TurnLeft();
            turnable.TurnRight();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            RoadVehicle roadVehicle = new RoadVehicle();
            RailVehicle railVehicle = new RailVehicle();
            Navigator navigator = new Navigator();

            // 아래와 같이 하위 클래스를 넣어도 상위클래스로 업캐스팅되어 잘 작동하는 것을 볼 수 있음.
            navigator.Move(roadVehicle);
            navigator.Turn(roadVehicle);
            navigator.Move(railVehicle);
            // navigator.Turn(railVehicle); // error
        }
    }
}