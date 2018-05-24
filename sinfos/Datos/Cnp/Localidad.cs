using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Cnp
{
    [Table("Localidad")]
    public class Localidad
    {
        #region Propiedades de navegación
        [Required, Key]
        [StringLength(40)]
        public string LocalidadId { get; set; }

        [StringLength(40)]
        public string MunicipioId { get; set; }       

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string CodigoDane { get; set; }

        public int CodigoPonal { get; set; }

        public bool Vigente { get; set; }
        #endregion

        #region Propiedades de navegación
        [ForeignKey("MunicipioId")]
        public virtual Municipio Municipio { get; set; }
        #endregion
    }
}
