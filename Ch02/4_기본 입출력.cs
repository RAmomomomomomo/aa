using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    internal class _4_기본_입출력
    {
        //날짜:2022/7/12
        //이름:배석현
        //내용:기본입출력 실습p.90

        static void Main3(string[] args)
        {
            //이름 입력
            Console.Write("이름 입력: ");
            string name = Console.ReadLine();
            Console.WriteLine("나이 입력: ");
            string age = Console.ReadLine();
            Console.Write("주소 입력: ");
            string addr = Console.ReadLine();

            Console.WriteLine("=====================");
            Console.WriteLine($"이름: {name}");
            Console.WriteLine($"나이: {age}");
            Console.WriteLine($"주소: {addr}");
        }
    }
}
