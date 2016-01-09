using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Aula10.Models
{
    public class Usuario
    {
       
        public int ID { get; set; }
        [Required(ErrorMessage = "Favor preencher o nome!")]
        [StringLength(20, ErrorMessage = "O nome deve ter de 5 a 20 caracteres", MinimumLength = 5)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Favor preencher o CEP!")]
        [RegularExpression(@"\d{5}-\d{3}", ErrorMessage = "Utilize o formato 00000-000")]
        public string CEP { get; set; }

        [EmailAddress(ErrorMessage = "Email Incorreto!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo Nascimento é de preenchimento obrigatorio!")]
        public DateTime DataNascimento { get; set; }

        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [DataType(DataType.Password)]
        [Display(Name="Confirmar a Senha")]
        [Compare("Senha", ErrorMessage = "A senha e a confirmação de senha sçao diferentes")]
        public string SenhaRepetir { get; set; }
    }

    public class UsuarioContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
    }
}