using AppTurmas.Model;
using AppTurmas.View.PopupPage;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppTurmas.ViewModel
{
    class LoginViewModel
    {
        public Command LogarCmd { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        private INavigation Navigation { get; set; }
        private Usuario user { get; set; } = new Usuario();
        private MenssagemConfirmacao Confirmacao { get; set; }
        private List<Usuario> Lista_usuario { get; set; }
        public LoginViewModel(INavigation _Navigation)
        {
            Navigation = _Navigation;

            LogarCmd = new Command(Logar);
        }



        public async void Logar()
        {
            user.Email = Email;
            user.Senha = Senha;

            var _request = new LoginRequest(user);
            var _response = await HttpsRequests<LoginRequest, usuarioResponse>.PostAsync(_request);
            if (_response.Usuario != null)
            {
                Lista_usuario=App.Database.Consultar();
                if(Lista_usuario.Count != 0)
                {
                    App.Database.Exclusao(App.Usuario);
                }
                App.Database.Cadastro(_response.Usuario);
                App.Usuario = _response.Usuario;
                App.Current.MainPage = new View.Menu.MainPage();
            }
            else
            {
                Confirmacao = new MenssagemConfirmacao();
                Confirmacao.Titulo = "Erro";
                Confirmacao.Texto_menssagem = "Senha ou email incorreto";
                await Navigation.PushPopupAsync(new ConfirmacaoPopupPage(Confirmacao));
            }
        }
    }
}
