using AgendaMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace AgendaMvc.Controllers
{
    public class CompromissoController : Controller
    {
        public IActionResult Index()
        {
            return View(Dados.Db.compromissos);
        }

        [HttpGet]
        public IActionResult Create()
        {
            List<SelectListItem> Contatos = new List<SelectListItem>();
            Contatos = Dados.Db.contatos.Select(c => new SelectListItem()
            { Text = c.Email, Value = c.Id.ToString() }).ToList();
            ViewBag.Contatos = Contatos;

            List<SelectListItem> Locais = new List<SelectListItem>();
            Locais = Dados.Db.locais.Select(l => new SelectListItem()
            { Text = l.Nome, Value = l.Id.ToString() }).ToList();
            ViewBag.Locais = Locais;

            return View();
        }

        [HttpPost]
        public IActionResult Create(Compromisso compromisso)
        {
            compromisso.Id = Dados.Db.compromissos.Max(c => c.Id) + 1;
            /*Contato ct = Dados.Db.contatos.FirstOrDefault(c => c.Id == compromisso.Contato.Id);
            compromisso.Contato = ct;*/
            compromisso.Contato = Dados.Db.contatos.FirstOrDefault(c => c.Id == compromisso.Contato.Id);

            compromisso.Local = Dados.Db.locais.FirstOrDefault(l => l.Id == compromisso.Local.Id);
            Dados.Db.compromissos.Add(compromisso);
            return RedirectToAction("Index");
        }      
        
    }
}
