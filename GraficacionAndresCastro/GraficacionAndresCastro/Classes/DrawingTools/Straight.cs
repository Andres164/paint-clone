using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficacionAndresCastro.Classes.DrawingTools
{
    internal class Straight : Tool
    {
        public override void drawOnBitmap(ref Bitmap canvas, List<Point> points, ref Brush brush)
        {
            brush.drawPixelOnBitmap(ref canvas, points[0]);
            int DX, DY, e, XIncrement, YIncrement;
            DX = points[1].X - points[0].X;
            DY = points[1].Y - points[0].Y;
            Point currentPoint;
            if (DX >= 0)
                XIncrement = 1;
            else
            {
                DX = -DX;
                XIncrement = -1;
            }

            if (DY >= 0)
                YIncrement = 1;
            else
            {
                DY = -DY;
                YIncrement = -1;
            }
            currentPoint = points[0];
            brush.drawPixelOnBitmap(ref canvas, currentPoint);
            int iterations = 1, divisor = (int)brush.selectedSize * 4 + 2;
            if (DX >= DY)
            {
                e = 2 * DY - DX;
                while (currentPoint.X != points[1].X)
                {
                    currentPoint.X += XIncrement;
                    if (e < 0)
                        e = e + 2 * DY;
                    else
                    {
                        currentPoint.Y += YIncrement;
                        e = e + 2 * (DY - DX);
                    }
                    switch (selectedStyle)
                    {
                        case styles.Dotted:
                            if (iterations % divisor == 0)
                                brush.drawPixelOnBitmap(ref canvas, currentPoint);
                            break;
                        case styles.Dashed:
                            if (brush.selectedSize == Brush.Sizes.Small && iterations % 5 != 0)
                                brush.drawPixelOnBitmap(ref canvas, currentPoint);
                            else if (brush.selectedSize!= Brush.Sizes.Small && iterations % 10 == iterations % 20)
                                brush.drawPixelOnBitmap(ref canvas, currentPoint);
                            break;
                        default:
                            brush.drawPixelOnBitmap(ref canvas, currentPoint);
                            break;

                    }
                    iterations++;
                }
            }
            else
            {
                e = 2 * DX - DY;
                while (currentPoint.Y != points[1].Y)
                {
                    currentPoint.Y += YIncrement;
                    if (e < 0)
                        e = e + 2 * DX;
                    else
                    {
                        currentPoint.X += XIncrement;
                        e = e + 2 * (DX - DY);
                    }
                    switch (selectedStyle)
                    {
                        case styles.Dotted:
                            if (iterations % divisor == 0)
                                brush.drawPixelOnBitmap(ref canvas, currentPoint);
                            break;
                        case styles.Dashed:
                            if (brush.selectedSize == Brush.Sizes.Small && iterations % 5 != 0)
                                brush.drawPixelOnBitmap(ref canvas, currentPoint);
                            else if (brush.selectedSize != Brush.Sizes.Small && iterations % 10 == iterations % 20)
                                brush.drawPixelOnBitmap(ref canvas, currentPoint);
                            break;
                        default:
                            brush.drawPixelOnBitmap(ref canvas, currentPoint);
                            break;
                    }
                    iterations++;
                }
            }
        }
    }
}
