using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Comun.DTOs
{
    public class CnpHechoDTO
    {


       
        [StringLength(40)]
        public string HechoId { get; set; }

        /// <summary>
        /// Fecha cuando ocurrieron los hechos. Formato “dd/mm/yyyy”
        /// </summary>
        [DataType(DataType.Date)]
        public DateTime Fecha { get; set; }

        [StringLength(40)]
        public string PaisId { get; set; }

        [StringLength(40)]
        public string DepartamentoId { get; set; }

        /// <summary>
        /// Municipio donde ocurrieron los hechos.
        /// </summary>
        [StringLength(40)]
        public string MunicipioId { get; set; }

        /// <summary>
        /// Barrio donde ocurrió el hecho(s).
        /// </summary>
        [StringLength(40)]
        public string BarrioId { get; set; }

        [StringLength(40)]
        public string LocalidadId { get; set; }

        [StringLength(255)]
        public string DireccionHechos { get; set; }

        [StringLength(2)]
        public string Apelacion { get; set; }

        [StringLength(maximumLength: 4000)]
        [DataType(DataType.MultilineText)]
        public string RelatoHechos { get; set; }

        /// <summary>
        /// Medio de policía (Orden de Policía).
        /// </summary>        
        [Display(Name = "Orden de Policía")]
        public int Mop { get; set; }

        /// <summary>
        /// Medio de policía (Retiro del sitio).
        /// </summary>
        public int Mrs { get; set; }

        /// <summary>
        /// Medio de policía (Incautación).
        /// </summary>
        public int Minc { get; set; }

        /// <summary>
        /// Medio de policía (Traslado por protección).
        /// </summary>
        public int Mtpp { get; set; }

        /// <summary>
        /// Medio de policía (Suspensión inmediata de la actividad ).
        /// </summary>
        public int Msia { get; set; }

        /// <summary>
        /// Medio de policía (Traslado para procedimiento policivo).
        /// </summary>
        public int Mtppp { get; set; }

        /// <summary>
        /// Medio de policía (Ingreso a inmueble con orden escrita).
        /// </summary>
        public int Minicoe { get; set; }

        /// <summary>
        /// Medio de policía (Ingreso a inmueble sin orden escrita).
        /// </summary>
        public int Minisoe { get; set; }

        [StringLength(40)]
        public string TituloId { get; set; }

        [StringLength(40)]
        public string CapituloId { get; set; }

        [StringLength(40)]
        public string ArticuloId { get; set; }

        [StringLength(40)]
        public string NumeralId { get; set; }

        [StringLength(40)]
        public string LiteralId { get; set; }

        /// <summary>
        /// Corresponde al último comportamiento seleccionado al código nacional de Policía
        /// </summary>
        [StringLength(40)]
        public string ComportamientoId { get; set; }

        public decimal Latitud { get; set; }

        public decimal Longitud { get; set; }

        [StringLength(40)]
        public string TipoLugarId { get; set; }

        [StringLength(maximumLength: 255)]
        [DataType(DataType.MultilineText)]
        public string Descargos { get; set; }

        public DateTime HoraHechos { get; set; }

        [StringLength(maximumLength: 2)]
        public string AtiendeApelacion { get; set; }

        [StringLength(40)]
        public string EntidadRemiteApelacionId { get; set; }

        [StringLength(40)]
        public string FuenteId { get; set; }

        [StringLength(40)]
        public string TipoTranspId { get; set; }

        /// <summary>
        /// Tipo de medida (Querella o Aplicación CNP)
        /// </summary>
        [StringLength(40)]
        public string TipoMedidaId { get; set; }

        #region Propiedades retornada por el servicio de Policiía Nacional

        /// <summary>
        /// Id Hechos generado por la Policía Nacional
        /// </summary>
        public int idHechosPonal { get; set; }

        /// <summary>
        /// Número de expediente emitido por la Policía Nacional
        /// </summary>
        [StringLength(maximumLength: 255)]
        public string NumeroExpediente { get; set; }

        #endregion       

        public List<CnpPersona> Persona { get; set; }
    }
}
