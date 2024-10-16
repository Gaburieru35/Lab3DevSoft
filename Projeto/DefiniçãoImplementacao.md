# Projeto usando ORM com Spring Data JPA

## Definição de ORM
ORM (Object-Relational Mapping) é uma técnica de programação que permite a conversão entre dados de uma base de dados relacional e objetos de programação orientada a objetos. Basicamente, ele mapeia classes a tabelas de banco de dados e vice-versa, facilitando a manipulação dos dados de forma mais intuitiva e menos propensa a erros.

## Implementação com Spring Data JPA

### Entidades (Entities)
Nossas classes `Aluno`, `Professor`, `Transacao`, etc., são anotadas com `@Entity` e representam tabelas no banco de dados.

### Repositórios (Repositories)
Utilizamos interfaces que estendem `JpaRepository` para realizar operações de CRUD, como `AlunoRepository` e `EmpresaParceiraRepository`.

### Serviços (Services)
Os serviços, como `AlunoService` e `EmpresaParceiraService`, contêm a lógica de negócios e utilizam os repositórios para interagir com o banco de dados.

### Controladores (Controllers)
Expondo endpoints REST para operações CRUD, como `AlunoController` e `EmpresaParceiraController`.

## Benefícios do ORM

### Redução de Código Boilerplate
O Spring Data JPA gera automaticamente a maioria das consultas SQL.
