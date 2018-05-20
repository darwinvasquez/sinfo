using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    /// <summary>
    /// Permisos a los usuarios para consumir los servicios web
    /// </summary>
    /// <returns></returns>
    [Table("PermisoServicioWeb")]
    public class PermisoServicioWeb
    {
        /// <summary>
        /// Codigo autoincremental
        /// </summary>  
        [Column("PermisoServicioWebId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PermisoServicioWebId { get; set; }


        /// <summary>
        /// Llave foranea usuario autorizado
        /// </summary>
        [Column("UsuarioAutorizadoId")]
        [Required]
        [Display(Name = "Usuario")]
        public int UsuarioAutorizadoId { get; set; }

        /// <summary>
        /// Llave foranea url base
        /// </summary>
        [Column("UrlBaseId")]
        [Required]
        [Display(Name = "Url Servicio Base")]
        public int UrlBaseId { get; set; }

        /// <summary>
        /// Llave foranea url servicios web
        /// </summary>
        [Column("UrlServicioWebId")]
        [Required]
        [Display(Name = "Url Servicio Web")]
        public int UrlServicioWebId { get; set; }

        /// <summary>
        /// Estado del registro
        /// </summary>
        [Column("Vigente")]
        [Required]
        [Display(Name = "Vigente")]
        public bool Vigente { get; set; }

        #region Propiedades de navegación

        [ForeignKey("UsuarioAutorizadoId")]
        public virtual UsuarioAutorizado UsuarioAutorizado { get; set; }

        [ForeignKey("UrlBaseId")]
        public virtual UrlBase UrlBase { get; set; }

        [ForeignKey("UrlServicioWebId")]
        public virtual UrlServicioWeb UrlServicioWeb { get; set; }
        #endregion
    }
}