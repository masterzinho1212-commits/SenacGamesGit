[README_SenacGamesGit.md](https://github.com/user-attachments/files/32577086/README_SenacGamesGit.md)
# Senac Games

Sistema para gerenciamento de jogos e categorias, desenvolvido como projeto de estudo para aplicar conceitos de desenvolvimento back-end, front-end, banco de dados e organização de software em camadas.

## Tecnologias utilizadas

- C# e .NET 10
- ASP.NET Core Web API
- ASP.NET Core MVC
- Entity Framework Core
- SQL Server
- ASP.NET Core Identity
- OpenAPI

## Funcionalidades

- Cadastro, consulta, atualização e exclusão de jogos.
- Cadastro e gerenciamento de categorias.
- Associação de jogos às suas respectivas categorias.
- API para comunicação entre as camadas da aplicação.
- Persistência dos dados com Entity Framework Core e SQL Server.

## Organização do projeto

O projeto está organizado em camadas para separar responsabilidades e tornar o código mais fácil de manter:

```text
SenacGames.API/             # Endpoints e configuração da API
SenacGames.Application/     # Serviços, DTOs e regras da aplicação
SenacGames.Domain/          # Entidades e interfaces do domínio
SenacGames.Infrastructure/  # Banco de dados, repositórios e configurações
SenacGames.UI/              # Interface web
```

## Como executar localmente

1. Clone este repositório:

```bash
git clone https://github.com/masterzinho1212-commits/SenacGamesGit.git
cd SenacGamesGit
```

2. Abra a solução `SenacGames.slnx` no Visual Studio ou no Visual Studio Code.

3. Configure a string de conexão do SQL Server nos arquivos `appsettings.json` ou `appsettings.Development.json` do projeto de API.

4. Restaure as dependências:

```bash
dotnet restore
```

5. Execute a API:

```bash
dotnet run --project SenacGames.API
```

6. Em outro terminal, execute a interface web:

```bash
dotnet run --project SenacGames.UI
```

## Objetivo de aprendizado

Este projeto foi desenvolvido para praticar:

- Desenvolvimento de APIs REST.
- Arquitetura em camadas.
- Criação de entidades e relacionamentos.
- Acesso a dados com Entity Framework Core.
- Uso de repositórios e DTOs.
- Integração entre back-end, banco de dados e interface web.

## Autor

**Vinicius Oliveira de Souza**

- GitHub: [@masterzinho1212-commits](https://github.com/masterzinho1212-commits)
