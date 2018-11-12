using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.Data.EntityConfig
{
    public class ClinicaConfiguration : EntityTypeConfiguration<Clinica>
    {
        public ClinicaConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome)
                .HasMaxLength(50);

            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.IdUsuario);
        }
    }
}
