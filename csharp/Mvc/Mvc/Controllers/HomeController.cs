using Microsoft.AspNetCore.Mvc;
using MVC.Models;
using System.Diagnostics;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Teste()
        {
            List<Contato> contatos = new();
            contatos.Add(new Contato() { Id = 1, Nome = "analú", Email = "analu@gmail.com" });
            contatos.Add(new Contato() { Id = 2, Nome = "júlio", Email = "juio@gmail.com" });
            contatos.Add(new Contato() { Id = 3, Nome = "allana", Email = "allana@gmail.com" });
            return View(contatos);            
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}