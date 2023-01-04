using Negocio.Models;

namespace ConsoleApp.UI;

internal class MensagensUI
{
    public static void Mensagem(string mensagem, int timer = 2000)
    {
        

        Console.Clear();
        Console.WriteLine(mensagem);
        Thread.Sleep(timer);
        Console.Clear();

    }
}