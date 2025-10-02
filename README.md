
# Sistema de Chamados

## Descrição

O **Sistema de Chamados** é uma aplicação web desenvolvida com **ASP.NET Core** para gerenciar solicitações de suporte técnico. Ele permite que usuários criem, visualizem e gerenciem chamados de suporte, enquanto os administradores podem acompanhar o status e atribuir atendentes aos chamados.

## Tecnologias Usadas

- **ASP.NET Core**: Framework principal para o desenvolvimento da aplicação.
- **C#**: Linguagem de programação utilizada.
- **Entity Framework**: ORM utilizado para interação com o banco de dados.
- **MVC (Model-View-Controller)**: Arquitetura para organização da aplicação.
- **JavaScript, CSS**: Para a construção da interface do usuário (no diretório `wwwroot`).

## Como Rodar o Projeto

### 1. Clonando o Repositório

Clone o repositório ou extraia os arquivos no seu ambiente de desenvolvimento.

### 2. Configurando o Banco de Dados

Se o projeto estiver configurado para usar um banco de dados, certifique-se de que a string de conexão no arquivo `appsettings.json` ou `appsettings.Development.json` esteja correta.

### 3. Instalando as Dependências

No terminal, navegue até o diretório do projeto e execute o seguinte comando para restaurar os pacotes NuGet:

```bash
dotnet restore
```

### 4. Rodando a Aplicação

Para rodar a aplicação localmente, execute:

```bash
dotnet run
```

Isso iniciará o servidor na URL padrão `http://localhost:5000`.

### 5. Acessando a Aplicação

Abra seu navegador e acesse `http://localhost:5000` para ver o sistema em funcionamento.

## Estrutura do Projeto

- **Controllers**: Contém os controladores da aplicação, responsáveis por lidar com as requisições HTTP e manipular a lógica de negócio.
- **DAO**: Contém a camada de acesso a dados, geralmente com interações de banco de dados.
- **Models**: Contém as classes de modelos, representando as entidades do sistema, como `Chamado`, `Usuario`, etc.
- **Views**: Contém as páginas da interface de usuário (UI), usadas para renderizar as respostas para o usuário.
- **wwwroot**: Contém arquivos estáticos como imagens, CSS, e JavaScript.

## Configuração Adicional

Caso necessário, adicione mais informações sobre a configuração de terceiros, como APIs ou serviços que o sistema utiliza.

## Considerações Finais

Esse projeto pode ser expandido com novas funcionalidades, como autenticação, envio de notificações, relatórios, etc. Certifique-se de adaptar o arquivo `appsettings.json` de acordo com o ambiente de produção.
