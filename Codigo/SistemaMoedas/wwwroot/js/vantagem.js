$(document).on('click', '.modalVantagem', function () {

    $("#modalVantagem").modal('show')

})

$(document).on('click', '#criarVantagem', function () {

    var titulo = $('#nomeVantagem').val()
    var descricao = $('#descricaoVantagem').val()
    var valor = $('#valorVantagem').val()

    $.ajax({
        url: `/Vantagem/Cadastrar?titulo=${titulo}&descricao=${descricao}&valor=${valor}`,
        type: "POST",
        success: function (data) {
            location.href = "/Vantagem"
        }
    });

})
