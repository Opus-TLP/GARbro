namespace NetFrameworkCompat.Drawing;

public struct PixelFormat
{
    public int BitsPerPixel { get; set; }

    public static bool operator ==(PixelFormat left, PixelFormat right)
    {
        throw new NotImplementedException();
    }

    public static bool operator !=(PixelFormat left, PixelFormat right)
    {
        return !(left == right);
    }
}