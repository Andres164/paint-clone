using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraficacionAndresCastro.Classes.DrawingTools
{
    internal abstract class Tool
    {
        public enum styles { Solid, Dotted, Dashed }
        public styles selectedStyle { get; set; }
        
        public Tool() => this.selectedStyle = styles.Solid;
        public abstract void drawOnBitmap(ref Bitmap canvas, List<Point> points, ref Brush brush);
    }
}
