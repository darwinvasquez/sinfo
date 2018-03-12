using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    /// <summary>
    /// Obtiene información de los response al comsumir los servicios web
    /// </summary>
    /// <returns></returns>
    [Table("StatusCodeWebService")]
    public class StatusCodeWebService
    {
        /// <summary>
        /// Codigo autoincremental
        /// </summary>  
        [Column("StatusCodeWebServiceId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StatusCodeWebServiceId { get; set; }


        /// <summary>
        /// Nombre del controlador y el método donde se esta realizando la petición
        /// </summary>
        [Column("Accion")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Accion")]
        public string Accion { get; set; }

        /// <summary>
        /// Usuario que consume el servicio web
        /// </summary>
        [Column("Usuario")]
        [Required]
        [StringLength(255)]
        [Display(Name = "Usuario")]
        public string Usuario { get; set; }        

        /// <summary>
        /// Url para consumir el servicio web
        /// </summary>
        [Column("Url")]
        [Required]
        [StringLength(500)]
        [Display(Name = "Url")]
        public string Url { get; set; }

        /// <summary>
        /// Codigo status
        /// </summary>
        [Column("CodigoResponseId")]
        [Required]        
        [Display(Name = "Codigo Satuts")]
        public int CodigoResponseId { get; set; }

        /// <summary>
        /// Propietario del servicio web
        /// </summary>
        [Column("PropietarioServicioWeb")]
        [Required]
        [StringLength(100)]
        [Display(Name = "Propietario")]
        public string PropietarioSw { get; set; }

        /// <summary>
        /// Fecha en que se registra el servicio web
        /// </summary>
        [Column("FechaRegistro")]
        [Required]     
        [Display(Name = "Fecha Registro")]
        public DateTime FechaRegistro { get; set; }


        /// <summary>
        /// Estado del registro
        /// </summary>
        [Column("Vigente")]
        [Required]
        [Display(Name = "Vigente")]
        public bool Vigente { get; set; }

        #region Propiedades de navegación

        [ForeignKey("CodigoResponseId")]
        public virtual CodigoResponse CodigoResponse { get; set; }
        #endregion

    }
}