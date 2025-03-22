

// 고수준 모듈이 저수준 모듈에 직접 의존하면, 저수준 모듈이 변경될 때마다 고수준 모듈도 변경해야 함 → 유지보수가 어려움
// 클래스가 다른 클래스와 관계가 있으면 안되고, 작동 방식을 많이 알고 있으면 안됨.
// 결합도가 높아지며 A를 수정하면 종속된 B도 수정해야 하는 일이 생김.

namespace BadCode
{
    // 아래는 switch가 Door를 알고 있는 구조임.
    // 만약 Door이외의 기믹들이 추가될 경우 Door처럼 Switch가 전부를 알아야 하는구조가 되버림.
    // 계속적으로 변경해야하는 문제가 생겨 코드의 생산성이 떨어짐. 
    public class MonoBehaviour { }
    public class Switch : MonoBehaviour
    {
        public Door door = new Door();
        public bool isActivaged;
        public void Toggle()
        {
            if (isActivaged)
            {
                isActivaged = false;
                door.Close();
            }
            else
            {
                isActivaged = true;
                door.Open();
            }
        }
    }

    public class Door : MonoBehaviour
    {
        public void Open()
        {
            Console.WriteLine("Open");
        }
        public void Close()
        {
            Console.WriteLine("Open");
        }
    }
}
