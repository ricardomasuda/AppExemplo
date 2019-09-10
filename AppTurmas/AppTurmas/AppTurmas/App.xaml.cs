using AppTurmas.BancoSqlite;
using AppTurmas.Model;
using AppTurmas.View.Login;
using System;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppTurmas
{
    public partial class App : Application
    {
        public static Usuario Usuario { get; set; }  = new Usuario();
        public static AcessoBanco Database { get; set; } = new AcessoBanco();
        
        private List<Usuario> Lista_usuario { get; set; }
        public App()
        {
            InitializeComponent();

            //MainPage = new NavigationPage(new LoginPage());
        }

        protected override void OnStart()
        {
            Lista_usuario = new List<Usuario>();
            Lista_usuario = App.Database.Consultar();
            if (Lista_usuario.Count() == 0)
            {
                MainPage = new NavigationPage(new LoginPage());
            }
            else
            {
                App.Usuario = Lista_usuario[0];
                App.Current.MainPage = new View.Menu.MainPage();
            }
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
