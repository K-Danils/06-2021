namespace FuelConsumptionCalculator
{
    public class Car
    {
        double startKilometers;
        double endKilomteters;
        double liters;

        public Car(double startOdo)
        {
            startKilometers = startOdo;
        }

        public double CalculateConsumption()
        {
            return ConsumptionPer100Km();
        }

        private double ConsumptionPer100Km()
        {
            return (liters * 100) / endKilomteters - startKilometers;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15.0;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5.0;
        }

        public void FillUp(int mileage, double liters)
        {
            this.liters = liters;
            endKilomteters = mileage;
        }
    }
}
