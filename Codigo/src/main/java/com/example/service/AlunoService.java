package com.example.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.Aluno;
import com.example.repository.AlunoRepository;

@Service
public class AlunoService {

	 	@Autowired
	    private AlunoRepository alunoRepository;

	    public List<Aluno> getAllAlunos() {
	        return alunoRepository.findAll();
	    }

	    public Optional<Aluno> getAlunoById(Long id) {
	        return alunoRepository.findById(id);
	    }

	    public Aluno saveAluno(Aluno aluno) {
	        return alunoRepository.save(aluno);
	    }

	    public void deleteAluno(Long id) {
	        alunoRepository.deleteById(id);
	    }
}
