document.addEventListener("DOMContentLoaded", function () {
  const alunoForm = document.getElementById("aluno-form");
  const empresaForm = document.getElementById("empresa-form");
  const alunoList = document.getElementById("aluno-list");
  const empresaList = document.getElementById("empresa-list");
  const apiUrlAlunos = "http://localhost:8080/alunos";
  const apiUrlEmpresas = "http://localhost:8080/empresas";

  function carregarAlunos() {
    fetch(apiUrlAlunos)
      .then((response) => response.json())
      .then((alunos) => {
        alunoList.innerHTML = "";
        alunos.forEach((aluno) => {
          const li = document.createElement("li");
          li.innerHTML = `
              ${aluno.nome} - ${aluno.email}
              <button onclick="deletarAluno(${aluno.id})">Excluir</button>
            `;
          alunoList.appendChild(li);
        });
      });
  }

  function carregarEmpresas() {
    fetch(apiUrlEmpresas)
      .then((response) => response.json())
      .then((empresas) => {
        empresaList.innerHTML = "";
        empresas.forEach((empresa) => {
          const li = document.createElement("li");
          li.innerHTML = `
              ${empresa.nome} - ${empresa.endereco}
              <button onclick="deletarEmpresa(${empresa.id})">Excluir</button>
            `;
          empresaList.appendChild(li);
        });
      });
  }

  alunoForm.addEventListener("submit", function (event) {
    event.preventDefault();
    const novoAluno = {
      nome: document.getElementById("aluno-nome").value,
      email: document.getElementById("aluno-email").value,
      cpf: document.getElementById("aluno-cpf").value,
    };
    fetch(apiUrlAlunos, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(novoAluno),
    }).then((response) => {
      if (response.ok) {
        carregarAlunos();
        alunoForm.reset();
      }
    });
  });

  empresaForm.addEventListener("submit", function (event) {
    event.preventDefault();
    const novaEmpresa = {
      nome: document.getElementById("empresa-nome").value,
      endereco: document.getElementById("empresa-endereco").value,
    };
    fetch(apiUrlEmpresas, {
      method: "POST",
      headers: {
        "Content-Type": "application/json",
      },
      body: JSON.stringify(novaEmpresa),
    }).then((response) => {
      if (response.ok) {
        carregarEmpresas();
        empresaForm.reset();
      }
    });
  });

  window.deletarAluno = function (id) {
    fetch(`${apiUrlAlunos}/${id}`, {
      method: "DELETE",
    }).then((response) => {
      if (response.ok) {
        carregarAlunos();
      }
    });
  };

  window.deletarEmpresa = function (id) {
    fetch(`${apiUrlEmpresas}/${id}`, {
      method: "DELETE",
    }).then((response) => {
      if (response.ok) {
        carregarEmpresas();
      }
    });
  };

  carregarAlunos();
  carregarEmpresas();
});
