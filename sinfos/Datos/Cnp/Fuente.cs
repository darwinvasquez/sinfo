using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Cnp
{
    [Table("Fuente")]
    public class Fuente
    {
        [Required, Key]
        [StringLength(40)]
        public string FuenteId { get; set; }

        [StringLength(100)]
        public string Descripcion { get; set; }

        #region Propiedades de navegación

        public virtual ICollection<Hecho> Hecho { get; set; } 
        #endregion
    }
}
