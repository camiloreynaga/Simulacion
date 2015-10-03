using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_Library.Models;

namespace Simulacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Coordenada inicial = new Coordenada();
            Coordenada final = new Coordenada();

            inicial.X = Convert.ToDouble(tbXIni.Text);
            inicial.Y = Convert.ToDouble(tbYIni.Text);
            inicial.Z = Convert.ToDouble(tbZIni.Text);
            
            final.X = Convert.ToDouble(tbXFin.Text);
            final.Y = Convert.ToDouble(tbYFin.Text);
            final.Z = Convert.ToDouble(tbZFin.Text);
            
            //MessageBox.Show(Coordenada.DistanciaInclinada(inicial, final).ToString());

            tbInclinada.Text = Coordenada.DistanciaInclinada(inicial, final).ToString();
            tbHorizontal.Text = Coordenada.DistanciaHorizontal(inicial, final).ToString();
            tbVertical.Text = Coordenada.DistanciaVertical(inicial, final).ToString();
            tbGradiente.Text = Coordenada.Gradiente(
                Convert.ToDouble(tbVertical.Text),
                Convert.ToDouble(tbHorizontal.Text)).ToString();

            MessageBox.Show(Coordenada.Gradiente(inicial, final).ToString());
            //tbHorizontal.
        }
    }
}
