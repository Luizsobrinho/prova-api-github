using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGit.Models
{
    public class Favorito
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Linguagem { get; set; }
        public string DataUltimoUpdate { get; set; }
        public string UrlHtml { get; set; }
    }
}
