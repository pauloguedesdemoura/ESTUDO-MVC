using RotasMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RotasMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEnumerable<Noticia> TodasNoticias;

        public ActionResult Index()
        {
            var ultilmasNoticias = TodasNoticias.Take(3);

            var todasCategoria = TodasNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasCategoria;

            return View(ultilmasNoticias);
        }

        public ActionResult TodasAsNoticias() {
            return View(TodasNoticias);
        }

        public ActionResult MostraNoticia(int NoticiaId, string titulo, string categoria ) {

            return View(TodasNoticias.FirstOrDefault(x => x.NoticiaId == NoticiaId));
        }




        public HomeController() {
            TodasNoticias = new Noticia().TodasNoticias().OrderByDescending(n => n.Data);
        }

    }
}