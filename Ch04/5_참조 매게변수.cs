using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{/*
  * 날짜:2022/07/14
    이름:배석현
    내용:메서드 참조 매개변수 실습하기 교재p275
  */
    internal class _5_참조_매게변수
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 3;
            int num3 = 0;
            int num4 = 0;

            MyDivider(num1, num2,ref num3,ref num4);  //ref 주소값을 전달함

            Console.WriteLine("몫 : {0}, 나머지 : {1}",num3,num4);


        }

        public static void MyDivider(int n1,int n2, ref int result1,ref int result2)
        {
            result1 = n1 / n2;
            result2 = n1 % n2;

        }
    }
}
