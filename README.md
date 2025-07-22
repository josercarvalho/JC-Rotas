# Rota API

## Descri��o

Bem-vindo � documenta��o da API Rota. Esta API permite gerenciar e consultar rotas entre diferentes cidades. A seguir, est�o os detalhes das opera��es dispon�veis.

## Tecnologias Utilizadas

- **.NET Core 6.0**
- **MySQL para o banco de dados**

## Funcionalidades

- **Gerenciamento de Rotas**: 
  - Cadastro de rota.
  - Edi��o de rota.
  - Exclus�o de rota.
  - Obter todas as rotas dispon�veis.
  - Consulta a melhor rota entre dois pontos.

## Requisitos para Rodar a Aplica��o

- SDK do .NET 6.0: Certifique-se de ter o SDK do .NET 6.0 instalado. 
- MySQL: Instale o MySQL e configure um banco de dados para ser usado pela aplica��o.

## Instala��o

1. Clone o reposit�rio:
    ```sh
    git clone https://github.com/MatheusCavalari/rota-app.git
    cd rota-app
    ```

2. Restaure os pacotes NuGet:
    ```sh
    dotnet restore
    ```
3. Compile e execute o projeto:
    ```sh
    dotnet build
    dotnet run
    ```

### Endpoints
1. **GET /v1/rota
- **URL**: `/v1/rota`
- **M�todo**: `GET`
- **Resposta de Sucesso**:
    - C�digo: `200 OK`
    - Corpo: Lista de rotas

2. **GET /v1/rota/1
- **URL**: `/v1/rota/1`
- **M�todo**: `GET`
- **Resposta de Sucesso**:
    - C�digo: `200 OK`
    - Corpo: Rota encontrada

3. **POST /v1/rota
- **URL**: `/v1/rota`
- **M�todo**: `POST`
- **Corpo da Requisi��o**:
  ```json
  {
  "origem": "GRU",
  "destino": "BRC",
  "valor": 10
  }
  ```
- **Resposta de Sucesso**:
    - C�digo: `201 CREATED`
    - Corpo: Rota criada

4. **PUT /v1/rota/1
- **URL**: `/v1/rota/1`
- **M�todo**: `PUT`
- **Corpo da Requisi��o**:
  ```json
  {
  "origem": "GRU",
  "destino": "BRC",
  "valor": 12
  }
  ```
- **Resposta de Sucesso**:
    - C�digo: `204 NO CONTENT`

5. **DELETE /v1/rota/1
- **URL**: `/v1/rota/1`
- **M�todo**: `DELETE`
- **Resposta de Sucesso**:
    - C�digo: `204 NO CONTENT`

6. **GET /v1/rota/consulta?origem=GRU&destino=BRC
- **URL**: `/v1/rota/consulta?origem=GRU&destino=BRC`
- **M�todo**: `GET`
- **Resposta de Sucesso**:
  ```json
  {
  "rota": "GRU - BRC ao custo de $10"
  }
  ```

## Contribui��o

Contribui��es s�o bem-vindas! Sinta-se � vontade para abrir issues e pull requests.

## Autor

Matheus Cavalari Barbosa
