using ClassroomManagement.Domain.Tools;
using System.Runtime.CompilerServices;

namespace ClassroomManagement.Domain.ValueObjects;

public class Name
{
    public Name(string firstName, string lastName)
    {
        FirstName = firstName.ThrowIfNullOrEmpty(nameof(firstName));
        LastName = lastName.ThrowIfNullOrEmpty(nameof(lastName));
    }

    public string FirstName { get; private set; }
    public string LastName { get; private set; }

    public static implicit operator string(Name name)
    {
        return $"{name.FirstName} {name.LastName}";
    }
}
