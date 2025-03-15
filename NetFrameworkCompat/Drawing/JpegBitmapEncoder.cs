namespace NetFrameworkCompat.Drawing;

public class JpegBitmapEncoder
{
    public int QualityLevel { get; set; }
    public IList<BitmapFrame> Frames { get; set; }

    public void Save(Stream file)
    {
        throw new NotImplementedException();
    }
}