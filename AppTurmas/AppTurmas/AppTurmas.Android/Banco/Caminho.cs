using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using AppTurmas.Droid.Banco;
using AppTurmas.BancoSqlite;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caminho))]
namespace AppTurmas.Droid.Banco
{
    class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string CaminhoPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string CaminhoBanco = Path.Combine(CaminhoPasta, NomeArquivoBanco);
            return CaminhoBanco;
        }
    }
}