using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09
{
    //대리자 선언
    public delegate int Mydelegate(int x, int y);
    public delegate int Sumdelgate(int[] arr);
    internal class _1_대리자
    {
        

        static void Main1(string[] args)
        {
            //대리자 초기화

            Mydelegate my1 = new Mydelegate(Plus);
            Mydelegate my2 = new Mydelegate(Minus);

            //대리자 실행

           int r1= my1(1, 2);
           int r2= my2(1, 2);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);

            //대리자 활용 : 메서드의 매개변수로 대리자 선언
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int rs1 = Sum(arr, OddSum);
            int rs2 = Sum(arr, EvenSum);

            Console.WriteLine("홀수합 : "+rs1);
            Console.WriteLine("짝수합 : "+rs2);

            //대리자 활용 : 익명 메서드로 활용

            var function=delegate ()
            {

            };
        }
        public static int Plus(int x, int y)
        {
            return x + y;
        }
        public static int Minus(int x, int y)
        {
            return x - y;
        }

        public static int OddSum(int[] arr)
        {
            int sum = 0;

            foreach(int n in arr)
            {
                if(n%2==1)
                {
                    sum += n;
                }
            }
            return sum;
        }public static int EvenSum(int[] arr)
        {
            int sum = 0;

            foreach(int n in arr)
            {
                if(n%2==0)
                {
                    sum += n;
                }
            }
            return sum;
        }
        public static int Sum(int[] arr,Sumdelgate sd)
        {
            return sd(arr);
        }
    }
}
