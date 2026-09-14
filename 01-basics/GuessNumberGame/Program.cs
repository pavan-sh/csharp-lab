Console.WriteLine("Think of a number between 1 and 9:");

int number = int.Parse(Console.ReadLine());
int numberCopy = number;
number = number * 2;
number = number + 10;
number = number / 2;
number = number - numberCopy;

Console.WriteLine($"Your final number is {number}");