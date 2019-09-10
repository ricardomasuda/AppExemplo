using AppTurmas.Model;
using AppTurmas.View.PopupPage;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppTurmas.ViewModel
{
    class CadastrarViewModel
    {
        public Command CadastrarCmd { get; set; }
        public Command LogarCmd { get; set; }
        private Usuario usuario { get; set; } = new Usuario();
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Senha { get; set; }
        public string CPF { get; set; }
        public MenssagemConfirmacao Confirmacao { get; set; } = new MenssagemConfirmacao();

        private INavigation Navigation { get; set; }

        Page _page;
        public CadastrarViewModel(INavigation _Navigation)
        {
            Navigation = _Navigation;
            CadastrarCmd = new Command(Cadastrar_usuario);
           
        }


        public async void Cadastrar_usuario()
        {
            usuario.Nome = Nome;
            usuario.Email = Email;
            usuario.Senha = Senha;
            usuario.Telefone = Telefone;
            usuario.CPF = CPF; 
            var _request = new CadastroRequest(usuario);
            var _response = await HttpsRequests<CadastroRequest, SimpleResponse>.PostAsync(_request, _page);
            if(_response.retorno == "true")
            {
                Confirmacao.Titulo = "Cadastro Realizado com Sucesso";
                Confirmacao.Texto_menssagem = "Seu cadastro foi realizado e a partir de agora você pode logar no nosso App";
                await Navigation.PushPopupAsync(new ConfirmacaoPopupPage(Confirmacao));           
            }
            else
            {
                Confirmacao.Titulo = "Já há um cadastro com esse email";
                Confirmacao.Texto_menssagem = "Já temos um cadastro com esse email , use outro email ou resete sua senha";
                await Navigation.PushPopupAsync(new ConfirmacaoPopupPage(Confirmacao));
            }
            


        }

    }
}
