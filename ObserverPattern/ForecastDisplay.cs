namespace DesignPatterns.ObserverPattern
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;
        private WeatherData weatherData;
        public ForecastDisplay(WeatherData weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temp, float humidity, float pressure)
        {
            lastPressure = currentPressure;
            currentPressure = pressure;
            Display();
        }
        public void Display()
        {
            System.Console.WriteLine("Forecast: ");
            if (currentPressure > lastPressure)
            {
                System.Console.WriteLine("Improving weather on the way!");
            }
            else if (currentPressure == lastPressure)
            {
                System.Console.WriteLine("More of the same");
            }
            else if (currentPressure < lastPressure)
            {
                System.Console.WriteLine("Watch out for cooler, rainy weather");
            }
        }
    }
}