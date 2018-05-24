using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Cnp
{
    [Table("TipoComportamiento")]
    public class TipoComportamiento
    {
        [Required, Key]
        [StringLength(40)]
        public string TipoComportamientoId { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }      

        /// <summary>
        /// Consecutivo ponal para los comportamientos
        /// </summary>
        public int CodigoPonal { get; set; }

        /// <summary>
        /// Código padre ponal para tablas recursivas
        /// </summary>
        public int PadrePonal { get; set; }

        public bool Vigente { get; set; }

        public DateTime FechaCreacion { get; set; }

        public virtual ICollection<Hecho> Hecho { get; set; }

    }
}
