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

        /// <summary>
        /// Abre un archivo plano (SRG,SRV,TXT) y devuelve sus valores dentro de un arrayLIst
        /// </summary>
        /// <returns></returns>
        public static ArrayList OpenFile()
        {

            OpenFileDialog Dialogo = new OpenFileDialog();
            Dialogo.InitialDirectory = "D:\\1 Proyectos SW KIWI SOLUCIONES\\Simulacion\\Docs Simulacion";
            // Lista de arreglos en la cual se almacenarán los datos de la variable strLine
            ArrayList arrLines = new ArrayList();
            
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
                   
                    char[] delimitadores = { ' ', ',', '\t' };
                    
                    while (strLine != null)
                    {
                        strLine = objFile.ReadLine();
                        //strLine.
                        if (strLine != null && strLine.Trim().Length > 0)
                        {
                            arrLines.Add(strLine);
                          //  var linea = strLine.Split(delimitadores).ToList<string>();
                           // linea.RemoveAll(x => x.ToString() == string.Empty);
                        }
                    }
                    /// Cerrando objeto
                    objFile.Close();
                }
                return arrLines;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se debe seleccionar un archivo " + ex.Message);
                return null;
            }
        }

        /// <summary>
        /// Muestra las lineas de un arhivo de coordenadas en una grilla, Eliminando los espacios en blanco 
        /// </summary>
        /// <param name="LineArray">Arreglo de lineas</param>
        /// <param name="DataGrid"></param>
        public static void ShowInDataGrid(ArrayList LineArray, DataGridView DataGrid)
        {
            char[] delimitadores = { ' ', ',', '\t' };
            ArrayList NewList = new ArrayList();
            foreach (string line in LineArray)
            {

                var TrimLine = line.Split(delimitadores).ToList<string>();
                TrimLine.RemoveAll(x => x.ToString() == string.Empty);
                DataGrid.Rows.Add(TrimLine.ToArray<string>());
                //line
                //DataGrid.Rows.Add(line);
            }
        }

        /// <summary>
        /// borra los espacio en blanco, de las lineas del arreglo de coordenas
        /// </summary>
        /// <param name="LineArray"></param>
        public static ArrayList DeleteSpaces(ArrayList LineArray)
        {
            char[] delimitadores = { ' ', ',', '\t' };
            ArrayList newArray = new ArrayList(); ;
            foreach (string line in LineArray)
            {

                var TrimLine = line.Split(delimitadores).ToList<string>();
                TrimLine.RemoveAll(x => x.ToString() == string.Empty);
                newArray.Add(TrimLine.ToArray<string>());
            }
            return newArray;
        }

    }
}
