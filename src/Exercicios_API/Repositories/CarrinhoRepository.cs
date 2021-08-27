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

        public Carrinho AdicionarProduto(Carrinho carrinho)
        {
            carrinho.Produto = FakeData.Produtos.FirstOrDefault(x => x.Id == carrinho.ProdutoId);

            FakeData.Carrinhos.Add(carrinho);
            return carrinho;
        }
        public void RemoverProduto(Carrinho carrinho)
        {
            FakeData.Carrinhos.Remove(carrinho);
        }

    }
}
