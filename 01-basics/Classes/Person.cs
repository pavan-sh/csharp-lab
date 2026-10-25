public class Person
{
    private readonly string firstName;
    private readonly string lastName;

    private readonly PersonStatus status;

    public static class ErrorMessages
    {
        public const string FirstNameError = "First name cannot be blank.";
        public const string LastNameError = "Last name cannot be blank.";
    }

    public enum PersonStatus
    {
        Unknown = 0,
        Active = 1,
        Inactive = 2
    }


    public Person(string firstName, string lastName, PersonStatus status = PersonStatus.Active)
    {
        if (!string.IsNullOrWhiteSpace(firstName))
        {
            this.firstName = firstName;
        }
        else
        {
            throw new ArgumentException(ErrorMessages.FirstNameError, nameof(firstName));
        }
        if (!string.IsNullOrWhiteSpace(lastName))
        {
            this.lastName = lastName;
        }
        else
        {
            throw new ArgumentException(ErrorMessages.LastNameError, nameof(lastName));
        }
        if (!Enum.IsDefined(status))
        {
            throw new ArgumentOutOfRangeException(nameof(status));
        }
        this.status = status;
    }

    public string GetFullNameWithStatus()
    {
        return $"{firstName} {lastName} - {status}";
    }

}