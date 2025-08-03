# 🧱 dotnet-boilerplate

> Base project with layered architecture for .NET 8 applications, ready to scale for both monoliths and microservices.

[🇧🇷 Brazilian Portuguese Version](./README.ptBr.md) 

This repository serves as a reusable template for .NET applications, with layered separation following Clean Architecture best practices.

---

## 📁 Project Structure

```plaintext
├── DotnetBoilerplate.Api/               # Presentation layer
├── DotnetBoilerplate.Application/       # Use cases, interfaces, DTOs
├── DotnetBoilerplate.Domain/            # Business entities and rules
├── DotnetBoilerplate.Infra/             # Infrastructure (implementations)
├── DotnetBoilerplate.Infra.CrossCutting/# Middlewares, logging, configs, etc
├── DotnetBoilerplate.Infra.Shared/      # Common utilities and contracts  
├── DotnetBoilerplate.Infra.Tests/       # Automated tests (xUnit)
```

--- 


## 🔧 How to use

1. Click Use this template at the top right
2. Rename your repository
3. Clone:

```bash

git clone https://github.com/your-username/your-new-repo.git
```

4. Run:

```bash

cd DotnetBoilerplate.Api
dotnet run
```

Or simply clone the repository:

```bash

git clone https://github.com/RafaelRodriguesFraga/dotnet-boilerplate.git
```

Access at:
📍 http://localhost:5101/swagger

<br>

##### Feito com ❤️ por Rafael Fraga