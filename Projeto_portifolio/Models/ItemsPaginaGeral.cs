using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.Models
{
    [Table("items_pagina_conteudo")]
    public class ItemsPaginaGeral
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_pagina { get; set; }
        public string nome_pagina { get; set; }
        public string titulo_aba { get; set; }
        public string titulo_pagina { get; set; }
        public string conteudo_pagina { get; set; }
        public bool hasFoto { get; set; }
        public bool hasForm { get; set; }
        public bool isMainPhoto { get; set; }

    }
}
