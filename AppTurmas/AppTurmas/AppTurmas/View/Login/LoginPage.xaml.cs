using AppTurmas.Model;
using AppTurmas.View.PopupPage;
using AppTurmas.ViewModel;
using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTurmas.View.Login
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private Usuario user { get; set; } = new Usuario();

        private MenssagemConfirmacao Confirmacao { get; set; }
        public LoginPage()
        {
            InitializeComponent();
        }


        private void CadastrarNovoUsuarioCmd(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CadastroPage());
        }

        private void ResetarSenhaCmd(object sender, EventArgs e)
        {
            Navigation.PushAsync(new RecadastrarSenhaPage());
          
        }
        private void LogarCmd(object sender, EventArgs e)
        {
            App.Current.MainPage = new View.Menu.MainPage();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            BindingContext = new LoginViewModel(Navigation);
        }
    }
}