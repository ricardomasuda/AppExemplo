using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppTurmas.ViewModel
{
    class TimeLineAdminViewModel
    {
        public string Titulo { get; set; }
        public string Menssagem { get; set; }
        public List<string> Turma { get; set; }
        public Command EnviarCmd { get; set; }
        public TimeLineAdminViewModel()
        {
            EnviarCmd = new Command(EnviarNoticia);
        }

        public void EnviarNoticia()
        {

        }
    }
}
