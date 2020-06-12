using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ApiGit.Models
{
    public class Repositorio
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public string Linguagem { get; set; }
        public string Data { get; set; }
        public string Url { get; set; }
    }
}
