
using Exercicios_API.Models;
using Exercicios_API.Repositories;
using System.Collections.Generic;

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
            _carrinhoRepository.AdicionarProduto(carrinho);
            return _carrinhoRepository.PorId(carrinho.Id);
        }

        public void RemoverProduto(int id)
        {
            var carrinho = _carrinhoRepository.PorUsuarioId(id);
            _carrinhoRepository.RemoverProduto(carrinho);
        }
    }
}
