using Exercicios_API.Dtos.Produtos;
using Exercicios_API.Dtos.Usuarios;
using Exercicios_API.Models;
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

    public class CarrinhoDisplayDto : CarrinhoDto
    {
        public CarrinhoDisplayDto(Carrinho model)
        {
            Id = model.Id;
            Unidade = model.Unidade;
            ProdutoId = model.ProdutoId;
            UsuarioId = model.UsuarioId;

            Produto = new ProdutoDisplayDto(model.Produto);
        }

        public int Id { get; set; }

        public ProdutoDisplayDto Produto { get; set; }

    }
}
