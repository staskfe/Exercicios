
using Exercicios_API.Models;
using Exercicios_API.Repositories;
using System.Collections.Generic;

namespace Exercicios_API.Services
{
    public class ProdutoService
    {
        private ProdutoRepository _produtoRepository;
        public ProdutoService()
        {
            _produtoRepository = new ProdutoRepository();
        }

        public List<Produto> Listar()
        {
            return _produtoRepository.Listar();
        }
    }
}
