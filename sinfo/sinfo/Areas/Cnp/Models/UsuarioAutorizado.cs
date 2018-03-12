using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace sinfo.Areas.Cnp.Models
{
    /// <summary>
    /// Permite consultar los usuarios autorizados para utlizar los servicios web de la Policía Nacional
    /// </summary>
    [Table("UsuarioAutorizado")]
    public class UsuarioAutorizado
    {
        /// <summary>
        /// Código
        /// </summary>  
        [Column("UsuarioAutorizadoId"), Key]
        [Display(Name = "Código")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UsuarioAutorizadoId { get; set; }

        /// <summary>
        /// Usuario
        /// </summary>  
        [Column("Usuario")]
        [Required]
        [Display(Name = "Usuario")]
        [StringLength(255)]
        public string Usuario { get; set; }

        /// <summary>
        /// Contraseña
        /// </summary>  
        [Column("Password")]
        [Required]
        [Display(Name = "Password")]
        [StringLength(255)]
        public string Password { get; set; }

        /// <summary>
        /// Usuario
        /// </summary>  
        [Column("Alcaldia")]
        [Required]
        [Display(Name = "Alcaldia")]
        [StringLength(255)]
        public string Alcaldia { get; set; }


        /// <summary>
        /// Fecha Inicio
        /// </summary>  
        [Column("FechaInicio")]
        [Required]
        [Display(Name = "FechaInicio")]      
        public DateTime FechaInicio { get; set; }


        /// <summary>
        /// Fecha Final
        /// </summary>  
        [Column("FechaFinal")]
        [Required]
        [Display(Name = "FechaInicio")]
        public DateTime FechaFinal { get; set; }

        #region Propiedades de navegación

        public virtual ICollection<PermisoServicioWeb> PermisoServicioWeb { get; set; }
        #endregion

    }
}