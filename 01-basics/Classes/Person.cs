public class Person
{
    private readonly string firstName;
    private readonly string lastName;

    public Person(string firstName, string lastName)
    {
        if (!string.IsNullOrWhiteSpace(firstName))
        {
            this.firstName = firstName;
        }
        else
        {
            throw new ArgumentException("First name cannot be blank.", nameof(firstName));
        }
        if (!string.IsNullOrWhiteSpace(lastName))
        {
            this.lastName = lastName;
        }
        else
        {
            throw new ArgumentException("Last name cannot be blank.", nameof(lastName));
        }

    }

    public string GetFullName()
    {
        return $"{firstName} {lastName}";
    }

}