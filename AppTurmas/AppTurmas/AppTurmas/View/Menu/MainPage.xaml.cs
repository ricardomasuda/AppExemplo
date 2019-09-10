using AppTurmas.View.MenuPage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTurmas.View.Menu
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : MasterDetailPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoTimeLinePage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TimeLinePage());
            IsPresented = false;
        }

        private void GoAgendaPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AgendaPage());
            IsPresented = false;
        }

        private void GoChatPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new ChatPage());
            IsPresented = false;
        }
        private void GoTimeLineAdminPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new TimeLineAdminPage());
            IsPresented = false;
        }
        private void GoAgendaAdminPage(object sender, EventArgs e)
        {
            Detail = new NavigationPage(new AgendaAdminPage());
            IsPresented = false;
        }
    }
}