#pragma checksum "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22de296ae5504affed5ac50d4521218b86197bce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Manager_Pagina_alteracao), @"mvc.1.0.view", @"/Views/Shared/Manager/Pagina_alteracao.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Manager/Pagina_alteracao.cshtml", typeof(AspNetCore.Views_Shared_Manager_Pagina_alteracao))]
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
#line 1 "C:\Projeto_portifolio\Views\_ViewImports.cshtml"
using ProjetoPortifolio;

#line default
#line hidden
#line 2 "C:\Projeto_portifolio\Views\_ViewImports.cshtml"
using ProjetoPortifolio.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22de296ae5504affed5ac50d4521218b86197bce", @"/Views/Shared/Manager/Pagina_alteracao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Manager_Pagina_alteracao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoPortifolio.ViewModel.PortifolioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Components/MensagemAlerta.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(112, 186, true);
            WriteLiteral("\r\n<style>\r\n    #container-checkbox\r\n    {\r\n        border:none; \r\n        /*border-radius:8px 8px 8px 8px; */\r\n        /*border-color:gray;*/\r\n        width:220px;\r\n    }\r\n</style>\r\n\r\n\r\n");
            EndContext();
            BeginContext(298, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "22de296ae5504affed5ac50d4521218b86197bce4597", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(355, 61, true);
            WriteLiteral("\r\n\r\n    <div class=\"col-10\"></div>\r\n    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 416, "\"", 481, 3);
            WriteAttributeValue("", 426, "location.href=\'", 426, 15, true);
#line 21 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
WriteAttributeValue("", 441, Url.Action("Index","managerAlteracao"), 441, 39, false);

#line default
#line hidden
            WriteAttributeValue("", 480, "\'", 480, 1, true);
            EndWriteAttribute();
            BeginContext(482, 234, true);
            WriteLiteral(" class=\"btn btn-info\"><span class=\"fa fa-arrow-left\"></span>&nbsp; Voltar para manager principal </button>\r\n    <div class=\"col-10\"></div>\r\n    <br />\r\n    <br />\r\n    \r\n<div class=\"card bg-light\">\r\n    <article class=\"card-body\">\r\n\r\n");
            EndContext();
#line 29 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
             using(Html.BeginForm("validaCadastro","managerAlteracaoPaginas",FormMethod.Post , new { @id = "formulario_alteracao" }))
            {

#line default
#line hidden
            BeginContext(866, 23, true);
            WriteLiteral("                <br/>\r\n");
            EndContext();
            BeginContext(906, 43, false);
#line 32 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
           Write(Html.HiddenFor(r=>r.cadastroTela.id_pagina));

#line default
#line hidden
            EndContext();
            BeginContext(970, 64, false);
#line 34 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1054, 158, true);
            WriteLiteral("                <div class=\"row\">\r\n                    <div class=\"col col-2\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(1213, 43, false);
#line 39 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                       Write(Html.Label("nome_pagina", "Nome da Página"));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 65, true);
            WriteLiteral("\r\n                            <br/>\r\n                            ");
            EndContext();
            BeginContext(1322, 103, false);
#line 41 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                       Write(Html.ValidationMessageFor(r=>r.cadastroTela.nome_pagina , "" , new { @style = "color:red;!important" }));

#line default
#line hidden
            EndContext();
            BeginContext(1425, 306, true);
            WriteLiteral(@"

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                        <span class=""input-group-text""> <i class=""fa fa-user""></i> </span>
                                </div>
                                ");
            EndContext();
            BeginContext(1732, 100, false);
#line 47 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                           Write(Html.TextBoxFor(r=>r.cadastroTela.nome_pagina , new { @class= "form-control" , @id = "nome_pagina"}));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 224, true);
            WriteLiteral("\r\n                            </div>\r\n\r\n                        </div>\r\n                    </div> \r\n                    <div class=\"col col-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2057, 43, false);
#line 54 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                       Write(Html.LabelFor(r=>r.cadastroTela.titulo_aba));

#line default
#line hidden
            EndContext();
            BeginContext(2100, 66, true);
            WriteLiteral(" \r\n                            <br/>\r\n                            ");
            EndContext();
            BeginContext(2167, 98, false);
#line 56 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                       Write(Html.ValidationMessageFor(r=>r.cadastroTela.titulo_aba,"",new { @style = "color:red;!important" }));

#line default
#line hidden
            EndContext();
            BeginContext(2265, 306, true);
            WriteLiteral(@"

                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                        <span class=""input-group-text""> <i class=""fa fa-user""></i> </span>
                                </div>
                                ");
            EndContext();
            BeginContext(2572, 98, false);
#line 62 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                           Write(Html.TextBoxFor(r=>r.cadastroTela.titulo_aba , new { @class= "form-control" , @id = "titulo_aba"}));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 221, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"col col-4\">\r\n                        <div class=\"form-group\">\r\n                            ");
            EndContext();
            BeginContext(2892, 46, false);
#line 68 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                       Write(Html.LabelFor(r=>r.cadastroTela.titulo_pagina));

#line default
#line hidden
            EndContext();
            BeginContext(2938, 66, true);
            WriteLiteral(" \r\n                            <br/>\r\n                            ");
            EndContext();
            BeginContext(3005, 101, false);
#line 70 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                       Write(Html.ValidationMessageFor(r=>r.cadastroTela.titulo_pagina,"",new { @style = "color:red;!important" }));

#line default
#line hidden
            EndContext();
            BeginContext(3106, 300, true);
            WriteLiteral(@"
                            <div class=""input-group"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text""> <i class=""fa fa-user""></i> </span>
                                </div>
                                ");
            EndContext();
            BeginContext(3407, 104, false);
#line 75 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                           Write(Html.TextBoxFor(r=>r.cadastroTela.titulo_pagina , new { @class= "form-control" , @id = "titulo_pagina"}));

#line default
#line hidden
            EndContext();
            BeginContext(3511, 135, true);
            WriteLiteral("\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n\r\n                </div>           \r\n");
            EndContext();
            BeginContext(3648, 161, true);
            WriteLiteral("                <div class=\"row\">\r\n\r\n                    <div class=\"col col-9\">\r\n                        <div class=\"form-group\">\r\n                             ");
            EndContext();
            BeginContext(3810, 48, false);
#line 86 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                        Write(Html.LabelFor(r=>r.cadastroTela.conteudo_pagina));

#line default
#line hidden
            EndContext();
            BeginContext(3858, 68, true);
            WriteLiteral(" \r\n                             <br/>\r\n                             ");
            EndContext();
            BeginContext(3927, 107, false);
#line 88 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                        Write(Html.ValidationMessageFor(r=>r.cadastroTela.conteudo_pagina , "" , new { @style = "color:red;!important" }));

#line default
#line hidden
            EndContext();
            BeginContext(4034, 34, true);
            WriteLiteral("   \r\n                             ");
            EndContext();
            BeginContext(4069, 110, false);
#line 89 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                        Write(Html.TextAreaFor(r=>r.cadastroTela.conteudo_pagina , new { @class= "form-control",  @id = "conteudo_pagina" }));

#line default
#line hidden
            EndContext();
            BeginContext(4179, 672, true);
            WriteLiteral(@"
                        </div>
                    </div>

                   <div id=""container-checkbox"" class=""col col-sm-4 col-md-4 col-lg-3"">
                       <div class=""row"">
                            <div class=""col col-md-2 col-sm-2 col-lg-2""></div>
                            <div class=""col col-md-8"" ><span class=""col""> <b> Opções </b> </span> <br /> </div><br/>
                            <div class=""col col-md-2 col-sm-2 col-lg-2""></div>
                       </div>
                        
                        <hr/>
                        <div>
                            <div class=""col"" >
                                ");
            EndContext();
            BeginContext(4852, 103, false);
#line 103 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                           Write(Html.CheckBoxFor(r=>r.cadastroTela.cria_botao , new { @class="form-check-input" ,  @id = "criaBotao" }));

#line default
#line hidden
            EndContext();
            BeginContext(4955, 34, true);
            WriteLiteral("\r\n                                ");
            EndContext();
            BeginContext(4990, 76, false);
#line 104 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                           Write(Html.LabelFor(r=>r.cadastroTela.cria_botao , new {@class="checkbox-inline"}));

#line default
#line hidden
            EndContext();
            BeginContext(5066, 120, true);
            WriteLiteral(" \r\n                            </div>\r\n                            <div class=\"col\">\r\n                                  ");
            EndContext();
            BeginContext(5187, 98, false);
#line 107 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                             Write(Html.CheckBoxFor(r=>r.cadastroTela.hasFoto , new { @class="form-check-input" ,  @id = "hasFoto" }));

#line default
#line hidden
            EndContext();
            BeginContext(5285, 36, true);
            WriteLiteral("\r\n                                  ");
            EndContext();
            BeginContext(5322, 73, false);
#line 108 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                             Write(Html.LabelFor(r=>r.cadastroTela.hasFoto , new {@class="checkbox-inline"}));

#line default
#line hidden
            EndContext();
            BeginContext(5395, 122, true);
            WriteLiteral(" \r\n                            </div>\r\n\r\n                            <div class=\"col\">\r\n                                  ");
            EndContext();
            BeginContext(5518, 98, false);
#line 112 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                             Write(Html.CheckBoxFor(r=>r.cadastroTela.hasForm , new { @class="form-check-input" ,  @id = "hasForm" }));

#line default
#line hidden
            EndContext();
            BeginContext(5616, 36, true);
            WriteLiteral("\r\n                                  ");
            EndContext();
            BeginContext(5653, 73, false);
#line 113 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                             Write(Html.LabelFor(r=>r.cadastroTela.hasForm , new {@class="checkbox-inline"}));

#line default
#line hidden
            EndContext();
            BeginContext(5726, 139, true);
            WriteLiteral(" \r\n                            </div>\r\n\r\n                            <div class=\"col\" id=\"mainFotoGrp\">\r\n                                  ");
            EndContext();
            BeginContext(5866, 105, false);
#line 117 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                             Write(Html.CheckBoxFor(r=>r.cadastroTela.isMainPhoto , new { @class="form-check-input" ,  @id = "isMainFoto" }));

#line default
#line hidden
            EndContext();
            BeginContext(5971, 36, true);
            WriteLiteral("\r\n                                  ");
            EndContext();
            BeginContext(6008, 76, false);
#line 118 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                             Write(Html.LabelFor(r=>r.cadastroTela.isMainPhoto, new {@class="checkbox-inline"}));

#line default
#line hidden
            EndContext();
            BeginContext(6084, 580, true);
            WriteLiteral(@" 
                            </div>
                        </div>

                    </div>

                </div>
                <br/>
                <div class=""row float-right"">
                        <div class=""col"">
                            <button type=""button"" class=""btn btn-danger"" id=""clear_form""><span class=""fas fa-eraser""></span> &nbsp; Limpar</button>
                            <button class=""btn btn-primary"" type=""submit""><span class=""fas fa-save""></span> &nbsp; Salvar </button>
                        </div>

                </div>
");
            EndContext();
#line 133 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
            }

#line default
#line hidden
            BeginContext(6679, 30, true);
            WriteLiteral("    </article>\r\n\r\n</div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(7059, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(7063, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22de296ae5504affed5ac50d4521218b86197bce20367", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7114, 2147, true);
            WriteLiteral(@"
    <script type=""text/javascript"">

    $(document).ready(function () {
        var idPagina = parseInt($(""#cadastroTela_id_pagina"").val());

        // Valida se for pagina principal 
        var nomePagina = $(""#nome_pagina"").val();
        if (nomePagina == ""_main""){
            $(""#mainFotoGrp"").hide();
        }

        if (idPagina != 0){
           // $(""#cadastroTela_nome_pagina"").removeClass(""form-control"").addClass(""form-control-plaintext"");
            $(""#nome_pagina"").attr('readonly', 'readonly');
            $(""#criaBotao"").attr('onClick', 'return false;');
        } 

        if ($(""#isMainFoto"")[0].checked == true) {

            $(""#conteudo_pagina"").attr('readonly', 'readonly');
            $(""#conteudo_pagina"").val("""");

            $(""#hasFoto"").prop('disabled',true);
            $(""#hasFoto"").prop('checked',false);

            $(""#hasForm"").prop('disabled',true);
            $(""#hasForm"").prop('checked',false);
        }   
    });



$(""#isMainFoto"").");
            WriteLiteral(@"click(
    function () {
        if ($(""#isMainFoto"")[0].checked == true) {

            $(""#conteudo_pagina"").attr(""readonly"", true); 
            $(""#conteudo_pagina"").val("""");

            $(""#hasFoto"").prop('disabled',true);
            $(""#hasFoto"").prop('checked',false);

            $(""#hasForm"").prop('disabled',true);
            $(""#hasForm"").prop('checked',false);
        } else {
            $(""#conteudo_pagina"").attr(""readonly"", false); 
            $(""#hasFoto"").attr('disabled', false);
            $(""#hasForm"").attr('disabled', false);
        }

    }
);


$(""#clear_form"").click(function(){
    var idPagina = $(""#cadastroTela_id_pagina"").val();

    // So limpa nome da pagina caso seja um novo registro
    if (idPagina == 0){
        $(""#nome_pagina"").val("""");
        $(""#criaBotao"").prop('checked',false);
    } 

    $(""#titulo_aba"").val("""");
    $(""#titulo_pagina"").val("""");
    $(""#conteudo_pagina"").val("""");
    $(""#hasFoto"").prop('checked',false);
    $(""#h");
            WriteLiteral("asForm\").prop(\'checked\',false);\r\n    $(\"#isMainFoto\").prop(\'checked\',false);\r\n});\r\n\r\n\r\n </script>\r\n");
            EndContext();
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
