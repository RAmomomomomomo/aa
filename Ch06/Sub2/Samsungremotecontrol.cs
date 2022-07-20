using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class Samsungremotecontrol : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("Samsung ChDown");
        }

        public void ChUp()
        {
            Console.WriteLine("Samsung ChOn");
        }

        public void Poweroff()
        {
            Console.WriteLine("Samsung PowerDown");
        }

        public void PowerOn()
        {
            Console.WriteLine("Samsung PowerOn");
        }

        public void SoundDown()
        {
            Console.WriteLine("Samsung SoundDown") ;
        }

        public void SoundUp()
        {
            Console.WriteLine("Samsung SoundOn");
        }
    }
}
