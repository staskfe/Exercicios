using Exercicios_API.Dtos.Carrinhos;
using System;
using System.Collections.Generic;

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
            UsuarioId = dto.UsuarioId;
            ProdutosCarrinho = new List<ProdutoCarrinho> { new ProdutoCarrinho(Id, dto.ProdutoId, dto.Unidade) };
        }

        public int Id { get; set; }
        public IEnumerable <ProdutoCarrinho> ProdutosCarrinho { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; }
    }
}
