#pragma checksum "C:\Projeto_portifolio\Views\Components\PaginationImages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4baa5148569115b23ae39c40f6799db1fc70c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_PaginationImages), @"mvc.1.0.view", @"/Views/Components/PaginationImages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/PaginationImages.cshtml", typeof(AspNetCore.Views_Components_PaginationImages))]
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
#line 1 "C:\Projeto_portifolio\Views\Components\PaginationImages.cshtml"
using X.PagedList;

#line default
#line hidden
#line 7 "C:\Projeto_portifolio\Views\Components\PaginationImages.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e4baa5148569115b23ae39c40f6799db1fc70c3f", @"/Views/Components/PaginationImages.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_PaginationImages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoPortifolio.ViewModel.ParametrosPaginacaoViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(88, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Projeto_portifolio\Views\Components\PaginationImages.cshtml"
  
    Layout = null;
    

#line default
#line hidden
            BeginContext(151, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 10 "C:\Projeto_portifolio\Views\Components\PaginationImages.cshtml"
 if (Model.imagens != null)
{
    

#line default
#line hidden
            BeginContext(190, 308, false);
#line 12 "C:\Projeto_portifolio\Views\Components\PaginationImages.cshtml"
Write(Html.PagedListPager(Model.imagens, pagina => Url.Action("ChamaViewDinamica", new { Model.dadosPagina.nome_pagina, pagina }),
    new X.PagedList.Mvc.Common.PagedListRenderOptionsBase
    {
        LiElementClasses = new string[] { "page-item" },
        PageClasses = new string[] { "page-link" }
    }));

#line default
#line hidden
            EndContext();
#line 17 "C:\Projeto_portifolio\Views\Components\PaginationImages.cshtml"
      ;
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoPortifolio.ViewModel.ParametrosPaginacaoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
