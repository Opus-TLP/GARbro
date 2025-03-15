namespace NetFrameworkCompat.Drawing;

public class BmpBitmapEncoder
{
    public List<BitmapFrame> Frames { get; set; }

    public void Save(Stream file)
    {
        throw new NotImplementedException();
    }
}