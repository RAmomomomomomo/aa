using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{
    //날짜:2022/7/13
    //이름:배석현
    //내용:조건문 switch 실습p.138
    internal class _2_Switch문
    {
        static void Main2(string[] args)
        {
            Console.Write("숫자입력 : ");
            string strnumber = Console.ReadLine();

            int number = int.Parse(strnumber);

            switch (number % 2)
            {   
                case 0:
                    Console.WriteLine("짝");
                    break;
                case 1:
                    Console.WriteLine("홀");
                    break;
                
            }
        }
    }
}
