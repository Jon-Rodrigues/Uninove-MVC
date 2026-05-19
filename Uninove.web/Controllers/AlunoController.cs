using Microsoft.AspNetCore.Mvc;

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