using AppTurmas.Model;
using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AppTurmas.Util
{
    public class MenssagemDataTemplateSelector : DataTemplateSelector
    {
       
            public DataTemplate MinhasMenssagensTamplate { get; set; }
            public DataTemplate MenssagensOutrasPessoasTemplate { get; set; }

            protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
            {
                if(((Menssagem)item).User.Nome == "Ricardo")
                {
                    return MinhasMenssagensTamplate;
                }
                else
                {
                    return MenssagensOutrasPessoasTemplate;
                }
                //return ((Menssagem)item).User.Nome == "Ricardo" ? MinhasMenssagensTamplate : MenssagensOutrasPessoasTemplate;
            //return ((Menssagem)item).User.Id_user == App.Usuario.Id_user ? MinhasMenssagensTamplate : MenssagensOutrasPessoasTemplate;
            }
        
    }
}
