package com.example.model;

import java.io.Serializable;
import java.util.ArrayList;
import java.util.List;
import jakarta.persistence.CascadeType;
import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import jakarta.persistence.JoinColumn;
import jakarta.persistence.ManyToOne;
import jakarta.persistence.OneToMany;
import jakarta.persistence.Table;

@Entity
@Table(name = "tb_aluno")
public class Aluno implements Serializable {
    private static final long serialVersionUID = 1L;

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
    private String email;
    private String cpf;
    private String rg;
    private String endereco;

    @ManyToOne
    @JoinColumn(name = "instituicao_id")
    private Instituicao instituicao;

    private String curso;
    private int saldo;

    @OneToMany(mappedBy = "aluno", cascade = CascadeType.ALL)
    private List<Transacao> extrato = new ArrayList<>();

    public Aluno() {
    }

    public Aluno(String nome, String email, String cpf, String rg, String endereco, Instituicao instituicao,
                 String curso) {
        this.nome = nome;
        this.email = email;
        this.cpf = cpf;
        this.rg = rg;
        this.endereco = endereco;
        this.instituicao = instituicao;
        this.curso = curso;
        this.saldo = 0;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public String getNome() {
        return nome;
    }

    public void setNome(String nome) {
        this.nome = nome;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getRg() {
        return rg;
    }

    public void setRg(String rg) {
        this.rg = rg;
    }

    public String getEndereco() {
        return endereco;
    }

    public void setEndereco(String endereco) {
        this.endereco = endereco;
    }

    public Instituicao getInstituicao() {
        return instituicao;
    }

    public void setInstituicao(Instituicao instituicao) {
        this.instituicao = instituicao;
    }

    public String getCurso() {
        return curso;
    }

    public void setCurso(String curso) {
        this.curso = curso;
    }

    public int getSaldo() {
        return saldo;
    }

    public void setSaldo(int saldo) {
        this.saldo = saldo;
    }

    public List<Transacao> getExtrato() {
        return extrato;
    }

    public void setExtrato(List<Transacao> extrato) {
        this.extrato = extrato;
    }

    public List<Transacao> consultarExtrato() {
        return extrato;
    }

    public void trocarMoedas(Vantagem vantagem) {
        if (saldo >= vantagem.getCusto()) {
            saldo -= vantagem.getCusto();
            System.out.println("Troca de " + vantagem.getDescricao() + " realizada com sucesso!");
        } else {
            System.out.println("Saldo insuficiente para trocar a vantagem.");
        }
    }

    public void receberMoedas(int moedas, Transacao transacao) {
        saldo += moedas;
        extrato.add(transacao);
    }
}
