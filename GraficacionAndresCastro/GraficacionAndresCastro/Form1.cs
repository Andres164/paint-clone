namespace GraficacionAndresCastro
{
    public partial class MainForm : Form
    {
        Color selectedColor;
        Int16 selectedBrushSize;
        Bitmap canvas;
        bool isWorkSaved;
        public MainForm()
        {
            InitializeComponent();
            selectedColor = Color.Black;
            selectedBrushSize = 1;
            canvas = new Bitmap(ptbCanvas.Width, ptbCanvas.Height);
            this.btnSelectedColor.BackColor = selectedColor;
            isWorkSaved = true;
            recenterPtbCanvas();
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
            this.isWorkSaved = false;
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
            colorDialog.Dispose();
        }


        private void btnBrushSize1_Click(object sender, EventArgs e) { selectedBrushSize = 1; }

        private void btnBrushSize2_Click(object sender, EventArgs e) { selectedBrushSize = 2; }

        private void btnBrushSize3_Click(object sender, EventArgs e) { selectedBrushSize = 3; }
        
        private void stripMenuItemNew_Click(object sender, EventArgs e)
        {
            NewFileDialog newFileDialog = new NewFileDialog();
            if(isWorkSaved)
            {
                if (newFileDialog.ShowDialog(this) == DialogResult.OK)
                    resetCanvas(newFileDialog.canvasHeight, newFileDialog.canvasWidth);
            }
            else
            {
                if (MessageBox.Show("Los cambios realizados no seran guardados, desea continuar?", "No se guardaran los cambios", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation) == DialogResult.OK)
                    if (newFileDialog.ShowDialog() == DialogResult.OK)
                        resetCanvas(newFileDialog.canvasHeight, newFileDialog.canvasWidth);
            }
            newFileDialog.Dispose();
        }
        private void resetCanvas(Int16 height, Int16 width)
        {
            this.ptbCanvas.Image = null;
            this.canvas.Dispose();
            this.ptbCanvas.Height = height;
            this.ptbCanvas.Width = width;
            this.canvas = new Bitmap(this.ptbCanvas.Width, this.ptbCanvas.Height);
            recenterPtbCanvas();
        }

        private void stripMenuItemSaveAs_Click(object sender, EventArgs e)
        {

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                canvas.Save(saveFileDialog.FileName);
                isWorkSaved = true;
            }
            saveFileDialog.Dispose();
        }

        private void recenterPtbCanvas()
        {
            this.ptbCanvas.Left = (this.panelViewPort.Width - this.ptbCanvas.Width) / 2;
            this.ptbCanvas.Top = (this.panelViewPort.Height - this.ptbCanvas.Height) / 2;
        }

        private void panelViewPort_Resize(object sender, EventArgs e)
        { recenterPtbCanvas(); }
    }
}