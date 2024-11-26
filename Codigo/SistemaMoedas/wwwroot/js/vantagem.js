$(document).on('click', '.modalVantagem', function () {

    $("#modalVantagem").modal('show')

})

$(document).on('click', '#criarVantagem', function () {

    var formData = new FormData();

    var titulo = $('#nomeVantagem').val()
    var descricao = $('#descricaoVantagem').val()
    var valor = $('#valorVantagem').val()

    formData.append('imageFile', $('#imagemVantagem')[0].files[0]);
    formData.append('Vantagem.TituloVantagem', titulo);
    formData.append('Vantagem.DescricaoVantagem', descricao);
    formData.append('Vantagem.ValorVantagem', valor);

    $.ajax({
        url: `/Vantagem/Cadastrar`,
        type: "POST",
        data: formData,
        contentType: false,
        processData: false,
        success: function (data) {
            location.href = "/Vantagem"
        }
    });

})

$(document).on('click', '.comprarVantagem', function () {

    var id = $(this).attr('vantagem-codigo');
    var aluno = $(this).attr('data-codigo');

    $("#modalComprar").modal('show')

    $(document).find("#confirmarCompraVantagem").attr('data-id', id)
    $(document).find("#confirmarCompraVantagem").attr('data-aluno', aluno)

})

$(document).on('click', '#confirmarCompraVantagem', function () {

    var id = $(this).attr('data-id')
    var aluno = $(this).attr('data-aluno')

    $.ajax({
        url: `/Vantagem/Comprar?id=${id}&aluno=${aluno}`,
        type: "POST",
        success: function (data) {
            location.href = "/Vantagem"
        }
    });
})
