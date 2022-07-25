using System;
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
  * 큐 
  * -가장 기본적인 자료구조 
  * -먼저 입력된 데이터가 먼저 출력되는 선형구조 
  * -다양한 알고리즘및 함수 호출에 사용
  * 
  * 
  */
    internal class _2_Queue
    {
        static void Main2(string[] args)
        {
            Queue<string> que = new Queue<string>();

            que.Enqueue("김유신");
            que.Enqueue("김춘추");
            que.Enqueue("장보고");
            que.Enqueue("강감찬");
            que.Enqueue("이순신");

            while (que.Count>0)
            {
                Console.WriteLine(que.Dequeue());
            }
        }
    }
}
