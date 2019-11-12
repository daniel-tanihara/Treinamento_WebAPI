using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProAgil.WebAPI.Model;

namespace ProAgil.WebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly ILogger<EventoController> _logger;

        public EventoController(ILogger<EventoController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {
            return new Evento[] {
                new Evento() 
                {
                    EventoId = 1,
                    Tema = "Angular e .Net Core",
                    Local = "São Paulo",
                    Lote = "1o. Lote",
                    QtdPessoas = 100,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() 
                {
                    EventoId = 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "São Paulo",
                    Lote = "2o. Lote",
                    QtdPessoas = 150,
                    DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy")
                }
            };
        }

        [HttpGet("{id}")]
        public Evento Get(int id)
        {
            return new Evento[] {
                new Evento() 
                {
                    EventoId = 1,
                    Tema = "Angular e .Net Core",
                    Local = "São Paulo",
                    Lote = "1o. Lote",
                    QtdPessoas = 100,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy")
                },
                new Evento() 
                {
                    EventoId = 2,
                    Tema = "Angular e Suas Novidades",
                    Local = "São Paulo",
                    Lote = "2o. Lote",
                    QtdPessoas = 150,
                    DataEvento = DateTime.Now.AddDays(4).ToString("dd/MM/yyyy")
                }
            }.FirstOrDefault(x => x.EventoId == id);
        }
    }
}