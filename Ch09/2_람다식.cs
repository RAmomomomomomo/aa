using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09
{
    /*
     * 람다식
     * 함수적 프로그래밍을 지원하기 위한 문법식
     * 대리자를 조금더 간편하게 사용하기 위한 식
     * 
     * 
     * 
     * 
     */
    internal class _2_람다식
    {
        static void Main2(string[] args)
        {
            Func<string> f1 = () => { return "f1 실행"; };
            Func<int, string> f2 = (x) => { return "f2 : " + x; };
            Func<int,int,string> f3=(x,y)=> { return $"f3 x : {x},y : {y}"; };

            string r1 = f1();
            string r2 = f2(2);
            string r3 = f3(3, 4);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);

            Action act1 = () => { Console.WriteLine("act1 실행"); };
            Action<int> act2 = (x) => { Console.WriteLine("act2 x :" + x); };
            Action<int, int> act3 = (x, y) =>  Console.WriteLine($"act3 x : {x},y : {y}");

            act1();
            act2(2);
            act3(3, 4);

            //람다식활용 : 컬렉션 메서드에 익명함수로 활용
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            myList.ForEach ((int n) =>
            {
                Console.Write(myList + " ");
            });
            Console.WriteLine();
        }
    }
}
