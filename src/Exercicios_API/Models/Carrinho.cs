using Exercicios_API.Dtos.Carrinhos;
using System;

namespace Exercicios_API.Models
{
    public class Carrinho
    {
        public Carrinho()
        {

        }
        public Carrinho(CarrinhoCreateDto dto)
        {
            Random random = new Random();
            Id = random.Next(1, 100);
            Unidade = dto.Unidade;
            ProdutoId = dto.ProdutoId;
            UsuarioId = dto.UsuarioId;
        }
        public int Id { get; set; } 
        public int Unidade { get; set; }

        public int ProdutoId { get; set; }
        public Produto Produto { get; set; }

        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
