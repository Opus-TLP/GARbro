namespace NetFrameworkCompat.Drawing;

public class WriteableBitmap : BitmapSource
{
    public WriteableBitmap(BitmapSource source)
    {
        throw new NotImplementedException();
    }

    public WriteableBitmap(int metaWidth, int metaHeight, double defaultDpiX, double defaultDpiY, PixelFormat bgra32, object o)
    {
        throw new NotImplementedException();
    }

    public unsafe byte* BackBuffer { get; set; }
    public int BackBufferStride { get; set; }

    public void Lock()
    {
        throw new NotImplementedException();
    }

    public void AddDirtyRect(Int32Rect int32Rect)
    {
        throw new NotImplementedException();
    }

    public void Unlock()
    {
        throw new NotImplementedException();
    }

    public void WritePixels(Int32Rect rect, byte[] pixels, int stride, int i)
    {
        throw new NotImplementedException();
    }

    public void WritePixels(Int32Rect srcRect, byte[] mTileBuffer, int mTileStride, int x, int y)
    {
        throw new NotImplementedException();
    }
}