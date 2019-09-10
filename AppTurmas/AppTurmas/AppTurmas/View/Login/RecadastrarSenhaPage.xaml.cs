using AppTurmas.Model;
using AppTurmas.ViewModel;
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
    public partial class RecadastrarSenhaPage : ContentPage
    {
        public Usuario user { get; set; }
        public RecadastrarSenhaPage()
        {
            InitializeComponent();
        }

        private async void ResetarSenha(object sender, EventArgs e)
        {
            user.Nome = entryNome.Text;
            user.Email = entryEmail.Text;
            var _request = new ResetarSenhaRequest(user);
            var _response = await HttpsRequests<ResetarSenhaRequest, SimpleResponse>.PostAsync(_request);
        }
    }
}