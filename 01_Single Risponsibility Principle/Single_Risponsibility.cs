

// 단일 책임의 원칙 : 모든 클래스는 하나의 책임만 가져야 한다.

//   1. 클래스는 그 책임을 완전히 캡슐화 해야함.
//   2. 기능들을 한 곳에 구현하지 말고 개별적인 클래스를 만들어서 제작하는 것을 말함.

namespace Single_Risponsibility
{
    // 모듈을 분리하여 Player에 컴포넌트를 붙임 (Good)
    // 장점1 : 짧은 클래스가 읽기 쉬워 가독성이 높아짐.
    // 장점2 : 작은 클래스로부터 상속이 쉬워 확장성을 높일 수 있음.
    // 장점3 : 부분에서 재사용할 수 있도록 작고 모듈식으로 설계하려 재사용성을 높임
    public class Single_Risponsibility_Player
    {
        Component playerInput = new Input();
        Component playerMovement = new Movement();
        Component playerAudio = new Audio();
    }

    public class Component { }
    public class Input : Component { }
    public class Movement : Component { }
    public class Audio : Component { }

}

// 정리
// 작은 클래스들이 관리가 쉬움.
// 기능을 한곳에 모아두면 커지면 커질수록 기능 수정이 힘들어지고 분리또한 어려움.
// 기능들을 잘게 분리시켜서 조립하는 방식으로 짜면 개발을 효율적으로 할 수 있음.
