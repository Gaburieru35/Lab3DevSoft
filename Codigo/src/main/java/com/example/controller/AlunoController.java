package com.example.controller;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.CrossOrigin;
import org.springframework.web.bind.annotation.DeleteMapping;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PathVariable;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.PutMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

import com.example.model.Aluno;
import com.example.service.AlunoService;

@RestController
@RequestMapping("/alunos")
@CrossOrigin(origins = "http://127.0.0.1:5500")
public class AlunoController {

	 @Autowired
	    private AlunoService alunoService;

	    @GetMapping
	    public List<Aluno> getAllAlunos() {
	        return alunoService.getAllAlunos();
	    }

	    @GetMapping("/{id}")
	    public Optional<Aluno> getAlunoById(@PathVariable Long id) {
	        return alunoService.getAlunoById(id);
	    }

	    @PostMapping
	    public Aluno createAluno(@RequestBody Aluno aluno) {
	        return alunoService.saveAluno(aluno);
	    }

	    @PutMapping("/{id}")
	    public Aluno updateAluno(@PathVariable Long id, @RequestBody Aluno aluno) {
	        aluno.setId(id);
	        return alunoService.saveAluno(aluno);
	    }

	    @DeleteMapping("/{id}")
	    public void deleteAluno(@PathVariable Long id) {
	        alunoService.deleteAluno(id);
	    }
	
}
