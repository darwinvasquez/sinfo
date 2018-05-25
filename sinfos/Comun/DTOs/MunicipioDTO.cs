using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.DTOs
{
    public class MunicipioDTO
    {   
        [Display(Name =("Consecutivo"))]   
        public string MunicipioId { get; set; }

        [Display(Name = ("Departamento Id"))]
        public string DepartamentoId { get; set; }

        [Display(Name = ("Departamento"))]
        public string Departamento { get; set; }

        [Display(Name = ("Municipio"))]
        public string Descripcion { get; set; }

        [Display(Name = ("Código DANE"))]
        public string CodigoDane { get; set; }

        [Display(Name = ("Código PONAL"))]
        public int CodigoPonal { get; set; }
    }
}
