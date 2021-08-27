
using Exercicios_API.Models;

namespace Exercicios_API.Dtos.Usuarios
{
    public class UsuarioDto : PessoaDto
    {
        public string User { get; set; }
        public string Senha { get; set; }

    }

    public class UsuarioDisplayDto: UsuarioDto
    {
        public int Id { get; set; }
        public UsuarioDisplayDto(Usuario model)
        {
            Id = model.Id;
            User = model.User;
            Senha = model.Senha;
            Nome = model.Nome;
            Cpf = model.Cpf;
        }

    }
    public class UsuarioCreateDto : UsuarioDto
    { 

    }

    public class UsuarioEditDto : UsuarioDto
    {
        public int Id { get; set; }
    }
}
