using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.Models
{
    [Table("usuarios")]
    public class UsersAdmin
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_user { get; set; }
        public string username { get; set; }
        public string senha { get; set; }
        public string nome_completo { get; set; }
    }
}
