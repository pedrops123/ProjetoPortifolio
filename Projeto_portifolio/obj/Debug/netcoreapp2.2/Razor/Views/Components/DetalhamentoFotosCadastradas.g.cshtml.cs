#pragma checksum "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\Components\DetalhamentoFotosCadastradas.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30b7bc26fccf26997f84042562f5c92e0d1e1420"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_DetalhamentoFotosCadastradas), @"mvc.1.0.view", @"/Views/Components/DetalhamentoFotosCadastradas.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/DetalhamentoFotosCadastradas.cshtml", typeof(AspNetCore.Views_Components_DetalhamentoFotosCadastradas))]
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
#line 1 "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\_ViewImports.cshtml"
using ProjetoPortifolio;

#line default
#line hidden
#line 2 "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\_ViewImports.cshtml"
using ProjetoPortifolio.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30b7bc26fccf26997f84042562f5c92e0d1e1420", @"/Views/Components/DetalhamentoFotosCadastradas.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_DetalhamentoFotosCadastradas : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\Components\DetalhamentoFotosCadastradas.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 245, true);
            WriteLiteral("\r\n<style>\r\n\r\n    .imagens-portifolio-item {\r\n        display: -webkit-flex; /* Safari */\r\n        -webkit-flex-wrap: wrap; /* Safari 6.1+ */\r\n        display: inline-flex;\r\n        flex-wrap: wrap;\r\n        border: none;\r\n    }\r\n\r\n</style>\r\n\r\n\r\n");
            EndContext();
#line 18 "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\Components\DetalhamentoFotosCadastradas.cshtml"
 foreach (ImagensPortifolio foto in Model.imagens)
{

#line default
#line hidden
            BeginContext(327, 203, true);
            WriteLiteral("    <div class=\"imagens-portifolio-item  view overlay zoom\">\r\n        <div style=\"border:inset; width:253px; height:253px;  margin-left:20px; margin-top:20px;\">\r\n            <a class=\"example-image-link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 530, "\"", 550, 1);
#line 22 "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\Components\DetalhamentoFotosCadastradas.cshtml"
WriteAttributeValue("", 537, foto.urlFoto, 537, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(551, 39, true);
            WriteLiteral(" data-lightbox=\"example-1\" data-title=\"");
            EndContext();
            BeginContext(591, 19, false);
#line 22 "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\Components\DetalhamentoFotosCadastradas.cshtml"
                                                                                                Write(foto.descricao_foto);

#line default
#line hidden
            EndContext();
            BeginContext(610, 77, true);
            WriteLiteral("\"><img style=\"width:253px; height:253px;\" class=\"example-image img-thumbnail\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 687, "\"", 706, 1);
#line 22 "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\Components\DetalhamentoFotosCadastradas.cshtml"
WriteAttributeValue("", 693, foto.urlFoto, 693, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(707, 51, true);
            WriteLiteral(" alt=\"image-1\" /></a>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 25 "C:\Users\Pedro\Desktop\projeto_portifolio\ProjetoPortifolio\Projeto_portifolio\Views\Components\DetalhamentoFotosCadastradas.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
