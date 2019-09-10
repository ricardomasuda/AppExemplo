using System;
using System.Collections.Generic;
using System.Text;

namespace AppTurmas.Model
{
    public class EventoAgenda
    {
        public DateTime Inicio { get; set; }
        public DateTime Fim { get; set; }
        public DateTime Texto { get; set; }
        public string Cor { get; set; }
        public EventoAgenda()
        {

        }
    }
}
