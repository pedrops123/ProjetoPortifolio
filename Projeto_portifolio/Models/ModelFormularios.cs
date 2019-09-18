using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.Models
{
    [Table("formularios_portifolio")]
    public class ModelFormularios
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id_form { get; set; }
        public int order { get; set; }
        public string label_form { get; set; }
        public string tipo_form { get; set; }
        public string estilo_dado { get; set; }
        public string class_form { get; set; }
        public string id_item { get; set; }
        public string tag_pagina { get; set; }
        public bool isRequired { get; set; }
    }
}
