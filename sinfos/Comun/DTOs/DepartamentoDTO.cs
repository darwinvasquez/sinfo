using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comun.DTOs
{
    public class DepartamentoDTO
    {
        #region Propiedades
             
        public string DepartamentoId { get; set; }
                
        public string PaisId { get; set; }
     
        public string Descripcion { get; set; }
        
        public string CodigoDane { get; set; }

        public int CodigoPonal { get; set; }
        #endregion
    }
}
