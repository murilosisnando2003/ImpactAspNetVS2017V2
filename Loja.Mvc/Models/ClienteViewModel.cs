using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Loja.Mvc.Models;


namespace Loja.Mvc.Models
{
    public class ClienteViewModel
    {

        public int Id { get; set; }

        [Required]
        public string Nome { get; set; }

        [Required]
        [Display(Name ="Nascimento")]
        [IdadeMinima(18)]
        public DateTime DataNascimento { get; set; }

        [Required]
        [Remote("VerificarDisponibilidadeEmail", "Clientes",HttpMethod ="POST",ErrorMessage ="Email não disponivel")]
        [RegularExpression(@"^[a-zA-Z0-9.-_]{1,50}@[\w]+(\.[a-zA-Z]{2,3}){1,2}$",ErrorMessage ="E-mail com formato invalido")]
        public string Email { get; set; }
    }
}