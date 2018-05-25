using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.DTOs
{
    public class LocalidadDTO
    {
        [Display(Name = "Consecutivo")]
        public string LocalidadId { get; set; }
        [Display(Name = "Municipio Id")]
        public string MunicipioId { get; set; }

        [Display(Name = "Municipio")]
        public string Municipio { get; set; }

        [Display(Name = "Localidad")]
        public string Descripcion { get; set; }

        [Display(Name = "Código DANE")]
        public string CodigoDane { get; set; }

        [Display(Name = "Código PONAL")]
        public int CodigoPonal { get; set; }
    }
}
