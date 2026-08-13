class Program
{
    const float PI = 3.14F;

    static void Main()
    {
        Console.Write("Enter the radius of circle: ");
        string userInput = Console.ReadLine();
        float radius = float.Parse(userInput);
        float area = PI * radius * radius;
        Console.Write("Area of circle is "+ area+"\n");
    }

}