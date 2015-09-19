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
    }
}
