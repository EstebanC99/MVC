using ENTITIES;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DATA
{
    public partial class APContext : DbContext
    {
        public APContext()
            : base("name=AgenciaPersonalContext")
        {
        }

        public virtual DbSet<antecedente> antecedentes { get; set; }
        public virtual DbSet<cargo> cargos { get; set; }
        public virtual DbSet<comisione> comisiones { get; set; }
        public virtual DbSet<contrato> contratos { get; set; }
        public virtual DbSet<empresa> empresas { get; set; }
        public virtual DbSet<entrevista> entrevistas { get; set; }
        public virtual DbSet<entrevistas_evaluaciones> entrevistas_evaluaciones { get; set; }
        public virtual DbSet<evaluacione> evaluaciones { get; set; }
        public virtual DbSet<persona> personas { get; set; }
        public virtual DbSet<personas_titulos> personas_titulos { get; set; }
        public virtual DbSet<solicitudes_empresas> solicitudes_empresas { get; set; }
        public virtual DbSet<titulo> titulos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<cargo>()
                .HasMany(e => e.antecedentes)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<cargo>()
                .HasMany(e => e.solicitudes_empresas)
                .WithRequired(e => e.cargo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<comisione>()
                .Property(e => e.importe_comision)
                .HasPrecision(9, 3);

            modelBuilder.Entity<contrato>()
                .Property(e => e.sueldo)
                .HasPrecision(9, 3);

            modelBuilder.Entity<contrato>()
                .Property(e => e.porcentaje_comision)
                .HasPrecision(9, 3);

            modelBuilder.Entity<contrato>()
                .HasMany(e => e.comisiones)
                .WithRequired(e => e.contrato)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empresa>()
                .HasMany(e => e.antecedentes)
                .WithRequired(e => e.empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<empresa>()
                .HasMany(e => e.solicitudes_empresas)
                .WithRequired(e => e.empresa)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<entrevista>()
                .HasMany(e => e.entrevistas_evaluaciones)
                .WithRequired(e => e.entrevista)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<evaluacione>()
                .HasMany(e => e.entrevistas_evaluaciones)
                .WithRequired(e => e.evaluacione)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<persona>()
                .HasMany(e => e.antecedentes)
                .WithRequired(e => e.persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<persona>()
                .HasMany(e => e.contratos)
                .WithRequired(e => e.persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<persona>()
                .HasMany(e => e.entrevistas)
                .WithRequired(e => e.persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<persona>()
                .HasMany(e => e.personas_titulos)
                .WithRequired(e => e.persona)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<solicitudes_empresas>()
                .HasMany(e => e.contratos)
                .WithRequired(e => e.solicitudes_empresas)
                .HasForeignKey(e => new { e.cuit, e.cod_cargo, e.fecha_solicitud })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<solicitudes_empresas>()
                .HasMany(e => e.entrevistas)
                .WithRequired(e => e.solicitudes_empresas)
                .HasForeignKey(e => new { e.cuit, e.cod_cargo, e.fecha_solicitud })
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<titulo>()
                .HasMany(e => e.personas_titulos)
                .WithRequired(e => e.titulo)
                .WillCascadeOnDelete(false);
        }
    }
}
