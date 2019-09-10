using System;
using System.Collections.Generic;
using System.Text;

namespace AppTurmas.Model
{
    public interface IRequest
    {
        string Action { get; set; }
    }
    class CadastroRequest : IRequest
    {
        public string Action { get; set; }

        public string email { get; set; }
        public string token { get; set; }
        public string senha { get; set; }
        public string nome { get; set; }
        public string cpf { get; set; }
        public string telefone { get; set; }
       
        public CadastroRequest(Usuario _user)
        {
            Action = "login/Cadastrar.php";
            email = _user.Email;
            nome = _user.Nome;
            senha = _user.Senha;
            telefone = _user.Telefone;
            cpf = _user.CPF;
        }
    }

    class LoginRequest : IRequest
    {
        public string Action { get; set; }
        public string email { get; set; }    
        public string senha { get; set; }
     
        public LoginRequest(Usuario _user)
        {
            Action = "login/Login.php";
            email = _user.Email;
            senha = _user.Senha;
            
         

        }
    }

    class ResetarSenhaRequest : IRequest
    {
        public string Action { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }

        public ResetarSenhaRequest(Usuario _user)
        {
            Action = "login.php";
            Nome = _user.Nome;
            Senha = _user.Senha;

        }
    }

    class BuscarAgendaRequest : IRequest
    {
        public string Action { get; set; }
        public BuscarAgendaRequest()
        {
            Action = "BuscarAgenda.php";

        }
    }



    class Request
    {
    }
}
