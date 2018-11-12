using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.Data.EntityConfig
{
    public class PacienteConfiguration : EntityTypeConfiguration<Paciente>
    {
        public PacienteConfiguration()
        {
            HasKey(x => x.Id);

            Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(50);

            Property(x => x.Idade)
                .IsRequired();

            Property(x => x.Sexo)
                .IsRequired()
                .HasMaxLength(12);

            Property(x => x.Telefone)
                .IsRequired()
                .HasMaxLength(20);

            Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(x => x.Observacao)
                .HasMaxLength(1000);

            Property(x => x.Ativo)
                .IsRequired();
        }
    }
}
