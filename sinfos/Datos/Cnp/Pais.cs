using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Cnp
{
    [Table("Pais")]
    public class Pais
    {
        public Pais()
        {
            this.Hecho = new HashSet<Hecho>();
        }

        #region Propiedaades
        [Required, Key]
        [StringLength(40)]
        public string PaisId { get; set; }

        [StringLength(255)]
        public string Descripcion { get; set; }

        [StringLength(255)]
        public string CodigoDane { get; set; }

        public int CodigoPonal { get; set; }

        public bool Vigente { get; set; } 
        #endregion

        #region Propiedades de navegación
        public virtual ICollection<Departamento> Departamento { get; set; }
        public virtual ICollection<Hecho> Hecho { get; set; }
        #endregion
    }
}
