﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{//날짜:2022/7/13
 //이름:배석현
 //내용:조건문 If 실습p.127
    internal class _1_If문
    {
        static void Main1(string[] args)
        {
            //if
            int num1 = 1;
            int num2 = 2;
            if (num1<num2)
            {
                Console.WriteLine("num1이 num2보다 작다");

            }

            if (num1 < 0)
            {
                Console.WriteLine("num1은 0보다 작음");
            }
            if (num1>0)
            {
                if (num2>1)
                {
                    Console.WriteLine("num1은 0보다 크고, num2는 1보다 크다");
                }
            }
            if (num1>0&&num2>1)
            {
                Console.WriteLine("num1은 0보다 크고그리고 num2는 1보다 크다");
            }
            Console.WriteLine();

            //if-else
            int var1 = 1,var2 = 2;
            if (var1>var2)
            {
                Console.WriteLine("var1이 var2보다큼");
            }
            else
            {
                Console.WriteLine("var1이 var2보다 작음");
            }

            Console.WriteLine();
            //if-else if -else
            int n1 = 1, n2 = 2,n3=3,n4=4;
            if (n1>n2)
            {
                Console.WriteLine("n1이 n2보다큼");
            }
            else if (n2>n3)
            {
                Console.WriteLine("n2이 n3보다큼");
            }
            else if (n3>n4)
            {
                Console.WriteLine("n3이 n4보다큼");
            }
            else
            {
                Console.WriteLine("n4가 제일큼");
            }
        }
    }

}
