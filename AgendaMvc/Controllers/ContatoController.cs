using AgendaMvc.Models;
using Microsoft.AspNetCore.Mvc;
using AgendaMvc.Dao;

namespace MVC.Controllers
{
    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            /* List<Contato> contatos = new();
             contatos.Add(new Contato() { Id = 1, Nome = "analú", Email = "analu@gmail.com" });
             contatos.Add(new Contato() { Id = 2, Nome = "júlio", Email = "juio@gmail.com" });
             contatos.Add(new Contato() { Id = 3, Nome = "allana", Email = "allana@gmail.com" });*/

            return View(new DaoContato().consultar());
        }
        public IActionResult UmContato()
        {
            return View(new Contato() { Id = 1, Nome = "analú", Email = "analu@gmail.com" });
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contato contato)
        {
            if (new DaoContato().salvar(contato))
            {
                return RedirectToAction("Index");
            }

            return View();
        }
        
        [HttpGet]
        public IActionResult Edit(int? id)
        {
            //Contato contato = Dados.Db.contatos.FirstOrDefault(ct => ct.Id == id);
            Contato contato = new DaoContato().consultar((int)id);
            return View(contato);
        }

        [HttpPost]
        public IActionResult Edit(Contato contato)
        {
            Contato cont = new DaoContato().consultar(contato.Id);
            cont.Nome = contato.Nome;
            cont.Email = contato.Email;
            cont.Telefone = contato.Telefone;
            if(new DaoContato().alterar(cont))
               return RedirectToAction("Index");
            else
                return View(cont);
        }
        [HttpGet]
        public IActionResult Details(int? id)
        {
            Contato contato = new DaoContato().consultar((int)id);
            return View(contato);
        }   
        public IActionResult Delete(int? id)
        {
            new DaoContato().excluir((int)id);

            return RedirectToAction("Index");

        }
    }
}

