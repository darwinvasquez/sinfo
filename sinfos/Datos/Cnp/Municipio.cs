using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Cnp
{
    [Table("Municipio")]
    public class Municipio
    {
        #region Propiedades
        [Required, Key]
        [StringLength(40)]
        public string MunicipioId { get; set; }

        [StringLength(40)]
        public string DepartamentoId { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string CodigoDane { get; set; }

        public int CodigoPonal { get; set; }

        public bool Vigente { get; set; } 
        #endregion

        #region Propiedades de navegación
        [ForeignKey("DepartamentoId")]
        public virtual Departamento Departamento { get; set; }

        public virtual ICollection<Barrio> Barrio { get; set; }

        public virtual ICollection<Localidad> Localidad { get; set; }
        #endregion
    }
}
