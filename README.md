# TESTE DE PERFORMANCE - TP3 [OBRIGATÓRIO]

Nas etapas 5 e 6 de Fundamentos de Desenvolvimento com C#, você, que já compreende como utilizar variáveis e quais são os tipos básicos de objetos disponíveis no .NET Framework, e que sabe como criar estruturas para controlar fluxos de seleção e de iteração em seu código, entendeu como criar classes e também como criar bibliotecas.

Também aprendeu como criar hierarquias de classes para reaproveitar código, e compreendeu os conceitos de interfaces e de classes abstratas.

Nesse TP03, você deve criar, com o Visual Studio, uma aplicação para o Gerenciamento de Aniversários. Nessa aplicação o usuário deve poder inserir e consultar a data do aniversário de pessoas. No momento da inserção, a aplicação deve pedir o nome e o sobrenome da pessoa, assim como a sua data de nascimento. No momento da consulta, a aplicação deve receber o nome completo, ou parte do nome, da pessoa, e retornar todos os resultados que contiverem o nome completo, ou parte do nome, consultado. Quando o usuário selecionar um dos resultados retornados para ver os detalhes da pessoa, a aplicação deve mostrar se a pessoa já fez ou não aniversário no ano corrente, e em caso negativo, quanto dias faltam para seu próximo aniversário. O projeto deve ser do tipo Console App (.NET Core).

É muito importante que as chamadas de métodos da classe Console para a obtenção de inputs e também para a exibição de outputs fiquem restritos a classe Program.

É obrigatória a criação de classes para representar as entidades abaixo:

* Pessoa, contendo, pelo menos, as propriedades Nome, Sobrenome e Data de Nascimento. 
* Também pode conter métodos auxiliares, como por exemplo um método para calcular quanto tempo falta para o próximo aniversário daquela pessoa.
* Repositório de pessoas, contendo, pelo menos, o método para buscar pessoas pelo nome e o método para inserir uma pessoa na "base de dados".

Seu projeto deve armazenar as pessoas em uma coleção, em memória, e a classe que representa o repositório de pessoas deve ser a responsável por essa coleção, que deve ser mantida como um campo estático e privado desta classe.

Crie as classes que representam as entidades acima em uma biblioteca, projeto do tipo Class Library, na mesma solução do projeto do tipo Console App. 

É obrigatório o uso das classes criadas na aplicação.
