namespace NetFrameworkCompat.Drawing;

public class JpegBitmapDecoder(Stream fileAsStream, BitmapCreateOptions none, BitmapCacheOption onLoad)
{
    public IList<BitmapFrame> Frames { get; set; }
}