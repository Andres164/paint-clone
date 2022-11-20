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
        protected styles selectedStyle;
        public virtual styles SelectedStyle 
        {
            get => selectedStyle;
            set => selectedStyle = value;
        }
        
        public Tool() => this.SelectedStyle = styles.Solid;
        public abstract void drawOnBitmap(ref Bitmap canvas, List<Point> points, ref Brush brush);
    }
}
