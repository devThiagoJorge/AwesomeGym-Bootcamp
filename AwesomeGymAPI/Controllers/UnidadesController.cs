using AwesomeGymAPI.Dto;
using AwesomeGymAPI.Models;
using AwesomeGymAPI.Persistence;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGymAPI.Controllers
{
    [ApiController]
    [Route("api/unidades")]
    public class UnidadesController : ControllerBase
    {
        private readonly AwesomeDbContext _awesomeDbContext;
        public UnidadesController(AwesomeDbContext awesomeDbContext)
        {
            _awesomeDbContext = awesomeDbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var unidades = _awesomeDbContext.Unidades.ToList();
            return Ok(unidades);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var unidade = _awesomeDbContext.Unidades.FirstOrDefault(x => x.Id == id);
            if (unidade == null)
                return NotFound();

            return Ok(unidade);
        }
        [HttpPost]
        public IActionResult Post([FromBody]UnidadeDto unidade)
        {
            var unidadeCreate = new Unidade(
                    unidade.Nome,
                    unidade.Endereco
                );

            _awesomeDbContext.Add(unidadeCreate);
            _awesomeDbContext.SaveChanges();

            return NoContent();
        }
        [HttpPut("{id}")]
        public IActionResult Put(int id)
        {
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
