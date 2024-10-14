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
@Table(name = "tb_professor")
public class Professor implements Serializable {
    private static final long serialVersionUID = 1L;

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String nome;
    private String cpf;
    private String departamento;

    @ManyToOne
    @JoinColumn(name = "instituicao_id")
    private Instituicao instituicao;

    private int saldo;

    @OneToMany(mappedBy = "professor", cascade = CascadeType.ALL)
    private List<Transacao> extrato = new ArrayList<>();

    public Professor() {
    }

    public Professor(String nome, String cpf, String departamento, Instituicao instituicao) {
        this.nome = nome;
        this.cpf = cpf;
        this.departamento = departamento;
        this.instituicao = instituicao;
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

    public String getCpf() {
        return cpf;
    }

    public void setCpf(String cpf) {
        this.cpf = cpf;
    }

    public String getDepartamento() {
        return departamento;
    }

    public void setDepartamento(String departamento) {
        this.departamento = departamento;
    }

    public Instituicao getInstituicao() {
        return instituicao;
    }

    public void setInstituicao(Instituicao instituicao) {
        this.instituicao = instituicao;
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

    public void enviarMoedas(Aluno aluno, int moedas, Transacao transacao) {
        if (saldo >= moedas) {
            saldo -= moedas;
            aluno.receberMoedas(moedas, transacao);
            extrato.add(transacao);
        } else {
            System.out.println("Saldo insuficiente para enviar moedas.");
        }
    }
}
