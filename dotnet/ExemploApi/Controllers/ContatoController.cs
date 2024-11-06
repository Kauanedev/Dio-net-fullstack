using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExemploApi.Context;
using ExemploApi.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ExemploApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ContatoController : ControllerBase
    {
        private readonly AgendaContext _context;
        public ContatoController(AgendaContext context)
        {
            _context = context;
        }


        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            _context.Add(contato);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = contato.Id }, contato);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contato = _context.Contatos.Find(id);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);
        }
        [HttpGet("ObterPorNome")]
        public IActionResult GetByName(string nome)
        {
            var contato = _context.Contatos.Where(x => x.Nome == nome);

            if (contato == null)
            {
                return NotFound();
            }

            return Ok(contato);

        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contato contato)
        {
            var contatoExistente = _context.Contatos.Find(id);

            if (contatoExistente == null)
            {
                return NotFound();
            }

            contatoExistente.Nome = contato.Nome;
            contatoExistente.Telefone = contato.Telefone;
            contatoExistente.Ativo = contato.Ativo;

            _context.Contatos.Update(contatoExistente);
            _context.SaveChanges();

            return Ok(contatoExistente);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contatoExistente = _context.Contatos.Find(id);

            if (contatoExistente == null)
            {
                return NotFound();
            }

            _context.Contatos.Remove(contatoExistente);
            _context.SaveChanges();

            return Ok("Contato excluído com sucesso");
        }
    }
}