using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch07
{
      /*
  * 날짜 :2022/07/25 
  * 이름 :배석현
  * 내용 :컬렉션 큐 실습
  * 
  * 딕셔너리
  * -키값 쌍으로 이루어진 자료구조 
  * -Dictionary는 Hashtable을 일반화 시켜 더 나은 성능을 제공
  * -list와 더불어 가장 많이 사용하는 자료구조 
  */
    internal class _4_HashTable
    {

        static void Main4(string[] args)
        {

            ////////////////
            ///HashTable
            ////////////////

            //테이블 생성

            Hashtable table =new Hashtable();

            //데이터 추가
            table['a'] = "Apple";
            table.Add('B', "Banana");
            table.Add('C', "Cherry");

            //x\데이터 삽입은 없는데? 삭제는 있음
            table.Remove('C');


            //데이터 출력
            foreach (char k in table.Keys)
            {
                Console.WriteLine("table : "+k);
            }


            ////////////////
            ///Dictionary
            ////////////////
            ///

            //딕셔너리 생성 
            Dictionary<char,string> dic=new Dictionary<char,string>();

            //데이터 추가

            dic['a'] = "Apple";
            dic.Add('B', "Banana");
            dic.Add('C', "Cherry");

            //데이터 삭제
            dic.Remove('B');

            //데이터 출력
            foreach (string k in dic.Values)
            {
                Console.WriteLine("dic : "+k);
            }

            List<Dictionary<int ,Apple>> apples =new List<Dictionary<int, Apple>>();



            
        }



    }
}
