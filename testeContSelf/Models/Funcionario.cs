using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace testeContSelf.Models
{
    [Table("Funcionarios")]
    public class Funcionario
    {
        [Key]
        public int CodFuncionario { get; set; }

        [Required(ErrorMessage = "Preencha o {0}.")]
        [Display(Name = "Nome")]
        [StringLength(400, MinimumLength = 3, ErrorMessage = "O {0} deve ter entre {2} a {1} caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Preencha a {0}.")]
        [Display(Name = "Data de Nascimento")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DataNascimento { get; set; }

        [Required(ErrorMessage = "Preencha o {0}.")]
        [Display(Name = "Salário")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Salario { get; set; }

        [Required(ErrorMessage = "Preencha a {0}.")]
        [Display(Name = "Atividades")]
        public string Atividades { get; set; }

    }
}
