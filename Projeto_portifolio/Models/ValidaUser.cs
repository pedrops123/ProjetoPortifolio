using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.Models
{
    public class ValidaUser
    {
        public ValidaUser(string usuario ,string senha)
        {
            this.usuario = usuario;
            this.senha = senha;
        }

        [Required, StringLength(20), Display(Name = "Usuario")]
        public string usuario { get; set; }
        [Required,DataType(DataType.Password), StringLength(40), Display(Name = "Senha")]
        public string senha { get; set; }
    }
}
