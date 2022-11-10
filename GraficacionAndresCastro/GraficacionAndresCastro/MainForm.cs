namespace GraficacionAndresCastro
{
    using DrawingTools = GraficacionAndresCastro.Classes.DrawingTools;
    public partial class MainForm : Form
    {

        ////////////////////////////
        /// Deprecated Code
        enum Tools { Pixel, Straight, Circumference, IrregularPolygon, RegularPolygon, Ellipse }
        enum BrushSizes { Small, Medium, Big }
        enum straigthStyles { Solid, Dotted, Dashed }
        Tools selectedTool;
        BrushSizes selectedBrushSize;
        straigthStyles selectedStraigth;
        Color selectedColor;
        //// *
        

        DrawingTools.Brush brush;
        Bitmap canvas;
        List<Point> points;
        bool isLeftClickPressed;
        public MainForm()
        {
            InitializeComponent();

            brush = new DrawingTools.Brush();
            canvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.ptbCanvas.Image = canvas;
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

        private void ptbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (this.selectedTool)
            {
                case Tools.Pixel:
                    brush.drawPixelOnBitmap(ref this.canvas, e.Location);
                    this.ptbCanvas.Image = this.canvas;
                    break;
                case Tools.Straight: 
                    points.Add(e.Location);
                    if (points.Count == 2)
                    {
                        DrawingTools.Straight straight = new DrawingTools.Straight();
                        straight.drawOnBitmap(ref this.canvas, points, ref this.brush);
                        points.Clear();
                        this.ptbCanvas.Image = this.canvas;
                    }
                    break;
                case Tools.Circumference:
                    DrawingTools.Circle circle = new DrawingTools.Circle(30);
                    points.Add(e.Location);
                    circle.drawOnBitmap(ref this.canvas, points, ref this.brush);
                    this.ptbCanvas.Image = (Image)this.canvas;
                    points.Clear();
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
                        DrawingTools.Polygon irregularPolygon = new DrawingTools.Polygon(Convert.ToInt32(boxSidesText));
                        irregularPolygon.drawOnBitmap(ref this.canvas, this.points, ref this.brush);
                        this.ptbCanvas.Image = this.canvas;
                        this.points.Clear();
                    }
                    break;
                case Tools.RegularPolygon:
                    string regularPolyBoxSidesText = this.toolStripTxtBoxSidesRegularPoly.Text;

                    if (!isValidNumberOfPolygonSides(regularPolyBoxSidesText))
                        MessageBox.Show("El campo # de Lados solo acepta numeros enteros mayores a 2", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        DrawingTools.RegularPolygon regularPolygon = new DrawingTools.RegularPolygon(Convert.ToInt32(regularPolyBoxSidesText), 30);
                        regularPolygon.drawRegularPolygon(ref this.canvas, e.Location, ref this.brush);
                        this.ptbCanvas.Image = (Image)this.canvas.Clone();
                    }
                    break;
                case Tools.Ellipse:
                    DrawingTools.Ellipse ellipse = new DrawingTools.Ellipse(30, 50);
                    points.Add(e.Location);
                    ellipse.drawOnBitmap(ref this.canvas, points, ref this.brush);
                    this.ptbCanvas.Image = (Image)this.canvas;
                    this.points.Clear();
                    break;
            }
            this.isLeftClickPressed = false;
        }
        private void ptbCanvas_Resize(object sender, EventArgs e) { this.canvas = new Bitmap(this.canvas, this.ptbCanvas.Width, this.ptbCanvas.Height); }
        private void ptbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            if(this.selectedTool == Tools.Pixel && isLeftClickPressed)
            {
                brush.drawPixelOnBitmap(ref this.canvas, e.Location);
                this.ptbCanvas.Image = this.canvas;
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
        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedTool = Tools.Ellipse;
        }
    }
}