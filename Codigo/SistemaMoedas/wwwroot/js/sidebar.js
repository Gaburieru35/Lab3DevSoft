

$(document).on('click', '#sidebarItens a', function () {
    $("#sidebarItens a").each(function (index, item) {
        $(item).removeClass('active')
    })

    $(this).addClass('active')
})

$(document).ready(function () {

    if (window.location.href.includes('login') || window.location.href.includes('Login') || window.location.href.includes('Cadastro') || window.location.href.includes('cadastro')) {
        $("#sidebarMenu").hide()
    } else {
        $("#sidebarMenu").show(300)
    }
})