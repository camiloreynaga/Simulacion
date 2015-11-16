using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Simulacion_Library;

namespace Simulacion
{
    public partial class frmRuta : Form
    {
        public frmRuta()
        {
            InitializeComponent();
        }

        private void frmRuta_Load(object sender, EventArgs e)
        {
            dgvGrilla.ColumnCount = 4;
            dgvGrilla.ColumnHeadersVisible = true;
            dgvGrilla.Columns[0].Name = "Id";
            dgvGrilla.Columns[1].Name = "East";
            dgvGrilla.Columns[2].Name = "North";
            dgvGrilla.Columns[3].Name = "Level";
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            Files.OpenFile(dgvGrilla);
        }
    }
}
