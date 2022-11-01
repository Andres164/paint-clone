using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficacionAndresCastro.Classes.DrawingTools
{
    internal class RegularPolygon : Polygon
    { 
        public void drawRegularPolygon(ref Bitmap canvas, Point polygonCenter, ref Brush brush)
        {
            List<Point> points = new List<Point>();
            double X, Y, radius = 30, verticesAngle = 360.0 / this.sides;
            for (double i = 0; i < 360; i += verticesAngle)
            {
                X = polygonCenter.X + radius * Math.Cos((i + 90 * (this.sides - 2) / this.sides) * Math.PI / 180);
                Y = polygonCenter.Y + radius * Math.Sin((i + 90 * (this.sides - 2) / this.sides) * Math.PI / 180);
                points.Add(new Point(Convert.ToInt32(X), Convert.ToInt32(Y)));
            }
            this.drawOnBitmap(ref canvas, points, ref brush);
        }
    }
}
