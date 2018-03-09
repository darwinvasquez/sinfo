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

    public class DominioComportamiento
    {
        public decimal ID_COMPORTAMIENTO { get; set; }
        public string DESCRIPCION { get; set; }
        public string USUARIO_CREACION { get; set; }
        public Nullable<System.DateTime> FECHA_CREACION { get; set; }
        public string MAQUINA_CREACION { get; set; }
        public Nullable<decimal> ID_PAPA { get; set; }
        public Nullable<decimal> VIGENTE { get; set; }
        public Nullable<decimal> ID_TIPO { get; set; }
        public string ORDEN { get; set; }
        public Nullable<decimal> ID_TITULO { get; set; }
        public Nullable<decimal> ID_CAPITULO { get; set; }
        public Nullable<decimal> ID_ARTICULO { get; set; }
    }
}