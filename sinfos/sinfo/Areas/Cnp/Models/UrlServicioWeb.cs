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
    [Table("UrlServicioWeb")]
    public class UrlServicioWeb
    {
        /// <summary>
        /// Codigo autoincremental
        /// </summary>  
        [Column("UrlServicioWebId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UrlServicioWebId { get; set; }
                   

        /// <summary>
        /// Método de envio
        /// </summary>
        [Column("Metodo")]
        [Required]
        [StringLength(5)]
        [Display(Name = "Método")]
        public string Metodo { get; set; }

        /// <summary>
        /// Url del método de envio
        /// </summary>
        [Column("Url")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Url")]
        public string Url { get; set; }

        /// <summary>
        /// Nombre servicio
        /// </summary>
        [Column("NombreServicio")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Nombre Servicio")]
        public string NombreServicio { get; set; }


        /// <summary>
        /// Descripción servicio
        /// </summary>
        [Column("DescripcionServicio")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Descripción Servicio")]
        public string DescripcionServicio { get; set; }

        /// <summary>
        /// Descripción servicio
        /// </summary>
        [Column("Propietario")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Propietario")]
        public string Propietario { get; set; }

        #region Propiedades de navegación

        public virtual ICollection<PermisoServicioWeb> PermisoServicioWeb { get; set; }
        #endregion

    }
}