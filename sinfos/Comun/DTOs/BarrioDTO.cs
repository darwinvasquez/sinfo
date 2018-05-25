using System.ComponentModel.DataAnnotations;

namespace Comun.DTOs
{
    public class BarrioDTO
    {       
        [Display(Name = "Consecutivo")]
        public string BarrioId { get; set; }

        [Display(Name = "Municipio Id")]
        public string MunicipioId { get; set; }

        [Display(Name = "Municipio")]
        public string Municipio { get; set; }

        [Display(Name = "Tipo")]
        public string Tipo { get; set; }

        [Display(Name = "Barrio")]     
        public string Descripcion { get; set; }

        [Display(Name = "Codigo DANE")]
        public string CodigoDane { get; set; }

        [Display(Name = "Codigo PONAL")]
        public int CodigoPonal { get; set; }
    }
}
