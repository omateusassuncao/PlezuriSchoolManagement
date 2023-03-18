using PlezuriSchoolManagement.Personas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
        private List<Aluno> Alunos { get; set; }


        public void AddAluno(Aluno aluno)
        {

            Alunos.Add(aluno);

        }

        public void RemoveAluno(Aluno aluno)
        {

            Alunos.Remove(aluno);

        }

        internal void EditarEscola()
        {
            ShowDadosEscola();
            Console.WriteLine("Qual dado vocês quer editar?");
            Console.WriteLine("1. Nome");
            Console.WriteLine("2. Descrição");
            Console.WriteLine("3. Endereço");
            Console.WriteLine("4. Estado");
            Console.WriteLine("5. Cidade");
            Console.WriteLine("6. CEP");
            Console.WriteLine("7. Tipo");
            
            switch (int.Parse(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("Digite novo valor do NOME:");
                    this.Nome = Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Digite novo valor do DESCRIÇÃO:");
                    this.Descricao = Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Digite novo valor do ENDEREÇO:");
                    this.Endereco = Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Digite novo valor do ESTADO:");
                    this.Estado = Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Digite novo valor do CIDADE:");
                    this.Cidade = Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Digite novo valor do CEP:");
                    this.CEP = int.Parse(Console.ReadLine());
                    break;
                case 7:
                    Console.WriteLine("Digite novo valor do TIPO:");
                    this.Tipo = Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Valor incorreto selecionado");
                    break;

            }
        }

        private void ShowDadosEscola()
        {
            Console.WriteLine("Dados da escola:");
            Console.WriteLine("Nome: " + this.Nome);
            Console.WriteLine("Nome: " + this.Descricao);
            Console.WriteLine("Nome: " + this.Endereco);
            Console.WriteLine("Nome: " + this.Estado);
            Console.WriteLine("Nome: " + this.Cidade);
            Console.WriteLine("Nome: " + this.CEP);
            Console.WriteLine("Nome: " + this.Tipo);
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
