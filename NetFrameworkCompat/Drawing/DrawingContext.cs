namespace NetFrameworkCompat.Drawing;

public class DrawingContext : IDisposable
{
    public void Dispose()
    {
        // TODO release managed resources here
    }

    public void DrawImage(BitmapSource tile, Rect dstRect)
    {
        throw new NotImplementedException();
    }
}