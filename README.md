### ASP.NET Core MVC
Um aplicativo que gerencia e exibe dados do cadastro de alunos.

![alt text](/Screenshot/printdoprojeto.png)

![alt text](/Screenshot/printdoprojeto2.png)

Esse aplicativo seguiu o padrão de arquitetura MVC (Model-View-Controller).

### O que é MVC?
MVC é nada mais que um padrão de arquitetura de software, separando sua aplicação em 3 camadas. A camada de interação do usuário(view), a camada de manipulação dos dados(model) e a camada de controle(controller).

**Model** Sempre que você pensar em manipulação de dados, pense em model. Ele é responsável pela leitura e escrita de dados, e também de suas validações.

**View** Simples: a camada de interação com o usuário. Ela apenas faz a exibição dos dados, sendo ela por meio de um html ou xml.

**Controller** O responsável por receber todas as requisições do usuário. Seus métodos chamados actions são responsáveis por uma página, controlando qual model usar e qual view será mostrado ao usuário.

## O diálogo das camadas

View: Fala Controller ! O usuário acabou de pedir para acessar o Facebook ! Pega os dados de login dele ai. Controller: Blz. Já te mando a resposta. Ai model, meu parceiro, toma esses dados de login e verifica se ele loga. Model: Os dados são válidos. Mandando a resposta de login. Controller: Blz. View, o usuário informou os dados corretos. Vou mandar pra você os dados dele e você carrega a página de perfil. View: Vlw. Mostrando ao usuário…

Fonte de pesquisa: https://tableless.com.br/mvc-afinal-e-o-que/

Esse projeto foi feito usando como base o seguinte site: https://docs.microsoft.com/pt-br/aspnet/core/tutorials/first-mvc-app/start-mvc?view=aspnetcore-5.0&tabs=visual-studio
