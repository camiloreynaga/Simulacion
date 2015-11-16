using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Collections;

namespace Simulacion_Library
{
    public class Files
    {

        public static void OpenFile(DataGridView DataGrid)
        {
       
            OpenFileDialog Dialogo = new OpenFileDialog();
            Dialogo.InitialDirectory = "D:\\1 Proyectos SW KIWI SOLUCIONES\\Simulacion\\Docs Simulacion";

            try
            {
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
                    char[] delimitadores = { ' ', ',', '\t' };
                    while (strLine != null)
                    {
                        strLine = objFile.ReadLine();
                        //strLine.
                        //Dividir(strLine);
                        if (strLine != null && strLine.Trim().Length > 0)
                        {
                            arrLines.Add(strLine);
                            var linea = strLine.Split(delimitadores).ToList<string>();
                            linea.RemoveAll(x => x.ToString() == string.Empty);

                            //linea.to
                            DataGrid.Rows.Add(linea.ToArray<string>());


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

    }
}
