using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// semicolon;; 
namespace ExemploApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuarioController : ControllerBase
    {
        [HttpGet("obterhora")]
        public IActionResult ObterDataHora()
        {
            var obj = new
            {
                data = DateTime.Now.ToLongDateString(),
                hora = DateTime.Now.ToShortDateString()
            };
            return Ok(obj);

        }
        [HttpGet("Apresentar/{nome}")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Seja bem-vindo(a), {nome}";
            return Ok(new { mensagem });
        }
    }
}