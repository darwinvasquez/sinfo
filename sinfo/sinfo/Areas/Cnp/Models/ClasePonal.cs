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
    public class DominioLocalidad
    {
        public decimal ID_LOCALIDAD { get; set; }
        public Nullable<decimal> COD_MUNICIPIO { get; set; }
        public string MUNICIPIO { get; set; }
        public string LOCALIDAD { get; set; }
    }

    public class DominioEntidad
    {
        public decimal ID_ENTIDAD { get; set; }
        public decimal COD_TIPO_ENTIDAD { get; set; }
        public string TIPO_ENTIDAD { get; set; }
        public string DESCRIPCION { get; set; }
        public string DIRECCION { get; set; }
        public string CORREO { get; set; }
        public string TELEFONO { get; set; }
        public string CELULAR { get; set; }
        public string NIT { get; set; }
        public string WEB { get; set; }
        public Nullable<decimal> LATITUD { get; set; }
        public Nullable<decimal> LONGITUD { get; set; }
        public Nullable<decimal> COD_MUNICIPIO { get; set; }
        public string MUNICIPIO { get; set; }
        public Nullable<int> COD_DEPARTAMENTO { get; set; }
        public string DEPARTAMENTO { get; set; }
    }
}