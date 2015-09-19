using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Library.Models
{
    public class Camion
    {
        /// <summary>
        ///  Identificador de camiones
        /// </summary>        
        public virtual int Id { get; set; }
        
        /// <summary>
        /// Nombre del camion
        /// </summary>
        public virtual string Nombre { get; set; }

        /// <summary>
        /// Capacidad del camion
        /// </summary>
        public virtual string CargaUtil { get; set; }

        /// <summary>
        /// Curva de velocidad por gradiente
        /// </summary>
        public virtual IList<VelocidadGradiente> CurvaVelocidad { get; set; }


        /// <summary>
        /// Curva de consumo de combustible por gradiente
        /// </summary>
        public virtual IList<ConsumoGradiente> CurvaConsumo { get; set; }
    }
}
