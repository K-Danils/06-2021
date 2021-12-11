using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    class Alpine : Car
    {
        override public int SpeedIncrease { get;}
        override public int SpeedDecrease { get;}

        public Alpine()
        {
            SpeedIncrease = 20;
            SpeedDecrease = 15;
        }

        public override void StartEngine()
        {
            Console.WriteLine("--- brooom broom brom ---");
        }
    }
}
