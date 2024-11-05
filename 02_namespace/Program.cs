// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// "namespace"란 Potion이라는 클래스 이름이 겹치는 것을 방지하기 위해서
// 구역을 분리한 느낌.
// 프로그래머들이 협업하다보면 클래스의 이름을 지정할때 겹칠수가 있음.
// 그러므로 namespace로 분리하면 같은 이름의 클래스를 사용할 수 있다는것임.
// 이름으로 한번 더 묶었다 생각하면 됨.

namespace NS1
{
    class A
    {
    }
}

namespace NS2
{
    class A
    {
    }
}