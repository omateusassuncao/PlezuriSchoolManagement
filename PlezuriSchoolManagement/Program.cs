using PlezuriSchoolManagement.Locais;
using System.Runtime.ConstrainedExecution;

List<Escola> listaEscolas = new List<Escola>();

Console.WriteLine("Olá. Seja bem vindo@ ao Plézuri School Management App!");

while (ShowMenu());

void EditarCadastroEscola()
{
    Console.WriteLine("Escolha uma escola:");
    int i = 1;
    foreach (Escola escola in listaEscolas)
    {
        Console.WriteLine(i + " " + escola.Nome);
        i++;
    }
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

bool ShowMenu()
{
    Console.WriteLine("Digite um valor relativo a opção do menu abaixo:");

    Console.WriteLine("Menu:");
    Console.WriteLine("1. Escolas - Cadastrar nova Escola");
    Console.WriteLine("2. Escolas - Editar uma Escola");
    Console.WriteLine("3. Escolas - Deletar uma Escola");
    Console.WriteLine("4. Alunos - Cadastrar nov@ Alun@");
    Console.WriteLine("5. Alunos - Editar um Alun@");
    Console.WriteLine("6. Alunos - Deletar um Escol@");
    Console.WriteLine("0. SAIR");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
        case 1:
            CriarEscola();
            return true;
        break;
        case 2:
            EditarCadastroEscola();
            return true;
        break;
        //case 3:
        //    escola.DeletarEscola();
        //    return true;
        //break;
        //case 4:
        //    Aluno aluno = new Aluno();
        //    return true;
        //break;
        //case 5:
        //    aluno.EditarAluno();
        //    return true;
        //break;
        //case 6:
        //    aluno.DeletarALuno();
        //    return true;
        //break;
        default:
            return false;
        break;
    }
}