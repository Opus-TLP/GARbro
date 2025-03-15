namespace NetFrameworkCompat.Drawing;

public class BmpBitmapDecoder(Stream fileAsStream, BitmapCreateOptions none, BitmapCacheOption onLoad)
{
    public IList<BitmapFrame> Frames { get; set; }
}