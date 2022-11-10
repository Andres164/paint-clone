using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficacionAndresCastro.Classes.DrawingTools
{
    internal class Ellipse : Circle
    {
        protected int horizontalRadius;
        public int HorizontalRadius
        {
            get => this.horizontalRadius;
            set => this.horizontalRadius = value;
        }

        public Ellipse(int radius, int horizontalRadius) : base (radius) => this.HorizontalRadius = horizontalRadius;
        public override void drawOnBitmap(ref Bitmap canvas, List<Point> points, ref Brush brush)
        {
            Point center = points[0];
            int x, y, e;
            x = 0;
            y = this.radius;
            e = 2 * this.radius * this.radius + (1 - 2 * this.radius) * (this.horizontalRadius * this.horizontalRadius);
            while (this.radius * this.radius * x <= this.horizontalRadius * this.horizontalRadius * y)
            { 
                brush.drawPixelOnBitmap(ref canvas, new Point(center.X + x, center.Y + y));
                brush.drawPixelOnBitmap(ref canvas, new Point(center.X + x, center.Y - y));
                brush.drawPixelOnBitmap(ref canvas, new Point(center.X - x, center.Y + y));
                brush.drawPixelOnBitmap(ref canvas, new Point(center.X - x, center.Y - y));

                x += 1;
                if (e >= 0)
                {
                    e = e + 4 * this.horizontalRadius * this.horizontalRadius * (1 - y);
                    y = y - 1;
                }
                e = e + this.radius * this.radius * (4 * x + 6);
            }
            y = 0;
            x = this.horizontalRadius;
            e = 2 * this.horizontalRadius * this.horizontalRadius + (1 - 2 * this.horizontalRadius) * (this.radius * this.radius);

            while (this.horizontalRadius * this.horizontalRadius * y <= this.radius * this.radius * x)
            {
                brush.drawPixelOnBitmap(ref canvas, new Point(center.X + x, center.Y + y));
                brush.drawPixelOnBitmap(ref canvas, new Point(center.X + x, center.Y - y));
                brush.drawPixelOnBitmap(ref canvas, new Point(center.X - x, center.Y + y));
                brush.drawPixelOnBitmap(ref canvas, new Point(center.X - x, center.Y - y));
                y = y + 1;
                if (e >= 0)
                {
                    e = e + 4 * this.radius * this.radius * (1 - x);
                    x = x - 1;
                }
                e = e + this.horizontalRadius * this.horizontalRadius * (4 * y + 6);
            }
        }
    }
}
