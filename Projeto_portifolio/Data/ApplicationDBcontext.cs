using Microsoft.EntityFrameworkCore;
using ProjetoPortifolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.Data
{
    public class ApplicationDBcontext : DbContext
    {
        public ApplicationDBcontext()
        {
            Database.EnsureCreated();
        }

        public DbSet<ImagensPortifolio> Imagens { get; set; }
        public DbSet<ButtonSite> Botoes { get; set; }
        public DbSet<ItemsPaginaGeral> itemsPagina { get; set; }
        public DbSet<ModelFormularios> formularios { get; set; }
        public DbSet<UsersAdmin> usuarios { get; set; }
        public DbSet<OptionsForm> opcoesFormularios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connection string casa 
            //optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-9IU6ULD\SQLEXPRESS;Initial Catalog=PortifolioDB;Integrated Security=True;Connect Timeout=30; Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            
            //Connection string trabalho
            optionsBuilder.UseSqlServer(@"Data Source=DSK-TI-02\SQLEXPRESS; Initial Catalog=PortifolioDB;Integrated Security=True;Connect Timeout=30; User Id=tap.ti; Password=TrameAp112@;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ItemsPaginaGeral>().HasData(

                new ItemsPaginaGeral(
                    1,
                    "_main",
                    "Pagina Principal",
                    "Minha Página Principal",
                    "Meu site Portifolio , isto é o conteudo inicializado na pagina , para alterar ou incluir alguma tela  favor entrar no manager incluindo o parametro _Login",
                    false ,false,false
                    )                   
                );

            //modelBuilder.Entity<ItemsPaginaGeral>().HasData(
            //  new ItemsPaginaGeral
            //  {
            //      id_pagina = 2,
            //      nome_pagina = "_login",
            //      titulo_aba = "Login Manager",
            //      titulo_pagina = "Manager Administrador",
            //      conteudo_pagina = "",
            //      hasForm = true,
            //      hasFoto = false,
            //      pagina_pai = "_main"
            //  });

            //modelBuilder.Entity<ModelFormularios>().HasData(
            //    new ModelFormularios
            //    {
            //        id_form = 1,
            //        class_form = "form-control",
            //        id_item = "login_cmp",
            //        estilo_dado = "text",
            //        isRequired = true,
            //        label_form = "Login",
            //        order = 1,
            //        tipo_form = "input",
            //        tag_pagina = "_login"

            //    });

            //modelBuilder.Entity<ModelFormularios>().HasData(
            //new ModelFormularios
            //{
            //    id_form = 2,
            //    class_form = "form-control",
            //    id_item = "senha_cmp",
            //    estilo_dado = "password",
            //    isRequired = true,
            //    label_form = "Senha",
            //    order = 2,
            //    tipo_form = "input",
            //    tag_pagina = "_login"

            //});


            modelBuilder.Entity<ModelFormularios>().HasData(
            new ModelFormularios
            {
                id_form = 3,
                class_form = "form-control",
                id_item = "link_id",
                estilo_dado = "text",
                isRequired = true,
                label_form = "Link Direcionamento",
                order = 1,
                tipo_form = "input",
                tag_pagina = "manager_principal"

            });

            modelBuilder.Entity<ModelFormularios>().HasData(
             new ModelFormularios
             {
                 id_form = 4,
                 class_form = "form-control",
                 id_item = "desc_title_id",
                 estilo_dado = "text",
                 isRequired = true,
                 label_form = "Descrição Titulo Geral",
                 order = 2,
                 tipo_form = "input",
                 tag_pagina = "manager_principal"

             });

            modelBuilder.Entity<ModelFormularios>().HasData(
             new ModelFormularios
             {
                 id_form = 5,
                 class_form = "form-control",
                 id_item = "nome_pagina_id",
                 estilo_dado = "text",
                 isRequired = true,
                 label_form = "Nome da Pagina",
                 order = 1,
                 tipo_form = "input",
                 tag_pagina = "manager_alteracao"

             });

            modelBuilder.Entity<ModelFormularios>().HasData(
            new ModelFormularios
            {
                id_form = 6,
                class_form = "form-control",
                id_item = "titulo_aba_id",
                estilo_dado = "text",
                isRequired = true,
                label_form = "Titulo da Aba",
                order = 2,
                tipo_form = "input",
                tag_pagina = "manager_alteracao"
            });

            modelBuilder.Entity<ModelFormularios>().HasData(
            new ModelFormularios
            {
                id_form = 7,
                class_form = "form-control",
                id_item = "titulo_pagina_id",
                estilo_dado = "text",
                isRequired = true,
                label_form = "Titulo da Pagina",
                order = 3,
                tipo_form = "input",
                tag_pagina = "manager_alteracao"
            });

            modelBuilder.Entity<ModelFormularios>().HasData(
            new ModelFormularios
            {
                id_form = 8,
                class_form = "form-control",
                id_item = "conteudo_pagina_id",
                estilo_dado = "text",
                isRequired = false,
                label_form = "Conteudo da Pagina",
                order = 4,
                tipo_form = "textarea",
                tag_pagina = "manager_alteracao"
            });

            modelBuilder.Entity<ModelFormularios>().HasData(
            new ModelFormularios
            {
                id_form = 9,
                class_form = "form-control",
                id_item = "foto_pagina_id",
                estilo_dado = "",
                isRequired = true,
                label_form = "Possui foto ?",
                order = 5,
                tipo_form = "select",
                tag_pagina = "manager_alteracao"
            });

            modelBuilder.Entity<ModelFormularios>().HasData(
            new ModelFormularios
            {
                id_form = 10,
                class_form = "form-control",
                id_item = "form_pagina_id",
                estilo_dado = "",
                isRequired = true,
                label_form = "Possui Formulário ?",
                order = 6,
                tipo_form = "select",
                tag_pagina = "manager_alteracao"
            });


            modelBuilder.Entity<ModelFormularios>().HasData(
            new ModelFormularios
            {
                id_form = 11,
                class_form = "",
                id_item = "check_foto_principal",
                estilo_dado = "",
                isRequired = false,
                label_form = " Galeria de fotos ?",
                order = 7,
                tipo_form = "checkbox",
                tag_pagina = "manager_alteracao"
            });


            modelBuilder.Entity<ModelFormularios>().HasData(
            new ModelFormularios
            {
                id_form = 12,
                class_form = "",
                id_item = "check_botao",
                estilo_dado = "",
                isRequired = false,
                label_form = " Cria Botão?",
                order = 8,
                tipo_form = "checkbox",
                tag_pagina = "manager_alteracao"
            });

            modelBuilder.Entity<ButtonSite>().HasData(
                new ButtonSite
                {
                    id_button = 1,
                    descricao = "Home",
                    caminhoUrl = "_main",
                    tagPagina = "",
                    type = "link"
                });

            //modelBuilder.Entity<ButtonSite>().HasData(
            //new ButtonSite
            //{
            //    id_button = 2,
            //    descricao = "Voltar",
            //    caminhoUrl = "_main",
            //    tagPagina = "_login",
            //    type = "redirect"
            //});


            //modelBuilder.Entity<ButtonSite>().HasData(
            //new ButtonSite
            //{
            //    id_button = 3,
            //    descricao = "Entrar",
            //    caminhoUrl = "_manager-index",
            //    tagPagina = "_login",
            //    type = "submit"
            //});

            modelBuilder.Entity<ButtonSite>().HasData(
            new ButtonSite
            {
                id_button = 4,
                descricao = "Pedro Vinicius Rodrigues Furlan",
                caminhoUrl = "https://www.linkedin.com/in/pedro-vinícius-rodrigues-furlan-a691bb10a",
                tagPagina = "",
                type = "linkMaster"
            });

            modelBuilder.Entity<ButtonSite>().HasData(
            new ButtonSite
            {
                id_button = 5,
                descricao = "<span class=\"fas fa-save\"></span> &nbsp Gravar Alterações",
                caminhoUrl = "_titleGeral",
                tagPagina = "manager_principal",
                type = "submit"
            });
            modelBuilder.Entity<ButtonSite>().HasData(
            new ButtonSite
            {
                id_button = 6,
                descricao = "<span class=\"fas fa-save\"></span> &nbsp Gravar Alterações",
                caminhoUrl = "manager_alteracao",
                tagPagina = "manager_alteracao",
                type = "submit"
            });


            modelBuilder.Entity<UsersAdmin>().HasData(
                new UsersAdmin
                {
                    id_user = 1,
                    username = "pedro.furlan",
                    nome_completo = "Pedro Vinicius Rodrigues Furlan",
                    senha = "97083252"
                });

            modelBuilder.Entity<OptionsForm>().HasData(
                new OptionsForm
                {
                    id_option = 1,
                    value = "Sim",
                    cmp_form = 9,
                    IsDeletado = false
                });
            modelBuilder.Entity<OptionsForm>().HasData(
            new OptionsForm
            {
                id_option = 2,
                value = "Não",
                cmp_form = 9,
                IsDeletado = false
            });

            modelBuilder.Entity<OptionsForm>().HasData(
            new OptionsForm
            {
                id_option = 3,
                value = "Sim",
                cmp_form = 10,
                IsDeletado = false
            });
            modelBuilder.Entity<OptionsForm>().HasData(
            new OptionsForm
            {
                id_option = 4,
                value = "Não",
                cmp_form = 10,
                IsDeletado = false
            });
        }

    }


}

