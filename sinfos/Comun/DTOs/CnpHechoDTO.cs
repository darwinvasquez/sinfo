using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Comun.DTOs
{
    public class CnpHechoDTO
    {
        [Display(Name = "Consecutivo")]
        public string HechoId { get; set; }

        /// <summary>
        /// Fecha cuando ocurrieron los hechos. Formato “dd/mm/yyyy”
        /// </summary>
        [Display(Name = "Fecha Hecho")]
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [Display(Name = "País Id")]
        public string PaisId { get; set; }

        [Display(Name = "País")]
        public string Pais { get; set; }

        [Display(Name = "Id Depatamento")]
        public string DepartamentoId { get; set; }

        [Display(Name = "Depatamento")]
        public string Departamento { get; set; }

        /// <summary>
        /// Municipio donde ocurrieron los hechos.
        /// </summary>      
        [Display(Name = "Municipio Id")]
        public string MunicipioId { get; set; }

        [Display(Name = "Municipio")]
        public string Municipio { get; set; }

        /// <summary>
        /// Barrio donde ocurrió el hecho(s).
        /// </summary>
        [Display(Name = "Barrio Id")]
        public string BarrioId { get; set; }

        [Display(Name = "Barrio")]
        public string Barrio { get; set; }

        [Display(Name = "Localidad Id")]
        public string LocalidadId { get; set; }

        [Display(Name = "Localidad")]
        public string Localidad { get; set; }

        [Display(Name = "Dirección Hechos")]
        public string DireccionHechos { get; set; }

        [Display(Name = "Apelación")]
        public string Apelacion { get; set; }

        [Display(Name = "Relato Hechos")]
        [DataType(DataType.MultilineText)]
        public string RelatoHechos { get; set; }

        /// <summary>
        /// Medio de policía (Orden de Policía).
        /// </summary>        
        [Display(Name = "Orden de Policía")]
        public int Mop { get; set; } = 0;

        /// <summary>
        /// Medio de policía (Retiro del sitio).
        /// </summary>
        [Display(Name = "Retiro del sitio")]
        public int Mrs { get; set; } = 0;

        /// <summary>
        /// Medio de policía (Incautación).
        /// </summary>
        [Display(Name = "Incautación")]
        public int Minc { get; set; } = 0;

        /// <summary>
        /// Medio de policía (Traslado por protección).
        /// </summary>
        [Display(Name = "Traslado por protección")]
        public int Mtpp { get; set; } = 0;

        /// <summary>
        /// Medio de policía (Suspensión inmediata de la actividad).
        /// </summary>
        [Display(Name = "Suspensión inmediata de la actividad")]
        public int Msia { get; set; } = 0;

        /// <summary>
        /// Medio de policía (Traslado para procedimiento policivo).
        /// </summary>
        [Display(Name = "Traslado para procedimiento policivo")]
        public int Mtppp { get; set; } = 0;

        /// <summary>
        /// Medio de policía (Ingreso a inmueble con orden escrita).
        /// </summary>
        [Display(Name = "Ingreso a inmueble con orden escrita")]
        public int Minicoe { get; set; } = 0;

        /// <summary>
        /// Medio de policía (Ingreso a inmueble sin orden escrita).
        /// </summary>
        [Display(Name = "Ingreso a inmueble sin orden escrita")]
        public int Minisoe { get; set; } = 0;

        [Display(Name = "Título Id")]
        public string TituloId { get; set; }

        [Display(Name = "Título")]
        public string Titulo { get; set; }

        [Display(Name = "Capitulo Id")]
        public string CapituloId { get; set; }

        [Display(Name = "Capitulo")]
        public string Capitulo { get; set; }

        [Display(Name = "Articulo Id")]
        public string ArticuloId { get; set; }

        [Display(Name = "Articulo")]
        public string Articulo { get; set; }

        [Display(Name = "Numeral Id")]
        public string NumeralId { get; set; }

        [Display(Name = "Numeral")]
        public string Numeral { get; set; }

        [Display(Name = "Literal Id")]
        public string LiteralId { get; set; }

        [Display(Name = "Literal")]
        public string Literal { get; set; }

        /// <summary>
        /// Corresponde al id de último comportamiento seleccionado al código nacional de Policía
        /// </summary>     
        [Display(Name = "Comportamiento Id")]
        public string ComportamientoId { get; set; }

        /// <summary>
        /// Corresponde al último comportamiento seleccionado al código nacional de Policía
        /// </summary>     
        [Display(Name = "Comportamiento")]
        public string Comportamiento { get; set; }

        [Display(Name = "Latitud")]
        public decimal Latitud { get; set; } = 0;

        [Display(Name = "Longitud")]
        public decimal Longitud { get; set; } = 0;

        [Display(Name = "TipoLugar Id")]
        public string TipoLugarId { get; set; }

        [Display(Name = "TipoLugar")]
        public string TipoLugar { get; set; }

        [Display(Name = "Descargos")]
        [DataType(DataType.MultilineText)]
        public string Descargos { get; set; }

        [Display(Name = "Hora Hechos")]
        [DataType(DataType.Time)]
        public DateTime HoraHechos { get; set; }

        [Display(Name = "Atiende Apelación")]
        public string AtiendeApelacion { get; set; }

        [Display(Name = "Entodad Atiende Apelación")]
        public string EntidadRemiteApelacionId { get; set; }

        [Display(Name = "Fuente Registro")]
        public string FuenteId { get; set; }

        [Display(Name = "Transporte Id")]
        public string TipoTranspId { get; set; }

        [Display(Name = "Transporte")]
        public string TipoTransp { get; set; }

        /// <summary>
        /// Tipo de medida (Querella o Aplicación CNP)
        /// </summary>     
        [Display(Name = "Medida Id")]
        public string TipoMedidaId { get; set; }

        [Display(Name = "Medida")]
        public string TipoMedida { get; set; }

        #region Propiedades retornada por el servicio de Policiía Nacional

        /// <summary>
        /// Id Hechos generado por la Policía Nacional
        /// </summary>
        [Display(Name = "Consecutivo Hechos PONAL")]
        public int idHechosPonal { get; set; }

        /// <summary>
        /// Número de expediente emitido por la Policía Nacional
        /// </summary>      
        [Display(Name = "Expediente PONAL")]
        public string NumeroExpediente { get; set; }

        #endregion       

        //public List<CnpPersona> Persona { get; set; }
    }
}
