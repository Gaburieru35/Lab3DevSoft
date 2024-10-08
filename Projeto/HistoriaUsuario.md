### 1. Cadastro de Alunos
- **Como** aluno interessado em ingressar no sistema de mérito,
- **Quero** me cadastrar informando meu nome, email, CPF, RG, endereço, instituição de ensino e curso,
- **Para** poder participar e receber moedas dos professores.

#### Critérios de Aceite:
- O sistema deve validar os campos obrigatórios (nome, email, CPF, RG, endereço, instituição e curso).
- A instituição de ensino deve ser selecionada de uma lista pré-cadastrada.
- O sistema deve enviar um email de confirmação ao aluno após o cadastro.
- O aluno deve criar login e senha no ato do cadastro.
- Não pode haver duplicidade de CPF no sistema.

---

### 2. Cadastro de Professores (via Instituições)
- **Como** instituição de ensino parceira,
- **Quero** enviar uma lista de professores com nome, CPF e departamento,
- **Para** que eles possam acessar o sistema e distribuir moedas aos alunos.

#### Critérios de Aceite:
- O sistema deve permitir a carga de professores via integração ou arquivo.
- O sistema deve validar a existência de cada professor em uma instituição previamente cadastrada.
- Cada professor deve ser associado a um departamento dentro da instituição.
- Professores recebem login e senha por email após o cadastro.

---

### 3. Distribuição de Moedas
- **Como** professor cadastrado no sistema de mérito,
- **Quero** distribuir moedas para alunos como reconhecimento,
- **Para** valorizar o bom comportamento e a participação em aula.

#### Critérios de Aceite:
- O professor deve possuir saldo suficiente de moedas (1.000 moedas por semestre, acumuláveis).
- O professor deve indicar o aluno destinatário e incluir uma mensagem obrigatória justificando o reconhecimento.
- O sistema deve notificar o aluno por email após o recebimento de moedas.
- O saldo do professor deve ser atualizado imediatamente após a transação.
- Não pode ser permitido o envio de moedas caso o saldo seja insuficiente.

---

### 4. Consulta de Extrato (Alunos)
- **Como** aluno cadastrado no sistema,
- **Quero** consultar meu extrato de moedas,
- **Para** visualizar o total de moedas recebidas e as transações realizadas.

#### Critérios de Aceite:
- O aluno deve visualizar o saldo atual de moedas.
- O extrato deve incluir todas as transações de recebimento e troca de moedas.
- O sistema deve permitir a filtragem por período de tempo.

---

### 5. Consulta de Extrato (Professores)
- **Como** professor cadastrado no sistema,
- **Quero** consultar meu extrato de moedas,
- **Para** visualizar as moedas enviadas aos alunos e meu saldo disponível.

#### Critérios de Aceite:
- O professor deve visualizar o saldo atual de moedas.
- O extrato deve listar todas as transações de envio de moedas, com data, aluno e mensagem de reconhecimento.
- O sistema deve permitir a filtragem por período de tempo.

---

### 6. Resgate de Vantagens (Alunos)
- **Como** aluno com saldo de moedas,
- **Quero** resgatar vantagens oferecidas por empresas parceiras,
- **Para** usufruir dos benefícios de minhas moedas.

#### Critérios de Aceite:
- O sistema deve listar as vantagens cadastradas e seu custo em moedas.
- Ao selecionar uma vantagem, o saldo do aluno deve ser descontado automaticamente.
- O sistema deve enviar um email com um cupom para o aluno, contendo um código único.
- O sistema deve notificar a empresa parceira por email, incluindo o mesmo código gerado.

---

### 7. Cadastro de Empresas Parceiras
- **Como** empresa parceira,
- **Quero** me cadastrar no sistema e incluir vantagens,
- **Para** que alunos possam trocar suas moedas por benefícios oferecidos pela minha empresa.

#### Critérios de Aceite:
- A empresa deve fornecer nome, email, CNPJ, endereço e vantagens oferecidas no cadastro.
- Cada vantagem deve incluir descrição, custo em moedas e uma foto do produto/benefício.
- A empresa deve receber um email de confirmação após o cadastro, com login e senha.

---

### 8. Autenticação
- **Como** qualquer usuário (aluno, professor ou empresa parceira),
- **Quero** realizar login no sistema com meu email e senha,
- **Para** acessar minhas funcionalidades e informações no sistema.

#### Critérios de Aceite:
- O sistema deve validar email e senha na tentativa de login.
- Em caso de erro de autenticação, uma mensagem clara deve ser exibida.
- O sistema deve oferecer funcionalidade de recuperação de senha.
- Após autenticação bem-sucedida, o usuário deve ser direcionado para a sua área de atuação (aluno, professor ou empresa).
