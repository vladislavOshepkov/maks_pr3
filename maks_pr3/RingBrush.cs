using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maks_pr3
{
    class RingBrush : Brush
    {
        public RingBrush(Color brushColor, int size) : base(brushColor, size) { }
        public override void Draw(Bitmap image, int x, int y)
        {
            int radius = Size;

            for (int y0 = -radius; y0 <= radius; ++y0)
            {
                for (int x0 = -radius; x0 <= radius; ++x0)
                {
                    if ((x0 * x0 + y0 * y0 <= radius * radius) && (x0 * x0 + y0 * y0 >= (radius * radius) - 20))
                    {
                        int pixelX = x + x0;
                        int pixelY = y + y0;

                        image.SetPixel(pixelX, pixelY, BrushColor);
                    }
                }
            }
        }
    }
}
