# 🔐 API de Autenticação e Autorização com JWT

API REST desenvolvida em **ASP.NET Core** para autenticação e autorização de usuários utilizando **JWT (JSON Web Token)**, com controle de acesso por **roles** (`User` e `Admin`).

---

## 🚀 Tecnologias utilizadas

- .NET / ASP.NET Core
- Entity Framework Core
- SQL Server
- JWT (JSON Web Token)
- BCrypt (hash de senha)
- Swagger (OpenAPI)

---

## 📌 Funcionalidades

- Registro de usuários
- Login com geração de token JWT
- Autenticação via Bearer Token
- Autorização por roles
- Endpoint protegido para usuário autenticado
- Endpoint restrito para administrador
- Seed automático de usuário Admin

---

## 📂 Estrutura do projeto

```text
api-auth/
├── Application/
│   └── DTOs/
│
├── Controllers/
│   ├── AuthController.cs
│   └── UserController.cs
│
├── Data/
│   ├── AppDbContext.cs
│   └── Seeds/
│       └── AdminUserSeed.cs
│
├── Domain/
│   └── Entities/
│       └── User.cs
│
├── Migrations/
├── Program.cs
├── appsettings.json
├── appsettings.Development.json
└── api-auth.csproj
```

## ⚙️ Como executar o projeto

1️⃣ Clone o repositório
```bash
git clone https://github.com/seu-usuario/api-auth-dotnet.git
cd api-auth-dotnet
```

2️⃣ Configurar o banco de dados

**Edite o arquivo appsettings.json:**

```bash
"ConnectionStrings": {
  "DefaultConnection": "Server=SEU_SERVIDOR;Database=AuthApiDb;Trusted_Connection=True;TrustServerCertificate=True"
}
```

3️⃣ Configurar JWT

**No mesmo arquivo appsettings.json:**
```bash
"Jwt": {
  "Key": "SUA_CHAVE_SUPER_SECRETA_COM_MAIS_DE_32_CARACTERES",
  "Issuer": "AuthApi",
  "Audience": "AuthApiUsers",
  "ExpireMinutes": 60
}
```

⚠️ A chave (Key) deve ter no mínimo 32 caracteres.


4️⃣ Criar o banco de dados

**Execute o comando abaixo para aplicar as migrations:**
```bash
dotnet ef database update
```

5️⃣ Executar a aplicação
```bash
dotnet run
```

A API ficará disponível em: `https://localhost:SUA_PORTA/swagger`

## 🔑 Autenticação no Swagger

Acesse o endpoint:

`POST /api/auth/login`

1. Copie apenas o token retornado na resposta
2. Clique no botão Authorize no Swagger
3. Cole o token sem escrever Bearer
4. Confirme a autorização
5. Agora os endpoints protegidos estarão liberados.


🔒 Endpoints da API / 🔐 Autenticação

`POST /api/auth/register` Cria um novo usuário

`POST /api/auth/login` Autentica o usuário e gera o token JWT

👤 Usuário autenticado


`GET /api/users/me` Retorna os dados do usuário logado


👑 Administrador 

`GET /api/users/admin-area` Endpoint acessível apenas para usuários com role Admin

---
> [!IMPORTANT]
> *👑 Usuário administrador (Seed),
Ao iniciar a aplicação, um usuário administrador é criado automaticamente caso não exista.*
---

*Credenciais padrão:*

> Email: admin@admin.com
> 
> Senha: Admin@123
> 
> Role: Admin

A lógica está localizada em: `Data/Seeds/AdminUserSeed.cs`

🔐 Segurança
Senhas armazenadas com hash BCrypt

*JWT contém:*

>
>sub (UserId)
>
>Email
>
>Role

Autorização feita com:
`[Authorize]
[Authorize(Roles = "Admin")]`
