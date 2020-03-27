using System;
using ProjetoPortifolio.Models;
using ProjetoPortifolio.Data;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace ProjetoPortifolio.RepositoryContext
{
    public class managerPrincipalRepository
    {

         ApplicationDBcontext contextoBase;
         GeralModelContext contextGeral;
        const string aspasDuplas = "\"";
        // Construtor
        public managerPrincipalRepository()
        {
            contextoBase = new ApplicationDBcontext();
            contextGeral = new GeralModelContext();
        }


        public object[] getDadosTitulo()
        {
            object[] retornoDados = new object[2];
            var dados = contextoBase.Botoes.Where(r => r.type == "linkMaster").FirstOrDefault();
            retornoDados[0] = dados.caminhoUrl;
            retornoDados[1] = dados.descricao;

            return retornoDados;
        }

        public ItemsPaginaGeral getDadosTela(string id_tela)
        {
            ItemsPaginaGeral conteudoTela;
            try
            {
                conteudoTela = contextoBase.itemsPagina.Where(r => r.nome_pagina.Trim() == id_tela.Trim()).FirstOrDefault();
            }
            catch (Exception)
            {
                conteudoTela = null;
            }

            return conteudoTela;
        }

        public List<string> montaImagensTela(string nomeTela)
        {
            var fotos = contextGeral.getFotosByTela(nomeTela);
            List<string> listaImagens = new List<string>();
            foreach (ImagensPortifolio fotosUrl in fotos)
            {
                var pathCompleto = @Path.GetFullPath(fotosUrl.urlFoto).Replace("\\","/");
                var posicaoFotos = pathCompleto.IndexOf("/Fotos/");
                var caminhoVirtualCompleto = pathCompleto.Substring(posicaoFotos);
                listaImagens.Add("<div onclick='chamaPopOver(\" " + fotosUrl.id_foto  + " \" , \" " + caminhoVirtualCompleto  + " \" )' data-toggle='popover' data-trigger='click' data-placement='right' data-content=' ' class='img-salva' style='border:solid; margin:10px; display: -webkit-flex; -webkit-flex-wrap:wrap; display:inline-flex;flex-wrap:wrap;'><img id='img-salva' width='80px' height='80px' src='" + fotosUrl.urlFoto + "'><a style='cursor:pointer;'><span onclick='deleteImageBD(" + fotosUrl.id_foto + ")' class='notify-badge'>x</span></a></img></div>");
            }
            return listaImagens;
        }

        public bool deletaImagem(int idImagem)
        {
            bool retorno = false;
            try
            {
                ImagensPortifolio data = contextoBase.Imagens.Where(r => r.id_foto == idImagem).FirstOrDefault();
                File.Delete(data.caminhoFisico);
                contextoBase.Imagens.Remove(data);
                contextoBase.SaveChanges();
            }
            catch (Exception e)
            {
                return retorno;
            }
            retorno = true;
            return retorno;
        }
        
        public string getDescricImagem(int id)
        {
            string descricao = "";
            try
            {
                descricao = contextoBase.Imagens.Where(r => r.id_foto == id).FirstOrDefault().descricao_foto;
            }
            catch (Exception)
            {
                return descricao;
            }
            return descricao;

        }

        public bool gravaDescricaoImagem(int id, string descricao)
        {
            bool retorno = false;
            try
            {
                ImagensPortifolio imagem = contextoBase.Imagens.Where(r => r.id_foto == id).FirstOrDefault();
                imagem.descricao_foto = descricao;
                contextoBase.Update(imagem);
                contextoBase.SaveChanges();

            }
            catch (Exception)
            {
                return retorno;
            }
            retorno = true;
            return retorno;
        }

        public KeyValuePair<bool, string> deletaTelaByTag(int idTela)
        {
            var Tela = contextoBase.itemsPagina.Where(r => r.id_pagina == idTela).First();
            KeyValuePair<bool, string> retornoFuncao = new KeyValuePair<bool, string>();

            // verifica se tela possui alguma imagem vinculada 
            if (Tela.hasFoto == true)
            {
                List<ImagensPortifolio> imagens = contextoBase.Imagens.Where(r => r.id_tela.Trim() == Tela.nome_pagina.Trim()).ToList();

                // tenta deletar todas as imagens vinculadas 
                try
                {
                    foreach (ImagensPortifolio imagem in imagens)
                    {
                        File.Delete(imagem.caminhoFisico);
                        contextoBase.Imagens.Remove(imagem);
                    }
                    // salva contexto
                    contextoBase.SaveChanges();
                }
                catch (Exception e)
                {
                    retornoFuncao =  new KeyValuePair<bool, string>(false, "Ocorreu um erro ao tentar deletar as fotos da  tela " + Tela.nome_pagina.Trim() + " <br/> Segue detalhes do erro abaixo <br/> " + e.Message + " <br/> " + e.InnerException);
                }

            }

            // Verifica se ha algum botão vinculado
            ButtonSite botaoPagina = new ButtonSite();
            try
            {
                botaoPagina = contextoBase.Botoes.Where(r => r.descricao == Tela.nome_pagina).First();
            }
            catch (Exception e)
            {
                botaoPagina = null;
            }
           
            if(botaoPagina != null)
            {
                contextoBase.Botoes.Remove(botaoPagina);
                contextoBase.SaveChanges();
            }

            // Apos a serie de validacoes , deleta a tela em si 

            try
            {
                contextoBase.itemsPagina.Remove(Tela);
                // salva contexto
                contextoBase.SaveChanges();

            }
            catch (Exception e)
            {
                retornoFuncao = new KeyValuePair<bool, string>(false, "Ocorreu um erro ao tentar a  tela " + Tela.nome_pagina.Trim() + " <br/> Segue detalhes do erro abaixo <br/> " + e.Message + " <br/> " + e.InnerException);
            }
            finally
            {
                retornoFuncao = new KeyValuePair<bool, string>(true, "Tela deletada com sucesso !");

            }

            return retornoFuncao;
        }
      
        public bool GravaCaminhoArquivos(List<string> listaCaminhos, string nomeTela)
        {
            bool retorno = false;
            List<ImagensPortifolio> ImagensPort = new List<ImagensPortifolio>();
            foreach (string imagem in listaCaminhos)
            {
                try
                {
                    ImagensPortifolio imagemUnitaria = new ImagensPortifolio();
                    imagemUnitaria.id_tela = nomeTela;
                    imagemUnitaria.caminhoFisico = imagem;
                    var posicaoPasta = imagem.IndexOf("wwwroot");
                    var pastaTeste = imagem.Substring(posicaoPasta);
                    imagemUnitaria.urlFoto = pastaTeste.Replace("wwwroot", "");
                    imagemUnitaria.descricao_foto = "";
                    ImagensPort.Add(imagemUnitaria);
                }
                catch (Exception e)
                {
                    return retorno;
                }

            }
            foreach (ImagensPortifolio img in ImagensPort)
            {
                contextoBase.Imagens.Add(img);
            }
            try
            {
                contextoBase.SaveChanges();
            }
            catch (Exception)
            {
                return retorno;
            }
            retorno = true;
            return retorno;
        }

        public bool gravaDadosTituloGeral(string link, string descricao)
        {
            bool retorno = false;
            var dadoTitulo = contextoBase.Botoes.Where(r => r.type == "linkMaster").FirstOrDefault();
            dadoTitulo.caminhoUrl = link;
            dadoTitulo.descricao = descricao;
            contextoBase.Update(dadoTitulo);
            try
            {
                contextoBase.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                return retorno;
            }
            return retorno;
        }

       



    }
   
}