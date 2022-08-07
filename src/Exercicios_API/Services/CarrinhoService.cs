
using Exercicios_API.Dtos.Produtos;
using Exercicios_API.Models;
using Exercicios_API.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios_API.Services
{
    public class CarrinhoService
    {
        private CarrinhoRepository _carrinhoRepository;
        public CarrinhoService()
        {
            _carrinhoRepository = new CarrinhoRepository();
        }

        public List<Carrinho> ListarPorUsuario(int usuarioId)
        {
            return _carrinhoRepository.ListarPorUsuario(usuarioId);
        }

        public Carrinho AdicionarProduto(Carrinho carrinho)
        {
            var buscaCarrinho = _carrinhoRepository.PorUsuarioId(carrinho.UsuarioId);

            if (buscaCarrinho != null)
            {
                buscaCarrinho.ProdutosCarrinho.ToList().AddRange(carrinho.ProdutosCarrinho);
                _carrinhoRepository.AdicionaProduto(carrinho);
                return carrinho;
            }
            else
            {
                _carrinhoRepository.AdicionaCarrinho(carrinho);
            }

            return _carrinhoRepository.PorId(carrinho.Id); 

        }

        public void RemoverProduto(int id)
        {
            var carrinho = _carrinhoRepository.PorUsuarioId(id);
            _carrinhoRepository.RemoverProduto(carrinho);
        }

    }
}
