namespace ClassroomManagement.Domain.Tools;

public static class ValidationTools
{
    public static string ThrowIfNullOrEmpty(this string value, string name)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new ArgumentNullException(name);

        return value;
    }
}
