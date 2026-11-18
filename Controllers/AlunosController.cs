
using Microsoft.AspNetCore.Mvc;
using PrimeiroProjetoMVC.Models;

namespace PrimeiroProjetoMVC.Controllers
{
    public class AlunosController : Controller
    {
        private static List<Aluno> _alunos = new()
        {
            new Aluno { Id = 1, Nome = "Ronaldo", Email = "fenomeno@gmail.com", Idade = 50},
            new Aluno {Id = 2, Nome = "Cafu", Email = "cafu@hotmail.com", Idade = 56}
        };

        // GET /Alunos - Listar todos os alunos
        public IActionResult Index()
        {
            return View(_alunos);
        }

        // GET /Alunos/Detalhes/1 - Mostrar um aluno especifico
        public IActionResult Detalhes(int id)
        {
            var aluno = _alunos.FirstOrDefault(a => a.Id == id);
            if(aluno == null)
            {
                return NotFound();
            }

            return View(aluno);
        }

        // GET /Alunos/Criar - retornar a View de Criação de Alunos
        [HttpGet]
        public IActionResult Criar()
        {
            return View();
        }

        // POST /Alunos/Criar - recebe dados da View Criar()
        [HttpPost]
        public IActionResult Criar(Aluno aluno)
        {
            if(!ModelState.IsValid)
            {
                return View(aluno);
            }

            // if(_alunos.Any())
            // {
            //     aluno.Id = _alunos.Max(a => a.Id) + 1;
            // }
            // else
            // {
            //     aluno.Id = 1;
            // }

            aluno.Id = _alunos.Any() ? _alunos.Max(a => a.Id) + 1 : 1; // Ternario
            _alunos.Add(aluno);

            return RedirectToAction("Index");
        }

    }
}