namespace NetFrameworkCompat;

public class FileFormatException : Exception
{
    public FileFormatException(string message) : base(message)
    {
    }

    public FileFormatException(string message, Exception inner) : base(message, inner)
    {
    }
}