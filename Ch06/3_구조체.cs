using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06
{
    /* 날짜 :2022/07/20 
     * 이름 : 배석현
     * 내용 : 구조체 실습 p404
     * 
     * 
     * 구조체
     * - 간단하게 객체를 만들때 사용하는 구조형식
     * - 클래스와 동일하지만 상속,다형성등 지원안함
     */
    internal class _3_구조체
    {
        struct Point
        {
            public int x;
            public int y;

            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }

            public int add()
            {
                return x + y;
            }

        }
        static void Main3(string[] args)
        {
            Point p1;
            p1.x = 1;
            p1.y = 2;

            Console.WriteLine("p1 add"+p1.add());

            Point p2 =new Point(2,3);
            
            Console.WriteLine("p2 add" + p2.add());
        }
    }
}
