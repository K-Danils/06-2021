using System;

namespace DragRace
{
    public class Audi : Car
    {
        override public int SpeedIncrease { get;}
        override public int SpeedDecrease { get;}

        public Audi()
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