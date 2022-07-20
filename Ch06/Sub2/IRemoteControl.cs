using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{ //인터페이스 만들때 이름 맨앞은 무조건 대문자 I로 시작하는 규칙이 있다네요 

    //인터페이스 : abstract메서든 갖는 구조체
    internal interface IRemoteControl
    {
        public abstract void PowerOn();
        public abstract void Poweroff();

        public void ChUp(); //인터페이스에서는 abstract안써도 된다네요
        public abstract void ChDown();

        public void SoundUp();
        public void SoundDown();
    }
}
