using System;

namespace DragRace
{
    public class Bmw : Car
    {
        override public int SpeedIncrease { get;}
        override public int SpeedDecrease { get;}

        public Bmw()
        {
            SpeedIncrease = 15;
            SpeedDecrease = 10;
        }

        override public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}