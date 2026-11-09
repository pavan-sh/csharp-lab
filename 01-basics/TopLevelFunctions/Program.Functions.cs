
// The compiler puts top-level statements in a generated Program class.
// This partial declaration adds this method to that class.
partial class Program
{
    static void WhatsMyNamespaces()
    {
        Console.WriteLine("Namespace of class: {0}", arg0: typeof(Program).Namespace ?? "null");
    }
    static void NumbersTable(byte number = 1, byte size = 10)
    {
        Console.WriteLine($"\n Table for {number} with {size} row: \n");
        for (int row = 1; row <= size; row++)
        {
            Console.WriteLine($"{number} * {row} = {number * row}");
        }
    }
    /// <summary>
    /// This Function Calculates Tax Based On Country code
    /// </summary>
    /// <param name="amount">Amount Required To Be Converted</param>
    /// <param name="countryCode"></param>
    /// <returns></returns>
    static decimal GetTaxAmount(decimal amount, string countryCode)
    {
        decimal conversionFactor = countryCode switch
        {
            "CH" => 0.08M,
            "DK" or "NO" => 0.25M,
            "GB" or "FR" => 0.2M,
            "HU" => 0.27M,
            "OR" or "AK" or "MT" => 0.0M,
            "ND" or "WI" or "VA" or "ME" => 0.05M,
            "CA" => 0.0825M,
            "IN" => 0.5M,
            _ => 0.06M
        };
        return amount * conversionFactor;
    }
    /// <summary>
    /// This function converts Cardinal To Ordinal
    /// </summary>
    /// <param name="number">Number to be converted</param>
    static string CardinalToOrdinal(uint number)
    {
        // Keeping uint as we are dealing with non-negative only
        uint lastTwoDigit = number % 100;

        string cardinal = lastTwoDigit switch
        {

            11 or 12 or 13 => "th",
            _ => GetOrdinalFromLastTwo(lastTwoDigit)
        };

        string output = $"{number}{cardinal}";
        return output;


        static string GetOrdinalFromLastTwo(uint number)
        {
            uint lastTwo = number % 10;
            string ordinal = lastTwo switch
            {
                1 => "st",
                2 => "nd",
                3 => "rd",
                _ => "th"
            };
            return ordinal;
        }
    }
    static void GetOrdinalSeriesFromNumber(uint number)
    {
        for (uint i = 1; i <= number; i++)
        {
            Console.WriteLine(CardinalToOrdinal(i));
        }
        ;
    }
}

