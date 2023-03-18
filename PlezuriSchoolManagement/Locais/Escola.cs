using PlezuriSchoolManagement.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlezuriSchoolManagement.Locais
{
    internal class Escola
    {
        public Escola(string nome, string descricao, string endereco, string estado, string cidade, int cEP, string tipo)
        {
            Nome = nome;
            Descricao = descricao;
            Endereco = endereco;
            Estado = estado;
            Cidade = cidade;
            CEP = cEP;
            Tipo = tipo;
        }

        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Endereco { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public int CEP { get; set; }
        public string Tipo { get; set; }
        public List<Aluno> Alunos { get; set; }


        public void AddAluno(Aluno aluno)
        {

            Alunos.Add(aluno);

        }

        public void RemoveAluno(Aluno aluno)
        {

            Alunos.Remove(aluno);

        }

        internal void showAlunos()
        {


            Console.WriteLine("Lista de alunos da escola " + Nome + ": ");
            for (int i = 0; i < Alunos.LongCount(); i++)
            {
                Console.WriteLine("Aluno " + i + 1 + ": " + Alunos[i].Nome);
            }
        }
    }
}
