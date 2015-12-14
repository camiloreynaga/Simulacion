using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Library.Models
{
    public class Segmento
    {
        /// <summary>
        /// Coordenada inical del segmento
        /// </summary>
        public virtual Coordenada PInicial { get; set; }

        /// <summary>
        /// Coordenada final del segento
        /// </summary>
        public virtual Coordenada PFinal { get; set; }

        /// <summary>
        /// coordenadas intermedias del segmento
        /// </summary>
        public virtual IList<Coordenada> Polylinea { get; set; }

        /// <summary>
        /// comentario sobre el segmento o nombre del segmento Ej: Punto 1 /Punto 2
        /// </summary>
        public virtual string Comentario { get; set; }

        /// <summary>
        /// orientacion del segmento 1= orientacion origen destino -1 orientacion destino - origen
        /// </summary>
        public virtual int Orientacion { get; set; }

        /// <summary>
        /// busca y devuelve el indice de la coordenada a buscar, 
        /// </summary>
        /// <param name="coordenadaList"></param>
        /// <param name="coordenadaVerificar"></param>
        /// <returns></returns>
        public int findCoordenada( Coordenada coordenadaVerificar)
        {
            return Polylinea.ToList().FindIndex(
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
        public bool ExisteCoordenada(IList<Coordenada> coordenadaList, Coordenada coordenadaVerificar)
        {
            return coordenadaList.ToList<Coordenada>().Exists(
                    x => x.X == coordenadaVerificar.X &&
                    x.Y == coordenadaVerificar.Y &&
                    x.Z == coordenadaVerificar.Z
                    );
        }
    }
}
