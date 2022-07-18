using Ch05.Sub2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05
{/*
  * 날짜 : 2022/07/18
  * 이름 : 배석현
  * 내용 : 캡슐화 실습 p203
  * 
  * 캡슐화
  * -캡슐화는 객체의 내용(필드)을 외부에서 참조하지 못하도록 객체의 정보(속성)를 은닉하는 특성
  * -캡슐화를 위해 접근 제한자 public,private,protected를 사용한다 
  * -은닉된 정보의 안전한 제공을 위해 Getter,Setter를 사용(프로퍼티)
  */
    internal class _2_캡슐화
    {
        static void Main2(string[] args)
        {
            //Account 객체 생성
            Account kb = new Account("국민은행","김성근","111-1111",10000);
            Car ss = new Car("벤츠","흰색",10);

            ss.SpeedUp(100);
            

            //Account 객체 초기화
            //kb.name = "ㅗㅗㅗ";
            //kb.id = "111-1111";
            //kb.bank = "국민 은행";
            //kb.balance = 10000;
            
            //Account 객체 활용

            kb.Deposit(5000);
            kb.Withraw(500);

       
            kb.Show();
            ss.Show();

            //Getter Setter활용
            Car bmw = new Car();
            bmw.Name = "BMW 520";
            bmw.Color = "남색";
            bmw.Speed = -10;

            Console.WriteLine("bmw name : "+bmw.Name);
            Console.WriteLine("bmw color : "+bmw.Color);
            Console.WriteLine("bmw speed : "+bmw.Speed);

            


        }
    }
}
