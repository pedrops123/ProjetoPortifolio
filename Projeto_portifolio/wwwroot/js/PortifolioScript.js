function ClickRedirectGeral(tela) {
       window.location.href = tela
}

function submitGeral(tela) {

    var camposValidacao = "";
    var dadosObject = [];
    var campos = document.getElementsByTagName("input");
    var select = document.getElementsByTagName("select");
    var textAreas = document.getElementsByTagName("textarea");

    var contaCampos = campos.length;
    var contaSelect = select.length;
    var contaTextArea = textAreas.length;
    var contadorCampo = 0;

    if (tela == "_titleGeral") {
        contadorCampo = 1;
    }


    if (contaCampos > 0) {
        for (var i = contadorCampo; i < contaCampos; i++) {

            if (campos[i].type == "checkbox") {
                dadosObject.push(campos[i].labels[0].innerText.trim().replace("?", ":") + campos[i].checked);
            }
            else {
                validaCampo = campos[i].value;
                if ((validaCampo == "" || validaCampo == null) && campos[i].required == true) {
                    camposValidacao += "* Favor preencher o campo <b>" + campos[i].labels[0].innerText.replace(":", "") + "</b> <br/><br/>";
                } else {
                    dadosObject.push(campos[i].labels[0].innerText + validaCampo);
                }
            }
        }
    }
    
    if (contaSelect > 0) {
        for (var s = 0; s < contaSelect; s++) {
            dadosObject.push(select[s].labels[0].innerText.replace("?",":") + select[s].value)
        }
    }

    if (contaTextArea > 0) {
        for (var t = 0; t < contaTextArea; t++) {
            var textoCampo = textAreas[t].value;
            if ((textoCampo == "" || textoCampo == null) && textAreas[t].required == true) {

                camposValidacao += "* Favor preencher o campo <b>" + textAreas[t].labels[0].innerText.replace(":", "") + "</b> <br/><br/>";
            } else {
                dadosObject.push(textAreas[t].labels[0].innerText + ":" + textoCampo);
            }
        }

    }

    if (camposValidacao != "") {
        $("#msg-alerta").removeClass("alert alert-danger alert-dismissible fade show").addClass("alert alert-warning alert-dismissible fade show");
        $('#titulo_alerta').html("<b>Atenção</b>");
        $('#texto-alerta').html(camposValidacao);
        $('#msg-alerta').fadeIn(100);
    }
    else {

        var jsonMontado = "";
        var corpoJson = "";    

        for (var i = 0; i < dadosObject.length; i++) {
            var dado = dadosObject[i].split(/:(.+)/)
            dado[0] = dado[0].replace(" ", "_")
            dado[0] = dado[0].replace("ç", "c")
            dado[0] = dado[0].replace("ã", "a")
            dado[0] = dado[0].replace("á", "a")

            if (dado.length > 1) {
                if (dado.length > 2) {
                    for (var r = 2; r < dado.length; r++) {
                        dado[1] = dado[1] + dado[r].replace(/<br>\u21b5/g, ", ");
                    }
                }
                jsonMontado = jsonMontado + "\"" + dado[0] + "\":\"" + dado[1] + "\"";
            } else {
                jsonMontado = jsonMontado + "\"" + dado[0] + "\":\"   \"";
            }
            
            if (i != dadosObject.length - 1) {
                jsonMontado += ",";
            }
        }

        corpoJson = jsonMontado.replace(/(\r\n|\n|\r)/gm, "<br />");
        var baseJson = $.parseJSON('{' + corpoJson + '}');

        if (tela == "manager_alteracao") {
            tela += "+" + document.getElementById("hdnPagina").getAttribute("value");
        }

        $.ajax({
            url: 'SubmitGeralValidador',
            type: "POST",
            data: {
                nomeTela: tela,
                object_form: JSON.stringify(baseJson)
            },
            success: function (retorno) {
                if (retorno[0] == "") {
                    window.location.href = retorno[1];
                } else {
                    $("#msg-alerta").removeClass("alert alert-warning alert-dismissible fade show").addClass("alert alert-danger alert-dismissible fade show");
                    $('#titulo_alerta').html("<b>Atenção</b>");
                    $('#texto-alerta').html(retorno[0]);
                    $('#msg-alerta').fadeIn(100);
                }
               
            }
        });
    }
}

$("#close-alert").click(function () {
    $("#msg-alerta").css("display", "none");
})

$(document).ready(function () {
    $(".tip-top").tooltip({
        placement: 'top'
    });
});

$("#title_main").hover(
   function () {
       $(this).css("color", "#F49E10");
    },
    function () {
        $(this).css("color", "#F6F6F6");
    }
);

$(".overlay").hover(
    function () {
        $(".img-project").css({
            "width": "253px",
            "height": "273px"
        });
    }
);

$("#check_foto_principal").click(
    function () {
        if ($("#check_foto_principal")[0].checked == true) {

            $("#conteudo_pagina_id").attr('disabled', 'disabled');
            $("#form_pagina_id").attr('disabled', 'disabled');
            $("#foto_pagina_id").attr('disabled', 'disabled');
            $("#foto_pagina_id").val("Não");
            $("#form_pagina_id").val("Não");
            $("#conteudo_pagina_id").val("")
        } else {

            $("#conteudo_pagina_id").attr('disabled', false);
            $("#form_pagina_id").attr('disabled', false);
            $("#foto_pagina_id").attr('disabled', false);
        }

    },
);

$(document).ready(function () {
    $("#img-principal").fadeIn(1000);
    $("#desc-principal").fadeIn(2000);
});


//Responsividade

$(document).ready(function () {
    //var largura = $(window).width();
    //if (largura <= 880) {

    //    $("#item-principal").css({
    //        "margin-right": "5%"
    //    });



    //    $(".content").css({
    //        "margin-top": "-19%",
    //        "margin-left": "-1%",
    //        "width": "110%",
    //        "padding":"0%"
    //    });

    //    $("#footer-content").css({
    //        "margin-left": "15%"
    //    });

    //    return 1;
    //}

    //if (largura <= 360) {

    //    $("#item-principal").css({
    //        "margin-right": "5%"
    //    });


    //    $(".content").css({
    //        "margin-top": "-19%",
    //        "margin-left": "15%"
    //    });

    //    $("#footer-content").css({
    //        "margin-left": "15%"
    //    });

    //    return 1;
    //}

    //$("#img-principal").css({
    //    "width": "300px",
    //    "height": "300px",
    //    "margin":"0% 0% 6% 41%"
    //});


});