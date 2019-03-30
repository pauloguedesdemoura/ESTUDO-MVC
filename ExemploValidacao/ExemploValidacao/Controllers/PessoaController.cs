using ExemploValidacao.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExemploValidacao.Controllers
{
    public class PessoaController : Controller
    {
    
        public ActionResult Index()
        {
            var pessoa = new Pessoa();
            return View(pessoa);
        }

        [HttpPost]
        public ActionResult Index(Pessoa pessoa) {

            /*if (string.IsNullOrEmpty(pessoa.Nome))
            {
                ModelState.AddModelError("Nome", "O Campo nome é obrigatorio");
            }

            if (pessoa.Senha != pessoa.ConfirmarSenha)
            {
                ModelState.AddModelError("", "As senha não conferem");
            }*/


            if (ModelState.IsValid)
            {
                return View("Resultado", pessoa);
            }
            return View(pessoa);
        }

        public ActionResult Resultado(Pessoa pessoa) {

            return View(pessoa);

        }


        public ActionResult LoginUnico(string login) {

            var bacnoDeNome = new Collection<string>
            {
                "Cleyton",
                "Anderson",
                "Renata"
            };
            return Json(bacnoDeNome.All(x => x.ToLower() != login.ToLower()),JsonRequestBehavior.AllowGet);
        }



    }
}