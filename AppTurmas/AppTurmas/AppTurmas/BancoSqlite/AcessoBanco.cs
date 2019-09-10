using AppTurmas.Model;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppTurmas.BancoSqlite
{
    public class AcessoBanco
    {
        private SQLiteConnection _conexao;

        public AcessoBanco()
        {
            var dep = DependencyService.Get<ICaminho>();
            string caminho = dep.ObterCaminho("database.sqlite");

            _conexao = new SQLiteConnection(caminho);
            _conexao.CreateTable<Usuario>();
        }

        public List<Usuario> Consultar()
        {
            return _conexao.Table<Usuario>().ToList();
        }
        public List<Usuario> Pesquisar(string palavra)
        {
            return _conexao.Table<Usuario>().Where(a => a.Email.Contains(palavra)).ToList();
        }
        public Usuario ObterUsuarioPorId(int id)
        {
            return _conexao.Table<Usuario>().Where(a => a.Id_user == id).FirstOrDefault();
        }
        public void Cadastro(Usuario user)
        {
            _conexao.Insert(user);
        }
        public void Atualizacao(Usuario user)
        {
            _conexao.Update(user);
        }
        public void Exclusao(Usuario user)
        {
            _conexao.Delete(user);
        }
    }
}
