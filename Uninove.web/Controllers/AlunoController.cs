using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Uninove.web.Models;

namespace Uninove.web.Controllers;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Jonatas";
        ViewBag.Curso = "ADS";
        ViewBag.Semestre = "1ºSemestre";

        return View();
    }

    public IActionResult Detalhes(int id)
    {
        ViewBag.Alunoid = id;
        return View();
    }

}