using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persona.Server.Models;


namespace Persona.Server.Controllers {
    [Route("api/[Controller]")]
    [ApiController]
    public class PersonasController : ControllerBase
    
    { private DbContexto _dbContexto;

        public PersonasController(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }

        [HttpGet("")]

        public async Task<ActionResult<IEnumerable<Shared.Persona>>> GetPersonas()
        {
            try
            {
                List<Shared.Persona> persona = await _dbContexto.personas.ToListAsync();

                return persona;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        
        [HttpGet("{Id}")]
        public async Task<ActionResult<Shared.Persona>> GetPersona(int id) {

            var persona = await _dbContexto.personas.FirstOrDefaultAsync(persona => persona.id == id);

            if (persona == null) {
                return NotFound();
            } else {
                return persona;
            }
        }

        [HttpPost]
        public async Task<ActionResult<Shared.Persona>> PostGuardar(Shared.Persona persona)
        {
            try
            {
                if (_dbContexto.personas.Add(persona) != null)
                {
                    await _dbContexto.SaveChangesAsync();
                }
                return Ok();
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
    }

