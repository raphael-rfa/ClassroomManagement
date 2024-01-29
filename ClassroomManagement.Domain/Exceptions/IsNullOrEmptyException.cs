namespace ClassroomManagement.Domain.Exceptions;

public class IsNullOrEmptyException : ArgumentNullException
{
    public IsNullOrEmptyException(string? paramName) : base(paramName)
    {}
}
