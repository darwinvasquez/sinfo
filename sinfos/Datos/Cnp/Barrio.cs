using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Cnp
{
    [Table("Barrio")]
    public class Barrio
    {
        #region Propiedades de navegación
        [Required, Key]
        [StringLength(40)]
        public string BarrioId { get; set; }

        [StringLength(40)]
        public string MunicipioId { get; set; }

        [StringLength(4)]
        public string Tipo { get; set; }

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
