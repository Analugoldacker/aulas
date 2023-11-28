using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            List<Contato> contatos = new();
            contatos.Add(new Contato() { Id = 1, Nome = "analú", Email = "analu@gmail.com" });
            contatos.Add(new Contato() { Id = 2, Nome = "júlio", Email = "juio@gmail.com" });
            contatos.Add(new Contato() { Id = 3, Nome = "allana", Email = "allana@gmail.com" });

            return View(contatos);
        }
        public IActionResult UmContato()
        { 
                    return View(new Contato() { Id = 1, Nome = "analú", Email = "analu@gmail.com" });
        }
    }
}
