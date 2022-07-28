using Exercicios_API.FakeDb;
using Exercicios_API.Models;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Exercicios_API.Repositories
{
    public class CarrinhoRepository
    {
        public Carrinho PorUsuarioId(int usuarioId)
        {
            return FakeData.Carrinhos.FirstOrDefault(x => x.UsuarioId == usuarioId);
        }
        public Carrinho PorId(int id)
        {
            return FakeData.Carrinhos.FirstOrDefault(x => x.Id == id);
        }
        public List<Carrinho> ListarPorUsuario(int usuarioId)
        {
            return FakeData.Carrinhos.Where(x => x.UsuarioId == usuarioId).ToList();
        }

        public Carrinho AdicionaCarrinho(Carrinho carrinho)
        {
            PreencherProduto(carrinho.ProdutosCarrinho);
            FakeData.Carrinhos.Add(carrinho);
            FakeData.ProdutosCarrinho.AddRange(carrinho.ProdutosCarrinho);
            return carrinho;
        }

        public Carrinho AdicionaProduto(Carrinho carrinho)
        {
            PreencherProduto(carrinho.ProdutosCarrinho);
            FakeData.ProdutosCarrinho.AddRange(carrinho.ProdutosCarrinho);
            return carrinho;
        }
        public void PreencherProduto(IEnumerable<ProdutoCarrinho> produtosCarrinho)
        {
            foreach (ProdutoCarrinho produto in produtosCarrinho)
            {
                produto.Produto = FakeData.Produtos.FirstOrDefault(x => x.Id == produto.ProdutoId);
            }
        }


        public void RemoverProduto(Carrinho carrinho)
        {
            FakeData.Carrinhos.Remove(carrinho);
        }

    }
}
