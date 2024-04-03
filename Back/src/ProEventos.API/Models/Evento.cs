using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProEventos.API.Models
{
    public class Evento
    {
        public int EventoId { get; set; }

        public String Local { get; set; }

        public String DataEvento { get; set; }

        public String Tema { get; set; }

        public int QtdPessoas { get; set; }

        public String Lote { get; set; }

        public String ImagemURL { get; set; }
    }
}