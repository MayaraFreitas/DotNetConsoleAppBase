## Instru��es para Compilar e Executar

1. Certifique-se de ter o [Docker](https://www.docker.com/products/docker-desktop/) instalado.
2. Utilizando linha de comando, navegue at� o diret�rio do projeto:
    ```bash
    ./DotNetConsoleAppBase/BasicConsoleApp
    ```
3. A partir desse diret�rio, voc� poder� compilar/executar o projeto e rodar os testes.

### Instru��es para Compilar e Executar o Projeto

1. Crie a imagem Docker:
    ```bash
    docker build --pull -t basic-console-app .
    ```
2. Crie e execute o container:

    a. Pipe:
    ```bash
    echo '<string-test>' | docker run -i --rm basic-console-app
    ```
    b. Colando a string ap�s executar:
    ```bash
    docker run -it --rm basic-console-app
    ```

### Instru��es para Executar os Testes

1. Crie a imagem Docker:
    ```bash
    docker build --pull --target test -t basic-console-app-tests .
    ```
2. Crie e execute o container:
    ```bash
    docker run -it --rm basic-console-app-tests
    ```

## Frameworks/Bibliotecas

### Projeto

**Microsoft.Extensions.Configuration**

Utilizado para centralizar as configura��es do aplicativo. O uso do `ConfigurationBuilder` garante flexibilidade para gerenciar configura��es em m�ltiplos ambientes e oferece integra��o com o `Host`, permitindo suporte ao controle de inje��o de depend�ncia. Isso facilita a configura��o e execu��o de aplicativos organizando e centralizando todas as configura��es.


**Microsoft.Extensions.Hosting**

Utilizada para o gerenciamento do ciclo de vida da aplica��o, integra um cont�iner de inje��o de depend�ncia (DI), permitindo registrar e resolver servi�os de forma eficiente. Isso facilita a configura��o e execu��o de aplicativos baseados em .NET, garantindo modularidade e escalabilidade.

**System.Text.Json**

Biblioteca para manipula��o de JSON, como serializa��o e desserializa��o. O uso da biblioteca facilita a manipula��o de objetos JSON, oferecendo flexibilidade de configura��o para as a��es necess�rias.

### Testes

**xUnit**

Framework de testes unit�rios utilizado para criar, organizar e executar testes automatizados. O framework oferece ferramentas que facilitam e agilizam a cria��o de testes, permitindo a defini��o de m�ltiplos casos de teste de forma organizada e clara, al�m de suportar testes parametrizados.

**Moq**

Biblioteca utilizada para criar mocks em testes unit�rios. Mocks s�o objetos configur�veis que simulam comportamentos espec�ficos e podem ser utilizados para verificar intera��es durante os testes. Seu uso � ben�fico, pois permite simular depend�ncias, especialmente ao trabalhar com interfaces, isolando responsabilidades e facilitando a cria��o de testes unit�rios focados em cada unidade.

**Coverlet Collector**

Biblioteca utilizada para medir a cobertura de c�digo dos testes unit�rios do projeto. Essa ferramenta � integrada ao comando `dotnet test`, permitindo a execu��o dos testes unit�rios e a gera��o de relat�rios de cobertura. Seu uso garante que os testes desenvolvidos possuam uma boa cobertura de c�digo, al�m de identificar �reas que ainda n�o foram testadas.
