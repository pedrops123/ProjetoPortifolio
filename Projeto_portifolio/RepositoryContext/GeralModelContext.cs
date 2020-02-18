using Microsoft.AspNetCore.Http;
using ProjetoPortifolio.Data;
using ProjetoPortifolio.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoPortifolio.RepositoryContext
{
    public class GeralModelContext
    {
        ApplicationDBcontext contexto;
        const string aspasDuplas = "\"";
        public GeralModelContext()
        {
            contexto = new ApplicationDBcontext();
        }


        public List<ButtonSite> getBotoesSite()
        {
            List<ButtonSite> botoesMenu = contexto.Botoes.ToList();
            return botoesMenu;
        }

        public List<itemFotoGaleriaPrincipal> getFotosCatalog()
        {
            List<itemFotoGaleriaPrincipal> retornoListaCatalog = new List<itemFotoGaleriaPrincipal>();
            var getTelas = contexto.Imagens.GroupBy(r => r.id_tela).Select(r => r.FirstOrDefault()).Where(r => r.id_tela != "_main").ToList();
            foreach (ImagensPortifolio imagensTela in getTelas)
            {
                itemFotoGaleriaPrincipal modeloGaleria = new itemFotoGaleriaPrincipal();
                string descricaoTela = "";
                modeloGaleria.idFoto = imagensTela.id_foto;
                modeloGaleria.idTela = imagensTela.id_tela;
                modeloGaleria.urlFoto = imagensTela.urlFoto;
                try
                {
                    descricaoTela = contexto.itemsPagina.Where(r => r.nome_pagina == imagensTela.id_tela).First().conteudo_pagina;

                }
                catch (Exception)
                {
                    descricaoTela = "";
                }

                modeloGaleria.descricaoProjeto = descricaoTela;
                retornoListaCatalog.Add(modeloGaleria);
            }

            return retornoListaCatalog;
        }

        public List<ImagensPortifolio> getFotosByTela(string idTela)
        {
            List<ImagensPortifolio> FotosDaTela = contexto.Imagens.Where(r => r.id_tela == idTela.Trim()).ToList();
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
                    string templateCheckBox = "<div class=" + aspasDuplas + "form-check" + aspasDuplas + " id=" + aspasDuplas + "area-" + form.id_item + aspasDuplas + "><input type=" + aspasDuplas + "checkbox" + aspasDuplas + " class=" + aspasDuplas + form.class_form + aspasDuplas + " id=" + aspasDuplas + form.id_item + aspasDuplas + "><label class=" + aspasDuplas + "form-check-label" + aspasDuplas + " for=" + aspasDuplas + form.id_item + aspasDuplas + ">" + "&nbsp &nbsp" + form.label_form + "</label></div>";
                    RetornoCamposFormulario.Add(templateCheckBox);
                }

            }
            RetornoCamposFormulario = MontaBotoesForm(RetornoCamposFormulario, id_tela);
            return RetornoCamposFormulario;
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
                // Alteracao de pagina 
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
                // Inclusao de dados
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


                // Validação para inclusão do pai na pagina
                if (gravacaoTabela.hasFoto == true)
                {
                    try
                    {
                        // Procura o pai de has foto que é isMainFoto
                        string nomeIsMainFoto = contexto.itemsPagina.Where(r => r.isMainPhoto == true).First().nome_pagina;
                        gravacaoTabela.pagina_pai = nomeIsMainFoto;
                    }
                    catch (Exception e)
                    {
                        retornoGravacao[0] = "Erro !<br/> Talvez ainda não tenha cadastrado uma pagina com a categoria de  foto principal ! <br/> Favor verificar se a página com a categoria existe e tente novamente !";
                        retornoGravacao[1] = 0;
                        return retornoGravacao;
                    }
                }
                else if (gravacaoTabela.isMainPhoto == true)
                {
                    // Condição para isMainPhoto , pagina main sera o pai 
                    gravacaoTabela.pagina_pai = "_main";
                }
                else if (gravacaoTabela.hasForm == true)
                {
                    // Condição para has Form , pagina main sera o pai 
                    gravacaoTabela.pagina_pai = "_main";
                }



                contexto.itemsPagina.Add(gravacaoTabela);

                //  Caso for uma galeria de fotos ou for para criar um botão
                if (dadosPagina.Cria_Botao.Trim() == "true" || dadosPagina.Galeria_de_fotos_ == "true")
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

        public List<KeyValuePair<string, int>> getBreadCrumbPaginaAtual(string nomePagina)
        {
            List<KeyValuePair<string, int>> breadcrumbs = new List<KeyValuePair<string, int>>();


            string nomePaginaPai = contexto.itemsPagina.Where(r => r.nome_pagina.Trim() == nomePagina.Trim()).First().pagina_pai;
            while (nomePaginaPai != null)
            {
                try
                {
                    var testaNomePagina = contexto.itemsPagina.Where(r => r.nome_pagina.Trim() == nomePaginaPai).First();
                    breadcrumbs.Add(new KeyValuePair<string, int>(testaNomePagina.nome_pagina, testaNomePagina.id_pagina));
                    nomePaginaPai = testaNomePagina.pagina_pai;
                }
                catch (Exception e)
                {
                    nomePagina = null;
                }
            }

            breadcrumbs.Add(new KeyValuePair<string, int>(nomePagina, 9999));
            return breadcrumbs;
        }








    }
}
