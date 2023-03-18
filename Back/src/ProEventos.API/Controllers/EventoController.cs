using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento>  _evento = new Evento[]{
            new Evento() {
                EventoId = 1,
                Tema = "Trabalhando com CSHARP Duka",
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                Local = "Carapicuiba",
                Lote = "1º Lote",
                QtdPessoas = 50,
                ImageURL = "Imagem_Evento.png"
            },
            new Evento() {
                EventoId = 2,
                Tema = "Angular 11 e .NET 5",
                DataEvento = DateTime.Now.AddDays(4).ToString(),
                Local = "Itaim Paulista",
                Lote = "2º Lote",
                QtdPessoas = 100,
                ImageURL = "Imagem_Evento_angular.png"
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
        public string EnviandoDados()
        {
            return "Exemplo de POST";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"Exemplo de PUT id = {id}";
        }
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete id = {id}";
        }
    }
}
