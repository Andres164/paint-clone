using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficacionAndresCastro.Classes.DrawingTools
{
    internal class Brush
    {
        public enum Sizes { Small, Medium, Big }
        public Color selectedColor { get; set; }
        public Sizes selectedSize { get; set; }

        public Brush()
        {
            selectedColor = Color.Black;
            selectedSize = Sizes.Small;
        }
        public void drawPixelOnBitmap(ref Bitmap canvas, Point location)
        {
            for (int i = 0; i <= (int)this.selectedSize; i++)
                for (int j = 0; j <= (int)this.selectedSize; j++)
                {
                    if (location.X + i >= 0 && location.X + i < canvas.Width && location.Y + j >= 0 && location.Y + j < canvas.Height)
                        canvas.SetPixel(location.X + i, location.Y + j, this.selectedColor); // Change the use of SetPixel to a more efficient method
                }
        }
    }
}
