using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;
using Microsoft.EntityFrameworkCore;
using ProEventos.API.Data;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {   
        private readonly DataContext _context;

        public EventoController(DataContext context)
        {
            _context = context;
           
        }

        [HttpGet("{id}")]
        
        public IEnumerable<Evento> GetById(int id)
        {
            return _context.Eventos.Where(evento => evento.EventoId ==id);
        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _context.Eventos;
        }

         [HttpPost]
        public string Post()
        {
            return  "Exemplo de Post";
        }

         [HttpPut]
        public string Put(int id)
        {
            return  $"Exemolo de put com o id={id}";
        }
        
         [HttpPatch]
        public string Patch()
        {
            return  "Exemplo de Patch";
        }
        
        [HttpDelete]
        public string Delete(int id)
        {
            return $"Exemplo de Delete id={id}";
        }
    }
}