using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProjetoPortifolio.RepositoryContext;
using ProjetoPortifolio.Models;
using ProjetoPortifolio.ViewModel;
using X.PagedList;



namespace ProjetoPortifolio.Controllers
{
    public class PortifolioController : Controller
    {
        GeralModelContext contexto;
        managerPrincipalRepository contextoManager;
        public PortifolioController()
        {
            contexto = new GeralModelContext();
            contextoManager = new managerPrincipalRepository();

        }
        // GET: Portifolio
        //[Route("")]
        //[Route("Portifolio")]
        //[Route("Portifolio/PortifolioPedro")]
        public ActionResult ChamaViewDinamica(string nomeTela = "_main" , int pagina = 1)
        {
            PortifolioViewModel item = new PortifolioViewModel();
            var tela = contextoManager.getDadosTela(nomeTela);

            if (tela == null)
            {
                ViewData["ViewDataContent"] = "";
                item.botoes = contexto.getBotoesSite();
                return View("~/Views/Errors/NotFoundTela.cshtml",item);
            }

            item.dadosPagina = tela;
            item.botoes = contexto.getBotoesSite();
            ViewBag.Title = item.dadosPagina.titulo_aba;
            ViewBag.TituloConteudo = item.dadosPagina.titulo_pagina;

            if (nomeTela == "_main")
            {
                item.mainFoto = contexto.getMainFoto();
            }

            if (item.dadosPagina.isMainPhoto)
            {                  
               var fotosCatalog = contexto.getFotosCatalog();
                item.imagensPrincipais = makePaginationPrincipal(pagina,fotosCatalog);
            }

            if (item.dadosPagina.hasFoto == true)
            {
                var todasFotos = contexto.getFotosByTela(nomeTela);
                item.imagens = makePagination(pagina, todasFotos);
            }

            if (item.dadosPagina.hasForm == true)
            {
                List<ModelFormularios> listaFormulario = contexto.getFormulariosByTela(nomeTela);
                item.formularios = contexto.MontaTemplateFormulario(listaFormulario, nomeTela);
            }

            var listaBreadCrumbs = contexto.getBreadCrumbPaginaAtual(nomeTela);

            //if (nomeTela != "_main")
            //{
                // Prepara bradCrumb 
                string breadCrumbRaw = "";
                var telaFinal = listaBreadCrumbs.LastOrDefault().Key;
                foreach (KeyValuePair<string , int> itemTela in listaBreadCrumbs.OrderBy(r=>r.Value))
                {
                    if(itemTela.Key.Trim() == telaFinal.Trim())
                    {
                        breadCrumbRaw = breadCrumbRaw + "<li class=\"breadcrumb-item active\" aria-current=\"page\">" + itemTela.Key.Trim().Replace("_"," ").Replace("main","Home")+"</li>";
                    }
                    else
                    {
                        breadCrumbRaw = breadCrumbRaw + "<li class=\"breadcrumb-item\"><a href=\"/Portifolio/pagina/1/" + itemTela.Key.Trim() + "\">" + itemTela.Key.Trim().Replace("_", " ").Replace("main", "Home") + "</a></li>";
                    }
                }

                ViewData["ViewDataContent"] = breadCrumbRaw;
            //}

            return View("LayoutGeral", item);
        }

/*
        [Authorize]
        public ActionResult chamaManagerPrincipal()
        {
            ViewBag.Title = "Manager Portifolio";
            ViewBag.TituloConteudo = "<h1><span class=\"fas fa-clipboard-list\"></span> &nbsp Manager Geral </h1>";
            PortifolioViewModel item = new PortifolioViewModel();
            item.dadosPagina = null;
            item.botoes = null;
            List<ModelFormularios> listaFormulario = contexto.getFormulariosByTela("manager_principal");
            item.formularios = contexto.MontaTemplateFormulario(listaFormulario, "manager_principal");
            item.imagens = null;
            item.listaPaginasSistema = contexto.getAllPaginas();
            ViewData["ViewDataContent"] = "";
            return View("Manager/Manager_principal", item);
        }
*/


/*
        [HttpPost]
        public async Task<object[]> SubmitGeralValidador(string nomeTela, string object_form)
        {
            var tela = nomeTela.Split("+");
            object[] retorno = new object[2];
            object_form = object_form.Replace(" ", "_");
            switch (tela[0])
            {
                case "_manager-index":

                 

                    break;

                case "_titleGeral":

                    var dadosTitulo = JsonConvert.DeserializeObject<TituloConteudoModel>(object_form);
                    var retornoGravacaoTitle = contexto.gravaDadosTituloGeral(dadosTitulo.Link_Direcionamento, dadosTitulo.Descricao_Titulo_Geral.Replace("_", " "));
                    if (retornoGravacaoTitle)
                    {
                        retorno[0] = "";
                        retorno[1] = "chamaManagerPrincipal";
                    }
                    else
                    {
                        retorno[0] = "Ocorreu um erro , favor tentar novamente mais tarde !";
                        retorno[1] = "";
                    }

                    break;

                case "manager_alteracao":

                    var dadosAlteracao = JsonConvert.DeserializeObject<AlteracoesPagina>(object_form);
                    var gravaDadosTela = contexto.gravaDadosTela(dadosAlteracao, tela[1]);
                    if (int.Parse(gravaDadosTela[1].ToString()) == 0)
                    {
                        retorno[0] = gravaDadosTela[0];
                        retorno[1] = "";
                    }
                    else
                    {
                        retorno[0] = "";
                        retorno[1] = "chamaManagerPrincipal";
                    }

                    break;
            }




            return retorno;
        }

        */

  

        //[Authorize]
        //public ActionResult DadosTelaDinamicoManager(string tagPagina = "")
        //{
        //    string nomeTelaAtual = "manager_alteracao";
        //    string idPagina = "";
        //    PortifolioViewModel itemModel = new PortifolioViewModel();
        //    if (tagPagina != "")
        //    {
        //        var dadosPagina = contexto.getDadosTela(tagPagina);
        //        if (dadosPagina == null)
        //        {
        //            return RedirectToAction("chamaManagerPrincipal");
        //        }

        //        idPagina = dadosPagina.nome_pagina;
        //    }
        //    if (tagPagina == "")
        //    {
        //        ViewBag.Title = "Inclusão de Tela";
        //        ViewBag.TituloConteudo = "Inclusao de nova tela";
        //        ViewData["idPagina"] = idPagina;
        //    }
        //    else
        //    {
        //        ViewBag.Title = "Alteração de tela - Pagina " + tagPagina;
        //        ViewBag.TituloConteudo = "Alteração  Tela  " + tagPagina;
        //        ViewData["idPagina"] = idPagina;
        //    }
        //    List<ModelFormularios> formularios = contexto.getFormulariosByTela(nomeTelaAtual);
        //    itemModel.formularios = contexto.MontaTemplateFormulario(formularios, nomeTelaAtual);
        //    ViewData["ViewDataContent"] = "";
        //    return View("Manager/Pagina_alteracao", itemModel);
        //}

       
        public IPagedList<itemFotoGaleriaPrincipal> makePaginationPrincipal(int pagina , List<itemFotoGaleriaPrincipal> projetos)
        {
            var imgFiltrada = projetos.OrderBy(r => r.idFoto).ToPagedList(pagina, 9);
            return imgFiltrada;
        }


        public IPagedList<ImagensPortifolio> makePagination(int pagina, List<ImagensPortifolio> imagens)
        {
            var imgFiltrada = imagens.OrderBy(r => r.id_foto).ToPagedList(pagina,9);
            return imgFiltrada;
        }

 



    }
}   
