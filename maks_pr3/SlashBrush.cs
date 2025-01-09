using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maks_pr3
{
    class SlashBrush : Brush
    {
        public SlashBrush(Color brushColor, int size) : base(brushColor, size) { }
        public override void Draw(Bitmap image, int x, int y)
        {
            int size = Size;

            for (int i = -size; i <= size; ++i)
            {
                int pixelX = x + i;
                int pixelY = y + i;

                image.SetPixel(pixelX, pixelY, BrushColor);
            }
        }
    }
}
