package com.example.model;

import java.io.Serializable;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.Table;

@Entity
@Table(name = "tb_vantagem")
public class Vantagem implements Serializable {
    
	private static final long serialVersionUID = 1L;
	
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
	
	private String descricao;
    private String foto;
    private int custo;
    
    @ManyToOne
    @JoinColumn(name = "empresa_parceira_id")
    private EmpresaParceira empresaParceira;

    public Vantagem(String descricao, String foto, int custo) {
        this.descricao = descricao;
        this.foto = foto;
        this.custo = custo;
    }

    public String getDescricao() {
        return descricao;
    }

    public int getCusto() {
        return custo;
    }

	public String getFoto() {
		return foto;
	}

	public void setFoto(String foto) {
		this.foto = foto;
	}

	public void setDescricao(String descricao) {
		this.descricao = descricao;
	}

	public void setCusto(int custo) {
		this.custo = custo;
	}

    
}