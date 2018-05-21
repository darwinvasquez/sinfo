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
    }   
}