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

        public double GetBonificacao()
        {
            return this.Salario * 1.15;
        }
    }
}
