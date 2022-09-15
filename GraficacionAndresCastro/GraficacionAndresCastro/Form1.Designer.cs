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
            this.ptbCanvas = new System.Windows.Forms.PictureBox();
            this.grpBoxTools = new System.Windows.Forms.GroupBox();
            this.grpBoxSize = new System.Windows.Forms.GroupBox();
            this.btnSize3 = new System.Windows.Forms.Button();
            this.btnSize2 = new System.Windows.Forms.Button();
            this.btnSize1 = new System.Windows.Forms.Button();
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
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanvas)).BeginInit();
            this.grpBoxTools.SuspendLayout();
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
            this.grpBoxTools.Controls.Add(this.grpBoxSize);
            this.grpBoxTools.Controls.Add(this.grpBoxColors);
            this.grpBoxTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpBoxTools.Location = new System.Drawing.Point(0, 24);
            this.grpBoxTools.Name = "grpBoxTools";
            this.grpBoxTools.Size = new System.Drawing.Size(871, 100);
            this.grpBoxTools.TabIndex = 1;
            this.grpBoxTools.TabStop = false;
            // 
            // grpBoxSize
            // 
            this.grpBoxSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBoxSize.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.grpBoxSize.Controls.Add(this.btnSize3);
            this.grpBoxSize.Controls.Add(this.btnSize2);
            this.grpBoxSize.Controls.Add(this.btnSize1);
            this.grpBoxSize.Location = new System.Drawing.Point(474, 12);
            this.grpBoxSize.Name = "grpBoxSize";
            this.grpBoxSize.Size = new System.Drawing.Size(146, 81);
            this.grpBoxSize.TabIndex = 3;
            this.grpBoxSize.TabStop = false;
            this.grpBoxSize.Text = "Tamaño";
            // 
            // btnSize3
            // 
            this.btnSize3.Location = new System.Drawing.Point(99, 29);
            this.btnSize3.Name = "btnSize3";
            this.btnSize3.Size = new System.Drawing.Size(36, 36);
            this.btnSize3.TabIndex = 10;
            this.btnSize3.UseVisualStyleBackColor = true;
            // 
            // btnSize2
            // 
            this.btnSize2.Location = new System.Drawing.Point(57, 29);
            this.btnSize2.Name = "btnSize2";
            this.btnSize2.Size = new System.Drawing.Size(36, 36);
            this.btnSize2.TabIndex = 9;
            this.btnSize2.UseVisualStyleBackColor = true;
            // 
            // btnSize1
            // 
            this.btnSize1.Location = new System.Drawing.Point(15, 29);
            this.btnSize1.Name = "btnSize1";
            this.btnSize1.Size = new System.Drawing.Size(36, 36);
            this.btnSize1.TabIndex = 8;
            this.btnSize1.UseVisualStyleBackColor = true;
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
            this.grpBoxColors.Location = new System.Drawing.Point(633, 12);
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
            this.circuloToolStripMenuItem});
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
            // 
            // rectaToolStripMenuItem
            // 
            this.rectaToolStripMenuItem.Name = "rectaToolStripMenuItem";
            this.rectaToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.rectaToolStripMenuItem.Text = "Recta";
            // 
            // circuloToolStripMenuItem
            // 
            this.circuloToolStripMenuItem.Name = "circuloToolStripMenuItem";
            this.circuloToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.circuloToolStripMenuItem.Text = "Circulo";
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
            ((System.ComponentModel.ISupportInitialize)(this.ptbCanvas)).EndInit();
            this.grpBoxTools.ResumeLayout(false);
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
        private Button btnSize3;
        private Button btnSize2;
        private Button btnSize1;
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
    }
}