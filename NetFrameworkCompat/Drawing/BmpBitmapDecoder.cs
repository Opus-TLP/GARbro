namespace NetFrameworkCompat.Drawing;

public class BmpBitmapDecoder(Stream fileAsStream, BitmapCreateOptions none, BitmapCacheOption onLoad)
{
    public IEnumerable<BitmapFrame> Frames { get; set; }
}