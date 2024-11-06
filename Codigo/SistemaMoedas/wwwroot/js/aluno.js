$(document).on('click', '.transferirMoedas', function () {

    var para = $(this).attr('data-codigo');

    $("#modalTransferir").modal('show')

    $(document).find("#transferirMoedas").attr('data-codigo', para)

})

$(document).on('click', '#transferirMoedas', function () {

    var codigoPara = $('#transferirMoedas').attr('data-codigo')
    var quantidade = $('#quantidadeTransferir').val()

    $.ajax({
        url: `/Professor/TransferirMoedas?codigoPara=${codigoPara}&quantidade=${quantidade}`,
        type: "POST",
        success: function (data) {
            location.href = "/Aluno"
        }
    });

})