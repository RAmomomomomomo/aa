using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    internal class _2_자료형
    {
        static void Main1(string[] args)
        {
            //날짜:2022/7/12
            //이름:배석현
            //내용:자료형 실습p.83

            //자료형
            //-변수에 저장되는 데이터의 종류와 크기를 자료형으로 선언
            //-자료형은 크게 기본형과  참조형으로 나눔


            //정수형
            sbyte num1 = 127;
            short num2 =32676;
            int num3 = 2147483647;
            long num4 = 123124124124124124L;

             Console.WriteLine("num1:{0}",num1);
             Console.WriteLine("num2:{0}",num2);
             Console.WriteLine("num3:{0}",num3);
             Console.WriteLine("num4:{0}",num4);
            Console.WriteLine("");
            //실수형
            float var1 = 0.123456789132f;//8자리
            double var2 = 0.12345678978978978979878;//17자리
            Console.WriteLine("float:{0}", var1);
            Console.WriteLine("double:{0}", var2);
            Console.WriteLine("");
            //논리형
            bool b1 = true;
            bool b2 = false;
            Console.WriteLine("b1 : "+b1);
            Console.WriteLine("b2 : "+b2);
            Console.WriteLine("");

            //문자형
            char c1 = 'A';
            char c2 = '아';
            Console.WriteLine("");
            //문자열
            string s1 = "A";
            string s2 = "fffff";
            string s3 = "ㅎㅇ";
            string s4 = "123123";
            Console.WriteLine("s1:"+s1);
            Console.WriteLine("s2:"+s2);
            Console.WriteLine("s3:"+s3);
            Console.WriteLine("s4:"+s4);

            //var형 
            var v1 = 10;
            var v2 = "a";//자동 타입 변환 

            //object형
            //var형이랑 같은거 ㄱ ㅏㅌ은데?



        }
        



    }
}
