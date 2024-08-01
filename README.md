# CodeSoup

 Projeto basico criado para mostrar os diferentes tipos de herança que podemos criar:

 Temos três estratégias de herança no Entity Framework: 

 * TPT (Table-Per-Type)
 * TPH (Table-Per-Hierarchy)
 * TPC (Table-Per-Concrete Class)  

A escolha da estratégia refletirá no design do seu banco de dados, ou seja,
será refletida na aparência das tabelas e suas relações.

Antes de começar, um pequeno comentário do chatgpt:

"""

Escolhendo a Estratégia Certa

    Desempenho: TPH tende a ter melhor desempenho em leitura, mas pode ser menos eficiente em armazenamento.
    Complexidade do Modelo: TPT pode ser útil para modelos complexos com muitas hierarquias, mas pode resultar em desempenho mais lento.
    Manutenção: TPC pode ser mais fácil de manter, mas pode levar a uma duplicação de dados.

A escolha da estratégia depende dos requisitos específicos do seu projeto, como desempenho, complexidade do modelo e necessidades de manutenção.

"""

Este projeto teremos três exemplos de herança:

## Exemplo TPT

classe Veiculo - Superclasse

classe Carro - Filha de Veiculo, ou subclasse
classe Moto - Filha de Veiculo, ou subclasse

## Exemplo TPH

classe Funcionario - Superclasse

classe Empregado - Filha de Funcionario, ou subclasse
classe Freelancer - Filha de Funcionario, ou subclasse

## Exemplo TPC

classe Equipamento - Superclasse

classe Computador - Filha de Equipamento, ou subclasse
classe Impressora - Filha de Equipamento, ou subclasse

Os exemplos serão feitos no banco de dados portátil sqllite
O banco de dados se encontra dentro da pasta Database na camada de CondeSoup.Sources ( Não está anexada ao projeto. Se abrir a pasta do projeto vai ver lá. Só abrir o gerenciador do Sqllite e procurar ) ;




