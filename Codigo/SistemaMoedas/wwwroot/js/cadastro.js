$(".submit_btn").click(function () {
    var Aluno = new Object()
    Aluno.CodigoAluno = null
    Aluno.EmailAluno = $('#email').val()
    Aluno.CpfAluno = $('#cpf').val()
    Aluno.NomeAluno = $('#nome').val()
    Aluno.SenhaAluno = $('#senhaConfirm').val()
    Aluno.RGAluno = $('#rg').val()
    Aluno.EnderecoAluno = $('#endereco').val()
    Aluno.InstituicaoAluno = $('#selectInstituicao').val()
    Aluno.CursoAluno = $('#selectCurso').val()
    Aluno.QuantidadeMoedasAluno = 0;
    Aluno.DataCadastroAluno = null;

    $.ajax({
        url: `/Cadastro/Cadastrar`,
        type: "POST",
        data: Aluno,
        success: function (data) {
            console.log(data)
            location.href = "/Login"
        },
        error: function (data) {
            console.log(data)
        }
    });
})
$(".submit_btn_parceiro").click(function () {
    var Parceiro = new Object()
    Parceiro.CodigoParceiro = null
    Parceiro.EmailParceiro = $('#email').val()
    Parceiro.CnpjParceiro = $('#cnpj').val()
    Parceiro.NomeParceiro = $('#nome').val()
    Parceiro.SenhaParceiro = $('#senhaConfirm').val()
    Parceiro.DataCadastroParceiro = null;

    $.ajax({
        url: `/CadastroParceiro/Cadastrar`,
        type: "POST",
        data: Parceiro,
        success: function (data) {
            console.log(data)
            location.href = "/Login"
        },
        error: function (data) {
            console.log(data)
        }
    });
})