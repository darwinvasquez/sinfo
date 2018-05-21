using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Cnp
{
    [Table("CalidadPersonaCnp")]
    public class CalidadPersonaCnp
    {
        [Required, Key]
        [StringLength(40)]
        public string CalidadPersonaCnpId { get; set; }

        [StringLength(40)]
        public string HechoId { get; set; }

        [StringLength(40)]
        public string PersonaId { get; set; }

        public int TipoInfractoId { get; set; }

        public bool MenorEdad { get; set; }

        public int TipoPoblacion { get; set; }

        [StringLength(40)]
        public string RepresentanteMenor { get; set; }

        public bool Vigente { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string UsuarioCreacion { get; set; }

        public string MaquinaCreacion { get; set; }

        [ForeignKey("HechoId")]
        public virtual Hecho Hecho { get; set; }

        [ForeignKey("PersonaId")]
        public virtual Persona Persona { get; set; }
    }
}
