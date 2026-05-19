using Microsoft.AspNetCore.Mvc;

public class AlunoController : Controller
{
    public IActionResult Index()
    {
        ViewBag.Nome = "Nome";
        ViewBag.Curso = "Curso";
        ViewBag.Semestre = "Semestre";

        return View();
    }

    public IActionResult Detalhes(int id)
    {
        ViewBag.Aluno = id;
        return View();
    }

}