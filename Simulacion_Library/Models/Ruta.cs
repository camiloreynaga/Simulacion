using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulacion_Library.Models
{
    public class Ruta
    {
        /// <summary>
        /// Identificador de rutas
        /// </summary>
        public virtual int Id { get; set; }
        
        /// <summary>
        /// Coordenada del origen de la ruta
        /// </summary>
        public virtual Coordenada Origen { get; set; }

        /// <summary>
        /// Coordenada del destino de la ruta
        /// </summary>
        public virtual Coordenada Destino { get; set; }

        /// <summary>
        /// Segmentos que componen la ruta
        /// </summary>
        public virtual IList<Segmento> Segmentos { get; set; }
    }
}
