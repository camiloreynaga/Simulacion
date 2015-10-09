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
using System.IO;
using System.Collections;

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

        private void btnImport_Click(object sender, EventArgs e)
        {
            // datos_total: Guarda información de gradientes por separado
            DataSet datos_total;
            
            OpenFileDialog Dialogo = new OpenFileDialog();
            Dialogo.InitialDirectory = "D:\\17 Aplicaciones C#\\Simulacion";
            
            try{
                if (Dialogo.ShowDialog() == DialogResult.OK)
                {
                    //MessageBox.Show(Dialogo.FileName);
                    string strFile = Dialogo.FileName;
                    
                    /// Creando el objeto contenedor de archivo plano
                    StreamReader objFile = new StreamReader(strFile);

                    /// Variable en la cual se almacena una linea de texto
                    string strLine = "";

                    // Lista de arreglos en la cual se almacenarán los datos de la variable strLine
                    ArrayList arrLines = new ArrayList();
                    char[] delimitadores = { ',', '\t' };
                    while (strLine != null)
                    {
                        strLine = objFile.ReadLine();
                        if (strLine != null && strLine.Trim().Length > 0)
                        {
                            arrLines.Add(strLine);
                            dgvGrilla.Rows.Add(strLine.Split(delimitadores));

                            
                        }
                    }

                    /// Cerrando objeto
                    objFile.Close();


                    // separando valores
                    foreach (string strLine1 in arrLines)
                    {
                        //char[] delimitadores = { ',', '\t' };
                        string[] arrSeparado = strLine1.Trim().Split(delimitadores);
                    }

                        
    

                }
            }

            catch (Exception ex) 
            {
                MessageBox.Show("Se debe seleccionar un archivo " + ex.Message);           
            }
        }

        private void InitGrilla()
        {
            dgvGrilla.ColumnCount = 3;
            dgvGrilla.ColumnHeadersVisible = true;
            dgvGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgvGrilla.Columns[0].Name = "Gradient";
            dgvGrilla.Columns[1].Name = "Full";
            dgvGrilla.Columns[2].Name = "Empty";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitGrilla();
        }
    }
}
