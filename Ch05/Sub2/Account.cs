using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Account
    {
        //속성 : private 선언으로 캡슐화 
        private string bank;
        private string name;
        private string id;
        private int balance;


        //생성자  이거 위에 속성 다 드래그해서 우클릭으로 그냥 생성자 만들수 있음 
        public Account(string bank, string name, string id, int balance)
        {
            this.bank = bank;
            this.name = name;
            this.id = id;
            this.balance = balance;
        }



        //기능 : 일반적으로 외부에 기능을 제공하기 위해 public 

        public void Deposit(int money)
        {
            this.balance += money;
        }
        public void Withraw(int money) 
        {
            this.balance -= money;
        }
        public void Show() 
        {
            Console.WriteLine("===================");
            Console.WriteLine("은행명 : "+bank);
            Console.WriteLine("입금주 : "+name);
            Console.WriteLine("계좌번호 : "+id);
            Console.WriteLine("현재 잔액 : "+balance);
            Console.WriteLine("===================");
        }

    }
}
