﻿namespace GraficacionAndresCastro
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
            this.btnFill = new System.Windows.Forms.Button();
            this.btnCleanCanvas = new System.Windows.Forms.Button();
            this.grpBoxStyles = new System.Windows.Forms.GroupBox();
            this.btnDashed = new System.Windows.Forms.Button();
            this.btnDotted = new System.Windows.Forms.Button();
            this.btnSolid = new System.Windows.Forms.Button();
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pixelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rectaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.circuloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.poligonoIrregularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTxtBoxSides = new System.Windows.Forms.ToolStripTextBox();
            this.poligonoRegularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trianguloToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cuadradoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pentagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hexagonoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTxtBoxSidesRegularPoly = new System.Windows.Forms.ToolStripTextBox();
            this.elipseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transladarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanvas)).BeginInit();
            this.grpBoxTools.SuspendLayout();
            this.grpBoxStyles.SuspendLayout();
            this.grpBoxSize.SuspendLayout();
            this.grpBoxColors.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbCanvas
            // 
            this.ptbCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ptbCanvas.BackColor = System.Drawing.Color.White;
            this.ptbCanvas.Location = new System.Drawing.Point(41, 163);
            this.ptbCanvas.Name = "ptbCanvas";
            this.ptbCanvas.Size = new System.Drawing.Size(781, 394);
            this.ptbCanvas.TabIndex = 0;
            this.ptbCanvas.TabStop = false;
            this.ptbCanvas.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ptbCanvas_MouseClick);
            this.ptbCanvas.Resize += new System.EventHandler(this.ptbCanvas_Resize);
            // 
            // grpBoxTools
            // 
            this.grpBoxTools.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBoxTools.Controls.Add(this.btnFill);
            this.grpBoxTools.Controls.Add(this.btnCleanCanvas);
            this.grpBoxTools.Controls.Add(this.grpBoxStyles);
            this.grpBoxTools.Controls.Add(this.grpBoxSize);
            this.grpBoxTools.Controls.Add(this.grpBoxColors);
            this.grpBoxTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxTools.Location = new System.Drawing.Point(0, 24);
            this.grpBoxTools.Name = "grpBoxTools";
            this.grpBoxTools.Size = new System.Drawing.Size(871, 105);
            this.grpBoxTools.TabIndex = 1;
            this.grpBoxTools.TabStop = false;
            // 
            // btnFill
            // 
            this.btnFill.BackgroundImage = global::GraficacionAndresCastro.Properties.Resources.FillTool;
            this.btnFill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFill.Location = new System.Drawing.Point(337, 18);
            this.btnFill.Name = "btnFill";
            this.btnFill.Size = new System.Drawing.Size(68, 59);
            this.btnFill.TabIndex = 8;
            this.btnFill.UseVisualStyleBackColor = true;
            this.btnFill.Click += new System.EventHandler(this.btnFill_Click);
            // 
            // btnCleanCanvas
            // 
            this.btnCleanCanvas.Location = new System.Drawing.Point(6, 47);
            this.btnCleanCanvas.Name = "btnCleanCanvas";
            this.btnCleanCanvas.Size = new System.Drawing.Size(92, 47);
            this.btnCleanCanvas.TabIndex = 4;
            this.btnCleanCanvas.Text = "Limpiar lienzo";
            this.btnCleanCanvas.UseVisualStyleBackColor = true;
            this.btnCleanCanvas.Click += new System.EventHandler(this.btnCleanCanvas_Click);
            // 
            // grpBoxStyles
            // 
            this.grpBoxStyles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxStyles.Controls.Add(this.btnDashed);
            this.grpBoxStyles.Controls.Add(this.btnDotted);
            this.grpBoxStyles.Controls.Add(this.btnSolid);
            this.grpBoxStyles.Enabled = false;
            this.grpBoxStyles.Location = new System.Drawing.Point(411, 13);
            this.grpBoxStyles.Name = "grpBoxStyles";
            this.grpBoxStyles.Size = new System.Drawing.Size(102, 81);
            this.grpBoxStyles.TabIndex = 3;
            this.grpBoxStyles.TabStop = false;
            this.grpBoxStyles.Text = "Estilos";
            // 
            // btnDashed
            // 
            this.btnDashed.BackColor = System.Drawing.Color.White;
            this.btnDashed.Image = ((System.Drawing.Image)(resources.GetObject("btnDashed.Image")));
            this.btnDashed.Location = new System.Drawing.Point(6, 54);
            this.btnDashed.Name = "btnDashed";
            this.btnDashed.Size = new System.Drawing.Size(90, 19);
            this.btnDashed.TabIndex = 10;
            this.btnDashed.UseVisualStyleBackColor = false;
            this.btnDashed.Click += new System.EventHandler(this.btnDashed_Click);
            // 
            // btnDotted
            // 
            this.btnDotted.BackColor = System.Drawing.Color.White;
            this.btnDotted.Image = ((System.Drawing.Image)(resources.GetObject("btnDotted.Image")));
            this.btnDotted.Location = new System.Drawing.Point(6, 35);
            this.btnDotted.Name = "btnDotted";
            this.btnDotted.Size = new System.Drawing.Size(90, 19);
            this.btnDotted.TabIndex = 9;
            this.btnDotted.UseVisualStyleBackColor = false;
            this.btnDotted.Click += new System.EventHandler(this.btnDotted_Click);
            // 
            // btnSolid
            // 
            this.btnSolid.BackColor = System.Drawing.Color.White;
            this.btnSolid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSolid.Image = ((System.Drawing.Image)(resources.GetObject("btnSolid.Image")));
            this.btnSolid.Location = new System.Drawing.Point(6, 16);
            this.btnSolid.Name = "btnSolid";
            this.btnSolid.Size = new System.Drawing.Size(90, 19);
            this.btnSolid.TabIndex = 8;
            this.btnSolid.UseVisualStyleBackColor = false;
            this.btnSolid.Click += new System.EventHandler(this.btnSolid_Click);
            // 
            // grpBoxSize
            // 
            this.grpBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBoxSize.Controls.Add(this.btnBrushSize3);
            this.grpBoxSize.Controls.Add(this.btnBrushSize2);
            this.grpBoxSize.Controls.Add(this.btnBrushSize1);
            this.grpBoxSize.Location = new System.Drawing.Point(519, 13);
            this.grpBoxSize.Name = "grpBoxSize";
            this.grpBoxSize.Size = new System.Drawing.Size(127, 81);
            this.grpBoxSize.TabIndex = 3;
            this.grpBoxSize.TabStop = false;
            this.grpBoxSize.Text = "Tamaño";
            // 
            // btnBrushSize3
            // 
            this.btnBrushSize3.BackColor = System.Drawing.Color.Black;
            this.btnBrushSize3.Location = new System.Drawing.Point(78, 26);
            this.btnBrushSize3.Name = "btnBrushSize3";
            this.btnBrushSize3.Size = new System.Drawing.Size(36, 36);
            this.btnBrushSize3.TabIndex = 10;
            this.btnBrushSize3.UseVisualStyleBackColor = false;
            this.btnBrushSize3.Click += new System.EventHandler(this.btnBrushSize3_Click);
            // 
            // btnBrushSize2
            // 
            this.btnBrushSize2.BackColor = System.Drawing.Color.Black;
            this.btnBrushSize2.Location = new System.Drawing.Point(42, 30);
            this.btnBrushSize2.Name = "btnBrushSize2";
            this.btnBrushSize2.Size = new System.Drawing.Size(30, 30);
            this.btnBrushSize2.TabIndex = 9;
            this.btnBrushSize2.UseVisualStyleBackColor = false;
            this.btnBrushSize2.Click += new System.EventHandler(this.btnBrushSize2_Click);
            // 
            // btnBrushSize1
            // 
            this.btnBrushSize1.BackColor = System.Drawing.Color.Black;
            this.btnBrushSize1.Location = new System.Drawing.Point(11, 33);
            this.btnBrushSize1.Name = "btnBrushSize1";
            this.btnBrushSize1.Size = new System.Drawing.Size(25, 25);
            this.btnBrushSize1.TabIndex = 8;
            this.btnBrushSize1.UseVisualStyleBackColor = false;
            this.btnBrushSize1.Click += new System.EventHandler(this.btnBrushSize1_Click);
            // 
            // grpBoxColors
            // 
            this.grpBoxColors.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxColors.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBoxColors.Controls.Add(this.btnWite);
            this.grpBoxColors.Controls.Add(this.btnBlack);
            this.grpBoxColors.Controls.Add(this.btnLigthGreen);
            this.grpBoxColors.Controls.Add(this.btnGreen);
            this.grpBoxColors.Controls.Add(this.btnLigthBlue);
            this.grpBoxColors.Controls.Add(this.btnBlue);
            this.grpBoxColors.Controls.Add(this.btnColorPalette);
            this.grpBoxColors.Controls.Add(this.btnSelectedColor);
            this.grpBoxColors.Location = new System.Drawing.Point(652, 13);
            this.grpBoxColors.Name = "grpBoxColors";
            this.grpBoxColors.Size = new System.Drawing.Size(207, 81);
            this.grpBoxColors.TabIndex = 2;
            this.grpBoxColors.TabStop = false;
            this.grpBoxColors.Text = "Colores";
            // 
            // btnWite
            // 
            this.btnWite.BackColor = System.Drawing.Color.White;
            this.btnWite.Location = new System.Drawing.Point(120, 49);
            this.btnWite.Name = "btnWite";
            this.btnWite.Size = new System.Drawing.Size(23, 23);
            this.btnWite.TabIndex = 7;
            this.btnWite.UseVisualStyleBackColor = false;
            this.btnWite.Click += new System.EventHandler(this.btnWite_Click);
            // 
            // btnBlack
            // 
            this.btnBlack.BackColor = System.Drawing.Color.Black;
            this.btnBlack.Location = new System.Drawing.Point(120, 22);
            this.btnBlack.Name = "btnBlack";
            this.btnBlack.Size = new System.Drawing.Size(23, 23);
            this.btnBlack.TabIndex = 6;
            this.btnBlack.UseVisualStyleBackColor = false;
            this.btnBlack.Click += new System.EventHandler(this.btnBlack_Click);
            // 
            // btnLigthGreen
            // 
            this.btnLigthGreen.BackColor = System.Drawing.Color.LightGreen;
            this.btnLigthGreen.Location = new System.Drawing.Point(91, 49);
            this.btnLigthGreen.Name = "btnLigthGreen";
            this.btnLigthGreen.Size = new System.Drawing.Size(23, 23);
            this.btnLigthGreen.TabIndex = 5;
            this.btnLigthGreen.UseVisualStyleBackColor = false;
            this.btnLigthGreen.Click += new System.EventHandler(this.btnLigthGreen_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.Green;
            this.btnGreen.Location = new System.Drawing.Point(91, 22);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(23, 23);
            this.btnGreen.TabIndex = 4;
            this.btnGreen.UseVisualStyleBackColor = false;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnLigthBlue
            // 
            this.btnLigthBlue.BackColor = System.Drawing.Color.LightBlue;
            this.btnLigthBlue.Location = new System.Drawing.Point(62, 49);
            this.btnLigthBlue.Name = "btnLigthBlue";
            this.btnLigthBlue.Size = new System.Drawing.Size(23, 23);
            this.btnLigthBlue.TabIndex = 3;
            this.btnLigthBlue.UseVisualStyleBackColor = false;
            this.btnLigthBlue.Click += new System.EventHandler(this.btnLigthBlue_Click);
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.Blue;
            this.btnBlue.Location = new System.Drawing.Point(62, 22);
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
            this.btnColorPalette.Location = new System.Drawing.Point(149, 22);
            this.btnColorPalette.Name = "btnColorPalette";
            this.btnColorPalette.Size = new System.Drawing.Size(50, 50);
            this.btnColorPalette.TabIndex = 1;
            this.btnColorPalette.UseVisualStyleBackColor = true;
            this.btnColorPalette.Click += new System.EventHandler(this.btnColorPalette_Click);
            // 
            // btnSelectedColor
            // 
            this.btnSelectedColor.Location = new System.Drawing.Point(6, 22);
            this.btnSelectedColor.Name = "btnSelectedColor";
            this.btnSelectedColor.Size = new System.Drawing.Size(50, 50);
            this.btnSelectedColor.TabIndex = 0;
            this.btnSelectedColor.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pixelToolStripMenuItem,
            this.rectaToolStripMenuItem,
            this.circuloToolStripMenuItem,
            this.poligonoIrregularToolStripMenuItem,
            this.poligonoRegularToolStripMenuItem,
            this.elipseToolStripMenuItem,
            this.transladarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(871, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pixelToolStripMenuItem
            // 
            this.pixelToolStripMenuItem.Name = "pixelToolStripMenuItem";
            this.pixelToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.pixelToolStripMenuItem.Text = "Pixel";
            this.pixelToolStripMenuItem.Click += new System.EventHandler(this.pixelToolStripMenuItem_Click);
            // 
            // rectaToolStripMenuItem
            // 
            this.rectaToolStripMenuItem.Name = "rectaToolStripMenuItem";
            this.rectaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.rectaToolStripMenuItem.Text = "Recta";
            this.rectaToolStripMenuItem.Click += new System.EventHandler(this.rectaToolStripMenuItem_Click);
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.circuloToolStripMenuItem.Text = "Circulo";
            this.circuloToolStripMenuItem.Click += new System.EventHandler(this.circuloToolStripMenuItem_Click);
            // 
            // poligonoIrregularToolStripMenuItem
            // 
            this.poligonoIrregularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTxtBoxSides});
            this.poligonoIrregularToolStripMenuItem.Name = "poligonoIrregularToolStripMenuItem";
            this.poligonoIrregularToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.poligonoIrregularToolStripMenuItem.Text = "Poligono Irregular";
            this.poligonoIrregularToolStripMenuItem.Click += new System.EventHandler(this.poligonoIrregularToolStripMenuItem_Click);
            // 
            // toolStripTxtBoxSides
            // 
            this.toolStripTxtBoxSides.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTxtBoxSides.Name = "toolStripTxtBoxSides";
            this.toolStripTxtBoxSides.Size = new System.Drawing.Size(100, 23);
            this.toolStripTxtBoxSides.Text = "# de lados";
            // 
            // poligonoRegularToolStripMenuItem
            // 
            this.poligonoRegularToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.trianguloToolStripMenuItem,
            this.cuadradoToolStripMenuItem,
            this.pentagonoToolStripMenuItem,
            this.hexagonoToolStripMenuItem,
            this.toolStripTxtBoxSidesRegularPoly});
            this.poligonoRegularToolStripMenuItem.Name = "poligonoRegularToolStripMenuItem";
            this.poligonoRegularToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.poligonoRegularToolStripMenuItem.Text = "Poligono Regular";
            this.poligonoRegularToolStripMenuItem.Click += new System.EventHandler(this.poligonoRegularToolStripMenuItem_Click);
            // 
            // trianguloToolStripMenuItem
            // 
            this.trianguloToolStripMenuItem.Name = "trianguloToolStripMenuItem";
            this.trianguloToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.trianguloToolStripMenuItem.Text = "Triangulo";
            this.trianguloToolStripMenuItem.Click += new System.EventHandler(this.trianguloToolStripMenuItem_Click);
            // 
            // cuadradoToolStripMenuItem
            // 
            this.cuadradoToolStripMenuItem.Name = "cuadradoToolStripMenuItem";
            this.cuadradoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.cuadradoToolStripMenuItem.Text = "Cuadrado";
            this.cuadradoToolStripMenuItem.Click += new System.EventHandler(this.cuadradoToolStripMenuItem_Click);
            // 
            // pentagonoToolStripMenuItem
            // 
            this.pentagonoToolStripMenuItem.Name = "pentagonoToolStripMenuItem";
            this.pentagonoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pentagonoToolStripMenuItem.Text = "Pentagono";
            this.pentagonoToolStripMenuItem.Click += new System.EventHandler(this.pentagonoToolStripMenuItem_Click);
            // 
            // hexagonoToolStripMenuItem
            // 
            this.hexagonoToolStripMenuItem.Name = "hexagonoToolStripMenuItem";
            this.hexagonoToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.hexagonoToolStripMenuItem.Text = "Hexagono";
            this.hexagonoToolStripMenuItem.Click += new System.EventHandler(this.hexagonoToolStripMenuItem_Click);
            // 
            // toolStripTxtBoxSidesRegularPoly
            // 
            this.toolStripTxtBoxSidesRegularPoly.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTxtBoxSidesRegularPoly.MaxLength = 3;
            this.toolStripTxtBoxSidesRegularPoly.Name = "toolStripTxtBoxSidesRegularPoly";
            this.toolStripTxtBoxSidesRegularPoly.Size = new System.Drawing.Size(100, 23);
            this.toolStripTxtBoxSidesRegularPoly.Text = "# de lados";
            // 
            // elipseToolStripMenuItem
            // 
            this.elipseToolStripMenuItem.Name = "elipseToolStripMenuItem";
            this.elipseToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.elipseToolStripMenuItem.Text = "Elipse";
            this.elipseToolStripMenuItem.Click += new System.EventHandler(this.elipseToolStripMenuItem_Click);
            // 
            // transladarToolStripMenuItem
            // 
            this.transladarToolStripMenuItem.Name = "transladarToolStripMenuItem";
            this.transladarToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.transladarToolStripMenuItem.Text = "Transladar";
            this.transladarToolStripMenuItem.Click += new System.EventHandler(this.transladarToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            this.ayudaToolStripMenuItem.Click += new System.EventHandler(this.ayudaToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(871, 595);
            this.Controls.Add(this.grpBoxTools);
            this.Controls.Add(this.ptbCanvas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Elaborado por Andres Castro";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanvas)).EndInit();
            this.grpBoxTools.ResumeLayout(false);
            this.grpBoxStyles.ResumeLayout(false);
            this.grpBoxSize.ResumeLayout(false);
            this.grpBoxColors.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private MenuStrip menuStrip1;
        private ToolStripMenuItem pixelToolStripMenuItem;
        private ToolStripMenuItem rectaToolStripMenuItem;
        private ToolStripMenuItem circuloToolStripMenuItem;
        private ColorDialog colorDialog;
        private GroupBox grpBoxStyles;
        private Button btnDashed;
        private Button btnDotted;
        private Button btnSolid;
        private ToolStripMenuItem poligonoIrregularToolStripMenuItem;
        private ToolStripTextBox toolStripTxtBoxSides;
        private ToolStripMenuItem poligonoRegularToolStripMenuItem;
        private ToolStripMenuItem trianguloToolStripMenuItem;
        private ToolStripMenuItem cuadradoToolStripMenuItem;
        private ToolStripMenuItem pentagonoToolStripMenuItem;
        private ToolStripMenuItem hexagonoToolStripMenuItem;
        private ToolStripTextBox toolStripTxtBoxSidesRegularPoly;
        private Button btnCleanCanvas;
        private ToolStripMenuItem elipseToolStripMenuItem;
        private ToolStripMenuItem transladarToolStripMenuItem;
        private ToolStripMenuItem ayudaToolStripMenuItem;
        private Button btnFill;
    }
}