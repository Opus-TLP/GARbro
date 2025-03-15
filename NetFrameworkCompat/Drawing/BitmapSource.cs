namespace NetFrameworkCompat.Drawing;

public class BitmapSource
{
    public int PixelWidth { get; set; }
    public int PixelHeight { get; set; }
    public PixelFormat Format { get; set; }

    public static BitmapSource Create(int infoWidth, int infoHeight, double defaultDpiX, double defaultDpiY, PixelFormat format, BitmapPalette palette, Array pixelData, int stride)
    {
        throw new NotImplementedException();
    }

    public void Freeze()
    {
        throw new NotImplementedException();
    }

    public void CopyPixels(Int32Rect rect, byte[] rowData, int stride, int i)
    {
        throw new NotImplementedException();
    }

    public void CopyPixels(byte[] pixels, int stride, int i)
    {
        throw new NotImplementedException();
    }
}