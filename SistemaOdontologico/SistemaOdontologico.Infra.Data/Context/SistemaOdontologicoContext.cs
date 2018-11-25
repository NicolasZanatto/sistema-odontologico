using MySql.Data.Entity;
using MySql.Data.MySqlClient;
using SistemaOdontologico.Domain.Models;
using SistemaOdontologico.Infra.Data.EntityConfig;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.Data.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class SistemaOdontologicoContext : DbContext
    {
        public SistemaOdontologicoContext()
            : base("SistemaOdontologico")
        {
        }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Clinica> Clinicas { get; set; }
        public DbSet<Radiografia> Radiografias { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            RemovendoConvencoes(modelBuilder);
            AdicionandoConfiguracoes(modelBuilder);
        }

        private void AdicionandoConfiguracoes(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UsuarioConfiguration());
            modelBuilder.Configurations.Add(new ClinicaConfiguration());
            modelBuilder.Configurations.Add(new PacienteConfiguration());
            modelBuilder.Configurations.Add(new RadiografiaConfiguration());
        }

        private static void RemovendoConvencoes(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
        }
    }
}
