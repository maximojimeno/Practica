﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Persona.Server.Models;

namespace Persona.Server.Controllers {
    [Route("api/personas")]
    [ApiController]
    public class PersonasController : ControllerBase {

        private readonly DbContexto contexto;

        public PersonasController(DbContexto _contexto) {
            contexto = _contexto;
        }


        [HttpGet("{PersonaId}")]
        public async Task<ActionResult<Shared.Persona>> GetPersona(int PersonaId) {

            var persona = await contexto.personas.Where(p => p.id == PersonaId).SingleOrDefaultAsync();

            if (persona == null) {
                return NotFound();
            } else {
                return persona;
            }


        }


    }



}
