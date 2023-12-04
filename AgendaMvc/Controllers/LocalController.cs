using AgendaMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.ConstrainedExecution;

namespace AgendaMvc.Controllers
{
    public class LocalController : Controller
    {
        public IActionResult Index()
        {
            return View(Dados.Db.locais);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Models.Local local)
        {
            local.Id = Dados.Db.locais.Max(l => l.Id);
            Dados.Db.locais.Add(local);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(int? id)
        {
            Models.Local local = Dados.Db.locais.FirstOrDefault(lc => lc.Id == id);
            return View(local);
        }

        [HttpPost]
        public IActionResult Edit(Models.Local local)
        {
            Models.Local loc = Dados.Db.locais.FirstOrDefault(lc => lc.Id == local.Id);
            loc.Nome = local.Nome;
            loc.Rua = local.Rua;
            loc.Numero = local.Numero;
            loc.Bairro = local.Bairro;
            loc.Cidade = local.Cidade;
            loc.CEP = local.CEP;
            loc.UF = local.UF;
            return RedirectToAction("Index");
        }
        
        [HttpGet]
        public IActionResult Details(int? id)
        {
            Models.Local local = Dados.Db.locais.FirstOrDefault(lc => lc.Id == id);
            return View(local);

        }
    }
}
