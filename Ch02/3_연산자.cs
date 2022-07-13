using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    
    internal class _3_연산자
    {
        //날짜:2022/7/12
        //이름:배석현
        //내용:연산자 실습p.90

        //연산자]
        //-변수에 저장된 데이터를 가공하기 위해 연산자를 사용
        //-연산자는 크게 밑에 적어둔게 있다 


        static void Main2(string[] args)
        {
            //산술연산자
            int num1 = 1;
            int num2 = 2;
            int num3 = 3;
            int num4 = 4;

            int s1 = num1+num2;
            int s2 = num1 - num2;
            int s3 = num1 + num3;
            int s4 = num1 - num4;

            Console.WriteLine("s1:"+s1);
            Console.WriteLine("s2:"+s2);
            Console.WriteLine("s3:"+s3);
            Console.WriteLine("s4:"+s4);


            Console.WriteLine(!true);
            Console.WriteLine(!false);
            Console.WriteLine(!(52<273));
            Console.WriteLine(!(52>273));



            string output = "hello ";
            output += "world";
            Console.WriteLine(output);
            //증감연산자
            //복합대입연산자  //걍 수학기호랑 같음 4개다 
            //비교연산자
            //논리연산자

            //삼항 연산자 
            int number = 1;
            string result = (number>1)?"맞음":"아님";  //(조건식)? 참일때:거짓일때   <<무조건 대입해서 사용해야 하나봄?

            Console.WriteLine(result);

           
        }
    }
}
