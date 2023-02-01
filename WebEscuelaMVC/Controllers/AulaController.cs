using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebEscuelaMVC.Data;
using WebEscuelaMVC.Models;

namespace WebEscuelaMVC.Controllers
{
    public class AulaController : Controller
    {
        private readonly EscuelaDBMVC context;

        public AulaController(EscuelaDBMVC context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var aula = context.Aulas.ToList();
            return View(aula);
        }


        [HttpGet]
        public ActionResult Create()
        {
            Aula aula = new Aula();
            return View("Create", aula);
        }

        [HttpPost]
        public ActionResult Create(Aula aula)
        {
            if (ModelState.IsValid)
            {
                context.Aulas.Add(aula);
                context.SaveChanges();
                return RedirectToAction("Index", aula);
            }
            return View(aula);
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Aula aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("Details", aula);
            }
        }



        private Aula TraerUna(int id)
        {
            return context.Aulas.Find(id);
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("Delete", aula);
            }

        }

        [ActionName("Delete")]
        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            Aula aula = TraerUna(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                context.Aulas.Remove(aula);
                context.SaveChanges();
                return RedirectToAction("Index");
            }

        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var aula = context.Aulas.Find(id);
            if (aula == null)
            {
                return NotFound();
            }
            else
            {
                return View("Edit", aula);
            }
        }


        [ActionName("Edit")]
        [HttpPost]
        public ActionResult EditConfirmed (int id) {

            Aula aula = TraerUna(id);
            context.Entry(aula).State = EntityState.Modified;
            context.SaveChanges();

            return RedirectToAction("Index");
        }


    }
}
