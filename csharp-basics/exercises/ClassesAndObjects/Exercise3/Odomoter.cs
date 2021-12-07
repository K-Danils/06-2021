using System;

namespace Exercise3
{
    class Odometer
    {
        private int _mileage;
        private int _startingMileage;
        const int maxMileage = 999999;
        int consumption = 10;
        public FuelGauge FuelControl;

        public Odometer(int fuel, int mileage)
        {
            _mileage = mileage;
            _startingMileage = mileage;
            FuelControl = new FuelGauge(fuel);
        }

        public void ShowMileage()
        {
            Console.WriteLine(_mileage);
        }

        public void IncreaseMileage()
        {
            if (_mileage == maxMileage)
            {
                _mileage = 0;
            }
            else
            {
                _mileage++;
            }

            if (_mileage - _startingMileage >= consumption)
            {
                FuelControl.DecreaseFuel();
                _startingMileage = _mileage;
            }
        }
    }
}
