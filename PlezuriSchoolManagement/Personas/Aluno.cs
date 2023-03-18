namespace PlezuriSchoolManagement.Personas
{
    public class Aluno
    {
        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

        public string Nome { get; set; }
        public int Idade { get; set; }
        private List<int> Notas { get; set; }

    }
}