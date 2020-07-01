using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _68_RecursosHumanos.Models
{
    public partial class Funcionario
    {
        [Key]
        public int IDFuncionario { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereco { get; set; }
        public string Cidade { get; set; }
        public string Email { get; set; }
        public DateTime DataAdmissao { get; set; }
        public int Dependentes { get; set; }
        public string Senha { get; set; }
        public string ConfirmarSenha { get; set; }
    }
}