using Aula10.Models;
using System.Linq;
using System.Web.Mvc;

namespace Aula10.Controllers
{
    public class UsuariosController : Controller
    {
        private UsuarioContext db = new UsuarioContext();
        public ActionResult Index()
        {
            return View(db.Usuarios.ToList());
        }

        public ActionResult Incluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Incluir(Usuario usuario) 
        {
            if(ModelState.IsValid)
            {
                db.Usuarios.Add(usuario);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(usuario);
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