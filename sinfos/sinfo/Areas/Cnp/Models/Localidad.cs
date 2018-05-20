using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{

    /// <summary>
    /// Localidades adscritas a los municpios
    /// </summary>
    /// <returns></returns>
    [Table("Localidad")]
    public class Localidad
    {
        /// <summary>
        /// Código lista de valor
        /// </summary>  
        [Column("LocalidadId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int LocalidadId { get; set; }

        /// <summary>
        /// Código localidad Policía Nacional
        /// </summary>
        [Column("CodigoPonal")]
        [Required]
        [Display(Name = "Código Ponal")]
        public int CodigoPonal { get; set; }

        /// <summary>
        /// Código Municipio
        /// </summary>
        [Column("CodigoMunicipio")]
        [Required]
        [Display(Name = "Codigo Municipio")]
        public int CodigoMunicipio { get; set; }

        /// <summary>
        /// Nombre del municipio
        /// </summary>
        [Column("Municipio")]
        [Required]
        [StringLength(100)]
        [Display(Name = "Municipio")]
        public string Municipio { get; set; }


        /// <summary>
        /// Nombre localidad asociada al municipio
        /// </summary>
        [Column("NombreLocalidad")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre Localidad")]
        public string NombreLocalidad { get; set; }

        /// <summary>
        /// Estado del registro
        /// </summary>
        [Column("Vigente")]
        [Required]
        [Display(Name = "Vigente")]
        public bool Vigente { get; set; }

    }
}