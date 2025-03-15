namespace NetFrameworkCompat.Drawing;

public class FormatConvertedBitmap : BitmapSource
{
    public FormatConvertedBitmap(BitmapSource bitmap, PixelFormat bgr32, object o, int i)
    {
        throw new NotImplementedException();
    }

    public FormatConvertedBitmap()
    {
        throw new NotImplementedException();
    }

    public void BeginInit()
    {
        throw new NotImplementedException();
    }

    public BitmapSource Source { get; set; }
    public PixelFormat DestinationFormat { get; set; }

    public void EndInit()
    {
        throw new NotImplementedException();
    }
}