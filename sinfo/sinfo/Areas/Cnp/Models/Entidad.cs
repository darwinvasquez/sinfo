using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    /// <summary>
    /// Permite consultar las entidades que se encuentrar adscritas a un municipio.
    /// </summary>
    /// <returns></returns>
    [Table("Entidad")]
    public class Entidad
    {
        /// <summary>
        /// Código lista de valor
        /// </summary>  
        [Column("EntidadId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EntidadId { get; set; }

        /// <summary>
        /// Cóidgo lista de valor Policía Nacional
        /// </summary>
        [Column("CodigoPonal")]
        [Required]
        [Display(Name = "Código Ponal")]
        public int CodigoPonal { get; set; }

        /// <summary>
        /// Decripción lista de valores
        /// </summary>  
        [Column("Descripcion")]
        [Required]
        [Display(Name = "Descripción")]
        [StringLength(500)]
        public string Descripcion { get; set; }

        [Column("Vigente")]
        [Required]
        [Display(Name = "Vigente")]
        public bool Vigente { get; set; }
    }
}