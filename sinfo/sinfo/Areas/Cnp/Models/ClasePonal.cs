using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    public class DominioPonal
    {
        public decimal ID_DOMINIO { get; set; }
        public string DESCRIPCION { get; set; }
        public decimal PADRE_ID { get; set; }
        public decimal VIGENTE { get; set; }
        public string ABREVIATURA { get; set; }
        public string OBSERVACION { get; set; }
    }
}