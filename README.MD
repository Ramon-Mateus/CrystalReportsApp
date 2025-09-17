# Projeto de Estudo: Crystal Reports com ASP.NET MVC

Este é um projeto para demonstrar a integração de relatórios dinâmicos com **Crystal Reports** em uma aplicação web **ASP.NET MVC**.

### Funcionalidades

* Geração de relatórios a partir de listas de objetos em C# (`List<T>`).
* Conexão direta com banco de dados SQL Server, usando **Tabelas** e **Views**.
* Implementação de **filtros dinâmicos**, tanto na aplicação (com LINQ) quanto no banco (com Parâmetros).

### Tecnologias

* C# e .NET Framework 4.8
* ASP.NET MVC 5
* SQL Server
* SAP Crystal Reports for VS

### Para Executar

1.  Tenha o **Crystal Reports for Visual Studio** instalado.
2.  Execute o script SQL para criar o banco de dados (caso ainda não tenha).
```sql
CREATE DATABASE ProdutosDB;

USE ProdutosDB;

CREATE TABLE Produtos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(100) NOT NULL,
    Categoria NVARCHAR(50),
    Preco DECIMAL(10, 2)
);

INSERT INTO Produtos (Nome, Categoria, Preco) VALUES
('Teclado Gamer', 'Periféricos', 250.75),
('Mouse Sem Fio', 'Periféricos', 120.00),
('Monitor 24 polegadas', 'Monitores', 950.50),
('SSD 1TB', 'Armazenamento', 450.00),
('Webcam Full HD', 'Periféricos', 310.00),
('Monitor Ultrawide', 'Monitores', 1850.00);
```

3.  Abra no Visual Studio e execute.