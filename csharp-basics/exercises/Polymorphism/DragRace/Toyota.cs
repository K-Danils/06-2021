using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    public class Toyota : Car, IBoostable
    {
        override public int SpeedIncrease { get;}
        override public int SpeedDecrease { get;}
        public Toyota()
        {
            SpeedIncrease = 10;
            SpeedDecrease = 5;
        }
        public void UseNitrousOxideEngine()
        {
            StartingSpeed += 100;
        }
        public override void StartEngine()
        {
            Console.WriteLine("--- brooom broom brom ---");
        }
    }
}
