using Ch06.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06
{   /* 날짜 :2022/07/20 
     * 이름 : 배석현
     * 내용 : 인터페이스 실습 p425
     * 
     * 인터페이스
     * -클레스간 공통의 표준 가이드 역활을 위한 구조체
     * -인터페이스를 활용해서 객체간 결합도를 완화
     */
    internal class _2_인터페이스
    {
        static void Main(string[] args)
        {
            //////////////////////////////////////
            //인터페이스로 공통 클래스 설계에 활용 <<추상클래스랑똑같음
            //////////////////////////////////////
            IRemoteControl lg      = new LGremotecontrol();
            IRemoteControl samsung = new Samsungremotecontrol();

            lg.PowerOn();
            lg.ChUp();
            lg.SoundDown();

            samsung.PowerOn();
            samsung.ChUp();
            samsung.SoundDown();

            //////////////////////////////////////
            //인터페이스로 다중 상속에 활용
            //////////////////////////////////////
            Tv smartTv = new Tv();
            smartTv.PowerOn();
            smartTv.Booting();
            smartTv.AccessInternet();

            //////////////////////////////////////
            //인터페이스로 객체간 결합도 완화에 활용 
            //////////////////////////////////////
            Bulb bulb =new Bulb();
            Socket socket = new cable(bulb);

            socket.SwitchOn();
            socket.SwitchDown();

        }
    }
}
