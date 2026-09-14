namespace TemperatureConverter;

public class Utilities
{
    public double GetTemperature(double temperatureInCelsius)
    {
        const double offset = 32;
        const double conversionFactor = 9.0 / 5.0;
        double fahrenheit = (temperatureInCelsius * conversionFactor) + offset;
        return fahrenheit;
    }
}
