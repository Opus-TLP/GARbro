using System.Drawing;

namespace NetFrameworkCompat.Drawing;

public class BitmapPalette(Color[] readColorMap)
{
    public IList<Color> Colors { get; set; }
}