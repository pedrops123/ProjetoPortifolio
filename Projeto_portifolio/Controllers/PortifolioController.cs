using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ProjetoPortifolio.ModelContext;
using ProjetoPortifolio.Models;
using ProjetoPortifolio.ViewModel;
using SmartBreadcrumbs.Attributes;
using SmartBreadcrumbs.Nodes;
using X.PagedList;



namespace ProjetoPortifolio.Controllers
{
    public class PortifolioController : Controller
    {
        GeralModelContext contexto;
        public PortifolioController()
        {
            contexto = new GeralModelContext();
        }
        // GET: Portifolio
        //[Route("")]
        //[Route("Portifolio")]
        //[Route("Portifolio/PortifolioPedro")]
        [DefaultBreadcrumb("_main")]
        public ActionResult ChamaViewDinamica(string nomeTela = "_main" , int pagina = 1)
        {
            PortifolioViewModel item = new PortifolioViewModel();
            var tela = contexto.getDadosTela(nomeTela);

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
                        breadCrumbRaw = breadCrumbRaw + "<li class=\"breadcrumb-item\"><a href=\"/Portifolio/" + itemTela.Key.Trim() + "\">" + itemTela.Key.Trim().Replace("_", " ").Replace("main", "Home") + "</a></li>";
                    }
                }

                ViewData["ViewDataContent"] = breadCrumbRaw;
            //}

            return View("LayoutGeral", item);
        }

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

        [HttpPost]
        public async Task<object[]> SubmitGeralValidador(string nomeTela, string object_form)
        {
            var tela = nomeTela.Split("+");
            object[] retorno = new object[2];
            object_form = object_form.Replace(" ", "_");
            switch (tela[0])
            {
                case "_manager-index":

                    var dadosUser = JsonConvert.DeserializeObject<ValidaUser>(object_form);
                    var validaUser = contexto.verificaUser(dadosUser);
                    if (validaUser != true)
                    {
                        retorno[0] = "Usuario ou senha incorretos , favor verificar os dados e tentar novamente !";
                        retorno[1] = "";
                    }
                    else
                    {
                        var claims = new List<Claim>
                            {
                                new Claim(ClaimTypes.Name, dadosUser.Login),
                            };

                        var claimsIdentity = new ClaimsIdentity(
                            claims, CookieAuthenticationDefaults.AuthenticationScheme);

                        ClaimsPrincipal principal = new ClaimsPrincipal(claimsIdentity);

                        var authProperties = new AuthenticationProperties
                        {
                            AllowRefresh = true,
                            IsPersistent = false,
                            ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(30)
                            //RedirectUri = "_manager"

                            //AllowRefresh = <bool>,
                            // Refreshing the authentication session should be allowed.

                            //ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                            // The time at which the authentication ticket expires. A 
                            // value set here overrides the ExpireTimeSpan option of 
                            // CookieAuthenticationOptions set with AddCookie.

                            //IsPersistent = true,
                            // Whether the authentication session is persisted across 
                            // multiple requests. When used with cookies, controls
                            // whether the cookie's lifetime is absolute (matching the
                            // lifetime of the authentication ticket) or session-based.

                            //IssuedUtc = <DateTimeOffset>,
                            // The time at which the authentication ticket was issued.

                            //RedirectUri = <string>
                            // The full path or absolute URI to be used as an http 
                            // redirect response value.
                        };

                        await HttpContext.SignInAsync(
                            scheme: "FiverSecurityScheme",
                            principal: principal
                            );

                        retorno[0] = "";
                        retorno[1] = "Manager_principal";
                    }

                    break;

                case "_titleGeral":

                    var dadosTitulo = JsonConvert.DeserializeObject<TituloConteudoModel>(object_form);
                    var retornoGravacaoTitle = contexto.gravaDadosTituloGeral(dadosTitulo.Link_Direcionamento, dadosTitulo.Descricao_Titulo_Geral.Replace("_", " "));
                    if (retornoGravacaoTitle)
                    {
                        retorno[0] = "";
                        retorno[1] = "Manager_principal";
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
                        retorno[1] = "Manager_principal";
                    }

                    break;
            }




            return retorno;
        }

        public async Task<IActionResult> logout()
        {
            if (User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync("FiverSecurityScheme");
            }
            return Redirect("_main");
        }

        [Authorize]
        public ActionResult DadosTelaDinamicoManager(string tagPagina = "")
        {
            string nomeTelaAtual = "manager_alteracao";
            string idPagina = "";
            PortifolioViewModel itemModel = new PortifolioViewModel();
            if (tagPagina != "")
            {
                var dadosPagina = contexto.getDadosTela(tagPagina);
                if (dadosPagina == null)
                {
                    return RedirectToAction("chamaManagerPrincipal");
                }

                idPagina = dadosPagina.nome_pagina;
            }
            if (tagPagina == "")
            {
                ViewBag.Title = "Inclusão de Tela";
                ViewBag.TituloConteudo = "Inclusao de nova tela";
                ViewData["idPagina"] = idPagina;
            }
            else
            {
                ViewBag.Title = "Alteração de tela - Pagina " + tagPagina;
                ViewBag.TituloConteudo = "Alteração  Tela  " + tagPagina;
                ViewData["idPagina"] = idPagina;
            }
            List<ModelFormularios> formularios = contexto.getFormulariosByTela(nomeTelaAtual);
            itemModel.formularios = contexto.MontaTemplateFormulario(formularios, nomeTelaAtual);
            ViewData["ViewDataContent"] = "";
            return View("Manager/Pagina_alteracao", itemModel);
        }

        [HttpPost]
        public bool uploadImages()
        {
            bool retorno = false;
            List<string> listaCaminhoArquivo = new List<string>();
            var dadosRecebidos = HttpContext.Request.Form.Files;
            if (dadosRecebidos.Count == 0)
            {
                return retorno;
            }
            var nome_tela = dadosRecebidos[0].ContentDisposition.Split("*")[1];
            foreach (var item in dadosRecebidos)
            {
                if (!item.ContentType.ToLower().Contains("image"))
                {
                    return retorno;
                }
            }
            var path = Directory.GetCurrentDirectory();

            // Se nao existir pasta Fotos , cria uma automaticamente

            if (!Directory.Exists(path + @"\wwwroot\Fotos\"))
            {
                Directory.CreateDirectory(path + @"\wwwroot\Fotos\");
            }
            
            foreach (var item in dadosRecebidos)
            {
                var caminhoImg = path + @"\wwwroot\Fotos\" + Guid.NewGuid() + "." + item.FileName.Split('.')[item.FileName.Split('.').Length - 1];
                using (var fileCreate = new FileStream(caminhoImg, FileMode.Create))
                {
                    item.CopyTo(fileCreate);
                    Dispose();
                }

                // Redimensiona imagem 
                //Image imgPhoto = Image.FromFile(caminhoImg);
                //Bitmap image = ResizeImage(imgPhoto, 300, 300);
                //image.Save(caminhoImg);
                listaCaminhoArquivo.Add(caminhoImg);
            }

            contexto.GravaCaminhoArquivos(listaCaminhoArquivo, nome_tela);
            retorno = true;
            return retorno;
        }

        public IPagedList<itemFotoGaleriaPrincipal> makePaginationPrincipal(int pagina , List<itemFotoGaleriaPrincipal> projetos)
        {
            var imgFiltrada = projetos.OrderBy(r => r.idFoto).ToPagedList(pagina, 8);
            return imgFiltrada;
        }


        public IPagedList<ImagensPortifolio> makePagination(int pagina, List<ImagensPortifolio> imagens)
        {
            var imgFiltrada = imagens.OrderBy(r => r.id_foto).ToPagedList(pagina,9);
            return imgFiltrada;
        }

        public bool gravaDescricaoImagem(int idImagem , string descricao)
        {
            var validacao = contexto.gravaDescricaoImagem(idImagem,descricao);
            return validacao;
        }




        #region chamadas_de_dados

        public object getDadosTituloGeral()
        {
            object[] retorno = new object[2];
            retorno = contexto.getDadosTitulo();
            return retorno;
        }
        public object getDadosTela(string idTela)
        {
            object[] retornoDados = new object[7];
            var dadosTela = contexto.getDadosTela(idTela);
            retornoDados[0] = dadosTela.nome_pagina;
            retornoDados[1] = dadosTela.titulo_aba;
            retornoDados[2] = dadosTela.titulo_pagina;
            retornoDados[3] = dadosTela.conteudo_pagina;
            retornoDados[4] = dadosTela.hasFoto;
            retornoDados[5] = dadosTela.hasForm;
            retornoDados[6] = dadosTela.isMainPhoto;
            return retornoDados;
        }
        public string MakeImages(string idTela)
        {
            var imagens = contexto.montaImagensTela(idTela);
            string imagensRetorno = "";
            foreach (string img in imagens)
            {
                imagensRetorno = imagensRetorno + img;
            }
            return imagensRetorno;
        }
        public bool DeletaImagemBD(int idFoto)
        {
            var retorno = contexto.deletaImagem(idFoto);
            return retorno;
        }
        public string getDescImg(int idImg)
        {
           var dado = contexto.getDescricImagem(idImg);           
           return dado;
        }

        #endregion


        public object deletaPagina(int idTela)
        {
            object[] retornoFuncao = new object[2];
            var retorno = contexto.deletaTelaByTag(idTela);

            retornoFuncao[0] = retorno.Key;
            retornoFuncao[1] = retorno.Value;

            return retornoFuncao;
        }




    }
}   
