using Aula10.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aula10.Controllers
{
    public class TreinamentosController : Controller
    {
        private TreinamentoContext db = new TreinamentoContext();
        public ActionResult Index()
        {
            return View(db.Treinamentos.ToList());
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(Treinamento treinamento)
        {
            if (ModelState.IsValid)
            {
                db.Treinamentos.Add(treinamento);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

                return View(treinamento);
        }

        protected override void Dispose(bool disposing)
        {
            if(disposing)
            {
                db.Dispose();
            }

            base.Dispose(disposing);
        }
    }
}