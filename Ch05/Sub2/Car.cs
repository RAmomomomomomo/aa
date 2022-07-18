using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch05.Sub2
{
    internal class Car
    {
        //속성(필드)
        private string name;
        private string color;
        private int speed;

        public string Name //Getter Setter == 프로퍼티 라고 함 
        { get => name; set => name = value; }
        public string Color 
        { 
            get => color;
            set => color = value; 
        }
        public int Speed 
        { 
            get => speed; 
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("speed는 0보다 작을 수 없다");
                    speed = 0;
                }
                else { 
                speed = value;
                }
            }
        }
        public Car() //bmw 오버라이드용
        { 
        }
        public Car(string name, string color, int speed)
        {
            this.name = name;
            this.color = color;
            this.speed = speed;
        }


        //기능(메서드)
        public void SpeedUp(int speed)
        {
            this.speed += speed;
        }
        public void SpeedDown(int speed) 
        {
            this.speed -= speed;
        }
        public void Show() 
        {
            Console.WriteLine("================");
            Console.WriteLine("차량명 : "+name);
            Console.WriteLine("차량색 : "+color);
            Console.WriteLine("현재 속도 : "+speed);
            Console.WriteLine("================");
        }
    }
}
