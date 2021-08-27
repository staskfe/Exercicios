using Exercicios_API.Dtos.Produtos;
using Exercicios_API.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProdutoController : ControllerBase
    {
        private ProdutoService _produtoService;

        public ProdutoController()
        {
            _produtoService = new ProdutoService();
        }
        [HttpGet]
        public IEnumerable<ProdutoDisplayDto> Get()
        {
            var result = _produtoService.Listar();
            return result.Select(x => new ProdutoDisplayDto(x));
        }

      
    }
}
