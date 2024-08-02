# CodeSoup

 Projeto basico criado para mostrar os diferentes tipos de heran�a que podemos criar:

 Temos tr�s estrat�gias de heran�a no Entity Framework: 

 * TPT (Table-Per-Type)
 * TPH (Table-Per-Hierarchy)
 * TPC (Table-Per-Concrete Class)  

A escolha da estrat�gia refletir� no design do seu banco de dados, ou seja,
ser� refletida na apar�ncia das tabelas e suas rela��es.

Antes de come�ar, um pequeno coment�rio do chatgpt:

"""

Escolhendo a Estrat�gia Certa

    Desempenho: TPH tende a ter melhor desempenho em leitura, mas pode ser menos eficiente em armazenamento.
    Complexidade do Modelo: TPT pode ser �til para modelos complexos com muitas hierarquias, mas pode resultar em desempenho mais lento.
    Manuten��o: TPC pode ser mais f�cil de manter, mas pode levar a uma duplica��o de dados.

A escolha da estrat�gia depende dos requisitos espec�ficos do seu projeto, como desempenho, complexidade do modelo e necessidades de manuten��o.

"""

Este projeto teremos tr�s exemplos de heran�a:

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

Os exemplos ser�o feitos no banco de dados MySQL
Os comandos para a cria��o do banco de dados e das tabelas s�o, respectivamente:
>> Abrir o Console do Gerenciador de Pacotes em Ferramentas > Gerenciador de Pacotes do Nuget > Console do Gerenciador de Pacotes

Escrever no terminal que ir� aparecer: 

PM> Add-Migration InitialMigration
PM> Update-Database

Se quiser excluir o banco de dados:
PM> Drop-Database

Se quiser excluir a migra��o:
PM> Remove-Migration





