using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simulacion
{
    public partial class frmListaExample : Form
    {
        public frmListaExample()
        {
            InitializeComponent();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            List<string> list1 = new List<string>();

            list1.Add("Uno");
            list1.Add("Dos");
            list1.Add("Tres");
            list1.Add("Cuatro");

            /// ubicacion de indice en la lista
            //var r = list1.FindIndex(x => x == "Uno").ToString();
            
            
            //forma de buscar un elemento
            //var r = list1.Find(x => x.Contains("o")).ToString();

            //var r = list1.Contains("Uno").ToString();

            var r = list1.Exists(x=>x =="uno").ToString();

            list1.Contains<string>("uno");
            // 
            var aO = list1.Find(x=>x.Length >= 4).ToString();
                MessageBox.Show(aO);

            //dgv.DataSource = list1.ToArray<string>();

        }
    }
}
