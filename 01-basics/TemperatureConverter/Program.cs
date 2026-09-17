// void - no returns
using TemperatureConverter;

void TemperatureConverter(double temperatureInCelsius)
{
    const double offset = 32;
    const double conversionFactor = 9.0 / 5.0;

    double fahrenheit = (temperatureInCelsius * conversionFactor) + offset;
    Console.WriteLine(fahrenheit);
}

TemperatureConverter(37);

double TemperatureFinder(double temperatureInCelsius)
{
    const double offset = 32;
    const double conversionFactor = 9.0 / 5.0;
    double fahrenheit = (temperatureInCelsius * conversionFactor) + offset;
    return fahrenheit;
}

double myTemperature = TemperatureFinder(37);

Console.WriteLine(myTemperature);

var Utilities = new Utilities();
var totalTemperatureinCelcius = Utilities.GetTemperature(38);

var totalTemperatureInKelvin = Utilities.GetTemperature(38, "Kelvin");

var normalizedTemperatureInKelvin = Utilities.GetTemperature(39, "Kelvin", 1);

Console.WriteLine($"\nTotal Temperature in Celcius is {totalTemperatureinCelcius} \n");

Console.WriteLine($"Total Temperature in Kelvin is {totalTemperatureInKelvin} \n");

Console.WriteLine($"Total Normalized Temperature is {normalizedTemperatureInKelvin} \n");


// Test optional param - optional param should be placed at end
Utilities.GetTemperatureOptional();

// Test named param - named param can have any order but values must be assigned
Utilities.GetTemperatureNamed();

// Test expression bodied syntax (fat arrow)
Utilities.GetTemperatureWithExpressionBodiedSyntax();