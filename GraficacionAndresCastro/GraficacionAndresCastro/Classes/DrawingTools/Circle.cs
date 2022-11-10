using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficacionAndresCastro.Classes.DrawingTools
{
    internal class Circle : Tool
    {
        protected int radius;
        public int Radius 
        { 
            get => this.radius; 
            set => this.radius = value;
        }
        public Circle(int radius) => this.radius = radius;
        // points should be a single Point and not a list, this represents the circumferences center
        public override void drawOnBitmap(ref Bitmap canvas, List<Point> points, ref Brush brush)
        {
            Point center = points[0];
            int x, y, e;
            x = this.radius; y = 0; e = 0;
            while (y <= x)
            {
                brush.drawPixelOnBitmap( ref canvas, new Point( center.X + x, center.Y + y ) );
                brush.drawPixelOnBitmap( ref canvas, new Point( center.X - x, center.Y + y ) );
                brush.drawPixelOnBitmap( ref canvas, new Point( center.X + x, center.Y - y ) );
                brush.drawPixelOnBitmap( ref canvas, new Point( center.X - x, center.Y - y ) );
                brush.drawPixelOnBitmap( ref canvas, new Point( center.X + y, center.Y + x ) );
                brush.drawPixelOnBitmap( ref canvas, new Point( center.X - y, center.Y + x ) );
                brush.drawPixelOnBitmap( ref canvas, new Point( center.X + y, center.Y - x ) );
                brush.drawPixelOnBitmap( ref canvas, new Point( center.X - y, center.Y - x ) );

                e = e + 2 * y + 1;
                y = y + 1;
                if ((2 * e) > (2 * x - 1))
                {
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
        }
    }
}
