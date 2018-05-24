using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Cnp
{
    [Table("Departamento")]
    public class Departamento
    {
        #region Propiedades
        [Required, Key]
        [StringLength(40)]
        public string DepartamentoId { get; set; }

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
        [ForeignKey("PaisId")]
        public virtual Pais Pais { get; set; }

        public virtual ICollection<Municipio> Municipio { get; set; }
        #endregion
    }
}
