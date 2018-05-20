using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    /// <summary>
    /// Url base del servicio web
    /// </summary>
    /// <returns></returns>
    [Table("UrlBase")]
    public class UrlBase
    {
        /// <summary>
        /// Codigo autoincremental
        /// </summary>  
        [Column("UrlBaseId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UrlBaseId { get; set; }       

        /// <summary>
        /// Nombre del servicio web base
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

        public virtual ICollection<PermisoServicioWeb> PermisoServicioWeb { get; set; }
        #endregion
    }
}