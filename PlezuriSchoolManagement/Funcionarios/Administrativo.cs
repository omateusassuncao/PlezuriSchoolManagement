using PlezuriSchoolManagement.Autenticacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlezuriSchoolManagement.Funcionarios
{
    public class Administrativo : Funcionario, IAutenticador
    {
        public Administrativo(string nome, double CPF, double salario, string senha) : base(nome, CPF, salario, 2)
        {
            this.Senha = senha;
        }

        public string Senha { get; set ; }

        public bool Autenticar(string senha)
        {
            return senha == this.Senha;
        }

        public override double GetBonificacao()
        {
            return this.Salario * 1.1;
        }
    }
}
