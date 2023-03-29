using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlezuriSchoolManagement.Funcionarios
{
    public class Funcionario
    {
        public Funcionario(string nome, int cpf, double salario, int tipo)
        {
            this.Nome = nome;
            this.CPF = cpf;
            this.Salario = salario;
            this.Tipo = tipo;
            TotalDeFuncionarios++;
        }

        public string Nome { get; set; }
        public int CPF { get; set; } 
        public double Salario { get; set; }
        public int Tipo { get; set; }
        public static int TotalDeFuncionarios { get; private set; }

        public virtual double GetBonificacao()
        {
            return this.Salario;
        }
    }
}
