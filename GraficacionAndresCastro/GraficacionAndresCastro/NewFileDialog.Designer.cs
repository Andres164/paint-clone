namespace GraficacionAndresCastro
{
    partial class NewFileDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numUpDownWidth = new System.Windows.Forms.NumericUpDown();
            this.numUpDownHeigth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.grpBoxCanvasSize = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHeigth)).BeginInit();
            this.grpBoxCanvasSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(93, 147);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAccept
            // 
            this.btnAccept.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnAccept.Location = new System.Drawing.Point(174, 147);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(75, 23);
            this.btnAccept.TabIndex = 2;
            this.btnAccept.Text = "Aceptar";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(11, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Anchura:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(11, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Altura:";
            // 
            // numUpDownWidth
            // 
            this.numUpDownWidth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numUpDownWidth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numUpDownWidth.Location = new System.Drawing.Point(85, 29);
            this.numUpDownWidth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownWidth.Name = "numUpDownWidth";
            this.numUpDownWidth.Size = new System.Drawing.Size(88, 23);
            this.numUpDownWidth.TabIndex = 0;
            this.numUpDownWidth.Value = new decimal(new int[] {
            800,
            0,
            0,
            0});
            // 
            // numUpDownHeigth
            // 
            this.numUpDownHeigth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.numUpDownHeigth.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numUpDownHeigth.Location = new System.Drawing.Point(85, 70);
            this.numUpDownHeigth.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numUpDownHeigth.Name = "numUpDownHeigth";
            this.numUpDownHeigth.Size = new System.Drawing.Size(88, 23);
            this.numUpDownHeigth.TabIndex = 1;
            this.numUpDownHeigth.Value = new decimal(new int[] {
            600,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(179, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Pixeles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(179, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pixeles";
            // 
            // grpBoxCanvasSize
            // 
            this.grpBoxCanvasSize.Controls.Add(this.label1);
            this.grpBoxCanvasSize.Controls.Add(this.label4);
            this.grpBoxCanvasSize.Controls.Add(this.label2);
            this.grpBoxCanvasSize.Controls.Add(this.label3);
            this.grpBoxCanvasSize.Controls.Add(this.numUpDownWidth);
            this.grpBoxCanvasSize.Controls.Add(this.numUpDownHeigth);
            this.grpBoxCanvasSize.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grpBoxCanvasSize.Location = new System.Drawing.Point(12, 12);
            this.grpBoxCanvasSize.Name = "grpBoxCanvasSize";
            this.grpBoxCanvasSize.Size = new System.Drawing.Size(234, 111);
            this.grpBoxCanvasSize.TabIndex = 8;
            this.grpBoxCanvasSize.TabStop = false;
            this.grpBoxCanvasSize.Text = "Tamaño del lienzo";
            // 
            // NewFileDialog
            // 
            this.AcceptButton = this.btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(261, 182);
            this.Controls.Add(this.grpBoxCanvasSize);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "NewFileDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Nuevo ";
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numUpDownHeigth)).EndInit();
            this.grpBoxCanvasSize.ResumeLayout(false);
            this.grpBoxCanvasSize.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnCancel;
        private Button btnAccept;
        private Label label1;
        private Label label2;
        private NumericUpDown numUpDownWidth;
        private NumericUpDown numUpDownHeigth;
        private Label label3;
        private Label label4;
        private GroupBox grpBoxCanvasSize;
    }
}