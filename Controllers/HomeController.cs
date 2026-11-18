using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {   
        // a view Index lê essa cjabe para exibir o valor da mensagem
        ViewData["Mensagem"] = "Bem vindo ao sistema!";
        return View();
    }

    //Action que recebe parametro pela: /Home/Sobre/5
    public IActionResult Sobre(int? id)
    {
        // id pode ser nulo porque o trecho final da rota é opcional
        ViewBag.Versao = "1.0";
        ViewBag.ParametroId = id;
        return View();
    }

    // Action que recebe parametro da query strung: /Home/Saudacao? nome=Kessia
    public IActionResult Saudacao(string nome)
    {
        ViewData["Nome"] = nome ?? "Visitante";
        return View();
    }
}
