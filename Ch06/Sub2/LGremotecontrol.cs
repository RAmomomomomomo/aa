using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class LGremotecontrol : IRemoteControl
    {
        public void ChDown()
        {
            Console.WriteLine("LG ChDown");
        }

        public void ChUp()
        {
            Console.WriteLine("LG ChUp");
        }

        public void Poweroff()
        {
            Console.WriteLine("LG Poweroff");
        }

        public void PowerOn()
        {
            Console.WriteLine("LG Poweron");
        }

        public void SoundDown()
        {
            Console.WriteLine("LG SoundDown");
        }

        public void SoundUp()
        {
            Console.WriteLine("LG SoundUp");

        }
    }
}
