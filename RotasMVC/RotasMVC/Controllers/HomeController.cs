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
        public ActionResult Index()
        {
            var ultilmasNoticias = TodasNoticias.Take(3);

            var todasCategoria = TodasNoticias.Select(x => x.Categoria).Distinct().ToList();

            ViewBag.Categorias = todasCategoria;

            return View(ultilmasNoticias);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {            ViewBag.Message = "Your contact page.";

            return View();
        }
        private readonly IEnumerable<Noticia> TodasNoticias;

        public HomeController() {
            TodasNoticias = new Noticia().TodasNoticias().OrderByDescending(n => n.Data);
        }

    }
}