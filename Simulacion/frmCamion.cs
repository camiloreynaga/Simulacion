using Simulacion_Library.Models;
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

        public List<double> lGradientes = new List<double>();

        private void frmCamion_Load(object sender, EventArgs e)
        {
            Camion oCamion = new Camion();
            dgvSpeed.Columns["Gradient"].ValueType = typeof(Double);
            //oCamion.CurvaConsumo.
        }

        private void dgvSpeed_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
           // ValidarGradiente(dgvSpeed);
            Enumerar(dgvSpeed);
        }

        #region metodos
        /// <summary>
        /// agregar un valor de gradiente a la lista lGradientes
        /// </summary>
        /// <param name="gradiente"></param>
        private void AgregarGradiente(double gradiente)
        {
            lGradientes.Add(gradiente);
        }

        /// <summary>
        /// enumera la columna Nro de la grilla
        /// </summary>
        /// <param name="dgvData"></param>
        private void Enumerar(DataGridView dgvData)
        {

            for (int i = 0; i < dgvData.RowCount; i++)
            {
                dgvData.Rows[i].Cells["Number"].Value = i + 1;
                //dgvData.Rows
            }
        }

        /// <summary>
        /// valida que le valor de la gradiente no exista en la lista
        /// </summary>
        /// <param name="lGradientes">lista de gradientes</param>
        /// <param name="Gradient"> valor de la gradietne a evaluar</param>
        /// <returns></returns>
        private bool ValidarGradiente(List<double> lGradientes, double Gradient)
        {

            return lGradientes.Count>0 ?  lGradientes.Contains(Gradient): false;
        }

        private int ContarGradienteIguales(List<double> lGradientes, double Gradient)
        {
            int cantidad = 0;
            if (lGradientes.Contains(Gradient))
            {
                cantidad=lGradientes.Count<double>(x => x == Gradient);
            }
            return cantidad;
             //lGradientes.Count > 0 ?  : false;
        }

        /// <summary>
        /// Valida que el nuevo valor de la gradiente no exista en la columna gradientes de la grilla
        /// </summary>
        /// <param name="dgvData">Grila en la que se busca</param>
        /// <param name="Gradient"> valor de la gradiente a evaluar</param>
        /// <returns></returns>
        private bool ValidarGradiente(DataGridView dgvData, double Gradient)
        {
            


                //double Gradient = (double)dgvData.CurrentRow.Cells["Gradient"].Value;

                List<double> lGradientes = new List<double>();
            //agregando la gradiente a evaluar en la lista de gradientes 
            // si ya existe la gradiente se duplicara.
                lGradientes.Add(Gradient);
                for (int i = 0; i < dgvData.RowCount-2; i++)
                {
                    lGradientes.Add( Convert.ToDouble( dgvData.Rows[i].Cells["Gradient"].Value));

                }
                //compara el valor de la variable Gradiente con los datos contenidos en la lista

                //return ValidarGradiente(lGradientes, Gradient);
                
                return ContarGradienteIguales(lGradientes, Gradient) > 1 ? true : false;

        }

        /// <summary>
        /// Ordena de forma ascendente una columna de la una grilla
        /// </summary>
        /// <param name="dgvData">Grilla en la que se ordena</param>
        /// <param name="nombreColumna">nombre de la columna a ordenar</param>
        /// <returns></returns>
        private void OrdenarColumnaAsc(DataGridView dgvData,string nombreColumna)
        {
            DataGridViewColumn columna = dgvData.Columns[nombreColumna];
            dgvSpeed.Sort(columna, ListSortDirection.Ascending);
        }
        #endregion


        
        private void dgvSpeed_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
           // ValidarGradiente(dgvSpeed, Convert.ToDouble(e.FormattedValue));
            try
            {
                //obteniendo el estado, si esta en edicion, de la celda actual
                var state = dgvSpeed.Rows[e.RowIndex].Cells[e.ColumnIndex].IsInEditMode;
                var nombreColumna = dgvSpeed.Columns[e.ColumnIndex].HeaderText;
                // Verificando que la celda no este vacia
                if (string.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dgvSpeed.Rows[e.RowIndex].ErrorText =
                        "Celda no puede estar vacia";
                    e.Cancel = true;
                }

                //Si la celda no esta vacia
                else
                {
                    //obteniendo el valor de la celda
                    double _gradiente = Convert.ToDouble(e.FormattedValue);// > 0 ? Convert.ToDouble(e.FormattedValue) : 0;
                    //verificando si es una nueva linea
                    if (!dgvSpeed.Rows[e.RowIndex].IsNewRow)
                    {
                        //validando que el estado sea igual a Edicion y el nombre de columna igual a Gradient
                        if (state && nombreColumna=="Gradient")
                        {
                            //verificando que el valor de la celda no exista en la columan Gradient
                            //si existe devuelve verdadero (true)
                            if (ValidarGradiente(dgvSpeed, _gradiente))
                            {

                                MessageBox.Show("Gradiente ya existe " + _gradiente);
                                //dgvSpeed.Rows[e.RowIndex].Cells[e.ColumnIndex].;
                                e.Cancel = true;
                            }
                            // si no existe ordena de forma ascendente
                            else
                            {
                                //ordenando la columna de nombre Gradiente de la grilla dgvSpeed
                                OrdenarColumnaAsc(dgvSpeed, "Gradient");
                            }
                        }
                        
                    }
                        
                }
            }
            catch (Exception ex)
            { }

        }



        private void dgvSpeed_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //borrar la fila en caso de presionar esc
            dgvSpeed.Rows[e.RowIndex].ErrorText = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataGridViewColumn columna = dgvSpeed.Columns["Gradient"];
            dgvSpeed.Sort(columna, ListSortDirection.Ascending);
        }

        private void dgvSpeed_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvSpeed_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //DataGridViewColumn columna = dgvSpeed.Columns["Gradient"];
            //dgvSpeed.Sort(columna, ListSortDirection.Ascending);
        }

    }
}
