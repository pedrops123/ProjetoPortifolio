#pragma checksum "C:\Projeto_portifolio\Views\Errors\NotFoundTela.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70c25f4751138d70fc22629092ff6f45c02d8aa5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Errors_NotFoundTela), @"mvc.1.0.view", @"/Views/Errors/NotFoundTela.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Errors/NotFoundTela.cshtml", typeof(AspNetCore.Views_Errors_NotFoundTela))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70c25f4751138d70fc22629092ff6f45c02d8aa5", @"/Views/Errors/NotFoundTela.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Errors_NotFoundTela : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projeto_portifolio\Views\Errors\NotFoundTela.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(54, 152, true);
            WriteLiteral("\r\n<h1> <p style=\"color:red;\">Atenção !</p> <br /> Tela não encontrada ! <br /> Provavelmente não existe ou foi deletada ! </h1>\r\n<br />\r\n<br />\r\n<button");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 206, "\"", 304, 3);
            WriteAttributeValue("", 216, "location.href=\'", 216, 15, true);
#line 8 "C:\Projeto_portifolio\Views\Errors\NotFoundTela.cshtml"
WriteAttributeValue("", 231, Url.Action("ChamaViewDinamica", "Portifolio",new { nomeTela = "_main"}), 231, 72, false);

#line default
#line hidden
            WriteAttributeValue("", 303, "\'", 303, 1, true);
            EndWriteAttribute();
            BeginContext(305, 84, true);
            WriteLiteral(" type=\"button\" class=\"btn btn-success\">Clique para voltar</button>\r\n<br />\r\n<br />\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
