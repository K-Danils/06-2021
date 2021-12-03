namespace FuelConsumptionCalculator
{
    public class Car
    {
        double startKilometers;
        double endKilomteters;
        double liters;

        public Car(double startOdo, double endingOdo, double liters)
        {
            this.startKilometers = startOdo;
            this.endKilomteters = endingOdo;
            this.liters = liters;
        }

        public double CalculateConsumption()
        {
            return ConsumptionPer100Km();
        }

        private double ConsumptionPer100Km()
        {
            double distance = endKilomteters - startKilometers;

            return distance / liters;
        }

        public bool GasHog()
        {
            return ConsumptionPer100Km() > 15;
        }

        public bool EconomyCar()
        {
            return ConsumptionPer100Km() < 5;
        }

        public void FillUp(int mileage, double liters)
        {
        }
    }
}
