using System;
using Microsoft.AspNetCore.Mvc;
using ProjetoPortifolio.Data;
using ProjetoPortifolio.ViewModel;
using ProjetoPortifolio.RepositoryContext;
using ProjetoPortifolio.Models;

namespace ProjetoPortifolio.Controllers
{
    public class managerAlteracaoPaginasController:Controller
    {
        ApplicationDBcontext context;
        managerPrincipalRepository contextoRepositoryPrincipal;
        managerAlteracaoRepository contextoAlteracao;
        // Construtor
        public managerAlteracaoPaginasController(){
            context = new ApplicationDBcontext();
            contextoRepositoryPrincipal = new managerPrincipalRepository();
        }

        public IActionResult Index(string idPagina)
        {
            PortifolioViewModel itemModel = new PortifolioViewModel();
            ItemsPaginaGeral dadosPagina = new ItemsPaginaGeral(0,"","","","",false,false,false,false);
            if (idPagina.Trim() != "newPage")
            {
               dadosPagina = contextoRepositoryPrincipal.getDadosTela(idPagina);
              if (dadosPagina == null)
               {
                 return RedirectToAction("Index","managerAlteracao");
               }
            }
    
               if (idPagina.Trim() == "newPage")
               {
                    // Popula BreadCrumb
                    ViewData["ViewDataContent"] = "<li class=\"breadcrumb-item\"><a href=\"/managerSistema/manager_principal\">Manager Principal </a></li><li class=\"breadcrumb-item active\" aria-current=\"page\"> " + idPagina + "</li>";
                    itemModel.cadastroTela = new ItemsPaginaGeral(0,"","","","",false,false,false,false);
                    ViewBag.Title = "Inclusão de Tela";
                    ViewBag.TituloConteudo = "Inclusao de nova tela";
         
               }
               else
               {
                  ViewData["ViewDataContent"] = "<li class=\"breadcrumb-item\"><a href=\"/managerSistema/manager_principal\">Manager Principal </a></li><li class=\"breadcrumb-item active\" aria-current=\"page\"> Alteração página " + idPagina + "</li>";
                  itemModel.cadastroTela = new ItemsPaginaGeral(dadosPagina.id_pagina,dadosPagina.nome_pagina,dadosPagina.titulo_aba,dadosPagina.titulo_pagina,dadosPagina.conteudo_pagina,dadosPagina.hasFoto,dadosPagina.hasForm,dadosPagina.isMainPhoto,dadosPagina.cria_botao);
                  ViewBag.Title = "Alteração de tela - Pagina " + idPagina;
                  ViewBag.TituloConteudo = "Alteração  Tela  " + idPagina;
               }
          
            return View("~/Views/Shared/Manager/Pagina_alteracao.cshtml", itemModel);
        }

        [HttpPost]
        public IActionResult validaCadastro(PortifolioViewModel dados){
            ViewResult view = new ViewResult();
            PortifolioViewModel itemModel = new PortifolioViewModel();
            if (dados.cadastroTela.id_pagina == 0){
                ViewData["ViewDataContent"] = "<li class=\"breadcrumb-item\"><a href=\"/Portifolio/pagina/1/_main\">Manager Principal </a></li><li class=\"breadcrumb-item active\" aria-current=\"page\"> newPage </li>";
                ViewBag.Title = "Inclusão de Tela";
                ViewBag.TituloConteudo = "Inclusao de nova tela";
            }
            else
            {
                ViewData["ViewDataContent"] = "<li class=\"breadcrumb-item\"><a href=\"/Portifolio/pagina/1/_main\">Manager Principal </a></li><li class=\"breadcrumb-item active\" aria-current=\"page\"> Alteração página " + dados.cadastroTela.nome_pagina + "</li>";
                ViewBag.Title = "Alteração de tela - Pagina " + dados.cadastroTela.nome_pagina;
                ViewBag.TituloConteudo = "Alteração  Tela  " + dados.cadastroTela.nome_pagina;
            }

            if(ModelState.IsValid)
            {
                var cadastro = dados.cadastroTela;
               return RedirectToAction("Index","managerAlteracao");
            }
       
            view = View("~/Views/Shared/Manager/Pagina_alteracao.cshtml",itemModel);    
            return view;
        }






    }
}