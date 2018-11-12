using SistemaOdontologico.Domain.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Infra.Data.EntityConfig
{
    public class UsuarioConfiguration : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfiguration()
        {

            HasKey(x => x.Id);

            Property(x => x.Senha)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.Login)
                .HasMaxLength(150)
                .IsRequired();

            Property(x => x.TipoUsuario)
                .IsRequired();
        }
    }
}
