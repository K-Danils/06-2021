using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DragRace
{
    public abstract class Car : ICar
    {
        private int _startingSpeed = 0;
        abstract public int SpeedIncrease { get;}
        abstract public int SpeedDecrease { get;}
        public int StartingSpeed { get => _startingSpeed; set => _startingSpeed = value; }

        public void SpeedUp()
        {
            StartingSpeed += SpeedIncrease;
        }

        public void SlowDown()
        {
            if (StartingSpeed > 0) { StartingSpeed -= SpeedDecrease; }
            else { StartingSpeed = 0; }
        }

        public string ShowCurrentSpeed()
        {
            return StartingSpeed.ToString();
        }

        abstract public void StartEngine();
    }
}
