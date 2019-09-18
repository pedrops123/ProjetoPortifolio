﻿using Microsoft.AspNetCore.Http;
using ProjetoPortifolio.Data;
using ProjetoPortifolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.ModelContext
{
    public class GeralModelContext
    {
        ApplicationDBcontext contexto;
        const string aspasDuplas = "\"";
        public GeralModelContext()
        {
            contexto = new ApplicationDBcontext();
        }

        public ItemsPaginaGeral getDadosTela(string id_tela)
        {
            ItemsPaginaGeral conteudoTela;
            try
            {
                conteudoTela = contexto.itemsPagina.Where(r => r.nome_pagina.Trim() == id_tela.Trim()).FirstOrDefault();
            }
            catch (Exception)
            {
                conteudoTela = null;
            }

            return conteudoTela;
        }

        public List<ButtonSite> getBotoesSite()
        {
            List<ButtonSite> botoesMenu = contexto.Botoes.ToList();
            return botoesMenu;
        }

        public List<ImagensPortifolio> getFotosCatalog()
        {
            List<ImagensPortifolio> retornoListaCatalog = new List<ImagensPortifolio>();
            var getTelas = contexto.Imagens.GroupBy(r => r.id_tela).Select(r => r.FirstOrDefault()).Where(r=>r.id_tela != "_main").ToList();
            return getTelas;
        }

        public List<ImagensPortifolio> getFotosByTela(string idTela)
        {
            List<ImagensPortifolio> FotosDaTela = contexto.Imagens.Where(r => r.id_tela == idTela.Trim() ).ToList();
            return FotosDaTela;
        }

        public List<ModelFormularios> getFormulariosByTela(string id_tela)
        {
            List<ModelFormularios> retornoFormularios = contexto.formularios.Where(r => r.tag_pagina.Trim() == id_tela.Trim()).OrderBy(r => r.order).ToList();
            return retornoFormularios;
        }

        public List<string> MontaTemplateFormulario(List<ModelFormularios> itensFormularios, string id_tela)
        {
            List<string> RetornoCamposFormulario = new List<string>();
            foreach (ModelFormularios form in itensFormularios)
            {
                var verificaRequired = form.isRequired == true ? "required" : "";
                if (form.tipo_form.Trim() == "input")
                {
                    string template = "<div class=" + aspasDuplas + "form-group" + aspasDuplas + "> <label for=" + aspasDuplas + form.id_item + aspasDuplas + "> " + form.label_form + ": </label> <" + form.tipo_form + " type = " + aspasDuplas + form.estilo_dado + aspasDuplas + " class=" + aspasDuplas + form.class_form + aspasDuplas + " id=" + aspasDuplas + form.id_item + aspasDuplas + verificaRequired + "></div>";
                    RetornoCamposFormulario.Add(template);
                }

                else if (form.tipo_form.Trim() == "select")
                {
                    string opcoes = montaOptions(form);
                    string templateOption = "<div class=" + aspasDuplas + "form-group" + aspasDuplas + "> <label for= " + aspasDuplas + form.id_item + aspasDuplas + "> " + form.label_form + " </label> <select class=" + aspasDuplas + form.class_form + aspasDuplas + " id=" + aspasDuplas + form.id_item + aspasDuplas + verificaRequired + ">" + opcoes + "</select></div>";
                    RetornoCamposFormulario.Add(templateOption);
                }

                else if (form.tipo_form.Trim() == "textarea")
                {
                    string templateTextArea = "<div class=" + aspasDuplas + "form-group" + aspasDuplas + "><label for= " + aspasDuplas + form.id_item + aspasDuplas + ">" + form.label_form + "</label><textarea class=" + aspasDuplas + form.class_form + aspasDuplas + " id=" + aspasDuplas + form.id_item + aspasDuplas + " rows=" + aspasDuplas + 4 + aspasDuplas + verificaRequired + "></textarea></div>";
                    RetornoCamposFormulario.Add(templateTextArea);
                }
                else if (form.tipo_form.Trim() == "checkbox")
                {
                    string templateCheckBox = "<div class=" + aspasDuplas + "form-check" + aspasDuplas + "><input type=" + aspasDuplas + "checkbox" + aspasDuplas + " class=" + aspasDuplas + form.class_form + aspasDuplas + " id=" + aspasDuplas + form.id_item + aspasDuplas + "><label class=" + aspasDuplas + "form-check-label" + aspasDuplas + " for=" + aspasDuplas + form.id_item + aspasDuplas + ">" + "&nbsp &nbsp" + form.label_form + "</label></div>";
                    RetornoCamposFormulario.Add(templateCheckBox);
                }

            }
            RetornoCamposFormulario = MontaBotoesForm(RetornoCamposFormulario, id_tela);
            return RetornoCamposFormulario;
        }

        internal bool verificaUser(ValidaUser dadosUser)
        {
            bool verificaUser = false;
            try
            {
                var testeUser = contexto.usuarios.Where(r => r.username.Trim() == dadosUser.Login.Trim() && r.senha == dadosUser.senha.Trim()).First();
            }
            catch (Exception)
            {
                return verificaUser;
            }

            verificaUser = true;
            return verificaUser;
        }

        public List<string> MontaBotoesForm(List<string> listaFormulario, string id_tela)
        {
            string linhaBotao = "";
            var listaBotoesForm = contexto.Botoes.Where(r => r.type != "link" && r.tagPagina.Trim() == id_tela.Trim()).ToList().OrderBy(r => r.id_button);
            foreach (ButtonSite botao in listaBotoesForm)
            {
                string botaoLayout = "";
                if (botao.type.Trim() != "submit")
                {
                    botaoLayout = "<button type=" + aspasDuplas + "button" + aspasDuplas + " onClick =" + aspasDuplas + "ClickRedirectGeral('" + botao.caminhoUrl.Trim() + "')" + aspasDuplas + " style=" + aspasDuplas + "margin:16px" + aspasDuplas + "class=" + aspasDuplas + "btn btn-primary" + aspasDuplas + ">" + botao.descricao + " </button>     ";

                }
                else
                {
                    botaoLayout = "<button type=" + aspasDuplas + "button" + aspasDuplas + "onClick=" + aspasDuplas + "submitGeral('" + botao.caminhoUrl.Trim() + "')" + aspasDuplas + " style=" + aspasDuplas + "margin:16px" + aspasDuplas + " class=" + aspasDuplas + "btn btn-success" + aspasDuplas + ">" + botao.descricao + " </button>   ";
                }
                linhaBotao += botaoLayout;
            }

            listaFormulario.Add(linhaBotao);
            return listaFormulario;
        }

        public List<ItemsPaginaGeral> getAllPaginas()
        {
            return contexto.itemsPagina.Where(r => r.nome_pagina.Trim() != "_login").ToList();
        }

        public object[] getDadosTitulo()
        {
            object[] retornoDados = new object[2];
            var dados = contexto.Botoes.Where(r => r.type == "linkMaster").FirstOrDefault();
            retornoDados[0] = dados.caminhoUrl;
            retornoDados[1] = dados.descricao;

            return retornoDados;
        }

        public bool gravaDadosTituloGeral(string link, string descricao)
        {
            bool retorno = false;
            var dadoTitulo = contexto.Botoes.Where(r => r.type == "linkMaster").FirstOrDefault();
            dadoTitulo.caminhoUrl = link;
            dadoTitulo.descricao = descricao;
            contexto.Update(dadoTitulo);
            try
            {
                contexto.SaveChanges();
                retorno = true;
            }
            catch (Exception)
            {
                return retorno;
            }
            return retorno;
        }

        public string montaOptions(ModelFormularios form)
        {
            string templateOptions = "";
            List<OptionsForm> opcoes = contexto.opcoesFormularios.Where(r => r.cmp_form == form.id_form).ToList();
            foreach (OptionsForm op in opcoes)
            {
                templateOptions += "<option value=" + aspasDuplas + op.value.Trim() + aspasDuplas + ">" + op.value.Trim() + "</option>";
            }
            return templateOptions;
        }

        public object[] gravaDadosTela(AlteracoesPagina dadosPagina, string pagina)
        {
            object[] retornoGravacao = new object[2];
            ItemsPaginaGeral gravacaoTabela = new ItemsPaginaGeral();
            if (dadosPagina.Conteudo_da_Pagina == null)
            {
                dadosPagina.Conteudo_da_Pagina = "";
            }

            if (pagina != "")
            {
                gravacaoTabela = contexto.itemsPagina.Where(r => r.nome_pagina.Trim() == pagina.Trim()).FirstOrDefault();
                gravacaoTabela.nome_pagina = dadosPagina.Nome_da_Pagina;
                gravacaoTabela.titulo_aba = dadosPagina.Titulo_da_Aba.Replace("_", " ");
                gravacaoTabela.titulo_pagina = dadosPagina.Titulo_da_Pagina.Replace("_", " ");
                gravacaoTabela.conteudo_pagina = dadosPagina.Conteudo_da_Pagina.Replace("_", " ");
                gravacaoTabela.hasFoto = dadosPagina.Possui_foto_ == "Sim" ? true : false;
                gravacaoTabela.hasForm = dadosPagina.Possui_Formulario_ == "Sim" ? true : false;
                gravacaoTabela.isMainPhoto = dadosPagina.Galeria_de_fotos_ == "true" ? true : false;
                contexto.Update(gravacaoTabela);
                try
                {
                    contexto.SaveChanges();
                    retornoGravacao[0] = "";
                    retornoGravacao[1] = 1;
                }
                catch (Exception)
                {
                    retornoGravacao[0] = "Ocorreu um erro na gravacao dos dados.";
                    retornoGravacao[1] = 0;
                }
            }
            else
            {

                var verificaTelaExistente = contexto.itemsPagina.Where(r => r.nome_pagina.Trim().ToLower() == dadosPagina.Nome_da_Pagina.Trim().ToLower()).Count();
                if (verificaTelaExistente > 0)
                {
                    retornoGravacao[0] = "Já Existe uma tela cadastrada com o mesmo nome inserido , favor verificar o nome da tela novamente.";
                    retornoGravacao[1] = 0;
                    return retornoGravacao;
                }

                gravacaoTabela.nome_pagina = dadosPagina.Nome_da_Pagina;
                gravacaoTabela.titulo_aba = dadosPagina.Titulo_da_Aba.Replace("_", " ");
                gravacaoTabela.titulo_pagina = dadosPagina.Titulo_da_Pagina.Replace("_", " ");
                gravacaoTabela.conteudo_pagina = dadosPagina.Conteudo_da_Pagina.Replace("_", " ");
                gravacaoTabela.hasFoto = dadosPagina.Possui_foto_ == "Sim" ? true : false;
                gravacaoTabela.hasForm = dadosPagina.Possui_Formulario_ == "Sim" ? true : false;
                gravacaoTabela.isMainPhoto = dadosPagina.Galeria_de_fotos_ == "true" ? true : false;
                contexto.itemsPagina.Add(gravacaoTabela);

                if (dadosPagina.Cria_Botao.Trim() == "true")
                {
                    ButtonSite botao = new ButtonSite();
                    botao.descricao = gravacaoTabela.nome_pagina;
                    botao.caminhoUrl = gravacaoTabela.nome_pagina;
                    botao.type = "link";
                    botao.tagPagina = "";
                    contexto.Botoes.Add(botao);
                }

                try
                {
                    contexto.SaveChanges();
                    retornoGravacao[0] = "";
                    retornoGravacao[1] = 1;
                }
                catch (Exception)
                {
                    retornoGravacao[0] = "Ocorreu um erro na gravacao dos dados.";
                    retornoGravacao[1] = 0;
                }
            }
            return retornoGravacao;
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
                contexto.Imagens.Add(img);
            }
            try
            {
                contexto.SaveChanges();
            }
            catch (Exception)
            {
                return retorno;
            }
            retorno = true;
            return retorno;
        }

        public List<string> montaImagensTela(string nomeTela)
        {
            var fotos = getFotosByTela(nomeTela);
            List<string> listaImagens = new List<string>();
            foreach (ImagensPortifolio fotosUrl in fotos)
            {
                listaImagens.Add("<div onclick=" + aspasDuplas + "chamaPopOver(" + fotosUrl.id_foto + ")" + aspasDuplas + " data-toggle='popover' data-trigger='click' data-placement='right' data-content='data' class='img-salva' style='border:solid; margin:10px; display: -webkit-flex; -webkit-flex-wrap:wrap; display:inline-flex;flex-wrap:wrap;'><img id='img-salva' width='80px' height='80px' src='" + fotosUrl.urlFoto + "'><a style='cursor:pointer;'><span onclick='deleteImageBD(" + fotosUrl.id_foto + ")' class='notify-badge'>x</span></a></img></div>");
            }
            return listaImagens;
        }

        public bool deletaImagem(int idImagem)
        {
            bool retorno = false;
            try
            {
                ImagensPortifolio data = contexto.Imagens.Where(r => r.id_foto == idImagem).FirstOrDefault();
                File.Delete(data.caminhoFisico);
                contexto.Imagens.Remove(data);
                contexto.SaveChanges();
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
                descricao = contexto.Imagens.Where(r => r.id_foto == id).FirstOrDefault().descricao_foto;
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
                ImagensPortifolio imagem = contexto.Imagens.Where(r => r.id_foto == id).FirstOrDefault();
                imagem.descricao_foto = descricao;
                contexto.Update(imagem);
                contexto.SaveChanges();

            }
            catch (Exception)
            {
                return retorno;
            }
            retorno = true;
            return retorno;
        }

        public string getMainFoto()
        {
            string foto = "";
            try
            {
                foto = contexto.Imagens.Where(r => r.id_tela == "_main").FirstOrDefault().urlFoto;
            }
            catch (Exception)
            {
                return foto;
            }
            return foto;
        }







    }
}