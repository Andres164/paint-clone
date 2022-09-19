using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraficacionAndresCastro
{
    public partial class NewFileDialog : Form
    {
        public Int16 canvasHeight { get; private set; }
        public Int16 canvasWidth { get; private set; }
        public NewFileDialog()
        {
            InitializeComponent();
            canvasHeight = 0;
            canvasWidth = 0;
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            canvasHeight = Convert.ToInt16(this.numUpDownHeigth.Value);
            canvasWidth = Convert.ToInt16(this.numUpDownWidth.Value);
        }
    }
}
