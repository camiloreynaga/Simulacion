using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Library.Models
{
    public class ConsumoGradiente
    {
        /// <summary>
        /// Gradiente de ruta
        /// </summary>
        public virtual double Gradiente { get; set; }

        /// <summary>
        /// Velocidad del camion cargado
        /// </summary>
        public virtual double ConsumoCargado { get; set; }

        /// <summary>
        /// Velocidad del camion vacio
        /// </summary>
        public virtual double ConsumoVacio { get; set; }
    }
}
