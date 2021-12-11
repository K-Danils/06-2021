using System;

namespace DragRace
{
    public class Tesla : Car
    {
        private int _currentSpeed = 0;
        override public int SpeedIncrease { get;}
        override public int SpeedDecrease { get;}

        public Tesla()
        {
            SpeedIncrease = 15;
            SpeedDecrease = 10;
        }

        override public void StartEngine()
        {
            Console.WriteLine("-- silence ---");
        }
    }
}