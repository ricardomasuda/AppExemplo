using System;
using System.Collections.Generic;
using System.Text;

namespace AppTurmas.Model
{
    public class Usuario
    {
        public int Id_user { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public int Tipo { get; set; }
        public Usuario()
        {

        }
    }
}
