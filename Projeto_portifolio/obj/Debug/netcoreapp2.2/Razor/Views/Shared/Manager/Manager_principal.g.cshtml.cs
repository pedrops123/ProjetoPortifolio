#pragma checksum "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b208243f3184a00f06e174159ab5c84914c2cb8e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Manager_Manager_principal), @"mvc.1.0.view", @"/Views/Shared/Manager/Manager_principal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Manager/Manager_principal.cshtml", typeof(AspNetCore.Views_Shared_Manager_Manager_principal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b208243f3184a00f06e174159ab5c84914c2cb8e", @"/Views/Shared/Manager/Manager_principal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Manager_Manager_principal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoPortifolio.ViewModel.PortifolioViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Components/MensagemAlerta.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("30"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/icon_photo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/icons/form_icon.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Shared/Manager/_ScriptsManagerPrincipal.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
  

    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(114, 370, true);
            WriteLiteral(@"
<style>
    .notify-badge {
        position: fixed;
        margin-left: -15px;
        background: red;
        text-align: center;
        border-radius: 30px 30px 30px 30px;
        color: white;
        padding: 1px 10px;
        margin-top: -18px;
        font-size: 20px;
    }

    #preview_fotos {
        margin-left: 21px;
    }
</style>

");
            EndContext();
            BeginContext(601, 1482, true);
            WriteLiteral(@"<br />


<div class=""modal fade"" id=""modalDinamico"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-dialog-centered"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <div id=""typeHdn"" hidden=""hidden""></div>
                <div id=""nomePagina"" hidden=""hidden""></div>
                <div id=""hdnIdFoto"" hidden=""hidden""></div>
                <h5 class=""modal-title"" id=""ModalTitulo""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div id=""conteudo_fotos"" class=""modal-body"">

            </div>
            <div class=""modal-footer"">

                <div class=""custom-file"">
                    <input type=""file"" class=""custom-file-input"" id=""data_fotos"" onchange=""adicionarFotoPreview()"" name=""");
            WriteLiteral(@"imgs[]"" multiple>
                    <label class=""custom-file-label"" for=""customFile""></label>
                </div>

                <button type=""button"" style=""display:none;"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""uploadFoto()"">Gravar Fotos</button>
            </div>
            <div id=""preview_fotos""></div>
        </div>
    </div>
</div>

");
            EndContext();
            BeginContext(2083, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b208243f3184a00f06e174159ab5c84914c2cb8e7852", async() => {
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
            BeginContext(2140, 737, true);
            WriteLiteral(@"

    <div class=""box-itens"" style=""width:1282px;"">
        <div class=""accordion"" id=""accordionExample"">
            <!-- area titulo geral -->
            <div class=""card"">
                <div class=""card-header"" id=""headingOne"">
                    <h2 class=""mb-0"">
                        <span class=""fa fa-pen-alt""></span> Modificação de Titulo Geral
                        <a class=""btn_toggle fa fa-arrow-circle-down fa-pull-right""  data-toggle=""collapse"" data-target=""#tabTituloGeral""></a>
                    </h2>
                </div>
                <div id=""tabTituloGeral"" class=""collapse show"" aria-labelledby=""headingOne"" data-parent=""#accordionExample"">
                    <div class=""card-body"">

");
            EndContext();
#line 75 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                         using(@Html.BeginForm("gravaLinkUrlPrincipal","managerAlteracao",FormMethod.Post))
                        {
                            

#line default
#line hidden
            BeginContext(3042, 23, false);
#line 77 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(3067, 225, true);
            WriteLiteral("                            <div class=\"row\">\r\n                                <div class=\"col col-md\"></div>\r\n                                <div class=\"col col-sm-6 col-md-5 col-lg-8\">\r\n                                    ");
            EndContext();
            BeginContext(3293, 40, false);
#line 81 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                               Write(Html.LabelFor(r=>r.cadastroLink.linkUrl));

#line default
#line hidden
            EndContext();
            BeginContext(3333, 43, true);
            WriteLiteral("<br/>\r\n                                    ");
            EndContext();
            BeginContext(3377, 99, false);
#line 82 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                               Write(Html.ValidationMessageFor(r => r.cadastroLink.linkUrl, "", new { @style = "color:red;!important" }));

#line default
#line hidden
            EndContext();
            BeginContext(3476, 38, true);
            WriteLiteral("\r\n                                    ");
            EndContext();
            BeginContext(3515, 107, false);
#line 83 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                               Write(Html.TextBoxFor(r=>r.cadastroLink.linkUrl , new { @class="form-control input", placeholder="Url do site" }));

#line default
#line hidden
            EndContext();
            BeginContext(3622, 142, true);
            WriteLiteral("\r\n                                </div>\r\n                                <div class=\"col col-md\"></div>\r\n                            </div>\r\n");
            EndContext();
            BeginContext(3794, 35, true);
            WriteLiteral("                            <hr/>\r\n");
            EndContext();
            BeginContext(3859, 238, true);
            WriteLiteral("                            <div class=\"row\">\r\n                                 <div class=\"col col-md\"></div>\r\n                                    <div class=\"col col-sm-6 col-md-5 col-lg-8\">    \r\n                                        ");
            EndContext();
            BeginContext(4098, 46, false);
#line 93 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                   Write(Html.LabelFor(r=>r.cadastroLink.linkDescricao));

#line default
#line hidden
            EndContext();
            BeginContext(4144, 48, true);
            WriteLiteral("<br/>\r\n                                         ");
            EndContext();
            BeginContext(4193, 105, false);
#line 94 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                    Write(Html.ValidationMessageFor(r => r.cadastroLink.linkDescricao, "", new { @style = "color:red;!important" }));

#line default
#line hidden
            EndContext();
            BeginContext(4298, 42, true);
            WriteLiteral("\r\n                                        ");
            EndContext();
            BeginContext(4341, 117, false);
#line 95 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                   Write(Html.TextBoxFor(r=>r.cadastroLink.linkDescricao, new { @class="form-control input", placeholder="Descrição da URL" }));

#line default
#line hidden
            EndContext();
            BeginContext(4458, 514, true);
            WriteLiteral(@"
                                    </div>  
                                <div class=""col col-md""></div>
                            </div>
                        <br/>
                        <div class=""row"">
                            <div class=""col col-md""></div>
                            <div class=""col col-md""><button type=""submit"" class=""btn btn-lg btn-primary btn-block""> Salvar </button></div>
                            <div class=""col col-md""></div>
                        </div>
");
            EndContext();
#line 105 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                        }

#line default
#line hidden
            BeginContext(4999, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(5739, 851, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <!-- area titulo geral -->

            <!-- area Paginas Cadastradas -->
            <div class=""card"">
                <div class=""card-header"" id=""headingTwo"">
                    <h2 class=""mb-0"">
                        <span class=""fa fa-book""></span> Paginas Cadastradas
                        <a class=""btn_toggle fa fa-arrow-circle-down fa-pull-right""   data-toggle=""collapse"" data-target=""#tabPaginasCadastradas""></a>
                    </h2>
                </div>
                <div id=""tabPaginasCadastradas"" class=""collapse"" aria-labelledby=""headingTwo"" data-parent=""#accordionExample"">
                    <div class=""card-body"">

                        <button style=""margin-left:920px; margin-top:-10px; width: 200px;"" type=""button""");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 6590, "\"", 6691, 3);
            WriteAttributeValue("", 6600, "location.href=\'", 6600, 15, true);
#line 139 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
WriteAttributeValue("", 6615, Url.Action("Index","managerAlteracaoPaginas",new { idPagina = "newPage" }), 6615, 75, false);

#line default
#line hidden
            WriteAttributeValue("", 6690, "\'", 6690, 1, true);
            EndWriteAttribute();
            BeginContext(6692, 1096, true);
            WriteLiteral(@" class=""btn btn-outline-success""> <span class=""fa fa-plus-circle""></span> &nbsp; Incluir nova pagina </button>
                        <br />
                        <br />

                        <table id=""listagem_telas"" class=""table table-striped table-bordered table-sm"" align=""center"" data-page-length='5'>
                            <thead>
                                <tr>
                                    <th scope=""col""> ID </th>
                                    <th scope=""col""> Pagina </th>
                                    <th scope=""col""> Titulo da Aba </th>
                                    <th scope=""col""> conteudo da pagina </th>
                                    <th scope=""col""> Possui foto ? </th>
                                    <th scope=""col""> Tem Formulario ? </th>
                                    <th scope=""col""> Galeria Principal ? </th>
                                    <th scope=""col""> Alterar dados </th>
                                </tr>
   ");
            WriteLiteral("                         </thead>\r\n                            <tbody>\r\n");
            EndContext();
#line 157 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                 foreach (ItemsPaginaGeral dadosPagina in Model.listaPaginasSistema)
                                {
                                    var temFoto = dadosPagina.hasFoto == true ? "Sim" : "Não";
                                    var temForm = dadosPagina.hasForm == true ? "Sim" : "Não";
                                    var isGaleria = dadosPagina.isMainPhoto == true ? "Sim" : "Não";
                                    var conteudoPagina = "";
                                    if (dadosPagina.conteudo_pagina.Length > 105)
                                    {
                                        conteudoPagina = dadosPagina.conteudo_pagina.Trim().Substring(0, 60) + "...";
                                    }
                                    else
                                    {
                                        conteudoPagina = dadosPagina.conteudo_pagina.Trim();
                                    }

#line default
#line hidden
            BeginContext(8775, 99, true);
            WriteLiteral("                                    <tr>\r\n                                        <th scope=\"row\"> ");
            EndContext();
            BeginContext(8875, 21, false);
#line 172 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                                    Write(dadosPagina.id_pagina);

#line default
#line hidden
            EndContext();
            BeginContext(8896, 53, true);
            WriteLiteral(" </th>\r\n                                        <td> ");
            EndContext();
            BeginContext(8950, 30, false);
#line 173 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                        Write(dadosPagina.nome_pagina.Trim());

#line default
#line hidden
            EndContext();
            BeginContext(8980, 53, true);
            WriteLiteral(" </td>\r\n                                        <td> ");
            EndContext();
            BeginContext(9034, 29, false);
#line 174 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                        Write(dadosPagina.titulo_aba.Trim());

#line default
#line hidden
            EndContext();
            BeginContext(9063, 53, true);
            WriteLiteral(" </td>\r\n                                        <td> ");
            EndContext();
            BeginContext(9117, 24, false);
#line 175 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                        Write(Html.Raw(conteudoPagina));

#line default
#line hidden
            EndContext();
            BeginContext(9141, 53, true);
            WriteLiteral(" </td>\r\n                                        <td> ");
            EndContext();
            BeginContext(9195, 7, false);
#line 176 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                        Write(temFoto);

#line default
#line hidden
            EndContext();
            BeginContext(9202, 53, true);
            WriteLiteral(" </td>\r\n                                        <td> ");
            EndContext();
            BeginContext(9256, 7, false);
#line 177 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                        Write(temForm);

#line default
#line hidden
            EndContext();
            BeginContext(9263, 53, true);
            WriteLiteral(" </td>\r\n                                        <td> ");
            EndContext();
            BeginContext(9317, 9, false);
#line 178 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                        Write(isGaleria);

#line default
#line hidden
            EndContext();
            BeginContext(9326, 131, true);
            WriteLiteral(" </td>\r\n                                        <td>\r\n                                            <div class=\"form-check-inline\">\r\n");
            EndContext();
#line 181 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                                 if (dadosPagina.nome_pagina != "_main")
                                                {

#line default
#line hidden
            BeginContext(9598, 83, true);
            WriteLiteral("                                                    <a style=\"margin:20px;\" href=\"\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 9681, "\"", 9727, 3);
            WriteAttributeValue("", 9691, "deletaPagina(", 9691, 13, true);
#line 183 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
WriteAttributeValue("", 9704, dadosPagina.id_pagina, 9704, 22, false);

#line default
#line hidden
            WriteAttributeValue("", 9726, ")", 9726, 1, true);
            EndWriteAttribute();
            BeginContext(9728, 86, true);
            WriteLiteral(" data-placement=\"top\" title=\"Excluir Pagina\" class=\"tip-top fas fa-trash fa-2x\"></a>\r\n");
            EndContext();
#line 184 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                                }

#line default
#line hidden
            BeginContext(9865, 48, true);
            WriteLiteral("                                                ");
            EndContext();
#line 185 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                                 if (dadosPagina.hasFoto == true)
                                                {

#line default
#line hidden
            BeginContext(9999, 162, true);
            WriteLiteral("                                                    <a href=\"\" data-placement=\"top\" style=\"margin:20px;\" class=\"tip-top\" title=\"Incluir Fotos\" data-toggle=\"modal\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 10161, "\"", 10216, 3);
            WriteAttributeValue("", 10171, "setDataModalFotos(\'", 10171, 19, true);
#line 187 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
WriteAttributeValue("", 10190, dadosPagina.nome_pagina, 10190, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 10214, "\')", 10214, 2, true);
            EndWriteAttribute();
            BeginContext(10217, 39, true);
            WriteLiteral(" data-target=\"#modalDinamico\" shref=\"\">");
            EndContext();
            BeginContext(10256, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b208243f3184a00f06e174159ab5c84914c2cb8e24306", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10315, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 188 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                                }

#line default
#line hidden
            BeginContext(10372, 48, true);
            WriteLiteral("                                                ");
            EndContext();
#line 189 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                                 if (dadosPagina.hasForm == true)
                                                {

#line default
#line hidden
            BeginContext(10506, 179, true);
            WriteLiteral("                                                    <a href=\"\" data-placement=\"top\" style=\"margin:20px;\" class=\"tip-top\" data-toggle=\"tooltip\" title=\"Incluir Formulário\" shref=\"\">");
            EndContext();
            BeginContext(10685, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b208243f3184a00f06e174159ab5c84914c2cb8e26504", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(10743, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 192 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                                }

#line default
#line hidden
            BeginContext(10800, 90, true);
            WriteLiteral("                                                <button type=\"button\" style=\"width:110px;\"");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 10890, "\"", 11015, 3);
            WriteAttributeValue("", 10900, "location.href=\'", 10900, 15, true);
#line 193 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
WriteAttributeValue("", 10915, Url.Action("Index","managerAlteracaoPaginas",new {idPagina = @dadosPagina.nome_pagina.ToString()}), 10915, 99, false);

#line default
#line hidden
            WriteAttributeValue("", 11014, "\'", 11014, 1, true);
            EndWriteAttribute();
            BeginContext(11016, 306, true);
            WriteLiteral(@" class=""tip-top btn btn-info"" data-placement=""top"" data-toggle=""tooltip"" title=""Alterar dados da tela""><span class=""fas fa-pen""></span> &nbsp; Alterar </button>

                                            </div>
                                        </td>
                                    </tr>
");
            EndContext();
#line 198 "C:\Projeto_portifolio\Views\Shared\Manager\Manager_principal.cshtml"
                                }

#line default
#line hidden
            BeginContext(11357, 1104, true);
            WriteLiteral(@"                            </tbody>
                        </table>

                    </div>
                </div>
            </div>
            <!-- area Paginas Cadastradas -->

            <div class=""card"">
                <div class=""card-header"" id=""headingThree"">
                    <h2 class=""mb-0"">
                        <a class=""btn_toggle fa fa-arrow-circle-down fa-pull-right"" id=""button-collapse"" data-toggle=""collapse"" data-target=""#collapseThree""></a>
                    </h2>
                </div>
                <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree"" data-parent=""#accordionExample"">
                    <div class=""card-body"">
                        <p>CSS stands for Cascading Style Sheet. CSS allows you to specify various style properties for a given HTML element such as colors, backgrounds, fonts etc. <a href=""https://www.tutorialrepublic.com/css-tutorial/"" target=""_blank"">Learn more.</a></p>
                    </div>
             ");
            WriteLiteral("   </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n   \r\n\r\n\r\n    ");
            EndContext();
            BeginContext(12461, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b208243f3184a00f06e174159ab5c84914c2cb8e30594", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(12532, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
