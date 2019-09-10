using Rg.Plugins.Popup.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTurmas.View.PopUpPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public LoadPage()
        {
            InitializeComponent();
        }
        protected override bool OnBackgroundClicked()
        {
            return false;
        }

        public async void Close()
        {
            try
            {
                await Navigation.PopAllPopupAsync();
            }
            catch (Exception)
            {
            }
        }
        public void AtualizarTexto(string _mensagem)
        {
            labelLoad.Text = _mensagem;
        }

    }
}