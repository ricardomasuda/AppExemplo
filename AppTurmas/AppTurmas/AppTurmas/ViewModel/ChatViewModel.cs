using AppTurmas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace AppTurmas.ViewModel
{
    class ChatViewModel
    {

        private ObservableCollection<Menssagem> _ListaMessenger;
        public ObservableCollection<Menssagem> ListaMessenger { get { return _ListaMessenger; } set { _ListaMessenger = value; OnPropertyChanged("ListaMessenger"); } }
        //public ObservableCollection<Menssagem> ListaMessenger { get; set; } = new ObservableCollection<Menssagem>();
        public Menssagem Menssagem_add { get; set; }
        public string MenssagemUp { get; set; }
        public Command EnviarCmd { get; set; }

        //TODO - ARRUMAR O UTIL E COLOCAR PRA COMPRAR COM O USUARIO E N COM RICARDO
        public ChatViewModel()
        {
            ListaMessenger = new ObservableCollection<Menssagem>();
            Menssagem menssagem0 = new Menssagem();
            menssagem0.User.Nome = "Ricardo";
            menssagem0.Texto_menssagem = "Isso é só um teste";
            menssagem0.Data = "16:45";
            menssagem0.Lado = "Start";
            Menssagem menssagem1 = new Menssagem();
            menssagem1.User.Nome = "Miguel";
            menssagem1.Texto_menssagem = "Vai se fuder";
            menssagem1.Data = "16:45";
            menssagem1.Lado = "End";
           Menssagem menssagem2 = new Menssagem();
            menssagem2.User.Nome = "Chicão";
            menssagem2.Texto_menssagem = "Ta doido Rapaz!!!";
            menssagem2.Data = "16:45";
            menssagem2.Lado = "Start";
            Menssagem menssagem3 = new Menssagem();
            menssagem3.User.Nome = "Kesley";
            menssagem3.Texto_menssagem = "A única área que eu acho, que vai exigir muita atenção nossa, e aí eu já aventei a hipótese de até criar um ministério. É na área de... Na área... Eu diria assim, como uma espécie de analogia com o que acontece na área agrícola.";
            menssagem3.Data = "16:45";
            menssagem3.Lado = "Start";
            ListaMessenger.Add(menssagem0);
            ListaMessenger.Add(menssagem1);
            ListaMessenger.Add(menssagem2);
            ListaMessenger.Add(menssagem3);
            EnviarCmd = new Command(EnviarMenssagem);
        }

        public void EnviarMenssagem()
        {
            Menssagem_add = new Menssagem();
            Menssagem_add.User.Nome = "Ricardo"; 
            Menssagem_add.Texto_menssagem = MenssagemUp;
            MenssagemUp = "";
            ListaMessenger.Add(Menssagem_add);

        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string NameProperty)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(NameProperty));
            }
        }

    }
}
