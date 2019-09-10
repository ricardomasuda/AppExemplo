using System;
using System.Collections.Generic;
using System.Text;

namespace AppTurmas.Model
{
    public class Menssagem
    {
        public int Id_menssagem { get; set; }
        public string Texto_menssagem { get; set; }
        public string Data { get; set; }
        public Usuario User { get; set; } = new Usuario();

        public string Lado { get; set; }
        public Menssagem()
        {

        }
    }
}
