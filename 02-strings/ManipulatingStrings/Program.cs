public class ManipulatingStrings
{
    static string firstName = "John";
    static string lastName = "Doe";

    static string firstNameWithSpaces = " Jane";
    static string lastNameWithSpaces = "Doe ";

    public static void Main()
    {
        StringConcatinationWithPlusOperator();
        StringConcatinationWithConcat();
        TrimLowerCaseString();
        CheckIfStringHasValue();
        GetInitials();
    }

    public static void StringConcatinationWithPlusOperator()
    {
        Console.WriteLine("Concat strings with + :");
        string fullName = firstName +" "+ lastName;
        Console.WriteLine(fullName);
    }

    public static void StringConcatinationWithConcat()
    {
        Console.WriteLine("Concat strings with Concat function: ");
        string fullName = String.Concat(firstName, lastName); 
        Console.WriteLine(fullName);       
    }

    public static void TrimLowerCaseString()
    {
        Console.WriteLine("Clean string whitespaces with Trim(), lowercase and concatinate: ");
        string fullName = firstName.ToLower().Trim() + lastName.ToLower().Trim();
        Console.WriteLine(fullName);
    }

    public static void CheckIfStringHasValue()
    {
        Console.WriteLine("Check firstName, lastName has character A: ");
        if(firstName.Contains("o") || lastName.Contains("o"))
        {
            Console.WriteLine("Contains o");
        }
    }

    public static void GetInitials()
    {
        Console.WriteLine("Get Initials");
        string fullName = firstName.Substring(0, 1) + lastName.Substring(0,1);
        Console.WriteLine(fullName);
    }
    
}