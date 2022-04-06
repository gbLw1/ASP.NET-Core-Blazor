# ASP.NET Core Blazor Server

  Uma simples apicação web [Blazor Server](https://docs.microsoft.com/pt-br/aspnet/core/blazor/?view=aspnetcore-6.0) que consome uma [WebAPI](https://docs.microsoft.com/pt-br/aspnet/core/web-api/?view=aspnetcore-6.0)

## Características do projeto
  .NET SDK Version: [net7.0](https://dotnet.microsoft.com/en-us/download/dotnet/7.0)

  Estilo Arquitetural: [Client-Server](https://pt.wikipedia.org/wiki/Modelo_cliente%E2%80%93servidor), [Multicamada](https://pt.wikipedia.org/wiki/Arquitetura_multicamada)

  Padrão arquitetural: [Repository](https://docs.microsoft.com/en-us/dotnet/architecture/microservices/microservice-ddd-cqrs-patterns/infrastructure-persistence-layer-design#:~:text=The%20Repository%20pattern%20is%20a,working%20with%20a%20data%20source.&text=A%20repository%20performs%20the%20tasks,of%20domain%20objects%20in%20memory.)

  Segurança: [ASP.NET Identity](https://docs.microsoft.com/en-US/aspnet/identity/overview/getting-started/introduction-to-aspnet-identity)

  ORM: [EntityFramework Core](https://pt.wikipedia.org/wiki/Entity_Framework)

---

## Camadas da aplicação

 - Api (webapi)
 - Models (classlib)
 - Web (blazorserver)

---

## Desenvolvimento da aplicação
 - [x] Criação do repositório
 - [x] Criação do projeto
 - [x] Criação das camadas
 - [x] Modelagem das entidades
 - [x] Referenciar os projetos
 - [x] Instalação e configuração do EF Core
 - [x] Mapeamento das entidades para o banco de dados (Fluent API)
 - [x] Implementação do Repository Pattern
 - [x] Criação das controllers (Alunos & Cursos)
 - [x] Testes da API com Postman
 - [x] Criação dos componentes Blazor (ListaAlunos)
 - [x] Implementação de Services para consumir a API
 - [x] Resolução de dependência (HttpClient)
 - [x] Criação componentes (Form + telas CRUD)
 - [x] Criação do componente para tratar imagens
 - [x] Realização do Delete com modal
 - [x] Implementação do filtro de busca (Alunos & Cursos)
 - [x] Implementação Autenticação e Autorização
 - [x] Code clean up

--- 

## NuGet Packages

  ### [DigitalCursos.Api](https://github.com/gbLw1/ASP.NET-Core-Blazor/tree/main/DigitalCursos/DigitalCursos.Api)
  - [x] Microsoft.EntityFrameworkCore.Design
  - [x] Microsoft.EntityFrameworkCore.SqlServer
  - [x] Microsoft.EntityFrameworkCore.Tools

  ### [DigitalCursos.Models](https://github.com/gbLw1/ASP.NET-Core-Blazor/tree/main/DigitalCursos/DigitalCursos.Models)
  >No packages needed
  
  ### [DigitalCursos.Web](https://github.com/gbLw1/ASP.NET-Core-Blazor/tree/main/DigitalCursos/DigitalCursos.Web)
  - [x] BlazorInputFile
  - [x] Microsoft.AspNetCore.Identity.EntityFrameworkCore
  - [x] Microsoft.AspNetCore.Identity.UI
  - [x] Microsoft.EntityFrameworkCore.SqlServer
  - [x] Microsoft.EntityFrameworkCore.Tools
  - [x] Microsoft.EntityFrameworkCore.Design

--- 

``` <TargetFramework>net7.0</TargetFramework> ```
![xD](https://c.tenor.com/pcCWcPVLXqgAAAAM/tf2dance.gif)