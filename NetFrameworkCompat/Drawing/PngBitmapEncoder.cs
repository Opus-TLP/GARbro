namespace NetFrameworkCompat.Drawing;

public class PngBitmapEncoder
{
    public IList<BitmapFrame> Frames { get; set; }

    public void Save(Stream file)
    {
        throw new NotImplementedException();
    }
}