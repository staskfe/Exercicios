
using Exercicios_API.Models;
using Exercicios_API.Repositories;
using System.Collections.Generic;

namespace Exercicios_API.Services
{
    public class UsuarioService
    {
        private UsuarioRepository _usuarioRepository;
        public UsuarioService()
        {
            _usuarioRepository = new UsuarioRepository();
        }

        public List<Usuario> Listar()
        {
            return _usuarioRepository.Listar();
        }

        public Usuario Criar(Usuario Usuario)
        {
            _usuarioRepository.Criar(Usuario);
            return Usuario;
        }
    }
}
