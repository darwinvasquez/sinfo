using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    /// <summary>
    /// Permite consultar las listas de valores relacionados con el tipo del lugar del hecho
    /// </summary>
    /// <returns></returns>
    [Table("TipoLugar")]
    public class TipoLugar
    {
        /// <summary>
        /// Código lista de valor
        /// </summary>  
        [Column("TipoLugarId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TipoLugarId { get; set; }

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