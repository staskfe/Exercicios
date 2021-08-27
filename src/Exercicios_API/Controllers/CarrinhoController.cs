using Exercicios_API.Dtos.Carrinhos;
using Exercicios_API.Dtos.Produtos;
using Exercicios_API.Models;
using Exercicios_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarrinhoController : ControllerBase
    {
        private CarrinhoService _carrinhoService;

        public CarrinhoController()
        {
            _carrinhoService = new CarrinhoService();
        }

        [HttpGet]
        public IEnumerable<CarrinhoDisplayDto> Get(int usuarioId)
        {
            var result = _carrinhoService.ListarPorUsuario(usuarioId);
            return result.Select(x => new CarrinhoDisplayDto(x));
        }

        [HttpPost]
        public CarrinhoDisplayDto Post(CarrinhoCreateDto dto)
        {
            var model = new Carrinho(dto);
            var result = _carrinhoService.AdicionarProduto(model);
            return new CarrinhoDisplayDto(result);
        }


    }
}
