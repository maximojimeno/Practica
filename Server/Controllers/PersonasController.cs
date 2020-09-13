using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persona.Server.Models;

namespace Persona.Server.Controllers {
    [Route("api/persona")]
    [ApiController]
    public class PersonasController : ControllerBase
    {

        private DbContexto _dbContexto;

        public PersonasController(DbContexto dbContexto)
        {
            _dbContexto = dbContexto;
        }

        [HttpGet("")]

        public ActionResult<IEnumerable<Shared.Persona>> GetPersonas()
        {
            return _dbContexto.personas.ToList();
        }
    }
}
