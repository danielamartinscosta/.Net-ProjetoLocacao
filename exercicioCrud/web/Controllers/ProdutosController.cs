using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Negocio.Models;


namespace web.Controllers;

public class ProdutosController : Controller
{

    public IActionResult Index()
    {
        ViewBag.produtos = Produto.Todos();
        return View();
    }


    public IActionResult Novo()
    {
        return View();
    }


    public IActionResult Cadastrar([FromForm] Produto produto)
    {
        if (string.IsNullOrEmpty(produto.Nome))
        {
            ViewBag.erro = "O nome não pode ser vazio";
            return View();
        }

        produto.Salvar();
        return Redirect("/produtos");
    }


    [Route("/produtos/{id}/deletar")]

    
    public IActionResult Apagar([FromRoute] int id)
    {
        Produto.ApagarPorId(id);
        return Redirect("/produtos");
    }
}


