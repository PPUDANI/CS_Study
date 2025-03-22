

// AreaCalculator라는 것에 Rectangle Circle 등 여러 연산을 해주는 클래스를 만들었음.
// 아래와 같이 구현하면 나중에 도형 별로 연산을 또 추가해 주어야 하고,
// 내부를 수정하게 되면 외부에서 사용하는 인터페이스도 수정해야할 경우가 생겨 코드 생산성이 좋지 않음.
namespace DefaultCode
{
    public class Ractangle
    {
        public float width;
        public float height;
    };

    public class Circle
    {
        public float radius;
    };

    public class AreaCalculator
    {
        public float GetRectangleArea(Ractangle _racangle)
        {
            return _racangle.width * _racangle.height;
        }

        public float GetCircleleArea(Circle _circle)
        {
            return _circle.radius * _circle.radius * MathF.PI;
        }
    }
}