using System.IO;


class Program
{

    private static void Main(string[] args)
    {

        var fornecedores = new List<Fornecedor>();
        var usuarios = new List<Usuario>();
        var json = File.ReadAllText(AppDomain.CurrentDomain.BaseDirectory + @"Import\cadastros.json");



        while (true)
        {
            Console.Clear();
            Console.WriteLine("===========[Seja bem vindo ao Sistema de Cadastro]=============");
            Console.WriteLine("1 - Cadastrar pessoa física");
            Console.WriteLine("2 - Cadastrar pessoa juridica");
            Console.WriteLine("3 - Listar cadastros");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("======================================");
            var opcao = Console.ReadLine()?.Trim(); // o Trim remove espaços antes e depois
            //var sair = false;

            switch (opcao)
            {
                case "1":
                    cadastrarPessoaFisica(usuarios);
                    break;
                case "2":
                    cadastrarPessoaJuridica(fornecedores);
                    break;
                case "3":
                    listarCadastros(fornecedores, usuarios);
                    break;
                case "4":
                    //sair = true;
                    System.Console.WriteLine("============Sistema encerrado============");
                    System.Environment.Exit(0); //encerra o sistema
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(2000); //tempo de 2 segundos para voltar para o menu
                    break;
            }
        }

    }

    private static void listarCadastros(List<Fornecedor> fornecedores, List<Usuario> usuarios)
    {
         Console.Clear(); // faz com que o menu não apareça junto com a lista

        if (usuarios.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Nenhuma pessoa cadastrada!");
            Thread.Sleep(2000);
            return;
        }
        foreach (var usuario in usuarios)
        {
            Console.WriteLine("========================");
            Console.WriteLine("Id: " + usuario.Id);
            Console.WriteLine("Nome: " + usuario.Nome);
            Console.WriteLine("CPF: " + usuario.Documento);
            Console.WriteLine("Tipo: " + usuario.Tipo);

        }
        Thread.Sleep(5000);
    }

    private static void cadastrarPessoaJuridica(List<Fornecedor> fornecedores)
    {
        var fornecedor = new Fornecedor();
        Console.Clear();
        Console.WriteLine("\nDigite o id do fornecedor: ");
        fornecedor.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nDigite a Razão social: ");
        fornecedor.Nome = Console.ReadLine();
        Console.WriteLine("\nDigite o CNPJ de: " + fornecedor.Nome);
        fornecedor.Documento = Console.ReadLine();

        fornecedores.Add(fornecedor); // se tudo estiver certo, adiciona o fornecedor na lista de fornecedores

        Console.Clear();
        Console.WriteLine("\nPessoa Jurídics cadastrada com sucesso!");
        Thread.Sleep(2000);
    }


    private static void cadastrarPessoaFisica(List<Usuario> usuarios)
    {

        var usuario = new Usuario();
        Console.Clear();
        Console.WriteLine("Digite o id da pessoa: ");
        usuario.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("\nDigite o nome da pessoa que deseja cadastrar: ");
        usuario.Nome = Console.ReadLine();
        Console.WriteLine("\nDigite o CPF de : " + usuario.Nome + " sem pontos");
        usuario.Documento = Console.ReadLine();

        usuarios.Add(usuario);

        Console.Clear();
        Console.WriteLine("\nPessoa Física cadastrada com sucesso!");
        Thread.Sleep(2000);
    }
}

