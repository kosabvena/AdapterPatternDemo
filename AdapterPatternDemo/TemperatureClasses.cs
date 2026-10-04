using System;

namespace AdapterPatternDemo
{
    public interface ITemperatureSensor
    {
        double GetTemperatureCelsius();
    }

    public class LegacyFahrenheitSensor
    {
        private readonly Random _rnd = new Random();

        public double ReadFahrenheit()
        {
            return 60 + _rnd.NextDouble() * 20; 
        }
    }

    public class SensorAdapter : ITemperatureSensor
    {
        private readonly LegacyFahrenheitSensor _legacySensor;

        public SensorAdapter(LegacyFahrenheitSensor legacySensor)
        {
            _legacySensor = legacySensor;
        }

        public double GetTemperatureCelsius()
        {
            double fahrenheit = _legacySensor.ReadFahrenheit();
            return (fahrenheit - 32) * 5.0 / 9.0;
        }
    }
}