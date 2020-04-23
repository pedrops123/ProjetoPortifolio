using System;
using System.IO;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace ProjetoPortifolio.RepositoryContext
{
    public class GeraPDFCurriculum
    {
        string caminhoDoc = "";
        string nomeCriador = "Pedro Vinicius Rodrigues Furlan";
         Document doc;

        // Construtor da classe
        public GeraPDFCurriculum(string caminhoSalvar)
        {
            this.caminhoDoc = caminhoSalvar;
        }

        public object[] montaPDFCurriculum()
        {

            object[] retornoMontagem = new object[2];
            
            // Verifica se o diretorio existe  e cria caso nao encontre
            if(!Directory.Exists(caminhoDoc))
            {
                Directory.CreateDirectory(caminhoDoc);
            }

            string nomeArquivo = String.Format("{0}{1}",caminhoDoc,"Curriculum_Pedro.pdf");

             
            FileStream ArquivoFisico = new FileStream(nomeArquivo, FileMode.Create);

            try
            {
                  doc = new Document(PageSize.A4, 20 , 20 , 20 , 20);
                  doc.AddTitle(String.Format("{0} - {1}","Curriculum",nomeCriador));
                  doc.AddAuthor(nomeCriador);
                  doc.AddCreator(nomeCriador);
                  PdfWriter writer = PdfWriter.GetInstance(doc,ArquivoFisico);
                  doc.Open();
                  criaCabecalho();

            }
            catch(Exception e)
            {
                doc.Close();
                ArquivoFisico.Close();
                ArquivoFisico.Dispose();
                retornoMontagem[0] = false;
                retornoMontagem[1] = "Houve um erro na montagem do arquivo ! <br/> Segue detalhes do erro : " + e.InnerException;
               return retornoMontagem;
            }

             doc.Close();
             ArquivoFisico.Close();
             ArquivoFisico.Dispose();
             retornoMontagem[0] = true;
             retornoMontagem[1] = nomeArquivo;

          
            return retornoMontagem;
        }


        public void criaCabecalho(){
            PdfPTable tableTituloPrincipal = new PdfPTable(10);
            PdfPCell celulaNome = new PdfPCell(new Paragraph(nomeCriador));
            celulaNome.HorizontalAlignment = Element.ALIGN_CENTER;
            celulaNome.VerticalAlignment = Element.ALIGN_MIDDLE;
            celulaNome.PaddingTop = 5;
            celulaNome.PaddingBottom = 5;
            celulaNome.Colspan = 10;
            tableTituloPrincipal.AddCell(celulaNome);
            doc.Add(tableTituloPrincipal);
        }










    }




    
}