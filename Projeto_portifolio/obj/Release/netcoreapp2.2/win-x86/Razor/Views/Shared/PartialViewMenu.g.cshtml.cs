#pragma checksum "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e8217a5a999dd51ddf49d3859439aff37fad2bb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_PartialViewMenu), @"mvc.1.0.view", @"/Views/Shared/PartialViewMenu.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/PartialViewMenu.cshtml", typeof(AspNetCore.Views_Shared_PartialViewMenu))]
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
#line 5 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
using SmartBreadcrumbs;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8217a5a999dd51ddf49d3859439aff37fad2bb", @"/Views/Shared/PartialViewMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_PartialViewMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProjetoPortifolio.Models.ButtonSite>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("bread"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::SmartBreadcrumbs.BreadcrumbTagHelper __SmartBreadcrumbs_BreadcrumbTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(50, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(95, 482, true);
            WriteLiteral(@"
<nav class=""navbar navbar-expand-lg nav"" id=""menu_principal"" style=""background-color:black; display:flex;  justify-content: space-around;"">

    <button class=""navbar-toggler"" type=""button"" data-toggle=""collapse"" data-target=""#navbarNav"" aria-controls=""navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
        <span class=""navbar-toggler-icon""></span>
    </button>

    <div class=""container"" style=""margin-left:20px; padding:0; width:auto;"">
");
            EndContext();
#line 15 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
         if (!User.Identity.IsAuthenticated)
        {

#line default
#line hidden
            BeginContext(634, 50, true);
            WriteLiteral("            <div class=\"navbar-header btn icon\">\r\n");
            EndContext();
#line 18 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
                 if (Model.Where(r => r.type == "linkMaster").Count() != 0)
                {
                    var dados = Model.Where(r => r.type == "linkMaster").First();

#line default
#line hidden
            BeginContext(863, 96, true);
            WriteLiteral("                    <a class=\"navbar-brand\" id=\"title_main\" target=\"_blank\" style=\"color:white;\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 959, "\"", 983, 1);
#line 21 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
WriteAttributeValue("", 966, dados.caminhoUrl, 966, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(984, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(986, 15, false);
#line 21 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
                                                                                                                     Write(dados.descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1001, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 22 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
                }

#line default
#line hidden
            BeginContext(1026, 87, true);
            WriteLiteral("            </div>\r\n            <div class=\"collapse navbar-collapse\" id=\"navbarNav\">\r\n");
            EndContext();
#line 25 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
                 foreach (var botoes in Model.Where(r => r.type == "link"))
                {


#line default
#line hidden
            BeginContext(1211, 78, true);
            WriteLiteral("                    <a class=\"btn_link btn btn-dark\" style=\"margin-left:10px;\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1289, "\"", 1331, 1);
#line 28 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
WriteAttributeValue("", 1296, "/Portifolio/"+botoes.caminhoUrl, 1296, 35, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1332, 2, true);
            WriteLiteral("> ");
            EndContext();
            BeginContext(1335, 34, false);
#line 28 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
                                                                                                                      Write(botoes.descricao.Replace("_", " "));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 6, true);
            WriteLiteral("</a>\r\n");
            EndContext();
#line 29 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
                }

#line default
#line hidden
            BeginContext(1394, 20, true);
            WriteLiteral("            </div>\r\n");
            EndContext();
#line 31 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"

        }

#line default
#line hidden
            BeginContext(1427, 14, true);
            WriteLiteral("    </div>\r\n\r\n");
            EndContext();
#line 35 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
     if (User.Identity.IsAuthenticated)
    {


#line default
#line hidden
            BeginContext(1491, 157, true);
            WriteLiteral("        <div class=\"justify-content-end\">\r\n            <div class=\"navbar-header btn icon\">\r\n                <p style=\"color:white;\"> Ola seja bem vindo <b> ");
            EndContext();
            BeginContext(1649, 18, false);
#line 40 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
                                                           Write(User.Identity.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1667, 53, true);
            WriteLiteral(" </b> ! </p>\r\n                <a class=\"btn btn-dark\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1720, "\"", 1750, 1);
#line 41 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
WriteAttributeValue("", 1727, "/Portifolio/logout", 1727, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1751, 49, true);
            WriteLiteral(">Logout</a>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 44 "C:\Users\pedro.furlan\Desktop\TesteProjetoPortifolio\ProjetoPortifolio\Projeto_portifolio\Views\Shared\PartialViewMenu.cshtml"
    }

#line default
#line hidden
            BeginContext(1807, 12, true);
            WriteLiteral("</nav>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1819, 36, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("breadcrumb", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e8217a5a999dd51ddf49d3859439aff37fad2bb10576", async() => {
            }
            );
            __SmartBreadcrumbs_BreadcrumbTagHelper = CreateTagHelper<global::SmartBreadcrumbs.BreadcrumbTagHelper>();
            __tagHelperExecutionContext.Add(__SmartBreadcrumbs_BreadcrumbTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProjetoPortifolio.Models.ButtonSite>> Html { get; private set; }
    }
}
#pragma warning restore 1591