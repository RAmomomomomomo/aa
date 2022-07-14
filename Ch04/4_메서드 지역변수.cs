using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{/*
  * 날짜:2022/07/14
    이름:배석현
    내용:메서드 지역변수 실습하기 교재p275
  */
    /*전역변수
     * - 모든 메서드에서 참조할 수 있는 변수
     * - 객체지향프로그래밍에서 전역변수는 맴버변수(속성) 이다
     * 
     * 
     * 지역변수
     * - 특정 메서드에서 선언한 변수로 해당 메서드에서만 참조할 수 있다 
     * - 해당 메서드가 끝나면 스택에서 사라짐 
     */
    
    internal class _4_메서드_지역변수
    {
        //전역변수
        static int result = 0;
        static void Main4(string[] args)
        {
            //지역변수
            int n1 = 1;
            int n2 = 10;

            result = Sum(n1, n2);
            Console.WriteLine("result : "+result);
        }

        public static int Sum(int start, int end)
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
