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



    [Route("/produtos/{id}/editar")]

    public IActionResult Editar([FromRoute] int id)
    {

        ViewBag.produto = Produto.BuscaPorId(id);
        return View();
    }

    


    [Route("/produtos/{id}/atualizar")]

    public IActionResult Atualizar([FromForm] int id, [FromForm] Produto produto)
    {

        produto.Id = id;
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


