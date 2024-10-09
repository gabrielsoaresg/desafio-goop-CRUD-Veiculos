# CRUD de Veículos

Este é um projeto de API REST para gerenciamento de veículos, desenvolvido em .NET 6.0. A API permite realizar operações CRUD (Create, Read, Update, Delete) em um banco de dados de veículos.

## Funcionalidades

- **Cadastro de Veículo**: Permite adicionar novos veículos ao sistema.
- **Edição de Veículo**: Possibilidade de editar qualquer informação de um veículo existente.
- **Exclusão de Veículo**: Remove um veículo específico da base de dados.
- **Listagem de Veículos**: Exibe uma lista de todos os veículos cadastrados.
- **Validações**: Implementadas para garantir que os campos obrigatórios e as regras de negócio sejam respeitados.

## Tecnologias Utilizadas

- [.NET 6.0](https://dotnet.microsoft.com/download)
- Entity Framework Core
- Swagger para documentação da API

## Pré-requisitos

Antes de começar, certifique-se de ter os seguintes itens instalados em sua máquina:

- [.NET SDK 6.0 ou superior](https://dotnet.microsoft.com/download)
- Um banco de dados (SQLite, SQL Server, etc. O projeto usa SQLite por padrão)

## Como Executar o Projeto Localmente

1. **Clone o Repositório**
   Clone este repositório para sua máquina local usando o seguinte comando:
   ```bash
     git clone https://github.com/seu_usuario/seu_repositorio.git
     cd seu_repositorio

2. **Instale as dependências**
   - Navegue até o diretório do projeto e execute:
   ```bash
     dotnet restore

3. **Configure o Banco de Dados**
    - Se você estiver usando SQLite, não há necessidade de configuração adicional. Caso contrário, configure sua conexão no arquivo appsettings.json.
  
4. **Execute as migrações**
    - Execute o seguinte comando para aplicar as migrações (caso esteja usando Entity Framework Core):
   ```bash
   dotnet ef database update

5. **Execute o Projeto**
   - Para iniciar a API, execute:
    ```bash
      dotnet run

6. Acesse o Swagger
   - Após iniciar a aplicação, você pode acessar a documentação da API através do Swagger no navegador:
     ```bash
     http://localhost:{PORT}/swagger (PORT --> PORTA A QUAL A APLICAÇÃO ESTÁ UTILIZANDO).

7. Teste a API
   ![374969493-1ee0354d-073d-4897-8f3e-b35d1c74f114](https://github.com/user-attachments/assets/d1dca8aa-3aa2-4b6a-bc2b-71ac548da7b9)

  

