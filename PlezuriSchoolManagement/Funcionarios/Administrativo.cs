using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlezuriSchoolManagement.Funcionarios
{
    public class Administrativo : Funcionario
    {
        public Administrativo(string nome, double CPF, double salario) : base(nome, CPF, salario, 2)
        {
        }

        public override double GetBonificacao()
        {
            return base.GetBonificacao() + this.Salario * 0.1;
        }
    }
}
