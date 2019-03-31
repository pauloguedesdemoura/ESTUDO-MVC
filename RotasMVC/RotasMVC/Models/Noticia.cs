using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RotasMVC.Models
{
    public class Noticia
    {
        public int NoticiaId { get; set; }
        public string Titulo { get; set; }
        public string Conteudo { get; set; }
        public string Categoria { get; set; }
        [DisplayFormat(DataFormatString = "(0:dd/MM/yyyy)")]
        public DateTime Data { get; set; }

        public IEnumerable<Noticia> TodasNoticias()
        {

            var retorno = new Collection<Noticia>{

                new Noticia
                {
                    NoticiaId = 1,
                    Categoria = "Esportes",
                    Titulo = "Santos perde mais uma",
                    Conteudo = "Dinovo dinovo dinovo",
                    Data = new DateTime(2017,11,10)

                },

                new Noticia
                {
                    NoticiaId = 2,
                    Categoria = "Esportes",
                    Titulo = "Santos perde mais uma",
                    Conteudo = "Dinovo dinovo dinovo",
                    Data = new DateTime(2017, 12, 11)

                },

                new Noticia
                {
                    NoticiaId = 3,
                    Categoria = "Esportes",
                    Titulo = "Sannnntos perde mais uma",
                    Conteudo = "Dinonfdbfgbgfvo dinovo dinovo",
                    Data = new DateTime(2019, 12, 11)

                }
            };

            return retorno;

        }


    }
}