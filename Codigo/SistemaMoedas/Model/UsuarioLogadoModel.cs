﻿using SistemaMoedas.Classes;

namespace SistemaMoedas.Model
{
    public class UsuarioLogadoModel
    {
        public Constantes.Constantes.TiposUsuarios TiposUsuario { get; set; }
        public Classes.Usuario Usuario;
        public Classes.Aluno Aluno;
        public Classes.Professor Professor;

    }
}
