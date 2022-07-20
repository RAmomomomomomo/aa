using Ch06.Sub1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06
{
    /* 날짜 :2022/07/20 
     * 이름 : 배석현
     * 내용 : 추상클래스 실습 p404
     * 
     * 추상클래스(Abstract calss)
     * - 공통의 기능은 하나의 ㅁ서드로 정의하고 개별적인 기능은 상속 받아 오버라이드 매서드로 정의하는 추상메서드 
     * -오직 상속을 목적으로 하는 클래스 
     */
    internal class _1_추상클래스
    {
        static void Main1(string[] args)
        {
           // Car car = new Car(); <<추상 클래스는 객체 생성할수 업음  

            Car sedan = new Sedan("그랜져", "검정", 0, 2000);
            sedan.SpeedUp(100);
            sedan.SpeedDown(20);
            sedan.Show();

            Car truck = new Truck("포터", "파랑", 0, 1);
            truck.SpeedUp(90);
            truck.SpeedDown(20);
            truck.Show();
        }
    }
}
