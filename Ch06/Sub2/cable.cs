using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06.Sub2
{
    internal class cable : Socket
    {
        private Bulb bulb;

        public cable(Bulb bulb)
        {
            this.bulb = bulb;
        }
        public void SwitchDown()
        {
            bulb.Lightoff();
        }

        public void SwitchOn()
        {
            bulb.LightOn();
        }
    }
}
