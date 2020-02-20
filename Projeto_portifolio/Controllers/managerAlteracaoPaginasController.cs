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
        // Construtor
        public managerAlteracaoPaginasController(){
            context = new ApplicationDBcontext();
            contextoRepositoryPrincipal = new managerPrincipalRepository();
        }

        public IActionResult Index(string idPagina)
        {
            PortifolioViewModel itemModel = new PortifolioViewModel();
            ItemsPaginaGeral dadosPagina = new ItemsPaginaGeral(0,"","","","",false,false,false);;
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
                    itemModel.cadastroTela = new ItemsPaginaGeral(0,"","","","",false,false,false);
                    ViewBag.Title = "Inclusão de Tela";
                    ViewBag.TituloConteudo = "Inclusao de nova tela";
                    ViewData["idPagina"] = "";
               }
               else
               {
                  itemModel.cadastroTela = new ItemsPaginaGeral(dadosPagina.id_pagina,dadosPagina.nome_pagina,dadosPagina.titulo_aba,dadosPagina.titulo_pagina,dadosPagina.conteudo_pagina,dadosPagina.hasFoto,dadosPagina.hasForm,dadosPagina.isMainPhoto);
                  ViewBag.Title = "Alteração de tela - Pagina " + idPagina;
                  ViewBag.TituloConteudo = "Alteração  Tela  " + idPagina;
                  ViewData["idPagina"] = idPagina;
               }
            // Popula BreadCrumb
            ViewData["ViewDataContent"] = "<li class=\"breadcrumb-item\"><a href=\"/Portifolio/pagina/1/_main\">Manager Principal </a></li><li class=\"breadcrumb-item active\" aria-current=\"page\">Manager Alteração pagina " + idPagina + "</li>";

            return View("~/Views/Shared/Manager/Pagina_alteracao.cshtml", itemModel);
        }






    }
}