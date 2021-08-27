
using Exercicios_API.Models;

namespace Exercicios_API.Dtos.Produtos
{
    public class ProdutoDto
    {
        public string Nome { get; set; }
        public double Valor { get; set; }

    }

    public class ProdutoDisplayDto: ProdutoDto
    {
        public int Id { get; set; }
        public ProdutoDisplayDto(Produto model)
        {
            Id = model.Id;
            Nome = model.Nome;
            Valor = model.Valor;
            Nome = model.Nome;
        }

    }
}
