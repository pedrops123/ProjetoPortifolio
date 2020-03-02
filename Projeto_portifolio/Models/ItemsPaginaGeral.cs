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
        // Construtor da classe

        // Sobrecarga de construtor para poder incializar dados no code First
        public ItemsPaginaGeral(){

        }
       
        public ItemsPaginaGeral(int idpagina, string nome_pagina , string tituloAba , string tituloPagina, string conteudoPagina, bool TemFoto , bool temFormulario , bool isMainFoto , bool criaBotao)
        {
            this.id_pagina = idpagina;
            this.nome_pagina = nome_pagina;
            this.titulo_aba = tituloAba;
            this.titulo_pagina = tituloPagina;
            this.conteudo_pagina = conteudoPagina;
            this.hasFoto = TemFoto;
            this.hasForm = temFormulario;
            this.isMainPhoto = isMainFoto;
            this.pagina_pai = "";
            this.cria_botao = criaBotao;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int id_pagina { get; set; }
        
        [Required(AllowEmptyStrings = false , ErrorMessage = "Nome da Página não pode ficar em branco !"), StringLength(40), Display(Name = "Tag Da Página")]
        public string nome_pagina { get; set; }

        [Required(AllowEmptyStrings = false , ErrorMessage="Titula da Aba não pode ficar em branco !"), StringLength(100), Display(Name = "Titulo da Aba")]
        public string titulo_aba { get; set; }

        [Required(AllowEmptyStrings = false , ErrorMessage = "Titulo da Página não pode ficar em branco !") , StringLength(100), Display(Name = "Titulo da Página")]
        public string titulo_pagina { get; set; }

        [StringLength(900), Display(Name = "Conteudo da Página")]
        public string conteudo_pagina { get; set; }

        [Required,  Display(Name = "Possui Foto ?")]
        public bool hasFoto { get; set; }

        [Required,  Display(Name = "Possui Formulário ?")]
        public bool hasForm { get; set; }

        [Required,  Display(Name = "É Galeria de Fotos ?")]
        public bool isMainPhoto { get; set; }
        public string pagina_pai { get; set; }
        
        [Required , Display(Name="Cria Botão ?")]
        public bool cria_botao {get;set;}    
    }
}
