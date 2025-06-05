# 🧠 SafeSpace API

**SafeSpace** é uma API RESTful desenvolvida em .NET, com o objetivo de oferecer suporte psicológico e assistência logística para vítimas de tragédias e pessoas em situação de vulnerabilidade emocional. A plataforma permite o gerenciamento de usuários, solicitações de ajuda e agendamentos de sessões de apoio emocional.

---

## 🚀 Tecnologias Utilizadas

- ASP.NET Core
- Entity Framework Core
- SQL Server / Oracle (dependendo da versão)
- Swagger (documentação)
- RESTful APIs

---

## 📌 Funcionalidades

- Cadastro de usuários (vítimas, voluntários, profissionais)
- Criação de solicitações de ajuda
- Agendamento de sessões de apoio psicológico
- Atualização e gerenciamento de todos os recursos
- Documentação interativa via Swagger

---

## 📁 Estrutura das Entidades

### 🔸 UsuarioSS

| Campo        | Tipo     | Obrigatório | Descrição                          |
|--------------|----------|-------------|------------------------------------|
| id           | GUID     | Sim (PUT)   | Identificador do usuário           |
| nome         | string   | Sim         | Nome completo do usuário           |
| email        | string   | Sim         | E-mail para contato                |
| telefone     | string   | Sim         | Telefone com DDD                   |
| senha        | string   | Sim         | Senha de acesso                    |
| tipoUsuario  | string   | Sim         | "Vitima", "Voluntario", "Psicologo" |
| dataCadastro | datetime | Sim (PUT)   | Data de criação do cadastro        |
| agendamentos | array    | Opcional    | Lista de agendamentos              |

---

### 🔸 SolicitacaoAjuda

| Campo            | Tipo     | Obrigatório | Descrição                        |
|------------------|----------|-------------|----------------------------------|
| id               | GUID     | Sim (PUT)   | Identificador da solicitação     |
| descricao        | string   | Sim         | Descrição da situação            |
| dataSolicitacao  | datetime | Sim (PUT)   | Data e hora da solicitação       |

---

### 🔸 Agendamento

| Campo           | Tipo     | Obrigatório | Descrição                          |
|-----------------|----------|-------------|------------------------------------|
| id              | GUID     | Sim (PUT)   | Identificador do agendamento       |
| dataAgendamento | datetime | Sim (PUT)   | Data e hora da sessão              |
| descricao       | string   | Sim         | Objetivo ou descrição da sessão    |
| usuarioSSId     | GUID     | Sim         | ID do usuário associado            |
| usuarioSS       | objeto   | Null (PUT)  | Referência ao objeto UsuarioSS     |

---

## 📮 Requisições à API

### 🔹 POST — Criar recursos

#### ➕ Criar UsuárioSS

POST /UsuarioSS
{
  "nome": "Samir",
  "email": "samihneto@gmail.com",
  "telefone": "11934025013",
  "senha": "123456",
  "tipoUsuario": "Vitima"
}

#### ➕ Criar Solicitação de Ajuda
POST /SolicitacaoAjuda
{
  "descricao": "teste123"
}

#### ➕ Criar Agendamento
POST /Agendamento
{
  "descricao": "Sessão de apoio emocional",
  "usuarioSSId": "GUID_do_UsuarioSS"
}

### 🔹 PUT — Atualizar recursos
#### ✏️ Atualizar UsuárioSS
PUT /api/UsuarioSS/{id}
{
  "id": "GUID_do_UsuarioSS",
  "nome": "Samir",
  "email": "samihneto@gmail.com",
  "telefone": "11934025013",
  "senha": "123456",
  "tipoUsuario": "Vitima",
  "dataCadastro": "2025-06-01T12:00:00",
  "agendamentos": []
}

#### ✏️ Atualizar Solicitação de Ajuda
PUT /api/SolicitacaoAjuda/{id}
{
  "id": "GUID_da_Solicitacao",
  "descricao": "teste123",
  "dataSolicitacao": "2025-06-01T12:00:00"
}

#### ✏️ Atualizar Agendamento
PUT /api/Agendamento/{id}
{
  "id": "GUID_do_Agendamento",
  "dataAgendamento": "2025-06-04T10:00:00",
  "descricao": "Sessão de apoio emocional",
  "usuarioSSId": "GUID_do_UsuarioSS",
  "usuarioSS": null
}

🛠️ Como Executar o Projeto
### Clone o repositório:
git clone https://github.com/seu-usuario/safespace-api.git

### Navegue até a pasta do projeto:
cd safespace-api

### Restaure os pacotes:
dotnet restore

### Execute o projeto:
dotnet run

### Acesse o Swagger em:
https://localhost:8080/swagger

## 👨‍💻 Autores
Desenvolvido por FJS.dev Associados
#### Felipe Levy Stephens Fidelix - RM556426 
#### Jennifer Suzuki - RM554661 
#### Samir Hage Neto - RM557260