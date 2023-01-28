using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
      public IEnumerable<Evento> _evento = new Evento[]
          {
            new Evento()
            {
            EventoID = 1,
            Tema = "Angular 12" ,
            Local = "Belo Horizonte",
            Lote = "1º Lote",
            QtdePessoas = 250,
            DataEvento = DateTime.UtcNow.AddDays(2).ToString(),
            ImagemUrl = "foto.png"
          },
          new Evento()
            {
            EventoID = 2,
            Tema = "Angular 12 e suas Novidades",
            Local = "São Paulo",
            Lote = "1º Lote",
            QtdePessoas = 250,
            DataEvento = DateTime.UtcNow.AddDays(2).ToString(),
            ImagemUrl = "foto.png"
          }
          };
        public EventoController()
        {   
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _evento;
        }

        [HttpGet ("{id}")]
       public IEnumerable<Evento> GetById(int id)
       {
        return _evento.Where(evento => evento.EventoID == id);
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
