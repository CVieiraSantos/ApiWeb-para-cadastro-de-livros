## ApiWeb-para-cadastro-de-livros

#Projeto de uma ApiWeb desenvolvido na linguagem C#, utilizando banco de dados relacional SQL SERVER como repositório e o Swagger como camada de interface para a visualização dos objetos cadastrados.

#A ideia do projeto foi retirado de uma vídeo aula do portal www.dio.me porém eu fiz algumas modificações. 
#Inicialmente o projeto tinha como objetivo utilizar um banco de dados in memory, porém eu utilizei um banco de dados SQL SERVER, utilizando um provider do Microsoft.EntityFrameworkCore.SqlServer. Também foi utilizado uma modelagem de dados para que o framework não cadastrasse os dados por conta própria, logo foi tomado cuidado em relação a isso, uma coluna nome por exemplo eu cadastrei manualmente como varchar, e não deixando a cargo do ORM, pois se assim deixasse, o mesmo cadastraria como nvarcharmax. Por fim utilizei o Swagger como interface para o gerenciamento dos objetos inseridos via Post e visualizados via Get.
