using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch04
{/*
  * 날짜:2022/07/14
    이름:배석현
    내용:메서드 타입 실습하기 교재p256
  */
    internal class _2_메서드_형태
    {
        static void Main2(string[] args)
        {
           double y1= Type1(1);
           double y2= Type1(1.13);

            Console.WriteLine("y1 : "+y1);
            Console.WriteLine("y2 : "+y2);

            Type2(true);
            Type2(false);

            string r1=Type3();

        }


        //typr1 : 매개변수 ㅇ 리턴값 ㅇ
        public static double Type1(double x) 
        {
           double y= x + Math.PI;
            return y;
        }

        //typr1 : 매개변수 ㅇ 리턴값 x
        public static void Type2(bool status) 
        {
            if (status)
            {
                Console.WriteLine("참");
            }
            else
            {
                Console.WriteLine("거짓");
            }
        }
        //typr1 : 매개변수 x 리턴값 ㅇ
        public static string Type3() 
        {
            int n1 = 1;
            int n2 = 2;

            if (n1>n2)
            {
                return "n1은 n2보다 크다";
            }
            else
            {
                return "n1은 n2보다 작다";
            }
        }
        //typr1 : 매개변수 x 리턴값 x
        public static void Type4()
        {
        }
    }
}
