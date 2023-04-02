#region 
//Essa é uma aplicação em C# com o intuito de aprender sobre a linguagem utilizando o 
//da
#endregion

using PlezuriSchoolManagement.Funcionarios;
using PlezuriSchoolManagement.Locais;
using PlezuriSchoolManagement.Parceria;
using System.Runtime.ConstrainedExecution;

List<Escola> listaEscolas = new List<Escola>();
List<ParceiroComercial> listaParceiro = new List<ParceiroComercial>();

Console.WriteLine("Olá. Seja bem vindo@ ao Plézuri School Management App!");

while (ShowMenu()) ;

Escola SelecionaEscola()
{
    Console.WriteLine("Escolha uma das " + Escola.TotalDeEscolas + " escolas:");
    int i = 1;
    foreach (Escola escola in listaEscolas)
    {
        Console.WriteLine(i + " " + escola.Nome);
        i++;
    }
    int o = int.Parse(Console.ReadLine()) - 1;
    return listaEscolas[o];
}

Funcionario SelecionaFuncionario()
{
    Console.WriteLine("Escolha um Funcionário:");
    int i = 1;
    foreach (Escola escola in listaEscolas)
    {
        int j = 1;
        List<Funcionario> lf = escola.Funcionarios;
        foreach (Funcionario funcionario in lf)
        {
            Console.WriteLine(i + "" + j + " :" + funcionario.Nome);
            j++;
        }
        i++;
    }
    int o = int.Parse(Console.ReadLine());
    char[] so = o.ToString().ToCharArray();
    int e = int.Parse(so[0].ToString()) - 1;
    int f = int.Parse(so[1].ToString()) - 1;

    return listaEscolas[e].Funcionarios[f];
}

ParceiroComercial SelecionaParceiro()
{
    Console.WriteLine("Escolha um Parceiro:");
    int i = 1;
    foreach (ParceiroComercial parceiro in listaParceiro)
    {
        Console.WriteLine(i + " " + parceiro.Nome);
        i++;
    }
    int o = int.Parse(Console.ReadLine()) - 1;
    return listaParceiro[o];
}

void EditarCadastroEscola()
{
    Escola e = SelecionaEscola();
    e.EditarEscola();

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


void CriarFuncionario()
{
    Escola e = SelecionaEscola();
    Console.WriteLine("Digite os dados a seguir para o novo funcionário da escola " + e.Nome + " :");
    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("CPF: ");
    double CPF = int.Parse(Console.ReadLine());
    Console.WriteLine("Tipo: (1:Professor, 2:Administrativo, 3:Coordenador/Diretor, 4:Assistente/Operação) ");
    int tipo = int.Parse(Console.ReadLine());

    if(tipo == 1)
    {
        Professor funcionario = new Professor(nome, CPF, e.GetSalarioBase());
        e.AddFuncionario(funcionario);
    }
    else if (tipo == 2)
    {
        Console.WriteLine("Senha: ");
        string senha = Console.ReadLine();
        Administrativo funcionario = new Administrativo(nome, CPF, e.GetSalarioBase(), senha);
        e.AddFuncionario(funcionario);
    }
    else
    {

        Console.WriteLine("Você selecionou um tipo que não existe");
    }

    Console.WriteLine("Funcionário criado: " + listaEscolas.Last().Nome + "(escola: " + e.Nome + ")");
}

void CriarParceiroComercial()
{
    Console.WriteLine("Digite os dados a seguir para o novo Parceiro Comercial");
    Console.WriteLine("Nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Descrição: ");
    string descricao = Console.ReadLine();
    Console.WriteLine("senha: ");
    string senha = Console.ReadLine();

    listaParceiro.Add(new ParceiroComercial(nome, descricao, senha));

    Console.WriteLine("Parceiro "+ listaParceiro.Last().Nome + " criado corretamente");
}

void Autenticar()
{
    Console.WriteLine("Qual perfil deseja Autenticar? 1 - Funcionário ou 2 - Parceiro Comercial ? ");
    int opcao = int.Parse(Console.ReadLine());
    string senha = null;
    switch (opcao)
    {
        case 1:
            Funcionario funcionario = SelecionaFuncionario();
            if (funcionario.Tipo == 2)
            {
                Administrativo administrativo = (Administrativo)funcionario;
                Console.WriteLine("Digite a senha:");
                senha = Console.ReadLine();
                if (administrativo.Autenticar(senha)) 
                {
                    Console.WriteLine("Autenticado");
                }
                else 
                {
                    Console.WriteLine("Senha incorreta.");
                }
            }
            else
            {
                Console.WriteLine("Não é um funcionário autenticável");
            }
        break;
        case 2:
            ParceiroComercial parceiro = SelecionaParceiro();
            Console.WriteLine("Digite a senha:");
            senha = Console.ReadLine();
            if (parceiro.Autenticar(senha))
            {
                Console.WriteLine("Autenticado");
            }
            else
            {
                Console.WriteLine("Senha incorreta.");
            }
            break;
        default:
        break;
    }
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
    Console.WriteLine("7. Funcionarios - Cadastrar Funcionari@");
    Console.WriteLine("8. Funcionarios - Editar Funcionari@");
    Console.WriteLine("9. Funcionarios - Deletar Funcionari@");
    Console.WriteLine("10. Parceiro - Criar Parceiro Comercial");
    Console.WriteLine("20 - Autenticar");
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
        case 7:
            CriarFuncionario();
            return true;
        break;
        case 10:
            CriarParceiroComercial();
            return true;
        break;
        case 20:
            Autenticar();
            return true;
        break;
        default:
            return false;
        break;
    }
}