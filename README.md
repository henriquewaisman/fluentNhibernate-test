# Fluent NHibernate Test

Este repositório é um projeto de testes e experimentações com **Fluent NHibernate**, uma API para mapeamento objeto-relacional (ORM) que permite configurar mapeamentos NHibernate usando código C# fluente, ao invés de arquivos XML.

## 📚 Objetivo

O objetivo deste projeto é explorar a configuração e o uso do Fluent NHibernate para mapear classes do .NET para tabelas em um banco de dados relacional. Ele serve como um ponto de partida para entender os conceitos fundamentais e testar diferentes funcionalidades do Fluent NHibernate.

## 🛠 Tecnologias e Ferramentas

- [.NET](https://dotnet.microsoft.com/)
- [Fluent NHibernate](https://github.com/nhibernate/fluent-nhibernate)
- [NHibernate](https://nhibernate.info/)
- [SQLite](https://www.sqlite.org/index.html) (ou outro banco, conforme usado no projeto)
- Visual Studio / Rider

## 🚀 Como Executar

1. **Clone o repositório:**
   ```bash
   git clone https://github.com/henriquewaisman/fluentNhibernate-test.git
   cd fluentNhibernate-test
   ```

2. **Restaure os pacotes NuGet:**
   ```bash
   dotnet restore
   ```

3. **Compile o projeto:**
   ```bash
   dotnet build
   ```

4. **Execute o projeto:**
   ```bash
   dotnet run
   ```

## 🧪 O que está sendo testado?

- Configuração do NHibernate usando mapeamento fluente
- Criação automática de schema
- Operações básicas de CRUD (Create, Read, Update, Delete)
- Session factory e controle de sessões
- Logging e visualização de queries SQL geradas

## 📂 Estrutura do Projeto

```bash
fluentNhibernate-test/
├── Entities/              # Classes de domínio (entidades)
├── Mappings/              # Configurações Fluent NHibernate
├── Database/              # Scripts ou configurações do banco (opcional)
├── Program.cs             # Ponto de entrada do app
└── fluentNhibernate-test.csproj
```

## ✅ Status

✔️ Projeto funcional e pronto para servir de base para testes e estudos com Fluent NHibernate.

## 📌 Requisitos

- .NET SDK 6.0 ou superior
- Visual Studio 2022 ou equivalente
- (Opcional) SQLite ou outro SGBD conforme usado

## 🧑‍💻 Autor

Desenvolvido por [Henrique Waisman](https://github.com/henriquewaisman)

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.
