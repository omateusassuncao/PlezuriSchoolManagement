using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlezuriSchoolManagement.Funcionarios
{
    public class Funcionario
    {
        public Funcionario(string nome, double CPF, double salario, int tipo)
        {
            this.Nome = nome;
            this.CPF = CPF;
            this.Salario = salario;
            this.Tipo = tipo;
            TotalDeFuncionarios++;
        }

        public string Nome { get; set; }
        public double CPF { get; set; } 
        public double Salario { get; set; }
        public int Tipo { get; set; }
        public static int TotalDeFuncionarios { get; private set; }

        public virtual double GetBonificacao()
        {
            return this.Salario;
        }
    }
}
