#pragma checksum "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07bcde66043a3b4ab7886a50f8e999ad7d9c03a1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Components_ApresentacaoLayout), @"mvc.1.0.view", @"/Views/Components/ApresentacaoLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Components/ApresentacaoLayout.cshtml", typeof(AspNetCore.Views_Components_ApresentacaoLayout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07bcde66043a3b4ab7886a50f8e999ad7d9c03a1", @"/Views/Components/ApresentacaoLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Components_ApresentacaoLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "~/Views/Components/ButtonExportCurriculum.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://code.highcharts.com/highcharts.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://code.highcharts.com/modules/data.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://code.highcharts.com/modules/drilldown.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://code.highcharts.com/modules/exporting.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://code.highcharts.com/modules/export-data.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "https://code.highcharts.com/modules/accessibility.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 555, true);
            WriteLiteral(@"
<style>
    .numberCircle {
        width: 250px;
        height: 250px;
        border-radius: 50%;
        text-align: center;
        font-size: 21.6px;
        border: 8px solid white;
        color: white;
        background: #3498db;
        position: absolute;
        top: -132px;
        left: 50%;
        transform: translateX(-50%)
    }
</style>


<div id=""item-principal"" class=""row justify-content-center"">

    <div class=""col-sm-10 col-lg-40 col-md-20"">
        <div class=""content col-sm-10 col-lg-40 col-md-20"">
");
            EndContext();
#line 27 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
             if (Model.mainFoto != "")
            {

#line default
#line hidden
            BeginContext(637, 41, true);
            WriteLiteral("                <img class=\"numberCircle\"");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 678, "\"", 699, 1);
#line 29 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
WriteAttributeValue("", 684, Model.mainFoto, 684, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(700, 5, true);
            WriteLiteral(" />\r\n");
            EndContext();
#line 30 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
            }
            else
            {

#line default
#line hidden
            BeginContext(753, 67, true);
            WriteLiteral("                <div class=\"numberCircle\"> Nenhuma Imagem  </div>\r\n");
            EndContext();
#line 34 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
            }

#line default
#line hidden
            BeginContext(835, 96, true);
            WriteLiteral("\r\n        <div style=\"display:none;\" id=\"desc-principal\" class=\"description-main\">\r\n            ");
            EndContext();
            BeginContext(932, 54, false);
#line 37 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
       Write(Html.Raw(Model.dadosPagina.conteudo_pagina.ToString()));

#line default
#line hidden
            EndContext();
            BeginContext(986, 15, true);
            WriteLiteral(";\r\n            ");
            EndContext();
            BeginContext(1001, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "07bcde66043a3b4ab7886a50f8e999ad7d9c03a18103", async() => {
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
            BeginContext(1068, 169, true);
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"col-sm-10 col-lg-40 col-md-20\"></div>\r\n</div>\r\n<br />\r\n<br />\r\n<br />\r\n\r\n\r\n<div id=\"container\"></div>\r\n\r\n\r\n");
            EndContext();
            BeginContext(1237, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07bcde66043a3b4ab7886a50f8e999ad7d9c03a19558", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#line 52 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1328, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1330, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07bcde66043a3b4ab7886a50f8e999ad7d9c03a111238", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#line 53 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1423, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1425, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07bcde66043a3b4ab7886a50f8e999ad7d9c03a112919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 54 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1523, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1525, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07bcde66043a3b4ab7886a50f8e999ad7d9c03a114600", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
#line 55 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1623, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1625, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07bcde66043a3b4ab7886a50f8e999ad7d9c03a116282", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 56 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1725, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1727, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "07bcde66043a3b4ab7886a50f8e999ad7d9c03a117964", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
#line 57 "C:\Projeto_portifolio\Views\Components\ApresentacaoLayout.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1829, 7111, true);
            WriteLiteral(@"


<script>

  // Function retirado do framework lodash
      debounce = function(func,wait,immediate){
        var timeout;
        return function(){
            var context = this,args = arguments;
            var later = function(){
                timeout = null;
                if(!immediate) func.apply(context,args);
            };
            var callNow = immediate && !timeout;
            clearTimeout(timeout);
            timeout = setTimeout(later,wait);
            if(callNow) func.apply(context,args);
        };
    };


    $(document).ready(function () {
        $(""#container"").hide();
    });

    //$(""#abrirGrafico"").click(
    //    function () {
    //        var isVisible = $(""#container"").is("":visible"");
    //        if (isVisible == false) {
    //            $(""#container"").show(""slow"");
    //        } else {
    //             $(""#container"").hide(""slow"");
    //        }
       
    //    }); 

    $(document).scroll(debounce(function () {

  ");
            WriteLiteral(@"      var documentTop = $(document).scrollTop();
        var graficoPosicao = $(""#container"").offset().top;
        var offset = $(window).height() * 3 / 4;
        var isVisible = $(""#container"").is("":visible"");
        if (documentTop > (graficoPosicao - offset)) {
            if (isVisible == false) {
                $(""#container"").show(""slow"");
            }
        }
        else {
            $(""#container"").hide(""slow"");
        }
    }, 600));


    // Create the chart
    Highcharts.chart('container', {
        chart: {
            type: 'column'
        },
        title: {
            text: 'Meus Conhecimentos Técnicos'
        },
        subtitle: {
            text: 'Minhas Experiencias gerais'
        },
        accessibility: {
            announceNewData: {
                enabled: true
            }
        },
        xAxis: {
            type: 'Categoria'
        },
        yAxis: {
            title: {
                text: 'Percentual Total '
          ");
            WriteLiteral(@"  }

        },
        legend: {
            enabled: false
        },
        plotOptions: {
            series: {
                borderWidth: 0,
                dataLabels: {
                    enabled: true,
                    format: '{point.y:.1f}%'
                }
            }
        },

        tooltip: {
            headerFormat: '<span style=""font-size:11px"">{series.name}</span><br>',
            pointFormat: '<span style=""color:{point.color}"">{point.name}</span>: <b>{point.y:.2f}%</b> of total<br/>'
        },

        series: [
            {
                name: ""Browsers"",
                colorByPoint: true,
                data: [
                    {
                        name: ""Chrome"",
                        y: 62.74,
                        drilldown: ""Chrome""
                    },
                    {
                        name: ""Firefox"",
                        y: 10.57,
                        drilldown: ""Firefox""
                    }
");
            WriteLiteral(@"                   
                ]
            }
        ],
        drilldown: {
            series: [
                {
                    name: ""Chrome"",
                    id: ""Chrome"",
                    data: [
                        [
                            ""v65.0"",
                            0.1
                        ],
                        [
                            ""v64.0"",
                            1.3
                        ],
                        [
                            ""v63.0"",
                            53.02
                        ],
                        [
                            ""v62.0"",
                            1.4
                        ],
                        [
                            ""v61.0"",
                            0.88
                        ],
                        [
                            ""v60.0"",
                            0.56
                        ],
                        [
     ");
            WriteLiteral(@"                       ""v59.0"",
                            0.45
                        ],
                        [
                            ""v58.0"",
                            0.49
                        ],
                        [
                            ""v57.0"",
                            0.32
                        ],
                        [
                            ""v56.0"",
                            0.29
                        ],
                        [
                            ""v55.0"",
                            0.79
                        ],
                        [
                            ""v54.0"",
                            0.18
                        ],
                        [
                            ""v51.0"",
                            0.13
                        ],
                        [
                            ""v49.0"",
                            2.16
                        ],
                        [
             ");
            WriteLiteral(@"               ""v48.0"",
                            0.13
                        ],
                        [
                            ""v47.0"",
                            0.11
                        ],
                        [
                            ""v43.0"",
                            0.17
                        ],
                        [
                            ""v29.0"",
                            0.26
                        ]
                    ]
                },
                {
                    name: ""Firefox"",
                    id: ""Firefox"",
                    data: [
                        [
                            ""v58.0"",
                            1.02
                        ],
                        [
                            ""v57.0"",
                            7.36
                        ],
                        [
                            ""v56.0"",
                            0.35
                        ],
           ");
            WriteLiteral(@"             [
                            ""v55.0"",
                            0.11
                        ],
                        [
                            ""v54.0"",
                            0.1
                        ],
                        [
                            ""v52.0"",
                            0.95
                        ],
                        [
                            ""v51.0"",
                            0.15
                        ],
                        [
                            ""v50.0"",
                            0.1
                        ],
                        [
                            ""v48.0"",
                            0.31
                        ],
                        [
                            ""v47.0"",
                            0.12
                        ]
                    ]
                }
            ]
        }
    });



</script>");
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