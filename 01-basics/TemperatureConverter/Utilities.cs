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

    public static double GetTemperatureExpressionBodied(double temperatureInCelsius) => (temperatureInCelsius * conversionFactor) + offset;

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
    public static double GetTemperature(double temperatureInCelsius, string targetUnit, int decimalPlaces = 0)
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

    public static void GetTemperatureOptional()
    {
        var output = GetTemperature(40, "Fahrenheit");
        Console.WriteLine($"The current temperature in Fahrenheit is - {output}");
    }   

    public static void GetTemperatureNamed()
    {
        var output = GetTemperature(targetUnit: "Kelvin", temperatureInCelsius: 33);
        Console.WriteLine($"The current temperature in Kelvin is - {output}");        
    }

    public static void GetTemperatureWithExpressionBodiedSyntax()
    {
        var output = GetTemperatureExpressionBodied(27);
        Console.WriteLine($"The Temperature in fahrenheit is - {output}");
    }
}
