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
        /// Código lista de valor Policía Nacional
        /// </summary>
        [Column("CodigoPonal")]
        [Required]
        [Display(Name = "Código Ponal")]
        public int CodigoPonal { get; set; }


        /// <summary>
        /// Código Tipo Entidad
        /// </summary>
        [Column("CodigoTipoEntidad")]      
        [Display(Name = "Codigo Tipo Entidad")]
        public int CodigoTipoEntidad { get; set; }

        /// <summary>
        /// Tipo Entidad
        /// </summary>  
        [Column("TipoEntidad")]      
        [Display(Name = "Tipo Entidad")]
        [StringLength(500)]
        public string TipoEntidad { get; set; }

        /// <summary>
        /// Descripción
        /// </summary>  
        [Column("Descripcion")]     
        [Display(Name = "Descripción")]
        [StringLength(255)]
        public string Descripcion { get; set; }

        /// <summary>
        /// Dirección
        /// </summary>  
        [Column("Direccion")]       
        [Display(Name = "Dirección")]
        [StringLength(255)]
        public string Direccion { get; set; }

        /// <summary>
        /// Correo
        /// </summary>  
        [Column("Correo")]     
        [Display(Name = "Correo")]
        [StringLength(255)]
        public string Correo { get; set; }

        /// <summary>
        /// Teléfono
        /// </summary>  
        [Column("Telefono")]     
        [Display(Name = "Teléfono")]
        [StringLength(255)]
        public string Telefono { get; set; }

        /// <summary>
        /// Celular
        /// </summary>  
        [Column("Celular")]        
        [Display(Name = "Celular")]
        [StringLength(255)]
        public string Celular { get; set; }

        /// <summary>
        /// Nit
        /// </summary>  
        [Column("Nit")]      
        [Display(Name = "Nit")]
        [StringLength(255)]
        public string Nit { get; set; }

        /// <summary>
        /// Nit
        /// </summary>  
        [Column("Web")]
        [Display(Name = "Web")]
        [StringLength(255)]
        public string Web { get; set; }

        /// <summary>
        /// Latitud
        /// </summary>  
        [Column("Latitud")]
        [Display(Name = "Latitud")]        
        public decimal Latitud { get; set; }

        /// <summary>
        /// Longitud
        /// </summary>  
        [Column("Longitud")]
        [Display(Name = "Longitud")]
        public decimal Longitud { get; set; }

        /// <summary>
        /// Código Municipio
        /// </summary>  
        [Column("CodMunicipio")]
        [Display(Name = "Código Municipio")]
        public int CodMunicipio { get; set; }

        /// <summary>
        /// Municipio
        /// </summary>  
        [Column("Municipio")]
        [Display(Name = "Municipio")]
        [StringLength(50)]
        public string Municipio { get; set; }
        
        /// <summary>
        /// Código Municipio
        /// </summary>  
        [Column("CodDepartamento")]
        [Display(Name = "Código Departamento")]
        public int CodDepartamento { get; set; }

        /// <summary>
        /// Departamento
        /// </summary>  
        [Column("Departamento")]
        [Display(Name = "Departamento")]
        [StringLength(50)]
        public string Departamento { get; set; }
    
        /// <summary>
        /// Estado del registro
        /// </summary>
        [Column("Vigente")]
        [Required]
        [Display(Name = "Vigente")]
        public bool Vigente { get; set; }
    }
}