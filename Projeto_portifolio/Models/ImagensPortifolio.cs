using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.Models
{
    [Table("fotos_sistema")]
    public class ImagensPortifolio
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_foto { get; set; }
        public string id_tela { get; set; }
        public string caminhoFisico { get; set; }
        public string urlFoto { get; set; }
        public string descricao_foto { get; set; }
        
    }
}
