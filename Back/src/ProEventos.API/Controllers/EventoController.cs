using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;


namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable <Evento> _evento=new Evento[]
        {   
               new Evento(){
                EventoId= 1,
                Tema = "Angular e DotNet 5",
                Local = "Franco da Rocha",
                Lote = "1 Lote",
                QtdePessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL="Foto.Png"
                },
                new Evento(){
                EventoId= 2,
                Tema = "PHP",
                Local = "São Paulo",
                Lote = "2 Lote",
                QtdePessoas = 350,
                DataEvento = DateTime.Now.AddDays(12).ToString("dd/mm/yyyy"),
                ImagemURL="Foto.Png"
                }
        };   

        public EventoController()
        {
           
        }

        [HttpGet("{id}")]
        
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId ==id);
        }
        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return _evento;
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