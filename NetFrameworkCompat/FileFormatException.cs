namespace NetFrameworkCompat;

public class FileFormatException : Exception
{
    protected FileFormatException(string message) : base(message)
    {
    }

    protected FileFormatException(string message, Exception inner) : base(message, inner)
    {
    }
}