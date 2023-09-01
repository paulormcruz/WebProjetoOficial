using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebProjetoOficial.Models
{
    public class Cliente
    {
        public int CodCliente { get; set; }

        [Display(Name = "Nome do Cliente")]
        [Required(ErrorMessage = "Campo Nome de prenchimento obrigatório")]
        [StringLength(150, MinimumLength = 2)]
        public string Nome { get; set; }

        [Display(Name = "Endereço")]
        [Required(ErrorMessage = "Preencha o campo Endereço")]
        [StringLength(500)]
        public string Endereco { get; set; }

        [Display(Name = "Telefone")]
        [Required(ErrorMessage = "Preencha o campo Telefone")]
        [RegularExpression("(\\(?\\d{2}\\)?\\s)? (\\d{4,5}\\-\\d{4})")]
        public string Telefone { get; set; }

        [Display(Name = "E-mail")]
        [Required(ErrorMessage = "Preencha o campo E-mail")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        [StringLength(500)]
        public string Email { get; set; }

        [Display(Name = "CPF")]
        [Required(ErrorMessage = "Preencha o campo CPF")]
        [RegularExpression("/ ^[0 - 9]{3}.?[0 - 9]{3}.?[0 - 9]{3}-?[0 - 9]{ 2}/")]
        public string CPF { get; set; }

        [Display(Name = "Data de Nascimento")]
        [Required(ErrorMessage = "Preencha o campo Data de Nascimento")]
        [RegularExpression("^(0[1-9]|[12][0-9]|3[01])/(0[1-9]|1[012])/[12][0-9]{3}$")]
        public DateTime DataNasc { get; set; }
    }
}
}