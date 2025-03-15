using System.Drawing;

namespace NetFrameworkCompat.Drawing;

public class BitmapPalette(Color[] readColorMap)
{
    public Color[] Colors { get; set; }
}