

namespace BadCode
{
    // 차량을 움직이는 클래스
    public class Navigator
    {
        void Move(Vehicle _vehicle)
        {
            _vehicle.GoFoward();
            _vehicle.Reverse();
            _vehicle.TurnLeft();
            _vehicle.TurnRight();
        }
    }

    // 차량 클래스
    public class Vehicle
    {
        float speed = 100f;
        float turnSpeed = 5f;
        public virtual void GoFoward() { }
        public virtual void Reverse() { }
        public virtual void TurnLeft() { }
        public virtual void TurnRight() { }
    };

    // 차량을 상속받은 Car 클래스
    public class Car : Vehicle
    {
        public override void GoFoward() { }
        public override void Reverse() { }
        public override void TurnLeft() { }
        public override void TurnRight() { }
    };

    // 기차는 레일로 움직이기 때문에 회전 매서드가 필요가 없다고 한다면.
    // vehicle을 받는 것은 필요없는 매서드 인터페이스가 만들어지고
    // 필요없는 이 매서드를 호출할 수도 있는 문제가 발생함.
    public class Train : Vehicle
    {
        public override void GoFoward() { }
        public override void Reverse() { }
        public override void TurnLeft() { } // x
        public override void TurnRight() { } // x
    };
}