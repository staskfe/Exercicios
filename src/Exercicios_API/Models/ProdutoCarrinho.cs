using System;

namespace Exercicios_API.Models
{
    public class ProdutoCarrinho
    {
        public ProdutoCarrinho(int carrinhoId, int produtoId, int quantidade)
        {
            Random random = new Random();
            Id = random.Next(1, 100);
            CarrinhoId = carrinhoId;
            ProdutoId = produtoId;
            Quantidade = quantidade;
        }

        public int Id { get; set; }
        public int CarrinhoId { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public Carrinho Carrinho { get; set; }
        public Produto Produto { get; set; }
    }
}
