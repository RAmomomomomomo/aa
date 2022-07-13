using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book.Book_class02
{
    internal class P111
    {
        static void Main(string[] args)
        {
            Console.WriteLine("52");
            Console.WriteLine("273");
            Console.WriteLine("52.273");
            Console.WriteLine("103.32");

            Console.WriteLine(int.Parse("52").GetType());
            Console.WriteLine(int.Parse("273").GetType());
            Console.WriteLine(int.Parse("52.273").GetType());
            Console.WriteLine(int.Parse("103.32").GetType());
        }
    }
}
