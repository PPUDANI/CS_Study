

// Player의 입력, 오디오, 움직임 기능을 Player 클래스 한곳에 구현했음. (Bad)
// 단점1 : 기능이 길어 클래스 가독성이 떨어짐.
// 단점2 : 기능의 응집도가 높아 확장성이 떨어짐. (필요없는 기능을 뺄 수 없음.)
// 단점3 : 기능들을 다른곳에서 재사용할 수 없어, 코드의 재사용성이 낮아짐. (movement를 가져가고싶다면 Player를 가져가야하므로 비효율적.)

namespace BadCode
{
    class Player
    {
        void Input() { }
        void Movement() { }
        void PlayAudio() { }
    }
}