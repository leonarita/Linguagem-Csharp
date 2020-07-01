using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _68_RecursosHumanos.Models
{
    [MetadataType(typeof(FuncionarioMetadado))]
    public partial class Funcionario { }

    public class FuncionarioMetadado
    {
        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(30, MinimumLength = 3, ErrorMessage = "Este campo deve ter entre 3 e 30 caracteres.")]
        [DisplayName("Nome")]
        //[RegularExpression(@"^[a-zA-Z\s]$", ErrorMessage = "Este campos não aceita números nem caracteres especiais.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [Display(Name = "CPF")]
        [RegularExpression(@"^\d{3}.\d{3}.\d{3}-\d{2}$", ErrorMessage = "Este CPF não é válido. Inclua todos os caracteres do CPF.")]
        [System.Web.Mvc.Remote("CpfNaoExiste", "Funcionario", ErrorMessage ="Este CPF já está cadastrado no banco de dados.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(30, MinimumLength = 5, ErrorMessage = "Este campo deve ter entre 5 e 30 caracteres.")]
        [Display(Name = "Endereço")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Este campo deve ter entre 3 e 20 caracteres.")]
        [Display(Name = "Cidade")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Este campo deve ter entre 3 e 20 caracteres.")]
        [DisplayName("E-mail")]
        [EmailAddress(ErrorMessage = "Este formato de email não é válido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [DisplayName("Data de Admissão")]
        [DataType(DataType.Date)]
        public DateTime DataAdmissao { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [DisplayName("Dependentes")]
        [Range(0, 5, ErrorMessage = "Este campo aceita apenas valores entre 0 e 5.")]
        public int Dependentes { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Este campo deve ter entre 6 e 12 caracteres.")]
        [DisplayName("Senha")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório.", AllowEmptyStrings = false)]
        [StringLength(12, MinimumLength = 6, ErrorMessage = "Este campo deve ter entre 6 e 12 caracteres.")]
        [DisplayName("Confirmar Senha")]
        [DataType(DataType.Password)]
        [Compare("Senha", ErrorMessage = "Senhas não correspondentes.")]
        public string ConfirmarSenha { get; set; }
    }
}