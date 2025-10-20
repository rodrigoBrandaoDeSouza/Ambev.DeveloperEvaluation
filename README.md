# 🧠 Ambev Developer Evaluation - API

Projeto de avaliação técnica com arquitetura **CQRS + DDD + Rebus**, utilizando **.NET 8**, **PostgreSQL**, e **Docker Compose** para orquestração.

---

## 🚀 Tecnologias principais

- **.NET 8 Web API**
- **Entity Framework Core (PostgreSQL)**
- **Dapper**
- **MediatR (CQRS)**
- **Rebus (mensageria)**
- **Docker Compose**

---

## 🐳 Subindo o ambiente com Docker Compose

O projeto utiliza o **PostgreSQL**

### 1️⃣ Preparando o ambiente
```bash
docker compose up -d
```
Isso irá:
Criar o container do PostgreSQL.

### 2️⃣ Aplicando Migrations no banco
```bash
dotnet ef database update \
  --project src/Ambev.DeveloperEvaluation.ORM \
  --startup-project src/Ambev.DeveloperEvaluation.Api
```
📝 Certifique-se de que a connection string no appsettings.json (ou nas variáveis de ambiente do container) está configurada corretamente para o PostgreSQL.

Exemplo
```bash
"ConnectionStrings": {
  "DefaultConnection": "Host=localhost;Port=56244;Database=developer_evaluation;Username=developer;Password=ev@luAt10n;Pooling=true;SSL Mode=Disable;Trust Server Certificate=true"
}
```

🧱 Estrutura de arquitetura
Camada	Responsabilidade
API	Endpoints e controle HTTP
Application	Handlers, CQRS, validações
Domain	Entidades e regras de negócio
ORM	Mapeamentos EF Core e Migrations
Messaging	Publicação de eventos e mensageria (Rebus)

✅ Resumo rápido
Subir containers	```docker compose up --build```

Aplicar migrations ```dotnet ef database update --project src/Ambev.DeveloperEvaluation.ORM --startup-project src/Ambev.DeveloperEvaluation.Api ```

Acessar Swagger	http://localhost:7181/swagger

---

Desenvolvido por Rodrigo Brandão

📍 Toledo - PR

[LinkedIn](https://www.linkedin.com/in/brandao-rodrigo/)




