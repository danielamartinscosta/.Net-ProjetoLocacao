using ConsoleApp.UI;

while (true)
{
    Console.WriteLine("1 - Cadastrar Produto ");
    Console.WriteLine("2 - Atualizar Produto ");
    Console.WriteLine("3 - Listar Produtos ");
    Console.WriteLine("4 - Sair ");

    var sair = false;
    var opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            ProdutosUI.CadastrarProduto();
            break;
        case "":
            ProdutosUI.AtualizarProduto();
            break;
        case "3":
            ProdutosUI.ListarProduto();
            break;
        default:
            sair = true;
            break;

    }
    if (sair) break;

}
