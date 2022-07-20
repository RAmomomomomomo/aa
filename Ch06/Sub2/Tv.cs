using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class Tv : Internet, Computer
    {
        public void PowerOn()
        {
            Console.WriteLine("Tv On");
        }
        public void AccessInternet()
        {
            base.Access();
        }

        public void Booting()
        {
            Console.WriteLine("Tv Booting");
        }
    }
}
