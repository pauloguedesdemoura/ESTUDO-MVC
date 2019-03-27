using PostGetModel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PostGetModel.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            pessoa.PessoaID = 2;
            pessoa.Nome = "Paulinho";
            pessoa.Twitter = "NadaVer";

            ViewBag.PessoaId = pessoa.PessoaID;
            ViewBag.NomePessoa = pessoa.Nome;
            ViewData["Twitter"] = pessoa.Twitter;

            var pessoa2 = new Pessoa();
            pessoa2.PessoaID = 3;
            pessoa2.Nome = "Pauleta";
            pessoa2.Twitter = "Tudo aver";


            return View(pessoa2);
        }

        [HttpPost]
        public ActionResult Lista(Pessoa pessoa) {

  

            return View(pessoa);

        }

    }
}