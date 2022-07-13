using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch02
{
    internal class 문자열
    {

            //날짜:2022/7/13
            //이름:배석현
            //내용:문자열 실습p.112

        static void Main(string[] args)
        {
            string greeting = "Good Morning";
            Console.WriteLine(greeting);
            Console.WriteLine();

            //문자열 길이
            Console.WriteLine("길이 : " +greeting.Length);
            Console.WriteLine();

            //문자열 추출
            Console.WriteLine("greeting 1번째 문자: " + greeting[0]);
            Console.WriteLine("greeting 6번째 문자: " + greeting[5]);
            Console.WriteLine("greeting 12번째 문자: " + greeting[11]);
            Console.WriteLine();

            //문자열 인덱스
            Console.WriteLine("'G'의 인덱스:"+greeting.IndexOf('G'));
            Console.WriteLine("'M'의 인덱스:"+greeting.IndexOf('M'));
            Console.WriteLine("'o'의 인덱스:"+greeting.IndexOf('o'));
            Console.WriteLine("'o'의 인덱스:"+greeting.LastIndexOf('o'));
            //같은게 있으면 가장 앞에있는거만 발견함 대소문자 구분함 
            //라스트인덱스는 뒤에서 부터 찾음 
            Console.WriteLine();

            //문자열 자르기 
            Console.WriteLine("greeting 0~4 까지 문자열 : "+greeting.Substring(0,4));//공백포함 안함 (스타트인덱스, 사이즈 )
            Console.WriteLine("greeting 5~7 까지 문자열 : "+greeting.Substring(5,7));
            Console.WriteLine("greeting 5~마지막 까지 문자열 : "+greeting.Substring(5));
            Console.WriteLine();

            //문자열 교체
            string replaced = greeting.Replace("Morning", "Afternoon");
            Console.WriteLine(replaced);
            Console.WriteLine();

            //문자열 변환

            int var1 = 1;
            double var2 = 2.12345;
            bool var3 = true;

            string str1 = var1.ToString();
            string str2 = var2.ToString();
            string str3 = ""+var3; //Tostring 이랑 같은 의미임

            Console.WriteLine("str1 : "+str1);
            Console.WriteLine("str2 : "+str2);
            Console.WriteLine("str3 : "+str3);
            Console.WriteLine();

            string s1 = "100";
            string s2 = "3.14";
            string s3 = "False";

            int r1 = int.Parse(s1);
            double r2 =double.Parse (s2);
            bool r3 = bool.Parse(s3);

            Console.WriteLine("r1 : "+r1);
            Console.WriteLine("r2 : "+r2);
            Console.WriteLine("r3 : "+r3);



        }
    }
}
