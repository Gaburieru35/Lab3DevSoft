package com.example.model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;

import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "tb_instituicao")
public class Instituicao implements Serializable {

	private static final long serialVersionUID = 1L;

	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;

	private String nome;
	private String endereco;

	@OneToMany(mappedBy = "instituicao", cascade = CascadeType.ALL)
	private List<Professor> professores = new ArrayList<>();

	@OneToMany(mappedBy = "instituicao", cascade = CascadeType.ALL)
	private List<Aluno> alunos = new ArrayList<>();

	public Instituicao(String nome, String endereco) {
		this.nome = nome;
		this.endereco = endereco;
	}

	public String getNome() {
		return nome;
	}

	public void setNome(String nome) {
		this.nome = nome;
	}

	public String getEndereco() {
		return endereco;
	}

	public void setEndereco(String endereco) {
		this.endereco = endereco;
	}

	public List<Professor> getProfessores() {
		return professores;
	}

	public void setProfessores(List<Professor> professores) {
		this.professores = professores;
	}

	public List<Aluno> getAlunos() {
		return alunos;
	}

	public void setAlunos(List<Aluno> alunos) {
		this.alunos = alunos;
	}

	public void cadastrarProfessor(Professor professor) {
		professores.add(professor); // Associação
		System.out.println("Professor " + professor.getNome() + " cadastrado com sucesso.");
	}

	public void cadastrarAluno(Aluno aluno) {
		alunos.add(aluno); // Associação
		System.out.println("Aluno " + aluno.getNome() + " cadastrado com sucesso.");
	}

}