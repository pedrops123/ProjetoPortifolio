#pragma checksum "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c5926820dd4faddb627c812b5e6944cfbb3aa3df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Portifolio_LayoutGeral), @"mvc.1.0.view", @"/Views/Portifolio/LayoutGeral.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Portifolio/LayoutGeral.cshtml", typeof(AspNetCore.Views_Portifolio_LayoutGeral))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\_ViewImports.cshtml"
using ProjetoPortifolio;

#line default
#line hidden
#line 2 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\_ViewImports.cshtml"
using ProjetoPortifolio.Models;

#line default
#line hidden
#line 5 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c5926820dd4faddb627c812b5e6944cfbb3aa3df", @"/Views/Portifolio/LayoutGeral.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Portifolio_LayoutGeral : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoPortifolio.ViewModel.PortifolioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    

#line default
#line hidden
            BeginContext(146, 883, true);
            WriteLiteral(@"
<style>
    .imagens-portifolio {
        display: -webkit-flex; /* Safari */
        -webkit-flex-wrap: wrap; /* Safari 6.1+ */
        display: inline-flex;
        flex-wrap: wrap;
    }

    .imagens-portifolio-item {
        display: -webkit-flex; /* Safari */
        -webkit-flex-wrap: wrap; /* Safari 6.1+ */
        display: inline-flex;
        flex-wrap: wrap;
        border: none;
    }
</style>




<div class=""alert alert-warning alert-dismissible fade show"" id=""msg-alerta"" role=""alert"" style=""display:none;"">
    <div id=""titulo_alerta""></div> <br /> <br />
    <div id=""texto-alerta""> </div>
    <button type=""button"" id=""close-alert"" class=""close"" aria-label=""Close"">
        <span aria-hidden=""true"">&times;</span>
    </button>
</div>


<div hidden=""hidden"" style=""align-content:center;"" class=""spinner-grow text-dark""></div>


");
            EndContext();
#line 40 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
 if (Model.dadosPagina.nome_pagina == "_main")
{

#line default
#line hidden
            BeginContext(1080, 114, true);
            WriteLiteral("    <div id=\"item-principal\" class=\"row\">\r\n        <div class=\"col-sm-2\"></div>\r\n        <div class=\"col-sm-11\">\r\n");
            EndContext();
#line 45 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
             if (Model.mainFoto != "")
            {

#line default
#line hidden
            BeginContext(1249, 63, true);
            WriteLiteral("                <img id=\"img-principal\"  class=\"rounded-circle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 1312, "\"", 1333, 1);
#line 47 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
WriteAttributeValue("", 1318, Model.mainFoto, 1318, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1334, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 48 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(1387, 207, true);
            WriteLiteral("                <div style=\" width:300px; height:300px; align-content:center; \" id=\"img-principal\" class=\"rounded-circle\"> <div style=\"width:150px; margin: 123px 0px 0px 66px;\">Nenhuma Imagem</div>  </div>\r\n");
            EndContext();
#line 52 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
            }

#line default
#line hidden
            BeginContext(1609, 145, true);
            WriteLiteral("            <div class=\"content\">\r\n                <div style=\"display:none;\" id=\"desc-principal\" class=\"description-main\">\r\n                    ");
            EndContext();
            BeginContext(1755, 54, false);
#line 55 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
               Write(Html.Raw(Model.dadosPagina.conteudo_pagina.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(1809, 113, true);
            WriteLiteral(";\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-sm-2\"></div>\r\n    </div>\r\n");
            EndContext();
#line 61 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"

}

#line default
#line hidden
            BeginContext(1927, 6, true);
            WriteLiteral("\r\n\r\n\r\n");
            EndContext();
#line 66 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
 if (Model.dadosPagina.conteudo_pagina != "" && Model.dadosPagina.nome_pagina != "_main")
{

#line default
#line hidden
            BeginContext(2027, 8, true);
            WriteLiteral("    <p> ");
            EndContext();
            BeginContext(2036, 54, false);
#line 68 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
   Write(Html.Raw(Model.dadosPagina.conteudo_pagina.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(2090, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
#line 69 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
}

#line default
#line hidden
            BeginContext(2100, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 72 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
 if (Model.dadosPagina.hasForm == true)
{
    

#line default
#line hidden
#line 74 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
     if (Model.dadosPagina.nome_pagina == "_login" && User.Identity.IsAuthenticated == true)
    {

#line default
#line hidden
            BeginContext(2249, 120, true);
            WriteLiteral("        <h3><b> <i style=\"color:red;\">Atenção</i> <br /><br /> Você já esta logado com o usuário  <i style=\"color:red;\">");
            EndContext();
            BeginContext(2370, 18, false);
#line 76 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
                                                                                                                   Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(2388, 105, true);
            WriteLiteral(" </i> caso queira acessar o login , favor deslogar e entrar com o usuario e senha novamente !</b> </h3>\r\n");
            EndContext();
#line 77 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
    }
    else
    {
        int contador = 1;
        string IdFormulario = "formularioSubmit" + contador.ToString();


#line default
#line hidden
            BeginContext(2619, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2627, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c5926820dd4faddb627c812b5e6944cfbb3aa3df11221", async() => {
                BeginContext(2662, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 85 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
             foreach (string forms in Model.formularios)
            {
                

#line default
#line hidden
                BeginContext(2756, 15, false);
#line 87 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
           Write(Html.Raw(forms));

#line default
#line hidden
                EndContext();
#line 87 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
                                ;
            }

#line default
#line hidden
                BeginContext(2789, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 83 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
AddHtmlAttributeValue("", 2637, IdFormulario, 2637, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2804, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 90 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
    }

#line default
#line hidden
#line 90 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
     
}

#line default
#line hidden
            BeginContext(2816, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 93 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
 if (Model.dadosPagina.nome_pagina != "_main")
{
    

#line default
#line hidden
#line 95 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
     if (Model.dadosPagina.hasFoto == true)
    {
        

#line default
#line hidden
#line 97 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
         foreach (ImagensPortifolio foto in Model.imagens)
        {

#line default
#line hidden
            BeginContext(2992, 227, true);
            WriteLiteral("            <div class=\"imagens-portifolio-item  view overlay zoom\">\r\n                <div style=\"border:inset; width:253px; height:253px;  margin-left:20px; margin-top:20px;\">\r\n                    <a class=\"example-image-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3219, "\"", 3239, 1);
#line 101 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
WriteAttributeValue("", 3226, foto.urlFoto, 3226, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3240, 39, true);
            WriteLiteral(" data-lightbox=\"example-1\" data-title=\"");
            EndContext();
            BeginContext(3280, 19, false);
#line 101 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
                                                                                                        Write(foto.descricao_foto);

#line default
#line hidden
            EndContext();
            BeginContext(3299, 77, true);
            WriteLiteral("\"><img style=\"width:253px; height:253px;\" class=\"example-image img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3376, "\"", 3395, 1);
#line 101 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
WriteAttributeValue("", 3382, foto.urlFoto, 3382, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3396, 82, true);
            WriteLiteral(" alt=\"image-1\" /></a>\r\n                </div>               \r\n            </div>\r\n");
            EndContext();
#line 104 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
        }

#line default
#line hidden
#line 104 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
         

    }

#line default
#line hidden
#line 108 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
     if (Model.dadosPagina.isMainPhoto == true)
    {
        

#line default
#line hidden
#line 110 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
         foreach (ImagensPortifolio foto in Model.imagens)
        {

#line default
#line hidden
            BeginContext(3627, 237, true);
            WriteLiteral("            <div style=\"border:inset; width:253px; height:253px; border-color:black; margin-left:20px; margin-top:20px;\" class=\"imagens-portifolio\">\r\n                <div class=\"hovereffect\">\r\n                    <img class=\"img-project\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3864, "\"", 3883, 1);
#line 114 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
WriteAttributeValue("", 3870, foto.urlFoto, 3870, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3884, 105, true);
            WriteLiteral(" alt=\"\">\r\n                    <div class=\"title\" style=\"margin-top:100px;\">\r\n                        <h2>");
            EndContext();
            BeginContext(3990, 30, false);
#line 116 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
                       Write(foto.id_tela.Replace("_", " "));

#line default
#line hidden
            EndContext();
            BeginContext(4020, 362, true);
            WriteLiteral(@"</h2>
                    </div>
                    <img />
                    <div class=""overlay"" style=""width:400px;"">
                        <div style=""width:300px; margin:2px; margin-left:-44px;"">
                            <a id=""btn_visit"" data-placement=""top"" data-toggle=""tooltip"" title=""Abrir Galeria de Fotos"" class=""tip-top btn btn-primary""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4382, "\"", 4419, 1);
#line 121 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
WriteAttributeValue("", 4389, "/Portifolio/"+foto.id_tela, 4389, 30, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4420, 319, true);
            WriteLiteral(@">Galeria</a>
                            <button type=""button"" data-placement=""top"" data-toggle=""tooltip"" title=""Ver História do projeto"" id=""btn_desc"" class=""tip-top btn btn-success""> Descrição  Projeto</button>
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 127 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"

        }

#line default
#line hidden
#line 128 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
         
    }

#line default
#line hidden
            BeginContext(4761, 36, true);
            WriteLiteral("    <br />\r\n    <br />\r\n    <br />\r\n");
            EndContext();
#line 135 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
     if (Model.imagens != null)
    {
        

#line default
#line hidden
            BeginContext(4848, 343, false);
#line 137 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
   Write(Html.PagedListPager(Model.imagens, pagina => Url.Action("ChamaViewDinamica", new { Model.dadosPagina.nome_pagina, pagina }),
           new X.PagedList.Mvc.Common.PagedListRenderOptionsBase
           {
               LiElementClasses = new string[] { "page-item" },
               PageClasses = new string[] { "page-link" }
           }));

#line default
#line hidden
            EndContext();
#line 142 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
             ;
    }

#line default
#line hidden
#line 143 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Portifolio\LayoutGeral.cshtml"
     


}

#line default
#line hidden
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoPortifolio.ViewModel.PortifolioViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
