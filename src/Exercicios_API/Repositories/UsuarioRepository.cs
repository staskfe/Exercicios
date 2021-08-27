using Exercicios_API.FakeDb;
using Exercicios_API.Models;
using System.Collections.Generic;

namespace Exercicios_API.Repositories
{
    public class UsuarioRepository
    {
        public List<Usuario> Listar()
        {
            return FakeData.Usuarios;
        }

        public Usuario Criar(Usuario Usuario)
        {
            FakeData.Usuarios.Add(Usuario);
            return Usuario;
        }
    }
}
