using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlezuriSchoolManagement.Autenticacao;



namespace PlezuriSchoolManagement.Parceria
{
    public class ParceiroComercial : IAutenticador
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Senha { get; set; }

        public ParceiroComercial(string nome, string descricao, string senha)
        {
            Nome = nome;
            Descricao = descricao;
            Senha = senha;
        }

        public bool Autenticar(string senha) 
        {
            return this.Senha == senha;
        }
    }
}
