using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.Data.EntityConfig
{
    public class RadiografiaConfiguration : EntityTypeConfiguration<Radiografia>
    {
        public RadiografiaConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Data)
                .IsRequired();

            Property(x => x.Hora)
                .IsRequired();

            Property(x => x.Observacao)
                .HasMaxLength(1000);

            Property(x => x.LinkImg)
                .HasMaxLength(100);

            HasRequired(x => x.Clinica)
                .WithMany()
                .HasForeignKey(x => x.IdClinica);

            HasRequired(x => x.Paciente)
                .WithMany()
                .HasForeignKey(x => x.IdPaciente);
        }
    }
}
