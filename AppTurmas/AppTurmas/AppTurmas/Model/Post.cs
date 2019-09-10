using System;
using System.Collections.Generic;
using System.Text;

namespace AppTurmas.Model
{
    public class Post
    {
        public int Id_post { get; set; }
        public string Titulo { get; set; }
        public string Texto { get; set; }
        public string Data { get; set; }
        public string Destino { get; set; }
        public string Nome { get; set; }
        public string Imagem { get; set; }
        public int Qtd_curtidas { get; set; }
        public string Imagem_curtidas { get; set; }


        public Post(int id_post, string _titulo, string _texto, string _data, string _imagem, string _nome, int _qtd_curtidas, string _imagem_curtidas)
        {
            Id_post = id_post;
            Nome = _nome;
            Titulo = _titulo;
            Texto = _texto;
            Data = _data;
            Imagem = _imagem;
            Qtd_curtidas = _qtd_curtidas;
            Imagem_curtidas = _imagem_curtidas;
        }
        public Post()
        {

        }
    }
}
