﻿using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        public readonly DataContext _context;
        public EventosController(DataContext context)
        {   
            _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _context.Eventos;
        }

        [HttpGet ("{id}")]
       public Evento GetById(int id)
       {
        return _context.Eventos.FirstOrDefault(evento => evento.EventoID == id);
       }

        [HttpPost]
        public string Post()
        {
          return "Valor de Post";
        }

        [HttpPut ("{id}")]
        public string Put(int id)
        {
          return $"Put de ID= {id}";
        }
    }
}
