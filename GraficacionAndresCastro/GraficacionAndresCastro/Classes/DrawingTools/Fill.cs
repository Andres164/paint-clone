using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficacionAndresCastro.Classes.DrawingTools
{
    internal class Fill : Tool
    {
        public override void drawOnBitmap(ref Bitmap canvas, List<Point> points, ref Brush brush)
        {
            Stack<Point> neighbours = new Stack<Point>();
            //neighbours.
            Color backColor = (Color)(canvas.GetPixel(points[0].X, points[0].Y));
            if (backColor != brush.selectedColor)
            {
                MessageBox.Show($"BackColor: {backColor}\nselectedColor: {brush.selectedColor}");
                neighbours.Push(points[0]);
            }
            while (neighbours.Count != 0)
            {
                Point pointToFill = neighbours.Pop();
                if (canvas.GetPixel(pointToFill.X, pointToFill.Y) == backColor)
                {
                    canvas.SetPixel(pointToFill.X, pointToFill.Y, brush.selectedColor);
                    neighbours.Push(new Point(pointToFill.X+1, pointToFill.Y));
                    neighbours.Push(new Point(pointToFill.X-1, pointToFill.Y));
                    neighbours.Push(new Point(pointToFill.X, pointToFill.Y+1));
                    neighbours.Push(new Point(pointToFill.X, pointToFill.Y-1));
                }
            }
        }
    }
}
