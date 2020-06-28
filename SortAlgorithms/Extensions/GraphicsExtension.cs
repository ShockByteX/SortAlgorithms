using System.Drawing;
using System.Drawing.Drawing2D;

namespace SortAlgorithms.Extensions
{
    public static class GraphicsExtension
    {
        public static void ConfigureHiqhQuality(this Graphics graphics)
        {
            graphics.CompositingQuality = CompositingQuality.HighQuality;
            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
            graphics.SmoothingMode = SmoothingMode.HighQuality;
        }
    }
}