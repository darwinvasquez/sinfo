using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos.Cnp
{
    [Table("Persona")]
    public class Persona
    {
        [Required, Key]
        [StringLength(40)]
        public string PersonaId { get; set; }

        [StringLength(100)]
        public string Nombres { get; set; }

        [StringLength(100)]
        public string Apellidos { get; set; }
        
        public int TipoIdentificacion { get; set; }

        [StringLength(12)]
        public string Identificacion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        [StringLength(255)]
        public string Telefono { get; set; }

        [StringLength(100)]
        public string Email { get; set; }
        
        public int NacionalidadId { get; set; }

        public int IdPaisReside { get; set; }

        public int IdMunicipioReside { get; set; }

        public int IdDepartamentoReside { get; set; }

        public string DireccionReside { get; set; }
       
        public bool Vigente { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string UsuarioCreacion { get; set; }

        public string MaquinaCreacion { get; set; }

        public virtual ICollection<CalidadPersonaCnp> CalidadPersonaCnp { get; set; }
    }
}
