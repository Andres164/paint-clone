namespace GraficacionAndresCastro
{
    using DrawingTools = GraficacionAndresCastro.Classes.DrawingTools;
    public partial class MainForm : Form
    {
        enum ModificationTools { None, Translation }
        ModificationTools currentModificationTool;

        DrawingTools.Tool selectedDrawTool;
        DrawingTools.Tool SelectedDrawTool
        {
            get => selectedDrawTool;
            set 
            { 
                value.SelectedStyle = this.selectedDrawTool.SelectedStyle;
                this.selectedDrawTool = value;
                this.grpBoxStyles.Enabled = true;
                this.currentModificationTool = ModificationTools.None;
            }
        }
        DrawingTools.Brush brush;
        Bitmap previousCanvas;
        Bitmap currentCanvas;
        List<Point> points;
        List<Point> previousFigurePoints;
        bool isLeftClickPressed;
        public MainForm()
        {
            InitializeComponent();

            this.currentModificationTool = ModificationTools.None;

            this.selectedDrawTool = new DrawingTools.Straight();
            this.brush = new DrawingTools.Brush();
            this.previousCanvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.currentCanvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.ptbCanvas.Image = currentCanvas;
            this.points = new List<Point>(20);
            this.previousFigurePoints = new List<Point>(20);
            this.previousFigurePoints.Add( new Point(1, 1) );
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
            // if(!translacionSelected)
            bool isDrawingFinished = this.points.Count == 0 && this.currentModificationTool != ModificationTools.Translation ? true : false;
            if (isDrawingFinished)
                this.previousCanvas = (Bitmap)currentCanvas.Clone();

            switch (this.currentModificationTool)
            {
                case ModificationTools.Translation:
                    this.currentCanvas = (Bitmap)this.previousCanvas.Clone();

                    int diffPreviousToNewPoint_X = e.Location.X - this.previousFigurePoints[0].X;
                    int diffPreviousToNewPoint_Y = e.Location.Y - this.previousFigurePoints[0].Y;
                    for(int i = 0; i < this.previousFigurePoints.Count; i++)
                    {
                        Point point = this.previousFigurePoints[i];
                        point.X += diffPreviousToNewPoint_X;
                        point.Y += diffPreviousToNewPoint_Y;
                        MessageBox.Show("i: " + i);
                        this.points.Add(point);
                    }
                    break;
            }
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
                        this.selectedDrawTool.drawOnBitmap(ref this.currentCanvas, points, ref this.brush);
                        this.previousFigurePoints = new List<Point>(this.points);
                        points.Clear();
                        this.ptbCanvas.Image = this.currentCanvas;
                    }
                    break;
                case DrawingTools.Ellipse:
                    points.Add(e.Location);
                    this.selectedDrawTool.drawOnBitmap(ref this.currentCanvas, points, ref this.brush);
                    this.ptbCanvas.Image = (Image)this.currentCanvas;
                    this.points.Clear();
                    break;
                case DrawingTools.Circle:
                    points.Add(e.Location);
                    this.selectedDrawTool.drawOnBitmap(ref this.currentCanvas, points, ref this.brush);
                    this.ptbCanvas.Image = (Image)this.currentCanvas;
                    points.Clear();
                    break;
                case DrawingTools.RegularPolygon:
                    string regularPolyBoxSidesText = this.toolStripTxtBoxSidesRegularPoly.Text;

                    if (!isValidNumberOfPolygonSides(regularPolyBoxSidesText))
                        MessageBox.Show("El campo # de Lados solo acepta numeros enteros mayores a 2", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    else
                    {
                        DrawingTools.Tool.styles selectedStyle = this.selectedDrawTool.SelectedStyle;
                        DrawingTools.RegularPolygon regularPolygon = new DrawingTools.RegularPolygon(Convert.ToInt32(regularPolyBoxSidesText), 30);
                        regularPolygon.SelectedStyle = selectedStyle;
                        regularPolygon.drawRegularPolygon(ref this.currentCanvas, e.Location, ref this.brush);
                        this.ptbCanvas.Image = (Image)this.currentCanvas.Clone();
                    }
                    break;
                case DrawingTools.Polygon:
                    string boxSidesText = this.toolStripTxtBoxSides.Text;
                    this.points.Add(e.Location);
                    if (!isValidNumberOfPolygonSides(boxSidesText))
                    {
                        MessageBox.Show("El campo # de Lados solo acepta numeros enteros mayores a 2", "Valor Invalido", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.points.Clear();
                    }
                    else if (this.points.Count == Convert.ToInt32(boxSidesText))
                    {
                        DrawingTools.Tool.styles selectedStyle = this.selectedDrawTool.SelectedStyle;
                        this.selectedDrawTool = new DrawingTools.Polygon(Convert.ToInt32(boxSidesText));
                        selectedDrawTool.SelectedStyle = selectedStyle;
                        this.selectedDrawTool.drawOnBitmap(ref this.currentCanvas, this.points, ref this.brush);
                        this.ptbCanvas.Image = this.currentCanvas;
                        this.previousFigurePoints = this.points;
                        this.points.Clear();
                    }
                    break;
            }
            this.isLeftClickPressed = false;
        }
        private void ptbCanvas_Resize(object sender, EventArgs e) 
        { 
            this.currentCanvas = new Bitmap(this.currentCanvas, this.ptbCanvas.Width, this.ptbCanvas.Height);
            this.previousCanvas = new Bitmap(this.previousCanvas, this.ptbCanvas.Width, this.ptbCanvas.Height);
        }
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

        private void rectaToolStripMenuItem_Click(object sender, EventArgs e) { this.SelectedDrawTool = new DrawingTools.Straight(); }
        private void circuloToolStripMenuItem_Click(object sender, EventArgs e) { this.SelectedDrawTool = new DrawingTools.Circle(30); }
        private void poligonoIrregularToolStripMenuItem_Click(object sender, EventArgs e) { this.SelectedDrawTool = new DrawingTools.Polygon(3); }
        private void poligonoRegularToolStripMenuItem_Click(object sender, EventArgs e) { this.SelectedDrawTool = new DrawingTools.RegularPolygon(3, 30); }
        private void elipseToolStripMenuItem_Click(object sender, EventArgs e) { this.SelectedDrawTool = new DrawingTools.Ellipse(30, 50); }
        private void transladarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.currentModificationTool = ModificationTools.Translation;
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
                this.ptbCanvas.Image = this.currentCanvas;
            }
        }
        private void btnCleanCanvas_Click(object sender, EventArgs e)
        {
            this.currentCanvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.previousCanvas = (Bitmap)currentCanvas.Clone();
            this.ptbCanvas.Image = (Image)this.currentCanvas;
        }
    }
}