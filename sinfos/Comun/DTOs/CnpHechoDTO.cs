using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Comun.DTOs
{
    public class CnpHechoDTO
    {

        public string HechoId { get; set; }
        /// <summary>
        /// Fecha cuando ocurrieron los hechos. Formato “dd/mm/yyyy”
        /// </summary>
        public DateTime Fecha { get; set; }

        /// <summary>
        /// Municipio donde ocurrieron los hechos.
        /// </summary>
        public int IdMunicipio { get; set; }

        /// <summary>
        /// Barrio donde ocurrió el hecho(s).
        /// </summary>
        public int IdBarrio { get; set; }

        [StringLength(maximumLength: 100)]
        public string Localidad { get; set; }

        [StringLength(maximumLength: 2555)]
        public string DireccionHechos { get; set; }

        public int IdComportamiento { get; set; }

        [StringLength(maximumLength: 2)]
        public string Apelacion { get; set; }

        [StringLength(maximumLength: 4000)]
        public string RelatoHechos { get; set; }

        /// <summary>
        /// Medio de policía (Orden de Policía).
        /// </summary>
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
        public Nullable<decimal> Msia { get; set; }

        /// <summary>
        /// Medio de policía (Traslado para procedimiento policivo).
        /// </summary>
        public Nullable<decimal> Mtppp { get; set; }

        /// <summary>
        /// Medio de policía (Ingreso a inmueble con orden escrita).
        /// </summary>
        public Nullable<decimal> Minicoe { get; set; }

        /// <summary>
        /// Medio de policía (Ingreso a inmueble sin orden escrita).
        /// </summary>
        public Nullable<decimal> Minisoe { get; set; }

        public int CnpArt { get; set; }

        public int CnpNum { get; set; }

        public int CnpLit { get; set; }

        public decimal Latitud { get; set; }

        public decimal Longitud { get; set; }

        public int IdTipoLugar { get; set; }

        [StringLength(maximumLength: 255)]
        public string Descargos { get; set; }

        public DateTime HoraHechos { get; set; }

        [StringLength(maximumLength: 2)]
        public string AtiendeApelacion { get; set; }

        public int IdEntidadeRemiteApelac { get; set; }

        public int Fuente { get; set; }

        public int IdTipoTransp { get; set; }

        public List<CnpPersona> Persona { get; set; }
    }
}
