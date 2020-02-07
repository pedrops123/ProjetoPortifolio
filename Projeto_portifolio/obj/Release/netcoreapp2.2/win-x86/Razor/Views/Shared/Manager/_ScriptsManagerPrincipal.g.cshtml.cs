#pragma checksum "C:\Projeto_portifolio\Views\Shared\Manager\_ScriptsManagerPrincipal.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db0b36ae3b7ed6e234d13fa885eeba01b619d4c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Manager__ScriptsManagerPrincipal), @"mvc.1.0.view", @"/Views/Shared/Manager/_ScriptsManagerPrincipal.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Manager/_ScriptsManagerPrincipal.cshtml", typeof(AspNetCore.Views_Shared_Manager__ScriptsManagerPrincipal))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db0b36ae3b7ed6e234d13fa885eeba01b619d4c6", @"/Views/Shared/Manager/_ScriptsManagerPrincipal.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22ffdad9f472785eed65d9d1fd1bbb3ff6fe6466", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Manager__ScriptsManagerPrincipal : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projeto_portifolio\Views\Shared\Manager\_ScriptsManagerPrincipal.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(29, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0b36ae3b7ed6e234d13fa885eeba01b619d4c63819", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(80, 7955, true);
            WriteLiteral(@"

<script type=""text/javascript"">

    var fotosAdicionadas = [];

    /* Carrega dados titulo geral */

    $(document).ready(function () {
        $.ajax({
            type: ""GET"",
            url: ""getDadosTituloGeral"",
            contentType: ""application/json; charset=utf-8"",
            dataType: ""json"",
            success: function (response) {
                document.getElementById(""link_id"").value = response[0];
                document.getElementById(""desc_title_id"").value = response[1];
            },
            failure: function () {
                alert(""Ocorreu um erro na captura dos dados"");
            }
        });

    });



    /* functions modal foto */
    function setDataModalFotos(nome) {
        limpaImagens();
        $(""#typeHdn"").text(""foto"");
        $(""#nomePagina"").text(nome);
        $(""#ModalTitulo"").html(""Fotos Página "" + nome);
        $("".custom-file-label"").html(""Escolha suas imagens..."");
        $(""#inputFileModal"").show();

     ");
            WriteLiteral(@"   $.ajax({
            type: 'GET',
            url: 'MakeImages',
            data: {
                idTela: nome
            },
            success: function (response) {
                if (response != """") {
                    $(""#conteudo_fotos"").html(response);
                } else {
                    $(""#conteudo_fotos"").html(""Não há fotos incluidas! "");
                }
            },
            error: function (error) {
                alert(""Ocorreu um erro na busca dos dados !"");
            }
        });



    }

    function adicionarFotoPreview() {
        $(""#preview_fotos"").html("""");
        fotosAdicionadas = Array.from(document.getElementById(""data_fotos"").files);
        $("".custom-file-label"").html("""");
        for (var i = 0; i < fotosAdicionadas.length; i++) {
            //Cria url da foto a ser subido
            var urlCriada = URL.createObjectURL(document.getElementById(""data_fotos"").files[i]);
            //Cria cada elemento div e da imagem pre");
            WriteLiteral(@"view
            $(""#preview_fotos"").append(""<div data-placement='top' class='tip-top' data-toggle='tooltip' title='"" + document.getElementById(""data_fotos"").files[i].name + ""' id='"" + document.getElementById(""data_fotos"").files[i].name + ""'style='border:solid; margin:10px; display: -webkit-flex; -webkit-flex-wrap:wrap; display:inline-flex;flex-wrap:wrap;'><img width='80px' height='80px' src='"" + urlCriada + ""'><a style='cursor:pointer;'><span onclick='retiraFoto(\"""" + document.getElementById(""data_fotos"").files[i].name + ""\"")' class='notify-badge'>x</span></a></img></div>"");
            $("".custom-file-label"").append(document.getElementById(""data_fotos"").files[i].name + "";"" + "" "");
        }
    }

    function limpaImagens() {
        $(""#preview_fotos"").html("""");
        $(""#data_fotos"").val("""");
    }

    function retiraFoto(tagFoto) {
        document.getElementById(tagFoto).remove();
        for (var i = 0; i < fotosAdicionadas.length; ++i) {
            if (fotosAdicionadas[i].name == ta");
            WriteLiteral(@"gFoto) {
                $("".custom-file-label"").html($("".custom-file-label"").html().replace(fotosAdicionadas[i].name + "";"", """"));
                document.getElementById(""data_fotos"").files[i].removed = true;
            }
        }

        //document.getElementById(""data_fotos"").value = fotosAdicionadas;
    }

    function uploadFoto() {
        var data = Array.from(document.getElementById(""data_fotos"").files);
        var newData = data.filter(function (n) {
            return n.removed != true;
        });
        var nomePagina = $('#nomePagina').text();
        var tamanhoArray = newData.length;

        var formdata = new FormData();

        for (i = 0; i < tamanhoArray; i++) {
            formdata.append(newData[i].name + ""*"" + nomePagina + ""*"", newData[i]);
        }

        $.ajax({
            type: 'post',
            url: 'uploadImages',
            data: formdata,
            dataType: 'json',
            contentType: false,
            processData: false,
    ");
            WriteLiteral(@"        success: function (response) {
                if (response == true) {
                    alert('Imagens salvas com sucesso !!');
                    setDataModalFotos(nomePagina);
                } else {
                    alert('Nada foi salvo !');
                }

            },
            error: function (error) {
                alert(""Atenção ocorreu um erro no upload de arquivos."");
            }
        });



    }

    function deleteImageBD(idimg) {
        var nomePagina = $('#nomePagina').text();

        $.ajax({
            type: 'POST',
            url: 'DeletaImagemBD',
            data: {
                idFoto: idimg
            },
            success: function (response) {
                if (response == true) {
                    alert('Foto deletada com sucesso !');
                    setDataModalFotos(nomePagina);
                } else {
                    alert('Erro no delete da imagem!');
                }
            },
          ");
            WriteLiteral(@"  error: function (error) {
                alert(""Ocorreu um erro no delete do dado !"");
            }
        });

    }

    function chamaPopOver(idFoto) {

        $('[data-toggle=""popover""]').popover('hide');

        $('.img-salva').popover({
            placement: 'top',
            html: true
        });
        //Desabilita o focus no modal para clicar no popover
        $(document).off('focusin.modal');
        $(""#hdnIdFoto"").text(idFoto);
        setTimeout(setDataPop, 10);
    }

    function setDataPop() {
        $("".popover-body"").html(""<form><div class='form-group'><label for='descImg'>Descrição  Imagem  &nbsp <br/></label><input id='cmpDesc' type=\"""" + ""text"" + ""\"" class=\"""" + ""form-control"" + ""\"" placeholder='Descrição da Imagem'> <br/> <button onclick='closePopOver()' type='button' class='btn btn-danger'> Fechar </button>  <button onclick='gravaDescricaoFoto()' type='button' class='btn btn-success'> Salvar Descrição </button></div></form>"");
        setTimeout(setTe");
            WriteLiteral(@"xtPop, 400);

    }

    function setTextPop() {

        var idimg = parseInt($(""#hdnIdFoto"").text());
        $.ajax({
            type: 'GET',
            url: 'getDescImg',
            data: {
                idImg: idimg
            },
            success: function (response) {
                $('#cmpDesc').val(response);
            },
            error: function (error) {
                alert(""Ocorreu um erro na busca dos dados !"");
            }
        });

    }

    function gravaDescricaoFoto() {
        var idimg = parseInt($(""#hdnIdFoto"").text());
        var desc = $(""#cmpDesc"").val();

        $.ajax({
            url: 'gravaDescricaoImagem',
            type: ""POST"",
            data: {
                idImagem: idimg,
                descricao: desc
            },
            success: function (retorno) {
                if (retorno == true) {
                    alert(""Descrição salva com sucesso !"");
                } else {
                    alert(");
            WriteLiteral(@"""Erro na gravacao da descricao !"");
                }

            },
            error: function (error) {
                alert(""Atenção ocorreu um erro no upload de arquivos."");
            }
        });
    }

    function closePopOver() {
        $('[data-toggle=""popover""]').popover('hide');
    }

    /* final functions modal foto */



    function deletaPagina(idPagina) {
        $.ajax({
            type: 'POST',
            url: 'deletePage',
            data: {
                idPage:idPagina
            },
            success: function (response) {
                location.reload(true);
            },
            error: function (error) {
                alert(""Falha ao deletar pagina"");
            }
        });
    }

</script>
");
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