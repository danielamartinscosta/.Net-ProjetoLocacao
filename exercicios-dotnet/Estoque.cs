/*Seu Roberto é um comerciante e precisa de um sistemas para armazenar os produtos do seu aramzem

Crie um programa que tenha um menu mostrando as opções de cadastro.

1 - Cadastrar produto
2 - Listar produtos cadastrados
3 - Quantidade total de itens no estoque
4 - Sair

No produto, terá os atributos 
-id
-nome
-quantidade
*/
using Estoque;

class Program
{
    private static void Main(string[] args)
    {
        var produtos = new List<Produto>();


        while (true)
        {
            Console.Clear();
            Console.WriteLine("===========[Seja bem vindo ao estoque]=============");
            Console.WriteLine("1 - Cadastrar produto");
            Console.WriteLine("2 - Listar produtos cadastrados");
            Console.WriteLine("3 - Quantidade total de itens no estoque");
            Console.WriteLine("4 - Sair");
            Console.WriteLine("======================================");
            var opcao = Console.ReadLine()?.Trim(); // o Trim remove espaços antes e depois
            bool sair = false;

            switch(opcao)
            {
                case "1":
                    cadastrarProduto(produtos);
                    break;
                case "2":
                    listarProdutos(produtos);
                    break;
                case "3":
                    qtdTotal(produtos);
                    break;
                case "4":
                    sair = true;
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Thread.Sleep(2000); //tempo de 2 segundos para voltar para o menu
                    break;
            }
        }

    }

    private static void qtdTotal(List<Produto> produtos)
    {
        Console.Clear();
        if (produtos.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Não há produtos cadastrados");
            Thread.Sleep(1000);
            return;
        }


            foreach (var produto in produtos)
            {
                
                Console.WriteLine($"=======[ Quantidade de {produto.Nome} ]========");

                Console.WriteLine("Quantidade: " + produto.Qtd);
            }
        
        Thread.Sleep(3000);
    }

    private static void listarProdutos(List<Produto> produtos)
    {
        Console.Clear(); // faz com que o menu não apareça junto com a lista

        if (produtos.Count == 0)
        {
            Console.Clear();
            Console.WriteLine("Nenhum produto cadastrado!");
            Thread.Sleep(2000);
            return;
        }
        foreach (var produto in produtos)
        {
            Console.WriteLine("========================");
            Console.WriteLine("Id: " + produto.Id);
            Console.WriteLine("Produto: " + produto.Nome);
            Console.WriteLine("Quantidade: " + produto.Qtd);


        }
        Thread.Sleep(5000);

    }

    private static void cadastrarProduto(List<Produto> produtos)
    {

        var produto = new Produto();
        Console.Clear();
        Console.WriteLine("Digite o id do produto: ");
        produto.Id = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o nome do produto: ");
        produto.Nome = Console.ReadLine();
        Console.WriteLine("Digite a quantidade do produto: ");
        produto.Qtd = Convert.ToInt32(Console.ReadLine());

        produtos.Add(produto);

        Console.Clear();
        Console.WriteLine("Produto cadastrado com sucesso!");
        Thread.Sleep(2000);
    }
}



