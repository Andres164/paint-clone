using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficacionAndresCastro.Classes.DrawingTools
{
    internal class Polygon : Tool
    {
        protected Straight straight;
        protected int sides;
        public int Sides
        {
            get { return this.sides; }
            set
            {
                if (value > 2 && value < 250)
                    this.sides = value;
            }
        }

        public Polygon(int sides)
        {
            straight = new Straight();
            this.Sides = sides;
        }
        public override void drawOnBitmap(ref Bitmap canvas, List<Point> points, ref Brush brush)
        {
            this.straight.SelectedStyle = this.SelectedStyle;
            for (int i = 0; i < points.Count; i++)
            {
                List<Point> straightPoints = new List<Point>();
                straightPoints.Add(points[i]);
                int j = i < points.Count - 1 ? i + 1 : 0;
                straightPoints.Add(points[j]);
                this.straight.drawOnBitmap(ref canvas, straightPoints, ref brush);
            }
        }
    }
}
