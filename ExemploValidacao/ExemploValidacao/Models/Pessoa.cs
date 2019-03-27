using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ExemploValidacao.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O nome deve ser preenchido")]
        public string Nome { get; set; }

        [StringLength(50, MinimumLength = 5,ErrorMessage = "5 a 50")]
        public string Observacao { get; set; }

        [Range(18,50, ErrorMessage = "Entre 18 e 50")]
        public int Idade { get; set; }

        [RegularExpression(@"/^[a-z0-9.]+@[a-z0-9]+\.[a-z]+\.([a-z]+)?$/i",ErrorMessage = "Email errado")]
        public string Email { get; set; }

        public string Login { get; set; }

        public string Senha { get; set; }

        public string ConfirmarSenha { get; set; }
    }
}



