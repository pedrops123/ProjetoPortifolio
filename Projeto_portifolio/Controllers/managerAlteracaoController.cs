using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ProjetoPortifolio.RepositoryContext;
using ProjetoPortifolio.Models;
using ProjetoPortifolio.ViewModel;
using Microsoft.AspNetCore.Authorization;
using System.IO;

namespace ProjetoPortifolio.Controllers
{
    public class managerAlteracaoController:Controller
    {
        #region repositorios
        GeralModelContext contextoGeral;
        #endregion

        #region construtor 
        public managerAlteracaoController(){
            contextoGeral = new GeralModelContext();
        }

        #endregion

        [Authorize]
        public IActionResult Index(){
            PortifolioViewModel dados = new PortifolioViewModel();
            ViewBag.Title = "Manager Portifolio";
            ViewBag.TituloConteudo = "<h1><span class=\"fas fa-clipboard-list\"></span> &nbsp Manager Geral </h1>";
            dados.listaPaginasSistema = contextoGeral.getAllPaginas();
            dados.botoes = contextoGeral.getBotoesSite();
            ViewData["ViewDataContent"] = "<li class=\"breadcrumb-item\"><a href=\"/Portifolio/pagina/1/_main\"> Manager Geral </a></li>";
            return View("~/Views/Shared/Manager/Manager_principal.cshtml",dados);
        }

       
        #region chamadas_de_dados

        public object getDadosTituloGeral()
        {
            object[] retorno = new object[2];
            retorno = contextoGeral.getDadosTitulo();
            return retorno;
        }
        public object getDadosTela(string idTela)
        {
            object[] retornoDados = new object[7];
            var dadosTela = contextoGeral.getDadosTela(idTela);
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
            var imagens = contextoGeral.montaImagensTela(idTela);
            string imagensRetorno = "";
            foreach (string img in imagens)
            {
                imagensRetorno = imagensRetorno + img;
            }
            return imagensRetorno;
        }
        public bool DeletaImagemBD(int idFoto)
        {
            var retorno = contextoGeral.deletaImagem(idFoto);
            return retorno;
        }
        public string getDescImg(int idImg)
        {
           var dado = contextoGeral.getDescricImagem(idImg);           
           return dado;
        }
        public bool gravaDescricaoImagem(int idImagem , string descricao)
        {
            var validacao = contextoGeral.gravaDescricaoImagem(idImagem,descricao);
            return validacao;
        }
        public object deletaPagina(int idTela)
        {
            object[] retornoFuncao = new object[2];
            var retorno = contextoGeral.deletaTelaByTag(idTela);

            retornoFuncao[0] = retorno.Key;
            retornoFuncao[1] = retorno.Value;

            return retornoFuncao;
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

            contextoGeral.GravaCaminhoArquivos(listaCaminhoArquivo, nome_tela);
            retorno = true;
            return retorno;
        }

        #endregion


        
    }
}