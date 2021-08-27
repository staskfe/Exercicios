using Exercicios_API.Dtos.Usuarios;
using Exercicios_API.Models;
using Exercicios_API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercicios_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : ControllerBase
    {
        private UsuarioService _usuarioService;

        public UsuarioController()
        {
            _usuarioService = new UsuarioService();
        }
        [HttpGet]
        public IEnumerable<UsuarioDisplayDto> Get()
        {
            var result = _usuarioService.Listar();
            return result.Select(x => new UsuarioDisplayDto(x));
        }

        [HttpPost]
        public UsuarioDisplayDto Post(UsuarioCreateDto dto)
        {

            var model = new Usuario(dto);
            var result = _usuarioService.Criar(model);

            return new UsuarioDisplayDto(result);
        }
    }
}
