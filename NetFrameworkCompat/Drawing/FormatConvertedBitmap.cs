namespace NetFrameworkCompat.Drawing;

public class FormatConvertedBitmap : BitmapSource
{
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