using AwesomeGymAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeGymAPI.Controllers
{
    [ApiController]
    [Route("api/alunos")]
    public class AlunosController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            var alunos = new List<Aluno>
            {
                new Aluno("Thiago", "Lois Fernando", DateTime.Now)
            };
            return Ok(alunos);
        }

        [HttpPost]
        public IActionResult Post()
        {
            return Ok();
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
