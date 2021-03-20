using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace printWayy_cine.Models
{
    public class Filme
    {
        public int id { get; set; }
        public string titulo { get; set; }
        public string urlImagem { get; set; }
        public string descricao { get; set; }
        public float duracao { get; set; }

        public override string ToString()
        {
            return $@"Id: {id} Titulo {titulo} ";
        }
    }
}