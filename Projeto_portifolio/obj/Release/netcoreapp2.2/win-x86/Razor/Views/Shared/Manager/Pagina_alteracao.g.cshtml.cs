#pragma checksum "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a609c7e4477aee1c0d712c179bfa4e6d6840eb47"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a609c7e4477aee1c0d712c179bfa4e6d6840eb47", @"/Views/Shared/Manager/Pagina_alteracao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Manager_Pagina_alteracao : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoPortifolio.ViewModel.PortifolioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Components/MensagemAlerta.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(56, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";
    string idPagina = ViewData["idPagina"].ToString();

#line default
#line hidden
            BeginContext(168, 42, true);
            WriteLiteral("\r\n<div id=\"hdnPagina\" style=\"display:none\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 210, "\"", 227, 1);
#line 8 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
WriteAttributeValue("", 218, idPagina, 218, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(228, 11, true);
            WriteLiteral("></div>\r\n\r\n");
            EndContext();
            BeginContext(239, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a609c7e4477aee1c0d712c179bfa4e6d6840eb475511", async() => {
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
            BeginContext(296, 59, true);
            WriteLiteral("\r\n    <div class=\"col-10\"></div>\r\n    <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 355, "\"", 431, 3);
            WriteAttributeValue("", 365, "location.href=\'", 365, 15, true);
#line 12 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
WriteAttributeValue("", 380, Url.Action("chamaManagerPrincipal", "Portifolio"), 380, 50, false);

#line default
#line hidden
            WriteAttributeValue("", 430, "\'", 430, 1, true);
            EndWriteAttribute();
            BeginContext(432, 166, true);
            WriteLiteral(" class=\"btn btn-info\"><span class=\"fa fa-arrow-left\"></span>&nbsp; Voltar para manager principal </button>\r\n    <div class=\"col-10\"></div>\r\n    <br />\r\n    <br />\r\n\r\n");
            EndContext();
#line 17 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
      
        int contador = 1;
        string IdFormulario = "formularioSubmit" + @contador.ToString();
        

#line default
#line hidden
            BeginContext(715, 184, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a609c7e4477aee1c0d712c179bfa4e6d6840eb477805", async() => {
                BeginContext(759, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 21 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
             foreach (string forms in Model.formularios)
            {
                

#line default
#line hidden
                BeginContext(851, 15, false);
#line 23 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
           Write(Html.Raw(forms));

#line default
#line hidden
                EndContext();
#line 23 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                                ;
            }

#line default
#line hidden
                BeginContext(884, 8, true);
                WriteLiteral("        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "id", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 20 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
AddHtmlAttributeValue("", 744, IdFormulario, 744, 13, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(899, 34, true);
            WriteLiteral("\r\n        <br />\r\n        <br />\r\n");
            EndContext();
            BeginContext(940, 6, true);
            WriteLiteral("\r\n    ");
            EndContext();
            BeginContext(946, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a609c7e4477aee1c0d712c179bfa4e6d6840eb4710587", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(997, 91, true);
            WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n    $(document).ready(function () {\r\n\r\n      if (\"");
            EndContext();
            BeginContext(1089, 8, false);
#line 35 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
      Write(idPagina);

#line default
#line hidden
            EndContext();
            BeginContext(1097, 322, true);
            WriteLiteral(@""" != """") {

            $(""#nome_pagina_id"").removeClass(""form-control"").addClass(""form-control-plaintext"");
            $(""#nome_pagina_id"").attr('disabled', 'disabled');

            $.ajax({
                type: ""GET"",
                url: ""getDadosTela"",
                data: {
                    idTela: """);
            EndContext();
            BeginContext(1420, 8, false);
#line 44 "C:\Projeto_portifolio\Views\Shared\Manager\Pagina_alteracao.cshtml"
                        Write(idPagina);

#line default
#line hidden
            EndContext();
            BeginContext(1428, 2255, true);
            WriteLiteral(@"""
                },
                success: function (response) {
                    $(""#nome_pagina_id"").val(response[0]);
                    $(""#titulo_aba_id"").val(response[1]);
                    $(""#titulo_pagina_id"").val(response[2]);
                    $(""#conteudo_pagina_id"").val(response[3]);

                    if (response[4] == 1) {
                        $(""#foto_pagina_id"").val(""Sim"");
                    } else {
                        $(""#foto_pagina_id"").val(""Não"");
                    }

                    if (response[5] == 1) {
                        $(""#form_pagina_id"").val(""Sim"");
                    } else {
                        $(""#form_pagina_id"").val(""Não"");
                    }

                    if (response[6] == 1) {

                        $(""#conteudo_pagina_id"").attr('disabled', 'disabled');
                        $(""#form_pagina_id"").attr('disabled', 'disabled');
                        $(""#foto_pagina_id"").attr('disabled', 'disabled");
            WriteLiteral(@"');
                        $(""#foto_pagina_id"").val(""Não"");
                        $(""#form_pagina_id"").val(""Não"");
                        $(""#conteudo_pagina_id"").val("""");
                        $(""#check_foto_principal"").prop('checked', true);
                    }

                     $(""#area-check_botao"").hide();
                },
                failure: function () {
                    alert(""Ocorreu um erro na captura dos dados"");
                }
            });
        }


    });



$(""#check_foto_principal"").click(
    function () {
        if ($(""#check_foto_principal"")[0].checked == true) {

            $(""#conteudo_pagina_id"").attr('disabled', 'disabled');
            $(""#form_pagina_id"").attr('disabled', 'disabled');
            $(""#foto_pagina_id"").attr('disabled', 'disabled');
            $(""#foto_pagina_id"").val(""Não"");
            $(""#form_pagina_id"").val(""Não"");
            $(""#conteudo_pagina_id"").val("""");
        } else {

            $(""#conteudo");
            WriteLiteral("_pagina_id\").attr(\'disabled\', false);\r\n            $(\"#form_pagina_id\").attr(\'disabled\', false);\r\n            $(\"#foto_pagina_id\").attr(\'disabled\', false);\r\n        }\r\n\r\n    },\r\n);\r\n\r\n\r\n\r\n\r\n\r\n    </script>\r\n");
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
