namespace NetFrameworkCompat.Drawing;

public class PngBitmapDecoder(Stream fileAsStream, BitmapCreateOptions none, BitmapCacheOption onLoad)
{
    public IList<BitmapFrame> Frames { get; set; }
}