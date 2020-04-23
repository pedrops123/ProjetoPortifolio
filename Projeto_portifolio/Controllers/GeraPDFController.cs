using System;
using ProjetoPortifolio.RepositoryContext;
using System.IO;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace ProjetoPortifolio.Controllers
{
    public class GeraPDFController:Controller
    {
        private string path = Directory.GetCurrentDirectory();
        GeraPDFCurriculum contextoPDF;
        public GeraPDFController(){
   
            // Path completo pasta
            var pathCompleto = path + @"\wwwroot\pdfTemp\";
            contextoPDF = new GeraPDFCurriculum(pathCompleto);
        }


        [HttpGet]
        public object[] geraPDFCurriculum()
        {
            var retorno = contextoPDF.montaPDFCurriculum();
            return retorno;
        }

         [HttpGet]
        public FileResult DonwloadArquivo(string caminhoArquivo){

            FileStreamResult response = PrepareArquivoErro();
            try
            {
                FileStream fileContent = new FileStream(caminhoArquivo,FileMode.Open,FileAccess.Read,FileShare.Read);
                string nomeArquivo = caminhoArquivo.Split('\\').Last(); 
                response = File(fileContent, "application/pdf",nomeArquivo);  
 
            }
            catch(Exception e)
            {
                return response;
            }
            
           return response;
        }

        public FileStreamResult PrepareArquivoErro(){
           FileStream arquivoErro = new FileStream("Erro.txt",FileMode.Create,FileAccess.ReadWrite,FileShare.ReadWrite);
            using(StreamWriter writer = new StreamWriter(arquivoErro)){
                writer.Write("Ocorreu um erro ao tentar gerar o PDF !");
            }
            
            FileStreamResult retornoArquivo = File(arquivoErro,"text/plain","Erro.txt");
            return retornoArquivo;
        }

        
    }
} 