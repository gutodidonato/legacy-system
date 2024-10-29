# Projeto LegacyRefactor

Este projeto é uma refatoração de um sistema legado utilizando .NET Core. A refatoração aplica o padrão **GoF Repository** para separar a lógica de acesso a dados da lógica de negócios. O sistema gerencia entidades como `Cliente` e `Transacao`, e contém um conjunto de testes unitários implementados com **xUnit**.

## Estrutura do Projeto

```bash
LegacyRefactor/
├── Business/                   # Camada de lógica de negócios
│   ├── IClienteRepository.cs   # Interface para repositório de Cliente
│   ├── ITransacaoRepository.cs # Interface para repositório de Transação
│   └── Repositories/           # Implementações dos repositórios
│       ├── ClienteRepository.cs
│       └── TransacaoRepository.cs
├── Domain/                     # Camada de domínio, contendo entidades
│   ├── Cliente.cs              # Classe de domínio Cliente
│   └── Transacao.cs            # Classe de domínio Transacao
├── Infrastructure/             # Infraestrutura e configuração do contexto de dados
│   └── DataContext.cs
└── Program.cs                  # Ponto de entrada da aplicação


# Tecnologias Utilizadas

- **.NET Core**: Framework utilizado para a aplicação e API.
- **xUnit**: Framework de testes unitários.
- **C#**: Linguagem de programação principal.
- **Padrão Repository**: Para abstração e organização de acesso a dados.

## Como Executar o Projeto

### Clone o repositório:

```bash
git clone https://github.com/seu-usuario/legacy-refactor.git
cd legacy-refactor
dotnet restore
dotnet build
dotnet run --project LegacyRefactor