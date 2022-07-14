using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{
    //날짜:2022/07/14
    //이름:배석현
    //내용:메서드 실습하기 교재p256

    //c계열에서 메서드랑 클레스는 앞글자 대문자로 시작함 
    //변수는 소문자 

    /*메서드
     * -일련의 코드로직을 재활용하기 위해 모듈화된 구조체 
     * -메서드는 정의(define)하고 호출(call) 
     */
    internal class _1_메서드
    {
        static void Main1(string[] args)
        {
            Console.WriteLine("f1 : "+F(1));
            Console.WriteLine("f2 : "+F(2));
            Console.WriteLine("f3 : "+F(3));
            A();
            Console.WriteLine("Sum(1,10) : "+Sum(1,10));
            Console.WriteLine("Sum(1,10) : "+Sum(start:1,end:10));//이렇게도 가능함 


            
            
        }//end of main

        //메서드 정의 
        public static int F(int x)
        {
            int y = 2 * x + 3;
            return y;
        }
        public static void A()
        {
            Console.WriteLine("아앓");
        }
        public static int Sum(int start,int end)
        {
            int total = 0;
            for (int i = start; i <= end; i++)
            {
                total += i;
            }
            return total;
        }
    }
}
