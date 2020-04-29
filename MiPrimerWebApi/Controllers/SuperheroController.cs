using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MiPrimerWebApi.Entities;

namespace MiPrimerWebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperheroController : Controller
    {
        private readonly SuperheroContext context;

        public SuperheroController(SuperheroContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Superhero> Get()
        {
            return context.Superhero.ToList();
        }

        [HttpGet("{id}")]
        public Superhero Get(int id)
        {
            var superhero = context.Superhero.FirstOrDefault(s=>s.SuperheroId==id);
            return superhero;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Superhero superhero)
        {
            context.Superhero.Add(superhero);
            await context.SaveChangesAsync();
            return Ok(superhero);
        }

    }
}
