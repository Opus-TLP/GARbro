namespace NetFrameworkCompat.Drawing;

public class BitmapDecoder
{
    public static BitmapDecoder Create(Stream input, BitmapCreateOptions none, BitmapCacheOption onLoad)
    {
        throw new NotImplementedException();
    }

    public IList<BitmapFrame> Frames { get; set; }
}