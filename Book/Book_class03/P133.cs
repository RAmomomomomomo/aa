using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Book_class03
{
    internal class P133
    {
        static void Main(string[] args)
        {
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침먹을시간");
            }
            else
            {
                if (DateTime.Now.Hour < 15)
                {
                    Console.WriteLine("점심시간");
                }
                else
                {
                    Console.WriteLine("저녁 먹을 시간 ");
                }
            }
        }
    }
}
