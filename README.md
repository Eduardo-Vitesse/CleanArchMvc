# CleanArchMvc

Este projeto é uma implementação da Arquitetura Limpa usando .NET 7 e C#. Ele usa o Entity Framework Core para acessar um banco de dados e DTOs para transferir dados entre as camadas.

## Tecnologias

* C#
* .NET 7
* ASP.NET Core
* MVC
* Repository
* Clean Architecture
* Entity Framework Core
* DDD
* AutoMapper
* DTOs

## Instalação

git clone https://github.com/Eduardo-Vitesse/CleanArchMvc.git

Em seguida, acesse a pasta do projeto e execute o seguinte comando para instalar as dependências:
```bash
    dotnet restore
```

Execução
```bash
    dotnet run
```


O projeto será executado.

## Arquitetura
O projeto segue a Arquitetura Limpa, que divide o código em quatro camadas:

Domínio: Essa camada é responsável por toda a lógica do domínio, como entidades, regras de negócios e exceções.
Aplicação: Essa camada é responsável por implementar a lógica de negócios do domínio.
Infraestrutura: Essa camada é responsável por acessar recursos externos, como bancos de dados e APIs.
Interface de Usuário: Essa camada é responsável pela interação com o usuário.
DDD
O projeto também usa o DDD (Domain-Driven Design), que é uma abordagem para o desenvolvimento de software que se concentra no domínio do negócio.

DTOs
O projeto usa DTOs (Data Transfer Objects) para transferir dados entre as camadas. DTOs são objetos simples que contêm apenas os dados necessários para a operação em questão.

## Recursos
[Clean Architecture:] (https://blog.cleancoder.com/uncle-bob/2012/08/13/the-clean-architecture.html)
[DDD:] (https://martinfowler.com/bliki/DomainDrivenDesign.html)
[Entity Framework Core:] (https://docs.microsoft.com/en-us/ef/core/)
[AutoMapper:] (https://automapper.org/)
[DTOs:] (https://en.wikipedia.org/wiki/Data_transfer_object)