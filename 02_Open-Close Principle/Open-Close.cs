﻿

// 개방 폐쇄의 원칙 : 확장에 대해 열려있어야 하고 수정에는 닫혀있어야 된다.

//   1. 코드를 수정하지 않고 확장하는 것이 개발의 효율을 높임.
//   2. 기존에 잘 돌아가는 코드를 수정하지 않고 기능을 확장할 수 있어야 하는 것임. 즉 override 키워드와 연관이 깊음.
//   3. 외부 라이브러리의 코드를 수정하지 않고 사용하는 것 또한 개방 폐쇄의 원칙에 들어감.

namespace _02_Open_Closed_Principle
{
    // Shape라는 Calculator라는 매서드를 추상매서드(순수 가상 함수)를 구현.
    public abstract class Shape
    {
        public abstract float CalculateArea();
    }


    // Shape를 상속받아 추상함수를 개별적으로 재정의하여 기능을 확장. (확장에는 열려있음.)
    public class Rectangle : Shape
    {
        public float width;
        public float height;
        public override float CalculateArea()
        {
            return width * height;
        }
    }

    public class Circle : Shape
    {
        public float radius;
        public override float CalculateArea()
        {
            return radius * radius * MathF.PI;
        }
    };

    // AreaCalculator에서는 Shape로 업캐스팅하여 받아 사용하면 코드를 수정할 필요가 없으며 (수정에는 닫혀있음.)
    // 같은 매서드로 개별적인 연산이 가능해짐.
    public class AreaCalculator
    {
        public float GetArea(Shape _shape)
        {
            return _shape.CalculateArea();
        }
    }
}
