# 🧱 dotnet-boilerplate

> Projeto base com arquitetura em camadas para aplicações .NET 8 pronto para escalar, seja para monolitos ou microsserviços.


[🇺🇸 English Version](./README.md) 

Este repositório serve como um **template reutilizável para aplicações em .NET**, com separação em camadas, seguindo boas práticas de Clean Architecture.

---

## 📁 Estrutura do Projeto

```plaintext
├── DotnetBoilerplate.Api/                # Camada de apresentação (Presentation)
├── DotnetBoilerplate.Application/        # Casos de uso, interfaces, DTOs
├── DotnetBoilerplate.Domain/             # Entidades e regras de negócio
├── DotnetBoilerplate.Infra/              # Infraestrutura (implementações)
├── DotnetBoilerplate.Infra.CrossCutting/ # Middlewares, logging, configs, etc
├── DotnetBoilerplate.Infra.Shared/       # Utilitários e contratos comuns
├── DotnetBoilerplate.Infra.Tests/        # Testes automatizados (xUnit)
```
---

## 🔧 Como usar

1. Clique em `Use this template` no canto superior direito
2. Renomeie seu repositório
3. Clone:
  
```bash
git clone https://github.com/seu-usuario/seu-novo-repositorio.git
```
4. Rode:

```bash
cd DotnetBoilerplate.Api
dotnet run
```

Ou simplesmente clone o repositório:

```bash
git clone https://github.com/RafaelRodriguesFraga/dotnet-boilerplate.git
```

Acesse em:
📍 http://localhost:5101/swagger

<br>

##### Feito com ❤️ por Rafael Fraga