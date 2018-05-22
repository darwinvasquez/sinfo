namespace Comun.DTOs
{
    public class CalidadPersonaCnpDTO
    {        
        public string CalidadPersonaCnpId { get; set; }
       
        public string HechoId { get; set; }
       
        public string PersonaId { get; set; }

        public int TipoInfractoId { get; set; }

        public bool MenorEdad { get; set; }

        public int TipoPoblacion { get; set; }
        
        public string RepresentanteMenor { get; set; }
    }
}
