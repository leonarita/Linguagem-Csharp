using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _66_Forum.Models
{
    public class Assunto
    {
        [Key]
        public int IdAssunto { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public ICollection<Topico> Topico { get; set; }
    }
}