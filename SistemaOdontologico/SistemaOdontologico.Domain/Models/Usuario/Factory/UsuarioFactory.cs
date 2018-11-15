using SistemaOdontologico.Domain.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaOdontologico.Domain.Models
{
    public partial class Usuario
    {
        public static Usuario CriarNovo(
            string nome,
            string login,
            string senha,
            eTipoUsuario tipoUsuario,
            bool ativo
            )
        {
            return new Usuario(0)
            {
                Nome = nome,
                Login = login,
                Senha = senha,
                TipoUsuario = tipoUsuario,
                Ativo = ativo
            };
        }

        public static Usuario Criar(
            long id,
            string nome,
            string login,
            string senha,
            eTipoUsuario tipoUsuario,
            bool ativo
            )
        {
            return new Usuario(id)
            {
                Nome = nome,
                Login = login,
                Senha = senha,
                TipoUsuario = tipoUsuario,
                Ativo = ativo
            };
        }


    }
}
