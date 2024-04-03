﻿using System;
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
        
        public IEnumerable<Evento> _evento = new Evento[]{
               new Evento(){
                   EventoId = 1,
                   Tema = "Angular 11 e .NET 5",
                   Local = "Belo Horizonte",
                   Lote = "1 Lote",
                   QtdPessoas = 250,
                   DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                   ImagemURL = "Foto1.png"
               },
               new Evento(){
                   EventoId = 2,
                   Tema = "Angular 12 e .NET 6",
                   Local = "São Paulo",
                   Lote = "2 Lote",
                   QtdPessoas = 350,
                   DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                   ImagemURL = "Foto2.png"
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
    }
}
