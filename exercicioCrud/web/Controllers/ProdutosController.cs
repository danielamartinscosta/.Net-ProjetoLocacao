using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Negocio.Entidades;
using Negocio.Repositorios;


namespace web.Controllers;

public class ProdutosController : Controller
{

    public IActionResult Index()
    {
        ViewBag.produtos = ProdutoRepositorio.Todos();
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

        ProdutoRepositorio.Salvar(produto);
        return Redirect("/produtos");
    }



    [Route("/produtos/{id}/editar")]

    public IActionResult Editar([FromRoute] int id)
    {

        ViewBag.produto = ProdutoRepositorio.BuscaPorId(id);
        return View();
    }

    


    [Route("/produtos/{id}/atualizar")]

    public IActionResult Atualizar([FromForm] int id, [FromForm] Produto produto)
    {

        produto.Id = id;
        ProdutoRepositorio.Salvar(produto);

        return Redirect("/produtos");
    }


    [Route("/produtos/{id}/deletar")]

    public IActionResult Apagar([FromRoute] int id)
    {
        ProdutoRepositorio.ApagarPorId(id);
        return Redirect("/produtos");
    }
}


