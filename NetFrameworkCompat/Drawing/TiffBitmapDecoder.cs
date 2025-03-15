namespace NetFrameworkCompat.Drawing;

public class TiffBitmapDecoder(Stream fileAsStream, BitmapCreateOptions preservePixelFormat, BitmapCacheOption onLoad)
{
    public IList<BitmapFrame> Frames { get; set; }
}