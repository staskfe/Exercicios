using Exercicios_API.Dtos.Produtos;
using Exercicios_API.Models;

namespace Exercicios_API.Dtos.Carrinhos
{
    public class ProdutoCarrinhoDto
    {
        public ProdutoCarrinhoDto(ProdutoCarrinho model)
        {
            CarrinhoId = model.CarrinhoId;
            ProdutoId = model.ProdutoId;
            Quantidade = model.Quantidade;
            Produto = new ProdutoDisplayDto(model.Produto);
        }

        public int Id { get; set; }
        public int CarrinhoId { get; set; }
        public int ProdutoId { get; set; }
        public ProdutoDisplayDto Produto { get; set; }
        public int Quantidade { get; set; }
    }
}
