using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using AppTurmas.BancoSqlite;
using AppTurmas.iOS.Banco;
using Foundation;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caminho))]
namespace AppTurmas.iOS.Banco
{
    class Caminho :ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string CaminhoPasta = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            string CaminhoDaBiblioteca = Path.Combine(CaminhoPasta, "..", "Library");
            string CaminhoBanco = Path.Combine(CaminhoDaBiblioteca, NomeArquivoBanco);
            return CaminhoBanco;
        }
    }
}