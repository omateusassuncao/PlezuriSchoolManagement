using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlezuriSchoolManagement.Funcionarios
{
    public class Professor : Funcionario
    {
        public Professor(string nome, double CPF, double salario) : base(nome, CPF, salario, 1)
        {
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() + this.Salario * 0.15;
        }
    }
}
