using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.Models
{
    [Table("options_form")]
    public class OptionsForm
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_option { get; set; }
        public string value { get; set; }
        public int cmp_form { get; set; }
        public bool IsDeletado { get; set; }

    }
}
