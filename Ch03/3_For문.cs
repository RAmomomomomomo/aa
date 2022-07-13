using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch03
{//날짜:2022/7/13
    //이름:배석현
    //내용:조건문 for 실습p.167
    internal class _3_For문
    {
        static void Main(string[] args)
        {
            for (int i=1;i<=5;i++)
            {
                Console.WriteLine("{0}회 반복...",i);
            }
            int sum = 0;
            for(int k =1;k<=10;k++)
            {
                sum +=  k;
            }
            Console.WriteLine("1부터 10까지 합 : "+sum);

            for(int i = 0; i < 10; i++)
            {
                for (int k = 10-i-1; k >0 ; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <(i*2)+1; j++)
                {
                    Console.Write("*");
                }
                
                Console.WriteLine();
            }
        }
    }
}
