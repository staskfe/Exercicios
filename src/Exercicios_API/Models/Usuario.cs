
using Exercicios_API.Dtos.Usuarios;
using System;

namespace Exercicios_API.Models
{
    public class Usuario : Pessoa
    {
        public Usuario()
        {

        }
        public Usuario(UsuarioCreateDto dto)
        {
            Random value = new Random();
            Id = value.Next(11, 100);
            
            Cpf = dto.Cpf;
            Nome = dto.Nome;
            Senha = dto.Senha;
            User = dto.User;
        }
        public int Id { get; set; }
        public string User { get; set; }
        public string Senha { get; set; }

    }
}
