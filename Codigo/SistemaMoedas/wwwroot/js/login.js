$("#btn_login").click(function () {

    var url = ""

    switch (parseInt($("#selectTipo").val())) {
        case 1:
            url = `/Login/Logar`
            break;
        case 3:
            url = `/Login/LogarParceiro`
            break;
        default:
            url = `/Login/LogarProfessor`
            break;
    }

    $.ajax({
        url: url,
        type: "GET",
        contentType: 'application/json',
        dataType: 'json',
        data: {
            'email': $('#emailInput').val(),
            'senha': $('#senhaInput').val(),
        },
        success: function (data) {
            location.href = "/Dashboard"
        }
    });
})

function toggleEye() {
    var x = document.getElementById("senhaInput");
    var eyeIcon = document.getElementById("eyeIcon");
    if (x.type === "password") {
        x.type = "text";
        eyeIcon.classList.remove("eye-open");
        eyeIcon.classList.add("eye-closed");
    } else {
        x.type = "password";
        eyeIcon.classList.remove("eye-closed");
        eyeIcon.classList.add("eye-open");
    }
}

