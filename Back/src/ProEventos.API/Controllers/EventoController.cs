using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        public IEnumerable<Evento> _evento = new Evento[] {
            new Evento{
                EventoId = 1,
                Tema = "Angular e .NET 5",
                Local = "Mondaí",
                Lote = "24bb17(1)",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                ImagemURL = "localimage"
            },
            new Evento{
                EventoId = 2,
                Tema = "Angular e suas novidades .NET 5",
                Local = "Mondaí",
                Lote = "24bb17(1)",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(5).ToString("dd/MM/yyyy"),
                ImagemURL = "localimage"
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

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpPost]
        public string Post()
        {
            return "value";
        }

        [HttpPut]
        public IEnumerable<Evento> Put()
        {
            return _evento;
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            if (id >= 10)
            {
                return "JSON não deletado";
            }
            else
            {
                return "Registro deletado com sucesso!";
            }

        }
    }
}
