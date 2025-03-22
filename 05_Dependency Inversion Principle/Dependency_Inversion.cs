

// <의존 역전의 원칙> : 상위 모듈은 하위 모듈의 것을 직접 가져오면 안되며 추상화(인터페이스 또는 추상 클래스)를 통해 의존하도록 해야 한다.

//   1. 모듈 사이의 참조를 최대한 추상화 하여 결합도를 낮추고 모듈 별 응집도를 높여야함.
//   2. 얕은 참조를 통해 서로의 구현이 변경되더라도 잘 작동함으로서 코드 유지보수성과 확장성이 좋아짐.
//   3. A를 수정해도 B를 수정할 필요가 없어지는것.

namespace Dependency_Inversion
{
    // ISwitchable 이라는 Interface를 만듦.
    public interface ISwitchable
    {
        public bool IsActive { get; }
        public void Active();
        public void Deactive();
    }

    // 기믹은 ISwitchable를 받아서 인터페이스의 필드 구현
    public class MonoBehaviour { }  
    public class Door : MonoBehaviour, ISwitchable
    {
        private bool isActive;
        public bool IsActive => isActive;

        public void Active()
        {
            isActive = true;
            Console.WriteLine("Open the door");
        }

        public void Deactive()
        {
            isActive = false;
            Console.WriteLine("Close the door");
        }
    }

    // Switch는 ISwitchable를 받아 사용함으로써 Door를 알지 않아도 상태 변경이 가능하게 됨.
    public class Switch : MonoBehaviour
    {
        public ISwitchable client;
        public void Toggle()
        {
            if(client.IsActive)
            {
                client.Deactive();
            }
            else
            {
                client.Active();
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Door door = new Door();
            Switch newSwitch = new Switch();
            newSwitch.client = door;
            newSwitch.Toggle();
            newSwitch.Toggle();
        }
    }
}
