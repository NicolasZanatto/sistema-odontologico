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
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.TipoSexo)
                .IsRequired();

            Property(x => x.Idade)
                .IsRequired();

            Property(x => x.Telefone)
                .HasMaxLength(50)
                .IsRequired();

            Property(x => x.Email)
                .HasMaxLength(100)
                .IsRequired();

            Property(x => x.Observacao)
                .HasMaxLength(1000);

            HasRequired(x => x.Usuario)
                .WithMany()
                .HasForeignKey(x => x.IdUsuario);

        }
    }
}
