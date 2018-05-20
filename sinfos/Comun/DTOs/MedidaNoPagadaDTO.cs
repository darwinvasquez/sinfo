using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.DTOs
{
    public class MedidaNoPagadaDTO
    {
        public decimal CodHecho { get; set; }
        public Nullable<int> CodDepartamento { get; set; }
        public string Departamento { get; set; }
        public Nullable<int> CodMunicipio { get; set; }
        public string Municipio { get; set; }
        public System.DateTime FechaComparendo { get; set; }
        public string NombreRazonSocial { get; set; }
        public string Identificacion { get; set; }
        public string Nit { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Correo { get; set; }
        public string LugarConducta { get; set; }
        public string DetalleConducta { get; set; }
        public string ArticuloInfringido { get; set; }
        public string Estado { get; set; }
        public decimal CodCategoriaMulta { get; set; }
        public string CategoriaMulta { get; set; }
    }
}
