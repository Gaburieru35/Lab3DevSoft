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

import com.example.model.EmpresaParceira;
import com.example.service.EmpresaParceiraService;

@RestController
@RequestMapping("/empresas")
@CrossOrigin(origins = "http://127.0.0.1:5500")
public class EmpresaParceiraController {
	
	  @Autowired
	    private EmpresaParceiraService empresaParceiraService;

	    @GetMapping
	    public List<EmpresaParceira> getAllEmpresas() {
	        return empresaParceiraService.getAllEmpresas();
	    }

	    @GetMapping("/{id}")
	    public Optional<EmpresaParceira> getEmpresaById(@PathVariable Long id) {
	        return empresaParceiraService.getEmpresaById(id);
	    }

	    @PostMapping
	    public EmpresaParceira createEmpresa(@RequestBody EmpresaParceira empresaParceira) {
	        return empresaParceiraService.saveEmpresa(empresaParceira);
	    }

	    @PutMapping("/{id}")
	    public EmpresaParceira updateEmpresa(@PathVariable Long id, @RequestBody EmpresaParceira empresaParceira) {
	        empresaParceira.setId(id);
	        return empresaParceiraService.saveEmpresa(empresaParceira);
	    }

	    @DeleteMapping("/{id}")
	    public void deleteEmpresa(@PathVariable Long id) {
	        empresaParceiraService.deleteEmpresa(id);
	    }

}
