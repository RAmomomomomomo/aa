using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Book_class03
{
    internal class P131
    {
        static void Main(string[] args)
        {
            Console.Write("숫자 입력 : ");
            int input = int.Parse(Console.ReadLine());

            if (input % 2 == 0)
            {
                Console.WriteLine("짝");
            }
            else
            {
                Console.WriteLine("홀");
            }

            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전");
            }
            else
            {
                Console.WriteLine("오후");
            }
        }
    }
}
