using System.Globalization;
using Negocio.Models;

namespace ConsoleApp.UI;

internal class ProdutosUI
{
    public static void CadastrarProduto()
    {
        var produto = new Produto();
        Console.WriteLine("=======[ Cadastro de Produtos]==============");
        Console.WriteLine("Nome: ");
        produto.Nome = Console.ReadLine();
        Console.WriteLine("Descrição: ");
        produto.Descricao = Console.ReadLine();
        Console.WriteLine("Data da criação: ");
        produto.DataCriacao = DateTime.Now;
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("Data de validade: ");
        produto.DataValidade = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Quantidade: ");
        produto.QuantidadeEstoque = Convert.ToInt32(Console.ReadLine());

        produto.Salvar();


        MensagensUI.Mensagem("Produto cadastrado com sucesso!");


    }

    internal static void AtualizarProduto()
    {


        Console.WriteLine("=======[ Atualização de Produtos]==============");
        Console.WriteLine("Digite o ID ou o nome do produto");
        var idOuNome = Console.ReadLine();

        if (string.IsNullOrEmpty(idOuNome))
        {
            MensagensUI.Mensagem("Digite o Id ou o Nome");
            ProdutosUI.AtualizarProduto();  //FUNÇÃO RECURSIVA
            return;
        }


        var produtos = Produto.BuscaPorIdOuNome(idOuNome);

        if (produtos.Count == 0)
        {
            MensagensUI.Mensagem("Produto não localizado");
            ProdutosUI.AtualizarProduto();  //FUNÇÃO RECURSIVA
            return;
        }


        Console.WriteLine("Digite o Id do produto abaixo para atualizar");

        foreach (var produtoDb in produtos)
        {
            Console.WriteLine("Id: " + produtoDb.Id);
            Console.WriteLine("Nome: " + produtoDb.Nome);
            Console.WriteLine("Descrição: " + produtoDb.Descricao);
            Console.WriteLine("Data de Criação: " + produtoDb.DataCriacao);
            Console.WriteLine("Data de validade: " + produtoDb.DataValidade);
            Console.WriteLine("Quantidade em estoque: " + produtoDb.QuantidadeEstoque);
            Console.WriteLine("----------------------------");
        }



        var produto = new Produto();
        produto.Id = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Novo Nome: ");
        produto.Nome = Console.ReadLine();
        Console.WriteLine("NOva Descrição: ");
        produto.Descricao = Console.ReadLine();
        Console.WriteLine("Nova Data de criação: ");
        produto.DataCriacao = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Nova Data de validade: ");
        produto.DataValidade = Convert.ToDateTime(Console.ReadLine());
        Console.WriteLine("Nova Quantidade: ");
        produto.QuantidadeEstoque = Convert.ToInt32(Console.ReadLine());


        produto.Salvar();



        Console.Clear();
        Console.WriteLine("Produto atualizado com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        //MensagensUI.Mensagem("Produto cadastrado com sucesso!");

    }

    internal static void ListarProduto()
    {
        Console.WriteLine("====== Lista de produtos ========");
        var produtos = Produto.Todos();
        foreach (var produtoDb in produtos)
        {
            Console.WriteLine("Id: " + produtoDb.Id);
            Console.WriteLine("Nome: " + produtoDb.Nome);
            Console.WriteLine("Descrição: " + produtoDb.Descricao);
            Console.WriteLine("Data de Criação: " + produtoDb.DataCriacao.ToString("dd/MM/yyyy"));
            Console.WriteLine("Data de validade: " + produtoDb.DataValidade.ToString("dd/MM/yyyy"));
            Console.WriteLine("Quantidade em estoque: " + produtoDb.QuantidadeEstoque);
            Console.WriteLine("----------------------------");
        }
    }
}