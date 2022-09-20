namespace GraficacionAndresCastro
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ptbCanvas = new System.Windows.Forms.PictureBox();
            this.grpBoxTools = new System.Windows.Forms.GroupBox();
            this.grpBoxSize = new System.Windows.Forms.GroupBox();
            this.btnBrushSize3 = new System.Windows.Forms.Button();
            this.btnBrushSize2 = new System.Windows.Forms.Button();
            this.btnBrushSize1 = new System.Windows.Forms.Button();
            this.grpBoxColors = new System.Windows.Forms.GroupBox();
            this.btnWite = new System.Windows.Forms.Button();
            this.btnBlack = new System.Windows.Forms.Button();
            this.btnLigthGreen = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnLigthBlue = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnColorPalette = new System.Windows.Forms.Button();
            this.btnSelectedColor = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.stripMenuItemSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelViewPort = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanvas)).BeginInit();
            this.grpBoxTools.SuspendLayout();
            this.grpBoxSize.SuspendLayout();
            this.grpBoxColors.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.panelViewPort.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbCanvas
            // 
            this.ptbCanvas.BackColor = System.Drawing.Color.White;
            this.ptbCanvas.Location = new System.Drawing.Point(118, 45);
            this.ptbCanvas.Name = "ptbCanvas";
            this.ptbCanvas.Size = new System.Drawing.Size(800, 600);
            this.ptbCanvas.TabIndex = 0;
            this.ptbCanvas.TabStop = false;
            this.ptbCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbCanvas_MouseClick);
            // 
            // grpBoxTools
            // 
            this.grpBoxTools.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpBoxTools.Controls.Add(this.grpBoxSize);
            this.grpBoxTools.Controls.Add(this.grpBoxColors);
            this.grpBoxTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxTools.Location = new System.Drawing.Point(0, 24);
            this.grpBoxTools.Name = "grpBoxTools";
            this.grpBoxTools.Size = new System.Drawing.Size(1009, 94);
            this.grpBoxTools.TabIndex = 1;
            this.grpBoxTools.TabStop = false;
            // 
            // grpBoxSize
            // 
            this.grpBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpBoxSize.Controls.Add(this.btnBrushSize3);
            this.grpBoxSize.Controls.Add(this.btnBrushSize2);
            this.grpBoxSize.Controls.Add(this.btnBrushSize1);
            this.grpBoxSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBoxSize.Location = new System.Drawing.Point(651, 11);
            this.grpBoxSize.Name = "grpBoxSize";
            this.grpBoxSize.Size = new System.Drawing.Size(127, 77);
            this.grpBoxSize.TabIndex = 3;
            this.grpBoxSize.TabStop = false;
            this.grpBoxSize.Text = "Tamaño";
            // 
            // btnBrushSize3
            // 
            this.btnBrushSize3.BackColor = System.Drawing.Color.Black;
            this.btnBrushSize3.Location = new System.Drawing.Point(78, 24);
            this.btnBrushSize3.Name = "btnBrushSize3";
            this.btnBrushSize3.Size = new System.Drawing.Size(36, 36);
            this.btnBrushSize3.TabIndex = 10;
            this.btnBrushSize3.UseVisualStyleBackColor = false;
            this.btnBrushSize3.Click += new System.EventHandler(this.btnBrushSize3_Click);
            // 
            // btnBrushSize2
            // 
            this.btnBrushSize2.BackColor = System.Drawing.Color.Black;
            this.btnBrushSize2.Location = new System.Drawing.Point(42, 28);
            this.btnBrushSize2.Name = "btnBrushSize2";
            this.btnBrushSize2.Size = new System.Drawing.Size(30, 30);
            this.btnBrushSize2.TabIndex = 9;
            this.btnBrushSize2.UseVisualStyleBackColor = false;
            this.btnBrushSize2.Click += new System.EventHandler(this.btnBrushSize2_Click);
            // 
            // btnBrushSize1
            // 
            this.btnBrushSize1.BackColor = System.Drawing.Color.Black;
            this.btnBrushSize1.Location = new System.Drawing.Point(11, 31);
            this.btnBrushSize1.Name = "btnBrushSize1";
            this.btnBrushSize1.Size = new System.Drawing.Size(25, 25);
            this.btnBrushSize1.TabIndex = 8;
            this.btnBrushSize1.UseVisualStyleBackColor = false;
            this.btnBrushSize1.Click += new System.EventHandler(this.btnBrushSize1_Click);
            // 
            // grpBoxColors
            // 
            this.grpBoxColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxColors.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.grpBoxColors.Controls.Add(this.btnWite);
            this.grpBoxColors.Controls.Add(this.btnBlack);
            this.grpBoxColors.Controls.Add(this.btnLigthGreen);
            this.grpBoxColors.Controls.Add(this.btnGreen);
            this.grpBoxColors.Controls.Add(this.btnLigthBlue);
            this.grpBoxColors.Controls.Add(this.btnBlue);
            this.grpBoxColors.Controls.Add(this.btnColorPalette);
            this.grpBoxColors.Controls.Add(this.btnSelectedColor);
            this.grpBoxColors.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBoxColors.Location = new System.Drawing.Point(791, 11);
            this.grpBoxColors.Name = "grpBoxColors";
            this.grpBoxColors.Size = new System.Drawing.Size(207, 77);
            this.grpBoxColors.TabIndex = 2;
            this.grpBoxColors.TabStop = false;
            this.grpBoxColors.Text = "Colores";
            // 
            // btnWite
            // 
            this.btnWite.BackColor = System.Drawing.Color.White;
            this.btnWite.Location = new System.Drawing.Point(120, 45);
            this.btnWite.Name = "btnWite";
            this.btnWite.Size = new System.Drawing.Size(23, 23);
            this.btnWite.TabIndex = 7;
            this.btnWite.UseVisualStyleBackColor = false;
            this.btnWite.Click += new System.EventHandler(this.btnWite_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(120, 18);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(23, 23);
            this.btnBlack.TabIndex = 6;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnLigthGreen
            // 
            this.btnLigthGreen.BackColor = System.Drawing.Color.LightGreen;
            this.btnLigthGreen.Location = new System.Drawing.Point(91, 45);
            this.btnLigthGreen.Name = "btnLigthGreen";
            this.btnLigthGreen.Size = new System.Drawing.Size(23, 23);
            this.btnLigthGreen.TabIndex = 5;
            this.btnLigthGreen.UseVisualStyleBackColor = false;
            this.btnLigthGreen.Click += new System.EventHandler(this.btnLigthGreen_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(91, 18);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(23, 23);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnLigthBlue
            // 
            this.btnLigthBlue.BackColor = System.Drawing.Color.LightBlue;
            this.btnLigthBlue.Location = new System.Drawing.Point(62, 45);
            this.btnLigthBlue.Name = "btnLigthBlue";
            this.btnLigthBlue.Size = new System.Drawing.Size(23, 23);
            this.btnLigthBlue.TabIndex = 3;
            this.btnLigthBlue.UseVisualStyleBackColor = false;
            this.btnLigthBlue.Click += new System.EventHandler(this.btnLigthBlue_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(62, 18);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(23, 23);
            this.btnBlue.TabIndex = 2;
            this.btnBlue.UseVisualStyleBackColor = false;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnColorPalette
            // 
            this.btnColorPalette.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnColorPalette.BackgroundImage")));
            this.btnColorPalette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnColorPalette.Location = new System.Drawing.Point(149, 18);
            this.btnColorPalette.Name = "btnColorPalette";
            this.btnColorPalette.Size = new System.Drawing.Size(50, 50);
            this.btnColorPalette.TabIndex = 1;
            this.btnColorPalette.UseVisualStyleBackColor = true;
            this.btnColorPalette.Click += new System.EventHandler(this.btnColorPalette_Click);
            // 
            // btnSelectedColor
            // 
            this.btnSelectedColor.Location = new System.Drawing.Point(6, 18);
            this.btnSelectedColor.Name = "btnSelectedColor";
            this.btnSelectedColor.Size = new System.Drawing.Size(50, 50);
            this.btnSelectedColor.TabIndex = 0;
            this.btnSelectedColor.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.pixelToolStripMenuItem,
            this.rectaToolStripMenuItem,
            this.circuloToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1009, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stripMenuItemNew,
            this.stripMenuItemSaveAs});
            this.archivoToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // stripMenuItemNew
            // 
            this.stripMenuItemNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stripMenuItemNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stripMenuItemNew.Name = "stripMenuItemNew";
            this.stripMenuItemNew.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.stripMenuItemNew.Size = new System.Drawing.Size(192, 22);
            this.stripMenuItemNew.Text = "Nuevo";
            this.stripMenuItemNew.Click += new System.EventHandler(this.stripMenuItemNew_Click);
            // 
            // stripMenuItemSaveAs
            // 
            this.stripMenuItemSaveAs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.stripMenuItemSaveAs.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.stripMenuItemSaveAs.Name = "stripMenuItemSaveAs";
            this.stripMenuItemSaveAs.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.stripMenuItemSaveAs.Size = new System.Drawing.Size(192, 22);
            this.stripMenuItemSaveAs.Text = "Guardar como";
            this.stripMenuItemSaveAs.Click += new System.EventHandler(this.stripMenuItemSaveAs_Click);
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pixelToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.pixelToolStripMenuItem.Text = "Pixel";
            // 
            // rectaToolStripMenuItem
            // 
            this.rectaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.rectaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rectaToolStripMenuItem.Name = "rectaToolStripMenuItem";
            this.rectaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.rectaToolStripMenuItem.Text = "Recta";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.circuloToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.circuloToolStripMenuItem.Text = "Circulo";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "PNG|*.png";
            this.saveFileDialog.Filter = "BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff";
            this.saveFileDialog.FilterIndex = 4;
            // 
            // panelViewPort
            // 
            this.panelViewPort.AutoScroll = true;
            this.panelViewPort.AutoScrollMargin = new System.Drawing.Size(5, 5);
            this.panelViewPort.Controls.Add(this.ptbCanvas);
            this.panelViewPort.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewPort.Location = new System.Drawing.Point(0, 118);
            this.panelViewPort.Name = "panelViewPort";
            this.panelViewPort.Size = new System.Drawing.Size(1009, 700);
            this.panelViewPort.TabIndex = 3;
            this.panelViewPort.Resize += new System.EventHandler(this.panelViewPort_Resize);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1009, 818);
            this.Controls.Add(this.panelViewPort);
            this.Controls.Add(this.grpBoxTools);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Elaborado por Andres Castro";
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanvas)).EndInit();
            this.grpBoxTools.ResumeLayout(false);
            this.grpBoxSize.ResumeLayout(false);
            this.grpBoxColors.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.panelViewPort.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox ptbCanvas;
        private GroupBox grpBoxTools;
        private GroupBox grpBoxSize;
        private Button btnBrushSize3;
        private Button btnBrushSize2;
        private Button btnBrushSize1;
        private GroupBox grpBoxColors;
        private Button btnWite;
        private Button btnBlack;
        private Button btnLigthGreen;
        private Button btnGreen;
        private Button btnLigthBlue;
        private Button btnBlue;
        private Button btnColorPalette;
        private Button btnSelectedColor;
        private MenuStrip menuStrip;
        private ToolStripMenuItem pixelToolStripMenuItem;
        private ToolStripMenuItem rectaToolStripMenuItem;
        private ToolStripMenuItem circuloToolStripMenuItem;
        private ColorDialog colorDialog;
        private ToolStripMenuItem archivoToolStripMenuItem;
        private ToolStripMenuItem stripMenuItemNew;
        private ToolStripMenuItem stripMenuItemSaveAs;
        private SaveFileDialog saveFileDialog;
        private Panel panelViewPort;
    }
}