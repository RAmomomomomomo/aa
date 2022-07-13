using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Book_class02
{
    internal class P108
    {
        static void Main(string[] args)
        {
            long longNumber = 52273;
            int intNumber = (int)longNumber;
            Console.WriteLine(intNumber);

            long longNumber1 = 2147483647L + 2147483647L;
            int intNumber1 = (int)longNumber;
            Console.WriteLine(longNumber1);

            double doubleNumber = 52.27310332;
            int doubleToInt = (int)doubleNumber;
            Console.WriteLine(doubleToInt);
        }
    }
}
