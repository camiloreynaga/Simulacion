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
    public partial class frmCamion : CRUD_Padre
    {
        public frmCamion()
        {
            InitializeComponent();
        }

        private void frmCamion_Load(object sender, EventArgs e)
        {

        }

        private void dgvSpeed_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           // ValidarGradiente(dgvSpeed);
            Enumerar(dgvSpeed);
        }

        #region metodos

        private void Enumerar(DataGridView dgvData)
        {

            for (int i = 0; i < dgvData.RowCount; i++)
            {
                dgvData.Rows[i].Cells["Number"].Value = i + 1;
                //dgvData.Rows
            }
        }

        private void ValidarGradiente(DataGridView dgvData, double Gradient)
        {
            try
            {


                //double Gradient = (double)dgvData.CurrentRow.Cells["Gradient"].Value;

                List<double> lGradiente = new List<double>();

                for (int i = 0; i < dgvData.RowCount; i++)
                {
                    lGradiente.Add( Convert.ToDouble( dgvData.Rows[i].Cells["Gradient"].Value));

                }
                //compara el valor de la variable Gradiente con los datos contenidos en la lista
                if (dgvData.RowCount > 0)
                {
                    if (lGradiente.Contains(Gradient))
                    {
                        MessageBox.Show("ya existe " + Gradient);
                    }
                }
            }
            catch
            {
            }


        }
        #endregion

        private void dgvSpeed_CurrentCellChanged(object sender, EventArgs e)
        {

            //.ToString()
            
            //MessageBox.Show(((DataGridView)sender).CurrentCell.Value.ToString());
            //MessageBox.Show(e.ToString());
        }

        
        private void dgvSpeed_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            //MessageBox.Show(e.FormattedValue.ToString());
            ValidarGradiente(dgvSpeed, Convert.ToDouble(e.FormattedValue));
        }

    }
}
