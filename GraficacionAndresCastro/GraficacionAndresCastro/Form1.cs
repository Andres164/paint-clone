namespace GraficacionAndresCastro
{
    public partial class MainForm : Form
    {
        Color selectedColor;
        Int16 selectedBrushSize;
        Bitmap canvas;
        public MainForm()
        {
            InitializeComponent();
            selectedColor = Color.Black;
            selectedBrushSize = 1;
            canvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.btnSelectedColor.BackColor = selectedColor;
        }
        private void changeSelectedColor(object sender)
        {
            Button senderBtn = (Button)sender;
            this.selectedColor = senderBtn.BackColor;
            this.btnSelectedColor.BackColor = this.selectedColor;
        }

        private void ptbCanvas_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i <= selectedBrushSize; i++)
                for(int j = 0; j <= selectedBrushSize; j++)
                    canvas.SetPixel(e.X + i, e.Y + j, selectedColor);

            this.ptbCanvas.Image = canvas;
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


        private void btnBrushSize1_Click(object sender, EventArgs e) { selectedBrushSize = 1; }

        private void btnBrushSize2_Click(object sender, EventArgs e) { selectedBrushSize = 2; }

        private void btnBrushSize3_Click(object sender, EventArgs e) { selectedBrushSize = 3; }
        private void ptbCanvas_Resize(object sender, EventArgs e)
        {
            Bitmap resizedCanvas = new Bitmap(this.canvas, this.ptbCanvas.Width, this.ptbCanvas.Height);
            this.canvas.Dispose();
            this.canvas = resizedCanvas;
        }
    }
}