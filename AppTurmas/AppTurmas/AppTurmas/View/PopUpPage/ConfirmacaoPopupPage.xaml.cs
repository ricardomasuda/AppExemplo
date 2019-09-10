using AppTurmas.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;


using Xamarin.Forms.Xaml;

namespace AppTurmas.View.PopupPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ConfirmacaoPopupPage : Rg.Plugins.Popup.Pages.PopupPage
    {
        public ConfirmacaoPopupPage(MenssagemConfirmacao _Menssagem )
        {
          
            InitializeComponent();
            menssagem.Text = _Menssagem.Texto_menssagem;
            titulo.Text = _Menssagem.Titulo;
        }
    }
}