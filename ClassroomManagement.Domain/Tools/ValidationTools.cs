using ClassroomManagement.Domain.Exceptions;

namespace ClassroomManagement.Domain.Tools;

public static class ValidationTools
{
    public static string ThrowIfNullOrEmpty(this string value, string name)
    {
        if (string.IsNullOrWhiteSpace(value))
            throw new IsNullOrEmptyException(name);

        return value;
    }

	public static int ThrowIfEqualZero(this int value, string message)
	{
		if (value.Equals(0))
			throw new EqualZeroException(message);

		return value;
	}
}
