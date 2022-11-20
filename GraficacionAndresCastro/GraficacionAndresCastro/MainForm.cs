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
        
        DrawingTools.Tool selectedDrawTool;
        DrawingTools.Brush brush;
        Bitmap canvas;
        List<Point> points;
        bool isLeftClickPressed;
        public MainForm()
        {
            InitializeComponent();

            this.selectedDrawTool = new DrawingTools.Straight();
            this.brush = new DrawingTools.Brush();
            this.canvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.ptbCanvas.Image = canvas;
            this.points = new List<Point>(20);
            this.isLeftClickPressed = false;

            this.btnSelectedColor.BackColor = this.brush.selectedColor;
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
            this.brush.selectedColor = senderBtn.BackColor;
            this.btnSelectedColor.BackColor = this.brush.selectedColor;
        }

        private void ptbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            switch (this.selectedDrawTool)
            {
                /*
                case Tools.Pixel:
                    brush.drawPixelOnBitmap(ref this.canvas, e.Location);
                    this.ptbCanvas.Image = this.canvas;
                    break;
                */
                case DrawingTools.Straight:
                    points.Add(e.Location);
                    if (points.Count == 2)
                    {
                        this.selectedDrawTool.drawOnBitmap(ref this.canvas, points, ref this.brush);
                        points.Clear();
                        this.ptbCanvas.Image = this.canvas;
                    }
                    break;
                case DrawingTools.Ellipse:
                    points.Add(e.Location);
                    this.selectedDrawTool.drawOnBitmap(ref this.canvas, points, ref this.brush);
                    this.ptbCanvas.Image = (Image)this.canvas;
                    this.points.Clear();
                    break;
                case DrawingTools.Circle:
                    points.Add(e.Location);
                    this.selectedDrawTool.drawOnBitmap(ref this.canvas, points, ref this.brush);
                    this.ptbCanvas.Image = (Image)this.canvas;
                    points.Clear();
                    break;
                case DrawingTools.RegularPolygon:
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
                case DrawingTools.Polygon:
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
                        this.selectedDrawTool = new DrawingTools.Polygon(Convert.ToInt32(boxSidesText));
                        this.selectedDrawTool.drawOnBitmap(ref this.canvas, this.points, ref this.brush);
                        this.ptbCanvas.Image = this.canvas;
                        this.points.Clear();
                    }
                    break;
            }
            this.isLeftClickPressed = false;
        }
        private void ptbCanvas_Resize(object sender, EventArgs e) { this.canvas = new Bitmap(this.canvas, this.ptbCanvas.Width, this.ptbCanvas.Height); }
        private void ptbCanvas_MouseMove(object sender, MouseEventArgs e)
        {
            /*
            if(this.selectedDrawTool == DrawingTools.Tool && isLeftClickPressed)
            {
                brush.drawPixelOnBitmap(ref this.canvas, e.Location);
                this.ptbCanvas.Image = this.canvas;
            }
            */
        }
        private void ptbCanvas_MouseDown(object sender, MouseEventArgs e) { this.isLeftClickPressed = true; }

        private void btnSolid_Click(object sender, EventArgs e) { this.selectedDrawTool.SelectedStyle = DrawingTools.Tool.styles.Solid; }
        private void btnDotted_Click(object sender, EventArgs e) { this.selectedDrawTool.SelectedStyle = DrawingTools.Tool.styles.Dotted; }
        private void btnDashed_Click(object sender, EventArgs e) { this.selectedDrawTool.SelectedStyle = DrawingTools.Tool.styles.Dashed; }

        private void btnBrushSize1_Click(object sender, EventArgs e) { this.brush.selectedSize = DrawingTools.Brush.Sizes.Small; }
        private void btnBrushSize2_Click(object sender, EventArgs e) { this.brush.selectedSize = DrawingTools.Brush.Sizes.Medium; }
        private void btnBrushSize3_Click(object sender, EventArgs e) { this.brush.selectedSize = DrawingTools.Brush.Sizes.Big; }

        private void btnBlue_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnLigthBlue_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnGreen_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnLigthGreen_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnBlack_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnWite_Click(object sender, EventArgs e) { changeSelectedColor(sender); }
        private void btnColorPalette_Click(object sender, EventArgs e)
        {
            if (this.colorDialog.ShowDialog() == DialogResult.OK)
            {
                this.brush.selectedColor = colorDialog.Color;
                this.btnSelectedColor.BackColor = this.brush.selectedColor;
            }
        }

        private void rectaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedDrawTool = new DrawingTools.Straight();
            this.grpBoxStyles.Enabled = true;
        }
        private void circuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedDrawTool = new DrawingTools.Circle(30);
            this.grpBoxStyles.Enabled = true;
        }
        private void poligonoIrregularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedDrawTool = new DrawingTools.Polygon(3);
            this.grpBoxStyles.Enabled = true;
        }
        private void poligonoRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedDrawTool = new DrawingTools.RegularPolygon(3, 30);
            this.grpBoxStyles.Enabled = true;
        }
        private void elipseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.selectedDrawTool = new DrawingTools.Ellipse(30, 50);
            this.grpBoxStyles.Enabled = true;
        }

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
    }
}