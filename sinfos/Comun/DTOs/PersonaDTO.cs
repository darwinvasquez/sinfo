using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.DTOs
{
    public class PersonaDTO
    {
        [Required]
        public string PersonaId { get; set; }

        public string HechoId { get; set; }

        [Required]
        public string Nombres { get; set; }

        [Required]
        public string Apellidos { get; set; }

      
        public int TipoIdentificacion { get; set; }
       
        public string Identificacion { get; set; }

        public DateTime FechaNacimiento { get; set; }

        
        public string Telefono { get; set; }

        
        public string Email { get; set; }

        public int NacionalidadId { get; set; }

        public int IdPaisReside { get; set; }

        public int IdMunicipioReside { get; set; }

        public int IdDepartamentoReside { get; set; }

        public string DireccionReside { get; set; }

        public bool MenorEdad { get; set; }

        public int TipoInfractoId { get; set; }        

        public int TipoPoblacion { get; set; }

        public string RepresentanteMenor { get; set; }

        public bool Vigente { get; set; }

        public DateTime FechaCreacion { get; set; }

        public string UsuarioCreacion { get; set; }

        public string MaquinaCreacion { get; set; }
    }
}
