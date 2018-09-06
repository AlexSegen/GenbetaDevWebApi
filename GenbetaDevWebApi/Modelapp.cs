namespace GenbetaDevWebApi
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Modelapp : DbContext
    {
        public Modelapp()
            : base("name=GenbetaDevApiWebEntities")
        {
        }

        public virtual DbSet<Persona> Personas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Persona>()
                .Property(e => e.Nombre)
                .IsFixedLength();

            modelBuilder.Entity<Persona>()
                .Property(e => e.Apellido1)
                .IsFixedLength();

            modelBuilder.Entity<Persona>()
                .Property(e => e.Apellido2)
                .IsFixedLength();
        }
    }
}
