using System;
using System.ComponentModel.DataAnnotations;

namespace ProjetoPortifolio.Models
{
    public class ModelCadastroLink
    {
        [Required, StringLength(150), Display(Name = "Url do Site")]
        public string linkUrl {get; set;}

        [Required, StringLength(20), Display(Name = "Descrição do Link")]
        public string linkDescricao {get; set;}
        
    }
}