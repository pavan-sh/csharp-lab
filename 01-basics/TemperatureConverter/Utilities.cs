namespace TemperatureConverter;

public class Utilities
{
    const double offset = 32;
    const double conversionFactor = 9.0 / 5.0;

    const double kelvinConversionOffset = 273.15;
    public static double GetTemperature(double temperatureInCelsius)
    {
        double fahrenheit = (temperatureInCelsius * conversionFactor) + offset;
        return fahrenheit;
    }

    // Method overloading
    public static double GetTemperature(double temperatureInCelsius, string targetUnit)
    {
        switch (targetUnit)
        {
            case "Fahrenheit":
                return (temperatureInCelsius * conversionFactor) + offset;
                break;
            case "Kelvin":
                return (temperatureInCelsius + kelvinConversionOffset);
                break;
            default:
                return (temperatureInCelsius * conversionFactor) + offset;
                break;
        }
    }

    // Method overloading
    public static double GetTemperature(double temperatureInCelsius, string targetUnit, int decimalPlaces)
    {
        double output = 0;
        switch (targetUnit)
        {
            case "Fahrenheit":
                output = (temperatureInCelsius * conversionFactor) + offset;
                break;
            case "Kelvin":
                output = (temperatureInCelsius + kelvinConversionOffset);
                break;
            default:
                output = (temperatureInCelsius * conversionFactor) + offset;
                break;
        }
        return Math.Round(output, decimalPlaces); 
    }    
}
