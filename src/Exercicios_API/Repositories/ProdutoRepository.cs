using Exercicios_API.FakeDb;
using Exercicios_API.Models;
using System.Collections.Generic;

namespace Exercicios_API.Repositories
{
    public class ProdutoRepository
    {
        public List<Produto> Listar()
        {
            return FakeData.Produtos;
        }

    }
}
