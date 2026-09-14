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
var totalTemperature = Utilities.GetTemperature(38);

Console.WriteLine(totalTemperature);