using System;
using ProjetoPortifolio.Data;
using ProjetoPortifolio.Models;
using System.Linq;

namespace ProjetoPortifolio.RepositoryContext
{
    public class managerAlteracaoRepository
    {
        ApplicationDBcontext contextoBase;
        

        // Construtor da classe
        public managerAlteracaoRepository()
        {
            contextoBase = new ApplicationDBcontext();
        }

        public object[] gravaDadosTela(ItemsPaginaGeral dados)
        {
            object[] retorno = new object[2];

            // Validações antes de gravar 

            dados.titulo_aba = dados.titulo_aba == null ? "" : dados.titulo_aba;
            dados.titulo_pagina = dados.titulo_pagina == null ? "" : dados.titulo_pagina;
            dados.conteudo_pagina = dados.conteudo_pagina  == null ? "" : dados.conteudo_pagina;

            try
            {
               // Faz insert de dados
               if(dados.id_pagina == 0)
               {
                   // Faz verificação de nome da tela 
                   var telaCadastrada = contextoBase.itemsPagina.Where( r => r.nome_pagina.Trim() == dados.nome_pagina).FirstOrDefault();

                    if(telaCadastrada != null)
                    {
                      retorno[0] = "Já Existe uma tela cadastrada com o mesmo nome inserido , favor verificar o nome da tela novamente.";
                      retorno[1] = false;
                      return retorno;
                    }

                    if (dados.hasFoto == true)
                    {
                            try
                            {
                                // Procura o pai de has foto que é isMainFoto
                                string nomeIsMainFoto = contextoBase.itemsPagina.Where(r => r.isMainPhoto == true).First().nome_pagina.Trim();
                                dados.pagina_pai = nomeIsMainFoto;
                            }
                            catch (Exception e)
                            {
                                retorno[0] = "Erro !<br/> Talvez ainda não tenha cadastrado uma pagina com a categoria de  foto principal ! <br/> Favor verificar se a página com a categoria existe e tente novamente !";
                                retorno[1] = false;
                                return retorno;
                            }
                        }
                        else if (dados.isMainPhoto == true)
                        {
                            // Condição para isMainPhoto , pagina main sera o pai 
                            dados.pagina_pai = "_main";
                        }
                        else if (dados.hasForm == true)
                        {
                            // Condição para has Form , pagina main sera o pai 
                            dados.pagina_pai = "_main";
                        }

                    // Grava pagina no banco 
                    contextoBase.itemsPagina.Add(dados);

                    // Valida se cria botão / caso for uma galeria de fotos ou 
                    // ou cria botão for verdadeiro 
                    if(dados.isMainPhoto == true || dados.cria_botao == true){
                        try
                        {
                            ButtonSite botao = new ButtonSite();
                            botao.descricao = dados.nome_pagina;
                            botao.caminhoUrl = dados.nome_pagina;
                            botao.type = "link";
                            botao.tagPagina = "";
                            contextoBase.Botoes.Add(botao);
                        }
                        catch(Exception e )
                        {
                            retorno[0] = "Erro !<br/> Houve um erro ao tentar gravar o botão da tela , <br/> favor tentar novamente ! <br/> Detalhes do erro : " + e.InnerException;
                            retorno[1] = false;
                            return retorno;

                        }
                    }

               }
               
               else
               {
                   // Faz update  de dados
                   contextoBase.itemsPagina.Update(dados);
               }

               contextoBase.SaveChanges();
            }
            catch(Exception e)
            {
                retorno[0] = "Houve um erro no cadastro da tela  segue detalhes abaixo <br/> detalhes do erro : " + e.InnerException;
                retorno[1] = false;
            }
            finally
            {
                retorno[0] = "";
                retorno[1] = true;
            }

            return retorno;
        }


/*
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
*/
        
    }
}