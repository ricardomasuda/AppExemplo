using AppTurmas.BancoSqlite;
using AppTurmas.UWP.Banco;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;

[assembly: Dependency(typeof(Caminho))]
namespace AppTurmas.UWP.Banco
{
    class Caminho : ICaminho
    {
        public string ObterCaminho(string NomeArquivoBanco)
        {
            string CaminhoPasta = ApplicationData.Current.LocalFolder.Path;
            string CaminhoBanco = Path.Combine(CaminhoPasta, NomeArquivoBanco);
            return CaminhoBanco;
        }
    }
}
