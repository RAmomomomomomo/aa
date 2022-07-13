using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Book_class02
{
    internal class P106
    {
        static void Main(string[] args)
        {
            long longNumber = 2147483647L + 2147483647L;
            int intNumber = longNumber;
            Console.WriteLine(intNumber);
        }
    }
}
