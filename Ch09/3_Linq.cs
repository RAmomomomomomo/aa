using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch09
{
    /*
     * linq는 걸렉션을 대상으로 데이터를 가공처리하기 위한 C#질의언어 
     * 
     * 
     * 
     * 
     */
    class Member
    {
        private string uid;
        private string name;
        private int age;

        public Member(string uid, string name, int age)
        {
            this.uid = uid;
            this.name = name;
            this.age = age;
        }

        public string Uid { get => uid; set => uid = value; }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
    //p.525
    internal class _3_Linq
    {
        static void Main(string[] args)
        {
            //컬렉션 생성
            List<int> myList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //결과 리스트 생성
            List<int> rsList1 = new List<int>();
            List<int> rsList2 = new List<int>();


            //for문을 이용한 짝수 추출
            foreach (int n in myList)
            {
                if (n%2==0)
                {
                    rsList1.Add(n);
                }

            }

            //람다식을 이용한 짝수 추출

            myList.ForEach((n) =>
            {
                if (n % 2 == 0)
                {
                    rsList2.Add(n);
                }
            });

            //Linq을 이용한 짝수 추출
            var rsList3 = from n in myList
                          where n % 2 == 0
                          select n;

            Console.WriteLine("rsList1 : "+String.Join(",",rsList1));
            Console.WriteLine("rsList2 : "+String.Join(",",rsList2));
            Console.WriteLine("rsList3 : "+String.Join(",",rsList3));
 
            //데이터가 5이상 큰 순서대로 추출
            
            var rsList4=from n in myList
                        where n>5
                        orderby n descending
                        select n;

            Console.WriteLine("rsList4 : "+String.Join(",",rsList4));

            //linq객체 리스트 활용

            List<Member> memberts = new List<Member>();
            memberts.Add(new Member("a101", "김유신", 25));
            memberts.Add(new Member("a102", "김춘추", 23));
            memberts.Add(new Member("a103", "장ㅂ고", 35));
            memberts.Add(new Member("a104", "강감찬", 45));
            memberts.Add(new Member("a105", "이순식", 55));




            //30세이상,이름 사전순 추출
            var lsList5 = from m in memberts
                          where m.Age >= 30
                          orderby m.Name ascending
                          select m;

            foreach (Member m in rsList5)
            {

            }

        }
    }
}
