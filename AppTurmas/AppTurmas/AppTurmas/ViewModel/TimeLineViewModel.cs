using AppTurmas.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AppTurmas.ViewModel
{
    class TimeLineViewModel
    {
        public Command aumentarcmd { get; set; }

        public Command ImageCommandCmd { get; set; }

        //private ObservableCollection<Post> _ListaNoticiaAux;

        private ObservableCollection<Post> _ListaNoticia;
        public ObservableCollection<Post> ListaNoticia { get { return _ListaNoticia; } set { _ListaNoticia = value; OnPropertyChanged("ListaNoticia"); } }
        ICommand tapCommand;
        int taps = 0;

        private bool _atualizando = false;
        public bool Atualizando { get { return _atualizando; } set { _atualizando = value; OnPropertyChanged("Atualizando"); } }

        Page page;
        public TimeLineViewModel()
        {
            
            ImageCommandCmd = new Command(ImageCommand);

            ListaNoticia = new ObservableCollection<Post>()
            {
               new Post(2,
                   "Culto Ecumênico",
                   "Sexta Teremos o culto ecumênico , por favor todos com roupa de Gala e sapatos",
                   "10/05/2019",
                   "https://extranet.esqproducoes.com.br/arquivos/20180319074043f3aa5dc8e08ef6e6419efa31c451c2ac.jpg",
                   "Eduarda",
                   2,
                   "heartSelected.png"
                   ),

               new Post(3,
                   "Reunião Comisssão ",
                   "A comissão se reunira com a turma as 19h" +
                   "Todos os integrantes devem se apresetar no horario na faculdade "+
                   "Todos as descrições das pessoas são sobre a humanidade do atendimento, a pessoa pega no pulso, examina, olha com carinho. Então eu acho que vai ter outra coisa, que os médicos cubanos trouxeram pro brasil, um alto grau de humanidade."
                   ,
                   "10/05/2019",
                   "https://extranet.esqproducoes.com.br/arquivos/20180508094910c11dc22f3ec7bc569f118e0af3a9926d.png",
                   "Comissão",
                   3,
                   "heartSelected.png"
                   )
            };
        }

        public ICommand AtualizarCommand
        {

            get
            {
                return new Command(async () =>
                {
                    Atualizando = true;

                    await GetNoticias();

                    Atualizando = false;
                });
            }
        }

        public async Task GetNoticias()
        {
            Post postinho = new Post(1,
                    "Post Tony Stak",
                   "Eu sou o Tony",
                   "10/05/2019",
                   "https://observatoriodocinema.bol.uol.com.br/wp-content/uploads/2018/11/invincible-iron-man-600-1111851-1280x0.jpeg",
                   "Tony Stark",
                   3,
                   "heartSelected.png");
            ListaNoticia.Add(postinho);
        }

        public async void ImageCommand(object sender)
        {
            Post postinho = (Post)sender;
            var antigoIndex = ListaNoticia.IndexOf(postinho);

            //Post postinho = ListaNoticia[ListaNoticia.IndexOf(postinho)];         
            ListaNoticia.Remove(postinho);

            if (postinho.Imagem_curtidas == "heartUnselected.png")
            {
                postinho.Imagem_curtidas = "heartSelected.png";
                postinho.Qtd_curtidas = postinho.Qtd_curtidas + 1;
            }
            else
            {
                postinho.Imagem_curtidas = "heartUnselected.png";
                postinho.Qtd_curtidas = postinho.Qtd_curtidas - 1;
            }
            ListaNoticia.Insert(antigoIndex, postinho);
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
