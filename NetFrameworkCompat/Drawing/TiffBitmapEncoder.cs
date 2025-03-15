namespace NetFrameworkCompat.Drawing;

public class TiffBitmapEncoder
{
    public TiffCompressOption Compression { get; set; }
    public IList<BitmapFrame> Frames { get; set; }

    public void Save(Stream file)
    {
        throw new NotImplementedException();
    }
}