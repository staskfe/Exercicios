using Exercicios_API.Dtos.Produtos;
using Exercicios_API.Dtos.Carrinhos;
using Exercicios_API.Dtos.Usuarios;
using Exercicios_API.Models;
using Exercicios_API.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercicios_API.Dtos.Carrinhos
{
    public class CarrinhoDto
    {
        public int Unidade { get; set; }
        public int ProdutoId { get; set; }
        public int UsuarioId { get; set; }
    }

    public class CarrinhoCreateDto : CarrinhoDto
    {

    }

    public class CarrinhoCreateDisplayDto : CarrinhoDto
    {
        public List <ProdutoCarrinhoDto> ProdutosCarrinho { get; set; }
        public CarrinhoCreateDisplayDto(Carrinho model)
        {
            Id = model.Id;
            ProdutosCarrinho = model.ProdutosCarrinho.Select(x => new ProdutoCarrinhoDto(x)).ToList();
            UsuarioId = model.UsuarioId;
        }
        public int Id { get; set; }
    }

    public class CarrinhoDisplayDto : CarrinhoDto
    {
        public List<ProdutoCarrinhoDto> ProdutosCarrinho { get; set; }
        public CarrinhoDisplayDto(Carrinho model)
        {
            Id = model.Id;
            ProdutosCarrinho = model.ProdutosCarrinho.Select(x => new ProdutoCarrinhoDto(x)).ToList();
            UsuarioId = model.UsuarioId;

            double totalCarrinho = 0;
            foreach (var countCarrinho in ProdutosCarrinho)
            {
                totalCarrinho += countCarrinho.Quantidade * countCarrinho.Produto.Valor;
            }
            TotalCarrinho = totalCarrinho;
        }
        public int Id { get; set; }
        public ProdutoDisplayDto Produto { get; set; }
        public double TotalCarrinho { get; set; }
    }
}
