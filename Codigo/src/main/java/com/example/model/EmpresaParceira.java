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
@Table(name = "tb_empresas")
public class EmpresaParceira implements Serializable {

	private static final long serialVersionUID = 1L;
	
	@Id
	@GeneratedValue(strategy = GenerationType.IDENTITY)
	private Long id;
	private String nome;
	private String endereco;
	
    @OneToMany(mappedBy = "empresaParceira", cascade = CascadeType.ALL)
	private List<Vantagem> vantagens = new ArrayList<>(); // Composição

	public EmpresaParceira(String nome, String endereco) {
		this.nome = nome;
		this.endereco = endereco;
	}

	public Long getId() {
		return id;
	}

	public void setId(Long id) {
		this.id = id;
	}

	public void cadastrarVantagem(Vantagem vantagem) {
		vantagens.add(vantagem);
		System.out.println("Vantagem cadastrada: " + vantagem.getDescricao());
	}

	public void receberResgate(String codigo) {
		System.out.println("Resgate com o código " + codigo + " realizado.");
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

	public List<Vantagem> getVantagens() {
		return vantagens;
	}

	public void setVantagens(List<Vantagem> vantagens) {
		this.vantagens = vantagens;
	}

}