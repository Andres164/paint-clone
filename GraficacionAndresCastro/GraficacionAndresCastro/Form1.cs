namespace GraficacionAndresCastro
{
    public partial class MainForm : Form
    {
        enum Tools { Pixel, Recta, Circunferencia }
        enum BrushSizes { Small, Medium, Big }
        enum straigthStyles { Solid, Dotted, Dashed }
        Bitmap canvas;
        Tools selectedTool;
        BrushSizes selectedBrushSize;
        straigthStyles selectedStraigth;
        Color selectedColor;
        List<Point> points;
        public MainForm()
        {
            InitializeComponent();
            canvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            selectedBrushSize = BrushSizes.Small;
            selectedStraigth = straigthStyles.Solid;
            selectedColor = Color.Black;
            points = new List<Point>(20);

            this.btnSelectedColor.BackColor = selectedColor;
        }
        private void changeSelectedColor(object sender)
        {
            Button senderBtn = (Button)sender;
            this.selectedColor = senderBtn.BackColor;
            this.btnSelectedColor.BackColor = this.selectedColor;
        }
        private void drawPixel(Point location)
        {
            for (int i = 0; i <= (int)selectedBrushSize; i++)
                for (int j = 0; j <= (int)selectedBrushSize; j++)
                    canvas.SetPixel(location.X + i, location.Y + j, selectedColor);
            this.ptbCanvas.Image = canvas;
        }
        private void drawStraight(List<Point> points)
        {
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
            drawPixel(currentPoint);
            int iterations = 2, divisor = ((int)selectedBrushSize)*4 +1;
            int skipedPixels = 0;
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
                    if (iterations % divisor == 0 || selectedStraigth == straigthStyles.Solid)
                        drawPixel(currentPoint);
                    else
                    {
                        //MessageBox.Show("iterations % divisor = " + Convert.ToString(iterations%divisor));
                        skipedPixels++;
                        //MessageBox.Show("Pixel skipped");
                    }
                    iterations++;
                }
                MessageBox.Show("iterations: " + Convert.ToString(iterations) + "\nskipedPixels: " + Convert.ToString(skipedPixels));
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
                    if (iterations % divisor != 0 || selectedStraigth == straigthStyles.Solid)
                        drawPixel(currentPoint);
                    iterations++;
                }
            }
        }
        private void drawCircumference()
        {

        }
        private void ptbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch(this.selectedTool)
            {
                case Tools.Pixel:
                    drawPixel(e.Location);
                    break;
                case Tools.Recta:
                    points.Add(e.Location);
                    drawPixel(e.Location);
                    if (points.Count == 2)
                    {
                        drawStraight(points);
                        points.Clear();
                    }
                    break;
                case Tools.Circunferencia:
                    drawCircumference();
                    break;
            }
        }
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
        private void ptbCanvas_Resize(object sender, EventArgs e)
        {
            Bitmap resizedCanvas = new Bitmap(this.canvas, this.ptbCanvas.Width, this.ptbCanvas.Height);
            this.canvas.Dispose();
            this.canvas = resizedCanvas;
        }
        private void pixelToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Pixel; }
        private void rectaToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Recta; this.grpBoxStyles.Enabled = true; }
        private void circuloToolStripMenuItem_Click(object sender, EventArgs e) { this.selectedTool = Tools.Circunferencia; }

        private void btnSolid_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Solid; }
        private void btnDotted_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Dotted; }
        private void btnDashed_Click(object sender, EventArgs e) { selectedStraigth = straigthStyles.Dashed; }
    }
}