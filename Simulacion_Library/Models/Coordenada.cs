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
        public virtual int Index { get; set; }

        /// <summary>
        /// Tipo de Identificador para la coordenada : Ramp/ Sb
        /// </summary>
        public virtual string Id { get; set; }

        #region Métodos
        public Coordenada()
        { }

        public Coordenada(double x, double y, double z)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            
        }
        public Coordenada(double x, double y, double z, int index, string id)
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
            this.Index = index;
            this.Id = id;
        }


        /// <summary>
        /// devlueve la ditancia inclinada entre dos coordenadas
        /// </summary>
        /// <param name="inicial"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public static double DistanciaInclinada(Coordenada inicial, Coordenada final)
        {
            return Math.Sqrt(
                        Math.Pow((final.X - inicial.X),2) + 
                        Math.Pow((final.Y - inicial.Y),2) + 
                        Math.Pow((final.Z - inicial.Z),2)
                        );
        }

        /// <summary>
        /// Calcula la distancia horizontal entre dos coordenas
        /// </summary>
        /// <param name="inicial"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public static double DistanciaHorizontal(Coordenada inicial, Coordenada final)
        {
            return Math.Sqrt(
                        Math.Pow((final.X - inicial.X), 2) +
                        Math.Pow((final.Y - inicial.Y), 2)
                        );
        }

        /// <summary>
        /// Calcula la distancia vertical entre dos coordenadas
        /// </summary>
        /// <param name="inicial"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public static double DistanciaVertical(Coordenada inicial, Coordenada final)
        {
            return final.Z - inicial.Z;
        }

        /// <summary>
        /// calcula la gradiente
        /// </summary>
        /// <param name="dblVertical"></param>
        /// <param name="dblHorizontal"></param>
        /// <returns></returns>
        public static double Gradiente(double dblVertical, double dblHorizontal)
        {            
            if (dblHorizontal == 0)
                return 0;
            else
                return 100 * dblVertical / dblHorizontal;

            //double nGradiente = 0;

            //dblHorizontal = 0 ? nGradiente : nGradiente = 100 * dblVertical / dblHorizontal;
        }

        /// <summary>
        /// calcula la gradiente
        /// </summary>
        /// <param name="inicial"></param>
        /// <param name="final"></param>
        /// <returns></returns>
        public static double Gradiente(Coordenada inicial, Coordenada final)
        {

            double dblHorizontal = DistanciaHorizontal(inicial, final);
            double dblVertical = DistanciaVertical(inicial, final);

            if (dblHorizontal == 0)
                return 0;
            else
                return 100 * dblVertical / dblHorizontal;

            //double nGradiente = 0;

            //dblHorizontal = 0 ? nGradiente : nGradiente = 100 * dblVertical / dblHorizontal;
        }
        #endregion
    }
}
