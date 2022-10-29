namespace GraficacionAndresCastro
{
    using DrawingTools = GraficacionAndresCastro.Classes.DrawingTools;
    public partial class MainForm : Form
    {
        DrawingTools.Brush brush;

        ////////////////////////////
        /// Deprecated Code
        enum Tools { Pixel, Straight, Circumference, IrregularPolygon, RegularPolygon, Ellipse }
        enum BrushSizes { Small, Medium, Big }
        enum straigthStyles { Solid, Dotted, Dashed }
        Bitmap canvas;
        Tools selectedTool;
        BrushSizes selectedBrushSize;
        straigthStyles selectedStraigth;
        Color selectedColor;
        List<Point> points;
        bool isLeftClickPressed;
        public MainForm()
        {
            InitializeComponent();

            brush = new DrawingTools.Brush();
            /////////////////////////////
            /// Deprecated
            canvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.ptbCanvas.Image = canvas;
            selectedBrushSize = BrushSizes.Small;
            selectedStraigth = straigthStyles.Solid;
            selectedColor = Color.Black;
            points = new List<Point>(20);
            isLeftClickPressed = false;

            this.btnSelectedColor.BackColor = selectedColor;
            this.KeyPreview = true;
        }
        private bool isStringOnlyNumbers(string text)
        {
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] < '0' || text[i] > '9')
                    return false;
            }
            return true;
        }
        private bool isValidNumberOfPolygonSides(string text)
        {
            return isStringOnlyNumbers(text) && Convert.ToInt32(text) > 2;
        }
        private void changeSelectedColor(object sender)
        {
            Button senderBtn = (Button)sender;
            this.selectedColor = senderBtn.BackColor;
            this.btnSelectedColor.BackColor = this.selectedColor;
        }

        private void drawPixelOnBitmap(ref Bitmap bitmap, Point location, Color color)
        {
            for (int i = 0; i <= (int)selectedBrushSize; i++)
                for (int j = 0; j <= (int)selectedBrushSize; j++)
                {
                    if(location.X+i >= 0  && location.X+i < canvas.Width && location.Y + j >= 0 && location.Y+j < canvas.Height)
                        bitmap.SetPixel(location.X + i, location.Y + j, color);
                }
        }
        private void drawStraightOnBitmap(ref Bitmap bitmap, List<Point> points, Color color)
        {
            drawPixelOnBitmap(ref bitmap, points[0], color);
            int DX , DY, e, XIncrement, YIncrement;
            DX = points[1].X - points[0].X;
            DY = points[1].Y - points[0].Y;
            Point currentPoint;
            if (DX >=0)
                XIncrement = 1;
            else
            {
                DX = -DX;
                XIncrement = -1;
            }

            if(DY >= 0)
                YIncrement = 1;
            else
            {
                DY = -DY;
                YIncrement = -1;
            }
            currentPoint = points[0];
            drawPixelOnBitmap(ref bitmap, currentPoint, color);
            int iterations = 1, divisor = (int)selectedBrushSize * 4 + 2;
            if(DX >= DY)
            {
                e = 2*DY - DX;
                while(currentPoint.X != points[1].X)
                {
                    currentPoint.X += XIncrement;
                    if (e < 0)
                        e = e + 2 * DY;
                    else
                    {
                        currentPoint.Y += YIncrement;
                        e = e + 2 * (DY - DX);
                    }
                    switch(selectedStraigth)
                    {
                        case straigthStyles.Dotted:
                            if (iterations % divisor == 0)
                                drawPixelOnBitmap(ref bitmap, currentPoint, color);
                            break;
                        case straigthStyles.Dashed:
                            if (selectedBrushSize == BrushSizes.Small && iterations % 5 != 0)
                                drawPixelOnBitmap(ref bitmap, currentPoint, color);
                            else if(selectedBrushSize != BrushSizes.Small && iterations % 10 == iterations % 20)
                                drawPixelOnBitmap(ref bitmap, currentPoint, color);
                            break;
                        default:
                            drawPixelOnBitmap(ref bitmap, currentPoint, color);
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
                    switch (selectedStraigth)
                    {
                        case straigthStyles.Dotted:
                            if (iterations % divisor == 0)
                                drawPixelOnBitmap(ref bitmap, currentPoint, color);
                            break;
                        case straigthStyles.Dashed:
                            if (selectedBrushSize == BrushSizes.Small && iterations % 5 != 0)
                                drawPixelOnBitmap(ref bitmap, currentPoint, color);
                            else if (selectedBrushSize != BrushSizes.Small && iterations % 10 == iterations % 20)
                                drawPixelOnBitmap(ref bitmap, currentPoint, color);
                            break;
                        default:
                            drawPixelOnBitmap(ref bitmap, currentPoint, color);
                            break;
                    }
                    iterations++;
                }
            }
        }
        private void drawCircumference(ref Bitmap bitmap, Point center, Color color)
        {
            int x, y, e;
            x = 30; y = 0; e = 0;
            while (y <= x)
            {
                Point pointToDraw = new Point(center.X + x, center.Y + y);
                drawPixelOnBitmap(ref bitmap, pointToDraw, color);
                pointToDraw.X = center.X - x;
                pointToDraw.Y = center.Y + y;
                drawPixelOnBitmap(ref bitmap, pointToDraw, color);
                pointToDraw.X = center.X + x;
                pointToDraw.Y = center.Y - y;
                drawPixelOnBitmap(ref bitmap, pointToDraw, color);
                pointToDraw.X = center.X - x;
                pointToDraw.Y = center.Y - y;
                drawPixelOnBitmap(ref bitmap, pointToDraw, color);
                pointToDraw.X = center.X + y;
                pointToDraw.Y = center.Y + x;
                drawPixelOnBitmap(ref bitmap, pointToDraw, color);
                pointToDraw.X = center.X - y;
                pointToDraw.Y = center.Y + x;
                drawPixelOnBitmap(ref bitmap, pointToDraw, color);
                pointToDraw.X = center.X + y;
                pointToDraw.Y = center.Y - x;
                drawPixelOnBitmap(ref bitmap, pointToDraw, color);
                pointToDraw.X = center.X - y;
                pointToDraw.Y = center.Y - x;
                drawPixelOnBitmap(ref bitmap, pointToDraw, color);

                e = e + 2 * y + 1;
                y = y + 1;
                if ( ( 2 * e ) > ( 2 * x  -1 ) )
                {   
                    x = x - 1;
                    e = e - 2 * x + 1;
                }
            }
        }
        private void drawIrregularPolygonOnBitmap(ref Bitmap bitmap, List<Point> points, Color color)
        {
            for(int i = 0; i < points.Count; i++)
            {
                List<Point> straightPoints = new List<Point>();
                straightPoints.Add(points[i]);
                int j = i < points.Count - 1 ? i+1 : 0;
                straightPoints.Add(points[j]);
                drawStraightOnBitmap(ref bitmap, straightPoints, color);
            }
        }
        private void drawRegularPolygonOnBitmap(ref Bitmap bitmap, Point polygonCenter, Int16 polygonSides, Color color)
        {
            List<Point> points = new List<Point>();
            double X, Y, radius = 30, verticesAngle = 360.0 / polygonSides;
            for(double i = 0; i < 360; i += verticesAngle)
            {
                X = polygonCenter.X + radius * Math.Cos( (i + 90 * (polygonSides -2) / polygonSides ) * Math.PI / 180 );
                Y = polygonCenter.Y + radius * Math.Sin( (i + 90 * (polygonSides -2) / polygonSides ) * Math.PI / 180 );
                points.Add( new Point( Convert.ToInt32(X), Convert.ToInt32(Y) ) );
            }
            drawIrregularPolygonOnBitmap(ref bitmap, points, color);
        }

        private void ptbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (this.selectedTool)
            {
                case Tools.Pixel:
                    brush.drawPixelOnBitmap(ref this.canvas, e.Location);
                    this.ptbCanvas.Image = this.canvas;
                    break;
                case Tools.Straight:  //* Deprecated Code starts *//
                    points.Add(e.Location);
                    if (points.Count == 2)
                    {
                        drawStraightOnBitmap(ref this.canvas, points, this.selectedColor);
                        points.Clear();
                        this.ptbCanvas.Image = this.canvas;
                    }
                    break;
                case Tools.Circumference:
                    drawCircumference(ref this.canvas, e.Location, this.selectedColor);
                    this.ptbCanvas.Image = (Image)this.canvas;
                    break;
                case Tools.Ellipse:
                    drawEllipseOnBitmap(ref this.canvas, e.Location, this.selectedColor);
                    this.ptbCanvas.Image = (Image)this.canvas;
                    break;
                case Tools.IrregularPolygon:
                    string boxSidesText = this.toolStripTxtBoxSides.Text;

                    this.points.Add(e.Location);

                    this.canvas = (Bitmap)this.ptbCanvas.Image;
                    if (!isValidNumberOfPolygonSides(boxSidesText))
                    {
                        MessageBox.Show("El campo # de Lados solo acepta numeros enteros mayores a 2", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.points.Clear();
                    }
                    else if (this.points.Count == Convert.ToInt32(boxSidesText))
                    {
                        drawIrregularPolygonOnBitmap(ref this.canvas, this.points, this.selectedColor);
                        this.points.Clear();
                        this.ptbCanvas.Image = this.canvas;
                    }
                    break;
                case Tools.RegularPolygon:
                    string regularPolyBoxSidesText = this.toolStripTxtBoxSidesRegularPoly.Text;

                    if (!isValidNumberOfPolygonSides(regularPolyBoxSidesText))
                        MessageBox.Show("El campo # de Lados solo acepta numeros enteros mayores a 2", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        drawRegularPolygonOnBitmap(ref this.canvas, e.Location, Convert.ToInt16(regularPolyBoxSidesText), this.selectedColor);
                        this.ptbCanvas.Image = (Image)this.canvas.Clone();
                    }
                    break;
            }
            this.isLeftClickPressed = false;
            //* Deprecated Code Ends *//
        }
        private void ptbCanvas_Resize(object sender, EventArgs e) { this.canvas = new Bitmap(this.canvas, this.ptbCanvas.Width, this.ptbCanvas.Height); }
        private void ptbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.selectedTool == Tools.Pixel && isLeftClickPressed)
            {
                drawPixelOnBitmap(ref this.canvas, e.Location, this.selectedColor);
                this.ptbCanvas.Image = this.canvas;
            }
            else if (this.selectedTool == Tools.Straight && this.points.Count > 0)
            {
                this.ptbCanvas.Image = this.canvas;

                Bitmap tempCanvas = (Bitmap)this.canvas.Clone();
                List<Point> previewPoints = new List<Point>();
                previewPoints.Add(this.points[0]);
                previewPoints.Add(e.Location);
                drawStraightOnBitmap(ref tempCanvas, previewPoints, Color.LightGray);
                this.ptbCanvas.Image = tempCanvas;
            }
            else if(this.selectedTool == Tools.IrregularPolygon && this.points.Count > 0)
            {
                this.ptbCanvas.Image = this.canvas;

                Bitmap tempCanvas = (Bitmap)this.canvas.Clone();
                List<Point> previewPoints = new List<Point>();
                int sidesOfPolygon = Convert.ToInt32((this.toolStripTxtBoxSides.Text));

                previewPoints.Add(this.points[this.points.Count-1]);
                previewPoints.Add(e.Location);
                drawStraightOnBitmap(ref tempCanvas, previewPoints, Color.LightGray);
                if(this.points.Count == sidesOfPolygon-1)
                {
                    previewPoints[0] = this.points[0];
                    drawStraightOnBitmap(ref tempCanvas, previewPoints, Color.LightGray);

                }

                this.ptbCanvas.Image = tempCanvas;
            }
        }
        private void ptbCanvas_MouseDown(object sender, MouseEventArgs e) { this.isLeftClickPressed = true; }

        private void btnSolid_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Solid; }
        private void btnDotted_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Dotted; }
        private void btnDashed_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Dashed; }

        private void btnBrushSize1_Click(object sender, EventArgs e) { selectedBrushSize = BrushSizes.Small; }
        private void btnBrushSize2_Click(object sender, EventArgs e) { selectedBrushSize = BrushSizes.Medium; }
        private void btnBrushSize3_Click(object sender, EventArgs e) { selectedBrushSize = BrushSizes.Big; }

        private void btnBlue_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnLigthBlue_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnGreen_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnLigthGreen_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnBlack_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnWite_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnColorPalette_Click(object sender, EventArgs e)
        {
            if(this.colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.selectedColor = colorDialog.Color;
                this.btnSelectedColor.BackColor = this.selectedColor;
            }
        }

        private void pixelToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Pixel; this.grpBoxStyles.Enabled = false; }
        private void rectaToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Straight; this.grpBoxStyles.Enabled = true; }
        private void circuloToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Circumference; this.grpBoxStyles.Enabled = true; }
        private void poligonoIrregularToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.IrregularPolygon; this.grpBoxStyles.Enabled = true; }
        private void poligonoRegularToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.RegularPolygon; this.grpBoxStyles.Enabled = true;  }
        private void trianguloToolStripMenuItem_Click(object sender, EventArgs e) { this.toolStripTxtBoxSidesRegularPoly.Text = "3"; }
        private void cuadradoToolStripMenuItem_Click(object sender, EventArgs e) { this.toolStripTxtBoxSidesRegularPoly.Text = "4"; }
        private void pentagonoToolStripMenuItem_Click(object sender, EventArgs e) { this.toolStripTxtBoxSidesRegularPoly.Text = "5"; }
        private void hexagonoToolStripMenuItem_Click(object sender, EventArgs e) { this.toolStripTxtBoxSidesRegularPoly.Text = "6"; }


        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && this.points.Count > 0)
            {
                this.points.Clear();
                this.ptbCanvas.Image = this.canvas;
            }
        }

        private void btnCleanCanvas_Click(object sender, EventArgs e)
        {
            this.canvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.ptbCanvas.Image = (Image)this.canvas;
        }


        public void drawEllipseOnBitmap(ref Bitmap bitmap, Point center, Color color)
        {
            {
                int Rx = 50, Ry = 30;
                int x, y, e;
                x = 0;
                y = Ry;
                e = 2 * Ry * Ry + (1 - 2 * Ry) * (Rx * Rx);
                while (Ry * Ry * x <= Rx * Rx * y)
                {
                    drawPixelOnBitmap(ref bitmap, new Point( center.X + x, center.Y + y ), color);
                    drawPixelOnBitmap(ref bitmap, new Point( center.X + x, center.Y - y ), color);
                    drawPixelOnBitmap(ref bitmap, new Point( center.X - x, center.Y + y ), color);
                    drawPixelOnBitmap(ref bitmap, new Point( center.X - x, center.Y - y ), color);

                    x += 1;
                    if (e >= 0)
                    {
                        e = e + 4 * Rx * Rx * (1 - y);
                        y = y - 1;
                    }
                    e = e + Ry * Ry * (4 * x + 6);
                }
                y = 0;
                x = Rx;
                e = 2 * Rx * Rx + (1 - 2 * Rx) * (Ry * Ry);

                while (Rx * Rx * y <= Ry * Ry * x)
                {
                    drawPixelOnBitmap(ref bitmap, new Point(center.X + x, center.Y + y), color);
                    drawPixelOnBitmap(ref bitmap, new Point(center.X + x, center.Y - y), color);
                    drawPixelOnBitmap(ref bitmap, new Point(center.X - x, center.Y + y), color);
                    drawPixelOnBitmap(ref bitmap, new Point(center.X - x, center.Y - y), color);
                    y = y + 1;
                    if (e >= 0)
                    {
                        e = e + 4 * Ry * Ry * (1 - x);
                        x = x - 1;
                    }
                    e = e + Rx * Rx * (4 * y + 6);
                }
            }
        }

        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedTool = Tools.Ellipse;
        }
    }
}