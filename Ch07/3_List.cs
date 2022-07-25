using Ch07.Sub1;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
* 날짜 :2022/07/25 
* 이름 :배석현
* 내용 :컬렉션 리스트 실습
* 
* 리스트
* -배열과 유사한 선형 자료구조로 배열과 다르게 동적으로 데이터를 처리 
* -ArratList일반화 시켜 더나은 성능을 가진 List를 사용 
* 
* 
* 
*/
namespace Ch07
{
  internal class _3_List
  {
        static void Main3(string[] args)
        {
            /////////////////////
            ///ArrayList
            /////////////////////
            //ArrayList 생성

            ArrayList arrlist1=new ArrayList();
            arrlist1.Add(1);
            arrlist1.Add(2);
            arrlist1.Add(3);
            arrlist1.Add(4);
            arrlist1.Add(5);

            //데이터 삽입

            arrlist1.Insert(1, 6);


            //데이터 삭제
            arrlist1.Remove(4);
            //자리 4번을 삭제하는게 아니라 4값 자체를 삭제함 
            arrlist1.RemoveAt(0);//첫번째 말함 리스트는 0부터 시작 

            //데이터 출력

            foreach (int n in arrlist1)
            {
                Console.Write(n+" ");
            }
                Console.WriteLine();

            //다양한 타입의 데이터를 갖는 Arratlist
            ArrayList arrlist2 = new ArrayList();
            arrlist2.Add(1);
            arrlist2.Add(1.23);
            arrlist2.Add(true);
            arrlist2.Add('A');
            arrlist2.Add("Apple");

            for (int i = 0; i < arrlist2.Count; i++)
            {
                Console.Write(arrlist2[i]+" ");
            }
            Console.WriteLine();

            /////////////////////
            //// List
            /////////////////////
            //List생성

            List<int> list = new List<int>();
            

            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            //데이터 삽입 
            list.Insert(1, 6);

            //데이터 삭제 
            //arrylist랑 똑같음

            //데이터 출력
            foreach (int n in arrlist1)
            {
                Console.Write(n + " ");
            }
                Console.WriteLine();

            List<Apple> list3 = new List<Apple>();

            list3.Add(new Apple("한국", 3000));
            list3.Add(new Apple("미국", 2000));
            list3.Add(new Apple("일본", 1000));
        }
    
  }
}
