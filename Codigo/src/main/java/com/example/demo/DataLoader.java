/*
package com.example.demo;

import org.springframework.boot.CommandLineRunner;
import org.springframework.stereotype.Component;

import com.example.model.Aluno;
import com.example.model.EmpresaParceira;
import com.example.model.Instituicao;
import com.example.repository.AlunoRepository;
import com.example.repository.EmpresaParceiraRepository;

@Component
public class DataLoader implements CommandLineRunner {

    private final AlunoRepository alunoRepository;
    private final EmpresaParceiraRepository empresaParceiraRepository;

    public DataLoader(AlunoRepository alunoRepository, EmpresaParceiraRepository empresaParceiraRepository) {
        this.alunoRepository = alunoRepository;
        this.empresaParceiraRepository = empresaParceiraRepository;
    }

    @Override
    public void run(String... args) throws Exception {
        // Criar uma Instituicao
        Instituicao instituicao = new Instituicao("Universidade Federal de Tecnologia", "Rua Universitária, 1000");

        // Precarregar alguns alunos usando o construtor com argumentos, incluindo a Instituição
        Aluno aluno1 = new Aluno("João da Silva", "joao.silva@email.com", "12345678901", 
                                  "MG123456", "Rua A, 123", instituicao, "Engenharia de Software");
        
        Aluno aluno2 = new Aluno("Maria Souza", "maria.souza@email.com", "98765432100", 
                                  "SP987654", "Av. B, 456", instituicao, "Ciência da Computação");

        alunoRepository.save(aluno1);
        alunoRepository.save(aluno2);

        // Precarregar algumas empresas parceiras usando o construtor com argumentos
        EmpresaParceira empresa1 = new EmpresaParceira("Loja de Eletrônicos", "Rua C, 789");
        
        EmpresaParceira empresa2 = new EmpresaParceira("Supermercado XYZ", "Av. D, 101");

        empresaParceiraRepository.save(empresa1);
        empresaParceiraRepository.save(empresa2);
    }
}
*/
