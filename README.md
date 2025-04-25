## Instruções para Compilar e Executar

1. Certifique-se de ter o [Docker](https://www.docker.com/products/docker-desktop/) instalado.
2. Utilizando linha de comando, navegue até o diretório do projeto:
    ```bash
    ./DotNetConsoleAppBase/BasicConsoleApp
    ```
3. A partir desse diretório, você poderá compilar/executar o projeto e rodar os testes.

### Instruções para Compilar e Executar o Projeto

1. Crie a imagem Docker:
    ```bash
    docker build --pull -t basic-console-app .
    ```
2. Crie e execute o container:

    a. Pipe:
    ```bash
    echo '<string-test>' | docker run -i --rm basic-console-app
    ```
    b. Colando a string após executar:
    ```bash
    docker run -it --rm basic-console-app
    ```

### Instruções para Executar os Testes

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

Utilizado para centralizar as configurações do aplicativo. O uso do `ConfigurationBuilder` garante flexibilidade para gerenciar configurações em múltiplos ambientes e oferece integração com o `Host`, permitindo suporte ao controle de injeção de dependência. Isso facilita a configuração e execução de aplicativos organizando e centralizando todas as configurações.


**Microsoft.Extensions.Hosting**

Utilizada para o gerenciamento do ciclo de vida da aplicação, integra um contêiner de injeção de dependência (DI), permitindo registrar e resolver serviços de forma eficiente. Isso facilita a configuração e execução de aplicativos baseados em .NET, garantindo modularidade e escalabilidade.

**System.Text.Json**

Biblioteca para manipulação de JSON, como serialização e desserialização. O uso da biblioteca facilita a manipulação de objetos JSON, oferecendo flexibilidade de configuração para as ações necessárias.

### Testes

**xUnit**

Framework de testes unitários utilizado para criar, organizar e executar testes automatizados. O framework oferece ferramentas que facilitam e agilizam a criação de testes, permitindo a definição de múltiplos casos de teste de forma organizada e clara, além de suportar testes parametrizados.

**Moq**

Biblioteca utilizada para criar mocks em testes unitários. Mocks são objetos configuráveis que simulam comportamentos específicos e podem ser utilizados para verificar interações durante os testes. Seu uso é benéfico, pois permite simular dependências, especialmente ao trabalhar com interfaces, isolando responsabilidades e facilitando a criação de testes unitários focados em cada unidade.

**Coverlet Collector**

Biblioteca utilizada para medir a cobertura de código dos testes unitários do projeto. Essa ferramenta é integrada ao comando `dotnet test`, permitindo a execução dos testes unitários e a geração de relatórios de cobertura. Seu uso garante que os testes desenvolvidos possuam uma boa cobertura de código, além de identificar áreas que ainda não foram testadas.
