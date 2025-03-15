namespace NetFrameworkCompat.Drawing;

public class WriteableBitmap : BitmapSource
{
    public WriteableBitmap(BitmapSource source)
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
}