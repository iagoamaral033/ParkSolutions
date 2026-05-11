# 🚗 ParkSolutions

Sistema de gerenciamento de estacionamento desenvolvido com C# e ASP.NET Blazor.

O projeto tem como objetivo controlar vagas, veículos, movimentações, reservas e configurações do estacionamento de forma simples e organizada.

---

# 📋 Funcionalidades

- Cadastro de veículos
- Controle de vagas
- Registro de movimentações
- Sistema de reservas
- Configuração do estacionamento
- Dashboard administrativo
- Integração com banco de dados usando Entity Framework Core

---

# 🛠️ Tecnologias Utilizadas

- C#
- .NET
- ASP.NET Core Blazor
- Entity Framework Core
- SQL Server

# ⚙️ Como Executar o Projeto

## Clone o repositório

```bash
git clone https://github.com/iagoamaral033/ParkSolutions.git
```

## Entre na pasta do projeto

```bash
cd ParkSolutions
```

## Restaure os pacotes

```bash
dotnet restore
```

## Execute o projeto

```bash
dotnet run
```

---

# 🗄️ Banco de Dados

O projeto utiliza Entity Framework Core.

Para criar as migrations:

```bash
dotnet ef migrations add InitialCreate
```

Para atualizar o banco:

```bash
dotnet ef database update
```

---

# 📌 Próximas Melhorias

- Sistema de autenticação
- Controle financeiro
- Relatórios
- Integração com pagamentos
- Dashboard com gráficos
- Responsividade mobile
