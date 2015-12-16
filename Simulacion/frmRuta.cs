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
using System.Collections;
using Simulacion_Library.Models;

namespace Simulacion
{
    public partial class frmRuta : Form
    {
        public frmRuta()
        {
            InitializeComponent();
        }
        /// <summary>
        /// lista de coordenas 
        /// </summary>
        List<Coordenada> coordenadaListSrg = new List<Coordenada>();
        List<Coordenada> coordenadaListSvr = new List<Coordenada>();

        List<Segmento> SegmentoList = new List<Segmento>();
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
            //Files.OpenFile(dgvGrilla);

            //obteniendo los datos desde el archivo srv
            ArrayList  arrayFromFile= Files.OpenFile();


            //mostrando las coordenas en la grilla
            Files.ShowInDataGrid(arrayFromFile,dgvGrilla);
            // quitando los espacios en blanco de las lineas del archivo srv
            ArrayList arrayClean = Files.DeleteSpaces(arrayFromFile);

            //string[] a = arrayClean;
            //cargando las coordenadas en la lista srv de coordenadas
            ListCoordenadas(coordenadaListSvr, arrayClean, 1, 2, 3);

            //ListCoordenadas(coordenadaListSvr, arrayClean, 1, 2, 3, 0, 0);

        }

        private void btnSrg_Click(object sender, EventArgs e)
        {
            //obteniendo los datos desde el archivo srg
            ArrayList  arrayFromFile= Files.OpenFile();
            // quitando los espacios en blanco de las lineas del archivo srg
            ArrayList arrayClean= Files.DeleteSpaces(arrayFromFile);
            
            Coordenada origen = new Coordenada();
            
            //cargando las coordenas del archivo sgr
            foreach (string[] line in arrayClean)
            {
                coordenadaListSrg.Add(new Coordenada(
                    Convert.ToDouble(line[0]),
                    Convert.ToDouble(line[1]),
                    Convert.ToDouble(line[2])
                    ));
            }
            
           //origen.X = Convert.ToDouble(); 

            tbCoordenada1.Text = arrayFromFile[0].ToString();
            tbCoordenada2.Text = arrayFromFile[1].ToString();

        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            //bool r= coordenadaListSvr.Contains(coordenadaListSrg[0]);

            //obteniendo las coordenadas origen, destino y asigandolas a veriables del tipo coordenada
            Coordenada origen = coordenadaListSrg[0];
            Coordenada destino = coordenadaListSrg[1];

            //evaluando la existencia de las coordenas en la lista de coordenadas
            //obtenidas desde el archivo srv
            bool OrigenExiste = ExisteCoordenada(coordenadaListSvr, origen);
            bool DestinoExiste = ExisteCoordenada(coordenadaListSvr, destino);
            //evaluadno la existencia de coordenadas
            if (OrigenExiste )
            {
                if (DestinoExiste)
                    Agrupar(coordenadaListSvr);
                else
                    MessageBox.Show("Coordenada destino no existen la lista de coordenadas");
            }
            else
            {
                MessageBox.Show("Coordenada origen no existen la lista de coordenadas");
            }

            List<Segmento> Ruta = new List<Segmento>();
            //ordenar coordenadas

            

            //definiendo la orientacion 
            // 1 = orientacion de Origen a Destino
            int orientacion = 1;
            //buscando el index para el segmento de la lista de segmentos que tiene a la coordenada 
            //Origen de la ruta en el atributo PuntoIncial
             int origenIndex=  SegmentoList.FindIndex(
                 x => x.PInicial.X==origen.X &&
                 x.PInicial.Y== origen.Y &&
                 x.PInicial.Z== origen.Z);

            // si busqueda de origen index no existe  ( retorna -1) en punto inicial
            // entonces buscar en punto final
             if (origenIndex < 0)
             {
                 origenIndex = SegmentoList.FindIndex(
                  x => x.PFinal.X == origen.X &&
                  x.PFinal.Y == origen.Y &&
                  x.PFinal.Z == origen.Z);
                 //establece como orientacion Destino hacia Origen
                 orientacion = -1;
                 
             }
            //obteniendo el segmento a partir del index que resulto de la busqueda anterior
            var SegmentoOrigen = SegmentoList.ElementAt<Segmento>(origenIndex);
            
            SegmentoOrigen.Orientacion = orientacion;
            SegmentoOrigen.Comentario = "Punto 1";
            
            //eliminando el segmento de la lista, porque ya fue trabajado
            SegmentoList.RemoveAt(origenIndex);

            //obteniendo la siguiente coordenada a concatenar
            //para establecer la ruta
            Coordenada sgtCoordenada;
            //concatenando la secuencia de coordenadas de oriden a destino 
            // si la orientacion es origen hacia destino (1), la sgte coordenada sera el punto final
            sgtCoordenada = orientacion==1 ? SegmentoOrigen.PFinal : SegmentoOrigen.PInicial; 
            
            //agregando segmento origen a ruta
            Ruta.Add(SegmentoOrigen);

            //asignando si esta completado
            bool completado = false;
            while(completado ==false)
            {
                
                int contador = 2; //contador para comentario punto + contador
                int segOrientacion = 1; // define la orientacion 
                
                //ubicando siguiente segmento de tiene la coordenada que sigue en la ruta
                int SegIndex = SegmentoList.FindIndex(
                 x => x.PInicial.X == sgtCoordenada.X &&
                 x.PInicial.Y == sgtCoordenada.Y &&
                 x.PInicial.Z == sgtCoordenada.Z);

                if (SegIndex < 0)
                {
                    SegIndex = SegmentoList.FindIndex(
                     x => x.PFinal.X == sgtCoordenada.X &&
                     x.PFinal.Y == sgtCoordenada.Y &&
                     x.PFinal.Z == sgtCoordenada.Z);
                    segOrientacion = -1;
                }

                Segmento Segmento = SegmentoList.ElementAt<Segmento>(SegIndex);
                Segmento.Orientacion = segOrientacion;
                Segmento.Comentario = "Punto " + contador ;
                
                //eliminando el segmento de la lista, porque ya fue trabajado
                SegmentoList.RemoveAt(SegIndex);

                //aqui estuvo el error ocurria que la variable Segmento no estab siendo usado sino que se como copie
                // el codigo se me olvido cambiar SegmentoOrigen por Segmento, por eso no pasaba de la 2da iteracion el bucle
                sgtCoordenada = segOrientacion == 1 ? Segmento.PFinal : Segmento.PInicial;
                
                //Aqui estoy probando si invierte cuando es orientacion -1, no lo he comprabad todavia
                if (segOrientacion==-1)
                    Segmento.Polylinea.Reverse();
                
                Ruta.Add(Segmento);

                //aumentando el contador
                contador++;
                if (sgtCoordenada.X == destino.X &&
                    sgtCoordenada.Y==destino.Y &&
                    sgtCoordenada.Z == destino.Z)
                    completado = true;
            }

            //foreach(Segmento s in SegmentoList)
            //{
            //    object o = (object)s.PInicial;
            //    o.Equals((object)origen);


            //   //int x= s.
            //   //if (x >= 0)
            //   //{
                   
            //   //}
            //       Ruta.Add(s);
            //}
        }
        

        /// <summary>
        /// busca y devuelve el indice de la coordenada a buscar, 
        /// </summary>
        /// <param name="coordenadaList"></param>
        /// <param name="coordenadaVerificar"></param>
        /// <returns></returns>
        public int findCoordenada(List<Coordenada> coordenadaList,Coordenada coordenadaVerificar )
        {
            return coordenadaList.FindIndex(
                    x => x.X == coordenadaVerificar.X &&
                    x.Y == coordenadaVerificar.Y &&
                    x.Z == coordenadaVerificar.Z
                    );
        }

        /// <summary>
        /// Verifica la existencia de una coordenada en una lista de coordenadas
        /// </summary>
        /// <param name="coordenadaList"></param>
        /// <param name="coordenadaVerificar"></param>
        /// <returns></returns>
        public bool ExisteCoordenada(List<Coordenada> coordenadaList,Coordenada coordenadaVerificar )
        {
            return coordenadaList.Exists(
                    x => x.X == coordenadaVerificar.X &&
                    x.Y == coordenadaVerificar.Y &&
                    x.Z == coordenadaVerificar.Z
                    );
        }

        

        /// <summary>
        /// lista en una variable lista de coordenadas valores a partir de una arraylist 
        /// evalua la extension de la coordenada si no es mayor a 1, registra una coordenada (0,0,0)
        /// como indicador de un nuevo grupo de coordenadas
        /// </summary>
        /// <param name="list">lista destino</param>
        /// <param name="array">arreglo origen</param>
        /// <param name="xValue">posicion dentro del arreglo para x</param>
        /// <param name="yValue">posicion dentro del arreglo para y</param>
        /// <param name="zValue">posicion dentro del arreglo para z</param>
        public void ListCoordenadas(List<Coordenada> list,ArrayList array, int xValue,int yValue,int zValue)
        {
            foreach (string[] line in array)
            {
                if(line.Length>1)
                    list.Add(new Coordenada(
                        Convert.ToDouble(line[xValue]),
                        Convert.ToDouble(line[yValue]),
                        Convert.ToDouble(line[zValue])

                        ));
                else
                {
                    list.Add(new Coordenada(0,0,0));
                }
            }
        }

        /// <summary>
        /// listando coordenadas en una variable lista de coordenadas
        /// evalua la extension de la coordenada si no es mayor a 1, registra una coordenada (0,0,0)
        /// como indicador de un nuevo grupo de coordenadas
        /// </summary>
        /// <param name="list"></param>
        /// <param name="array"></param>
        /// <param name="xValue"></param>
        /// <param name="yValue"></param>
        /// <param name="zValue"></param>
        /// <param name="index"></param>
        /// <param name="id"></param>
        public void ListCoordenadas(List<Coordenada> list, ArrayList array, int xValue, int yValue, int zValue,int index,int id)
        {
            foreach (string[] line in array)
            {
                if (line.Length > 1)
                    list.Add(new Coordenada(
                        Convert.ToDouble(line[xValue]),
                        Convert.ToDouble(line[yValue]),
                        Convert.ToDouble(line[zValue]),
                        index,
                        line[id]
                        ));
                else
                {
                    //cambiando a (0,0,0) para registrar en el grupo de coordenadas
                    list.Add(new Coordenada(0, 0, 0));
                }
            }
        }
        /// <summary>
        /// agrupa las coordenas en segmentos
        /// </summary>
        /// <param name="list"></param>
        public void Agrupar(List<Coordenada> list)
        {
            //creando la variado segmento
            Segmento segmento = new Segmento();
            //Inicializando la lista de polyniea
            segmento.Polylinea = new List<Coordenada>();
            //recorriendo las coordenadas para agruparlas
            foreach (Coordenada c in coordenadaListSvr)
            {
                
                // si segmento tiene coordenadas (0,0,0)
                //se crea un nuevo segmento
                if(c.X==0 && c.Y==0 && c.Z==0)
                {
                    //agregando el segmento en la lista de segmentos 
                    segmento.PInicial = segmento.Polylinea.First<Coordenada>();
                    segmento.PFinal = segmento.Polylinea.Last<Coordenada>();
                    //agregando el segmento a la variable global que almacena la lista de segmentos
                    SegmentoList.Add(segmento);
                    //inicializando segmento
                    segmento = new Segmento();
                    segmento.Polylinea = new List<Coordenada>();
                }
                else
                {
                    //agregando el segmento en la lista de segmentos 
                   // segmento.PInicial = segmento.Polylinea.First<Coordenada>();
                    //segmento.PFinal = segmento.Polylinea.Last<Coordenada>();
                    //agregando coordenadas a segmento
                    segmento.Polylinea.Add(c);
                }
                
            }
        }
    }
}
