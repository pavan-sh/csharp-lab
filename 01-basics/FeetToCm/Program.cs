Console.Write("\nEnter height in feet, eg. (5.9): ");
string userInput = Console.ReadLine();

float userHeightInFeet = float.Parse(userInput);
const float cmConversionFactor = 30.48F;
float heightInFeet = userHeightInFeet * cmConversionFactor;

Console.WriteLine($"Height in centimeter is: {heightInFeet} \n");
