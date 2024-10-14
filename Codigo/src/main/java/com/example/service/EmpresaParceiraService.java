package com.example.service;

import java.util.List;
import java.util.Optional;

import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.example.model.EmpresaParceira;
import com.example.repository.EmpresaParceiraRepository;

@Service
public class EmpresaParceiraService {
	
	 @Autowired
	    private EmpresaParceiraRepository empresaParceiraRepository;

	    public List<EmpresaParceira> getAllEmpresas() {
	        return empresaParceiraRepository.findAll();
	    }

	    public Optional<EmpresaParceira> getEmpresaById(Long id) {
	        return empresaParceiraRepository.findById(id);
	    }

	    public EmpresaParceira saveEmpresa(EmpresaParceira empresaParceira) {
	        return empresaParceiraRepository.save(empresaParceira);
	    }

	    public void deleteEmpresa(Long id) {
	        empresaParceiraRepository.deleteById(id);
	    }

}
