
using PlezuriSchoolManagement;
using System.Runtime.ConstrainedExecution;

List<Escola> listaEscolas = new List<Escola>();

Console.WriteLine("Olá. Seja bem vindo@ ao Plézuri School Management App!");
Console.WriteLine("Digite um valor relativo a opção do menu abaixo:");

Console.WriteLine("Menu:");
Console.WriteLine("1. Escolas - Cadastrar nova Escola");
Console.WriteLine("2. Escolas - Editar uma Escola");
Console.WriteLine("3. Escolas - Deletar uma Escola");
Console.WriteLine("4. Alunos - Cadastrar nov@ Alun@");
Console.WriteLine("5. Alunos - Editar um Alun@");
Console.WriteLine("6. Alunos - Deletar um Escol@");

int opcao = int.Parse(Console.ReadLine());

switch (opcao) {
    case 1:
        CriarEscola();
    break;
    //case 2:
    //    escola.EditarCadastro();
    //break;
    //case 3:
    //    escola.DeletarEscola();
    //break;
    //case 4:
    //    Aluno aluno = new Aluno();
    //break;
    //case 5:
    //    aluno.EditarAluno();
    //break;
    //case 6:
    //    aluno.DeletarALuno();
    //break;
}

void CriarEscola()
{
    Console.WriteLine("Digite os dados a seguir para a nova escola.");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Descrição: ");
    string descricao = Console.ReadLine();
    Console.Write("Endereço: ");
    string endereco = Console.ReadLine();
    Console.Write("Estado: ");
    string estado = Console.ReadLine();
    Console.Write("Cidade: ");
    string cidade = Console.ReadLine();
    Console.Write("CEP: ");
    int cep = int.Parse(Console.ReadLine());
    Console.Write("Tipo: ");
    string tipo = Console.ReadLine();
    listaEscolas.Add(new Escola(nome, descricao, endereco, estado, cidade, cep, tipo));

    Console.WriteLine("Escola criada: " + listaEscolas.Last().Nome);
}