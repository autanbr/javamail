using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace Aula10.Models
{

    // Sendo que na view Incluir adicione as seguinte validações:
    // 1- Todos os campos são requeridos
    // 2- O Treinamento deve ter de 2 a 30 caracteres
    // 3- Em local (Sala) só pode aceitar os seguintes valores: A, B ou C
    // 4- O preço deve ser maior que 10 e menor que 1000
    // 5- O desconto pode ser de 0 a 100


    public class Treinamento
    {
 
        public int Id {get;set;}

       // [Display(Name = "Treinamento")]
        [Required(ErrorMessage = "Favor preencher o campo treinamento!")]
        [StringLength(30, ErrorMessage = "O treinamento deve ter de 2 a 30 caracteres", MinimumLength = 2)]
        public string Treinammento { get; set; }


        
        [DataType(DataType.Date, ErrorMessage = "Data em formato inválido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Inicio { get; set; }

        
        [DataType(DataType.Date, ErrorMessage="Data em formato inválido")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime? Termino { get; set; }

        [Required(ErrorMessage = "O preço é obrigatório.")]
        [Range(10, 1000, ErrorMessage = "O preço deve ser maior que 10 e menor que 1000!")]
        public decimal? Preco { get; set; }

        [Required(ErrorMessage = "O desconto é obrigatório.")]
        [Range(0, 100, ErrorMessage = "O desconto pode ser de 0 a 100!")]
        public decimal? Desconto { get; set; }

        [Required(ErrorMessage = "O local é obrigatório.")]
        [RegularExpression(@"([abc])|([ABC])", ErrorMessage = "Em local (Sala) só pode aceitar os seguintes valores: A, B ou C")]
        [StringLength(1, ErrorMessage = "O local deve ter de 1 caracteres")]
        public string Local { get; set; }
    }

    public class TreinamentoContext : DbContext
    {
        public DbSet<Treinamento> Treinamentos { get; set; }
    }
}