using System;

namespace DragRace
{
    public class Lexus : Car, IBoostable
    {
        override public int SpeedIncrease { get;}
        override public int SpeedDecrease { get;}

        public Lexus()
        {
            SpeedIncrease = 15;
            SpeedDecrease = 10;
        }

        public void UseNitrousOxideEngine()
        {
            StartingSpeed += 50;
        }

        override public void StartEngine()
        {
            Console.WriteLine("Rrrrrrr.....");
        }
    }
}