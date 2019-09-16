using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.Models
{
    [Table("botoes_portifolio")]
    public class ButtonSite
    {
       [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_button { get; set; }
        public string descricao { get; set; }
        public string caminhoUrl { get; set; }
        public string type { get; set; }
        public string tagPagina { get; set; }

    }
}
