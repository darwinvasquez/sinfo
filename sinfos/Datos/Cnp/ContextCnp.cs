namespace Datos.Cnp
{
    using System.Data.Entity;

    public partial class ContextCnp : DbContext
    {       
        public ContextCnp()
            : base("name=ContextCnp")
        {
            Configuration.LazyLoadingEnabled = false;
        }
        
        public virtual DbSet<Hecho> Hecho { get; set; }
        public virtual DbSet<Persona> Persona { get; set; }
        public virtual DbSet<CalidadPersonaCnp> CalidadPersonaCnp { get; set; }
        public virtual DbSet<Barrio> Barrio { get; set; }
        public virtual DbSet<Departamento> Departamento { get; set; }
        public virtual DbSet<Fuente> Fuente { get; set; }
        public virtual DbSet<Localidad> Localidad { get; set; }
        public virtual DbSet<Municipio> Municipio { get; set; }
        public virtual DbSet<Pais> Pais { get; set; }
        public virtual DbSet<TipoComportamiento> TipoComportamiento { get; set; }
    }   
}