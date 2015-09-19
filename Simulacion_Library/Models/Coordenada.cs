using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Library.Models
{
    public class Coordenada
    {
        /// <summary>
        /// Coordenada X
        /// </summary>
        public virtual double X { get; set; }

        /// <summary>
        /// Coordenada Y
        /// </summary>
        public virtual double Y { get; set; }

        /// <summary>
        /// Coordenada Z
        /// </summary>
        public virtual double Z { get; set; }

        /// <summary>
        /// orden de ubicacion de la coordenada dentro del segmento
        /// </summary>
        public virtual int Orden { get; set; }

        /// <summary>
        /// devlueve la ditancia inclinada entre dos coordenadas
        /// </summary>
        /// <param name="inicial"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public double DistanciaInclinada(Coordenada inicial, Coordenada final)
        {
            return Math.Sqrt(
                        Math.Pow((final.X - inicial.X),2) + 
                        Math.Pow((final.Y - inicial.Y),2) + 
                        Math.Pow((final.Z - inicial.Z),2)
                        );

        }
    }
}
