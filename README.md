![buffers](https://github.com/user-attachments/assets/ea988313-efd9-4df1-8155-e3d3644edb51)

[![.NET](https://github.com/daniloopinheiro/FlatBufferNet/actions/workflows/dotnet.yml/badge.svg)](https://github.com/daniloopinheiro/FlatBufferNet/actions/workflows/dotnet.yml)

# FlatBufferNet

**FlatBufferNet** é um projeto de software desenvolvido para calcular a idade de uma pessoa com base na sua data de nascimento, utilizando o formato de serialização de dados **FlatBuffers** para persistência e manipulação eficiente dos dados. O projeto é desenvolvido com **.NET** e oferece uma forma compacta e rápida de armazenar e recuperar informações.

---

## Índice

- [Visão Geral](#visão-geral)
- [Tecnologias Utilizadas](#tecnologias-utilizadas)
- [Instalação](#instalação)
- [Como Usar](#como-usar)
- [Estrutura de Diretórios](#estrutura-de-diretórios)
- [Configuração](#configuração)
- [Contribuições](#contribuições)
- [Licença](#licença)
- [Contato](#contato)

---

## Visão Geral

Este projeto tem como objetivo calcular a idade de uma pessoa a partir de sua data de nascimento, utilizando **FlatBuffers** para serialização de dados e **.NET** como plataforma de desenvolvimento. Ele oferece as seguintes funcionalidades principais:

- **Cálculo de Idade**: A partir da data de nascimento fornecida, o sistema calcula a idade exata da pessoa.
- **Persistência de Dados**: Utiliza **FlatBuffers** para armazenar de forma eficiente os dados de entrada (nome e data de nascimento).
- **Leitura e Escrita de Arquivo**: Os dados podem ser salvos e carregados de arquivos binários, otimizando o uso de memória.

A arquitetura do projeto segue o modelo **Clean Architecture**, separando as responsabilidades de forma a garantir fácil manutenção e escalabilidade.

---

## Tecnologias Utilizadas

Este projeto foi desenvolvido com as seguintes tecnologias:

- **.NET 8**: Plataforma de desenvolvimento principal para a criação do aplicativo.
- **Google.FlatBuffers**: Biblioteca para serialização e deserialização de dados binários.
- **C#**: Linguagem de programação utilizada para implementar a lógica do projeto.

---

## Instalação

### Pré-requisitos

Certifique-se de que você tem as seguintes ferramentas instaladas em seu ambiente de desenvolvimento:

- **.NET SDK** (versão 8 ou superior): [Download do .NET](https://dotnet.microsoft.com/download)
- **FlatBuffers Compiler (`flatc`)**: [Instruções para instalar o `flatc`](https://google.github.io/flatbuffers/)

### Passos para Instalar

1. Clone o repositório:

   ```bash
   git clone https://github.com/seu-usuario/FlatBufferNet.git
   cd FlatBufferNet
   ```

2. Instale as dependências do projeto:

   Se estiver utilizando o Visual Studio ou VS Code, abra a solução e restaure os pacotes.

   Ou, se estiver utilizando a linha de comando, execute:

   ```bash
   dotnet restore
   ```

3. Gere o código C# a partir do schema do FlatBuffers:

   ```bash
   flatc --csharp Pessoa.fbs
   ```

4. Para rodar o projeto localmente, use o seguinte comando:

   ```bash
   dotnet run
   ```

---

## Como Usar

Este projeto pode ser utilizado para calcular a idade de uma pessoa a partir de sua data de nascimento. O exemplo abaixo mostra como a informação é manipulada.

1. **Input**: Nome e Data de Nascimento de uma pessoa.
2. **Processamento**: O sistema calcula a idade a partir da data fornecida.
3. **Output**: A idade da pessoa será exibida no console.

### Exemplos de Uso

Após rodar o projeto, você verá a saída no console:

```bash
Nome: João
Idade: 34 anos
```

### Como Modificar os Dados

Você pode alterar o nome e a data de nascimento no código `Program.cs`:

```csharp
string nome = "João";
DateTime dataNascimento = new DateTime(1990, 5, 15); // Exemplo de data de nascimento
```

---

## Estrutura de Diretórios

A estrutura do projeto segue uma organização simples e modular:

```
src/
├── Pessoa.fbs              # Arquivo de schema do FlatBuffers
├── Program.cs              # Lógica principal do cálculo de idade
├── obj/                    # Arquivos temporários de build
└── bin/                    # Arquivos de saída (binários)
```

---

## Configuração

Este projeto não exige configurações complexas, mas pode ser estendido para incluir outros parâmetros de configuração, como variáveis de ambiente ou conexões com outros serviços, caso necessário.

---

## Contribuições

Contribuições são bem-vindas! Para contribuir com o projeto, siga estas etapas:

1. Faça um **fork** do repositório.
2. Crie uma nova branch para sua feature (ex: `git checkout -b feature/nova-feature`).
3. Faça as alterações necessárias e commit (ex: `git commit -m 'Adiciona nova-feature'`).
4. Envie as alterações para seu repositório (ex: `git push origin feature/nova-feature`).
5. Crie um **pull request** para a branch principal do repositório original.

---

## Licença

Este projeto está licenciado sob a Licença [MIT](LICENSE). Consulte o arquivo [LICENSE](LICENSE) para mais detalhes.

---

## Contato

Caso tenha dúvidas ou sugestões, entre em contato:

- **Email**: [dopme.io](mailto:daniloopinheiro@dopme.io)
- **LinkedIn**: [Danilo O. Pinheiro](https://www.linkedin.com/in/daniloopinheiro/)
- **YouTube**: [dopme](https://www.youtube.com/@dopme-io)

---

<p align="center"> Feito com ❤️ por <strong>Danilo O. Pinheiro</strong><br/> <a href="https://devsfree.com.br" target="_blank">DevsFree</a> • <a href="https://dopme.io" target="_blank">dopme.io</a> </p>
