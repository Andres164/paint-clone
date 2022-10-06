namespace GraficacionAndresCastro
{
    public partial class MainForm : Form
    {
        enum Tools { Pixel, Straight, Circumference, IrregularPolygon }
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
            canvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
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
        private void drawCircumference()
        {

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

        private void ptbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (this.selectedTool)
            {
                case Tools.Pixel:
                    drawPixelOnBitmap(ref this.canvas, e.Location, this.selectedColor);
                    this.ptbCanvas.Image = this.canvas;
                    break;
                case Tools.Straight:
                    points.Add(e.Location);
                    if (points.Count == 2)
                    {
                        drawStraightOnBitmap(ref this.canvas, points, this.selectedColor);
                        points.Clear();
                        this.ptbCanvas.Image = this.canvas;
                    }
                    break;
                case Tools.Circumference:
                    drawCircumference();
                    break;
                case Tools.IrregularPolygon:
                    string boxSidesText = this.toolStripTxtBoxSides.Text;

                    this.points.Add(e.Location);
                    if (!isStringOnlyNumbers(boxSidesText))
                    {
                        MessageBox.Show("El campo # de Lados solo acepta numeros enteros", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.points.Clear();
                    }
                    else if (this.points.Count == Convert.ToInt32(boxSidesText))
                    {
                        drawIrregularPolygonOnBitmap(ref this.canvas, this.points, this.selectedColor);
                        this.points.Clear();
                        this.ptbCanvas.Image = this.canvas;
                    }
                    break;
            }
            this.isLeftClickPressed = false;
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
                List<Point> prevewPoints = new List<Point>();
                prevewPoints.Add(this.points[0]);
                prevewPoints.Add(e.Location);
                drawStraightOnBitmap(ref tempCanvas, prevewPoints, Color.LightGray);
                this.ptbCanvas.Image = tempCanvas;
            }
            else if(this.selectedTool == Tools.IrregularPolygon && this.points.Count > 0)
            {
                this.ptbCanvas.Image = this.canvas;

                Bitmap tempCanvas = (Bitmap)this.canvas.Clone();
                List<Point> prevewPoints = new List<Point>(this.points);
                prevewPoints.Add(e.Location);
                drawIrregularPolygonOnBitmap(ref tempCanvas, prevewPoints, Color.LightGray);
                
                this.ptbCanvas.Image = tempCanvas;
            }
        }
        private void ptbCanvas_MouseDown(object sender, MouseEventArgs e) { this.isLeftClickPressed = true; }

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
        private void btnBrushSize1_Click(object sender, EventArgs e) { selectedBrushSize = BrushSizes.Small; }
        private void btnBrushSize2_Click(object sender, EventArgs e) { selectedBrushSize = BrushSizes.Medium; }
        private void btnBrushSize3_Click(object sender, EventArgs e) { selectedBrushSize = BrushSizes.Big; }

        private void pixelToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Pixel; this.grpBoxStyles.Enabled = false; }
        private void rectaToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Straight; this.grpBoxStyles.Enabled = true; }
        private void circuloToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Circumference; this.grpBoxStyles.Enabled = true; }
        private void poligonoIrregularToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.IrregularPolygon; this.grpBoxStyles.Enabled = true; }

        private void btnSolid_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Solid; }
        private void btnDotted_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Dotted; }
        private void btnDashed_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Dashed; }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape && this.points.Count > 0)
            {
                this.points.Clear();
                this.ptbCanvas.Image = this.canvas;
            }
        }

    }
}