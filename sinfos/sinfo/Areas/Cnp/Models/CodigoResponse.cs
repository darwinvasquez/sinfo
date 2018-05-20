using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    /// <summary>
    /// Registar los códigos de las respuestas de los servicios web
    /// </summary>
    /// <returns></returns>
    [Table("CodigoResponse")]
    public class CodigoResponse
    {
        /// <summary>
        /// Codigo autoincremental
        /// </summary>  
        [Column("CodigoResponseId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CodigoResponseId { get; set; }

        /// <summary>
        /// Nombre del controlador y el método donde se esta realizando la petición
        /// </summary>
        [Column("CodigoStatus")]
        [Required]     
        [Display(Name = "Código Status")]
        public int CodigoStatus { get; set; }

        /// <summary>
        /// Nombre del controlador y el método donde se esta realizando la petición
        /// </summary>
        [Column("Descripcion")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Descripción")]
        public string Descripcion { get; set; }

        /// <summary>
        /// Estado del registro
        /// </summary>
        [Column("Vigente")]
        [Required]
        [Display(Name = "Vigente")]
        public bool Vigente { get; set; }

        #region Propiedades de navegación

        public virtual ICollection<StatusCodeWebService> StatusCodeWebService { get; set; }
        #endregion
    }
}