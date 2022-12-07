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
    public partial class VentanaAyuda : Form
    {
        public VentanaAyuda()
        {
            InitializeComponent();
        }

        private void pixelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Para dibujar pixeles, simplemente da click en el lienzo, la herramienta pixel es la herramienta default al abrir la aplicacion.";
            this.ptbGifTutorial.Image = Properties.Resources._1__Pixels;
        }

        private void circulosYPoligonoRegularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Para dibujar Círculos, elipses y polígonos regulares, selecciona cualquiera de estas opciones en el menú de arriba y da click en el lienzo para dibujar la figura. En el caso del polígono regular puedes seleccionar uno ya definido, o un polígono regular de la cantidad de lados que quieras escribiendo en la caja de texto de la tira de opciones.";
            this.ptbGifTutorial.Image = Properties.Resources._2__Herramientas_de_1_click;
        }

        private void rectasYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Para dibujar rectas y polígonos irregulares, selecciona cualquiera de estas opciones en el menú de arriba, en el caso de las rectas, tendrás que dar 2 clicks, el primero es de donde comienza la recta y el segundo es donde va terminar, en el caso del polígono irregular tienes que ingresar el número de lados que quieres que tenga tu polígono, para dibujarlo tendrás que dar tantos clicks como lados ingresaste, cada click es un vértice del polígono irregular.";
            this.ptbGifTutorial.Image = Properties.Resources._3__Herramientas_de_varios_clicks;
        }

        private void tamañosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Las opciones de tamaño modifican al grosor del pincel, hay 3 opciones a elegir, simplemente elige tu herramienta y posteriormente el tamaño del pincel, el tamaño por defecto es el más pequeño.";
            this.ptbGifTutorial.Image = Properties.Resources._4__Tamaños;
        }

        private void coloresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Para dibujar figuras con contornos de diferentes colores, solo selecciona tu herramienta y posteriormente selecciona un color predefinido, o puedes seleccionar un color propio en el botón con la gradiente de colores para mostrar la paleta de colores.";
            this.ptbGifTutorial.Image = Properties.Resources._5__Colores;
        }

        private void estilosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Las rectas y ambos tipos de polígonos tienen estilos de dibujo, sólido, punteado y discontinuo, para aplicarlo solo selecciona una de estas 3 herramientas, a continuación selecciona el estilo deseado y dibuja tu figura en el lienzo.";
            this.ptbGifTutorial.Image = Properties.Resources._6__Estilos;
        }

        private void rellenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Con la herramienta relleno o cubeta puedes rellenar un área encerrada del color que quieras, solo selecciona un color, la cubeta y da click en el área que quieras rellenar.";
            this.ptbGifTutorial.Image = Properties.Resources._6__Relleno;
        }

        private void limpiarLienzoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Si quieres borrar todo lo que has dibujado en el lienzo, simplemente presiona el botón limpiar lienzo y todo su contenido será borrado.";
            this.ptbGifTutorial.Image = Properties.Resources._7__Limpiar_lienzo;
        }

        private void translacionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txtBoxTutorial.Text =
                "Si dibujaste una figura y la quieres mover, puedes seleccionar la opción traslación, posteriormente da click al nuevo lugar al que quieres trasladar tu figura. Esta función solamente puede ser usada con la última figura dibujada.";
            this.ptbGifTutorial.Image = Properties.Resources._8__Translacion;
        }
    }
}
