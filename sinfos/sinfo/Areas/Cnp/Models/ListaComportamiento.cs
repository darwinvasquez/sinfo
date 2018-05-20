using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    /// <summary>
    /// Permite listar los comportamientos asociados al Código Nacional de Policía
    /// </summary>  
    [Table("ListaComportamiento")]
    public class ListaComportamiento
    {
        /// <summary>
        /// Autoicremnto base de datos local
        /// </summary>
        [Column("ListaComportamientoId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ListaComportamientoId { get; set; }

        /// <summary>
        /// Código Polcía Nacional
        /// </summary>
        [Column("CodigoPonal")]
        [Required]
        [Display(Name = "Id Comportamiento")]
        public decimal CodigoPonal { get; set; }


        /// <summary>
        /// Decripción 
        /// </summary>  
        [Column("Descripcion")]
        [Required]
        [Display(Name = "Descripción")]
        [StringLength(4000)]
        public string Descripcion { get; set; }


        /// <summary>
        /// Id Padre recursividad tabla
        /// </summary>
        [Column("IdPapa")]
        [Required]
        [Display(Name = "Id Papa")]
        public decimal IdPapa { get; set; }

        /// <summary>
        /// Estado del registro
        /// </summary>
        [Column("Vigente")]
        [Required]
        [Display(Name = "Vigente")]
        public bool Vigente { get; set; }


        /// <summary>
        /// Id Tipo
        /// </summary>
        [Column("IdTipo")]
        [Required]
        [Display(Name = "Id Papa")]
        public decimal IdTipo { get; set; }

        /// <summary>
        /// Id Tipo
        /// </summary>
        [Column("Orden")]
        [Required]
        [Display(Name = "Orden")]
        [StringLength(255)]
        public string Orden { get; set; }

        /// <summary>
        /// Id Título
        /// </summary>
        [Column("IdTitulo")]
        [Required]
        [Display(Name = "Id Título")]
        public decimal IdTitulo { get; set; }

        /// <summary>
        /// Id Capítulo
        /// </summary>
        [Column("IdCapitulo")]
        [Required]
        [Display(Name = "Id Capítulo")]
        public decimal IdCapitulo { get; set; }

        /// <summary>
        /// Id Artículo
        /// </summary>
        [Column("IdArticulo")]
        [Required]
        [Display(Name = "Id Artículo")]
        public decimal IdArticulo { get; set; }  
    }
}