# 🧰 LojaApiSdk

Projeto de exemplo utilizando o **Kiota**, um gerador de SDKs fortemente tipados a partir de contratos OpenAPI. Aqui exploramos a construção de um cliente .NET para consumo de APIs REST simuladas com o apoio do **Mockoon**.

---

## 🎯 Objetivo do projeto

Este projeto foi desenvolvido com o propósito principal de **estudar e compreender o funcionamento do Kiota**, a ferramenta de geração de SDKs da Microsoft baseada em OpenAPI. O foco está em explorar o processo completo de consumo de uma API REST de forma tipada e segura em C#, incluindo desde a criação da especificação até o uso do SDK.

> Embora parte do código seja gerada automaticamente via Kiota (como as estruturas do SDK), **toda a configuração do ambiente, definição do contrato OpenAPI, integração com mock server, estruturação do projeto console, fluxo de chamada e tratamento de resposta foram realizados manualmente**.

Durante o desenvolvimento, enfrentei desafios técnicos que exigiram análise e solução prática, como:

- Entendimento da estrutura OpenAPI e criação de arquivo `.yml` do zero
- Configuração de codificação UTF-8 para exibição de emojis no console
- Criação de ambiente local com Mockoon simulando diferentes verbos HTTP
- Tratamento explícito de erros HTTP com `try/catch`
- Organização do repositório e uso consciente de `.gitignore`

🧠 A intenção não foi entregar uma solução comercial, mas sim **testar ferramentas, validar conceitos e exercitar autonomia técnica**. O código está aberto para aprendizagem, ajustes e evolução.

---

## 🔍 Sobre o projeto

Este projeto demonstra, de forma didática e prática:

- Geração de SDK com Kiota a partir de uma especificação `.yaml`
- Escrita manual de um contrato OpenAPI
- Consumo de endpoints REST usando código limpo e tipado
- Criação de API fake com Mockoon para testes locais
- Configuração de app console com suporte a Unicode e boas práticas

---

## 🚀 Por que usar o Kiota?

**Kiota** é uma ferramenta oficial da Microsoft que gera SDKs cliente para APIs REST com base em arquivos OpenAPI. Ela evita repetição de código e erros comuns ao consumir APIs com `HttpClient` manualmente.

### ✅ Vantagens

- **Facilidade**: integração simples no build e editor
- **Segurança**: navegação por código fortemente tipado
- **Produtividade**: elimina o boilerplate de chamadas HTTP
- **Multiplataforma**: SDKs para C#, TypeScript, Go, Java, PHP e mais

🔗 [Documentação do Kiota](https://github.com/microsoft/kiota)

---

## 📚 O que foi aprendido

| Ferramenta       | Aprendizado                                                                 |
|------------------|------------------------------------------------------------------------------|
| **OpenAPI**      | Estrutura e escrita de contratos REST com `.yaml`                          |
| **Kiota**        | Geração de SDKs com base em YAML, consumo de rotas REST com tipagem        |
| **Mockoon**      | Simulação de APIs locais com `GET /produtos` e `POST /pedidos`              |
| **.NET**         | Projeto console com tratamento de erros, UTF-8 e saída enriquecida          |
| **Git**          | Criação de repositório limpo e uso adequado de `.gitignore`                 |

---

## 🛠️ Como executar localmente

### ✅ Pré-requisitos

| Ferramenta               | Versão recomendada     |
|--------------------------|------------------------|
| .NET SDK                 | 7.0 ou superior        |
| Visual Studio / VS Code  | Com extensão C#        |
| Git                      | Para clonar o projeto  |
| Mockoon                  | Para simular a API     |

---

### 📦 Pacotes NuGet utilizados

| Pacote                                      | Descrição                                                                  |
|---------------------------------------------|----------------------------------------------------------------------------|
| `Microsoft.Kiota.Abstractions`              | Interfaces e contratos base do SDK                                         |
| `Microsoft.Kiota.Http.HttpClientLibrary`    | Implementação HTTP usando `HttpClient`                                     |
| `Microsoft.Kiota.Serialization.Json`        | Suporte à serialização JSON                                                |
| `Microsoft.Kiota.Serialization.Form`        | Suporte a `application/x-www-form-urlencoded`                              |
| `Microsoft.Kiota.Serialization.Multipart`   | Suporte a envio multipart (upload de arquivos, etc.)                       |
| `Microsoft.Kiota.Serialization.Text`        | Suporte à serialização `text/plain`                                        |

💡 Esses pacotes são restaurados automaticamente com:

```bash
dotnet restore
```

---

### ▶️ Passo a passo

1. **Clone o repositório**

   ```bash
   git clone https://github.com/seu-usuario/LojaApiSdk.git
   cd LojaApiSdk
   ```

2. **Configure o ambiente no Mockoon**

   - Crie um ambiente com as rotas:
     - `GET /produtos` → retorna lista de produtos
     - `POST /pedidos` → simula envio de pedido
   - Defina a porta para `3001`
   - Inicie o servidor com o botão “Start”

3. **Ajuste a `BaseUrl` em `Program.cs`**

   ```csharp
   BaseUrl = "http://localhost:3001";
   ```

4. **Execute o projeto**

   ```bash
   dotnet run --project LojaApp
   ```

5. **Saída esperada**

   ```
   🔍 Buscando produtos...
   📦 Produtos disponíveis:
   - 1: Camiseta Branca - R$ 59,9
   - 2: Tênis Esportivo - R$ 199
   ✅ Pedido enviado com sucesso!
   ```

---

## 📄 Licença

Distribuído sob a licença MIT. Veja o arquivo LICENSE para mais detalhes.

---

## 🤝 Para recrutadores

Este projeto surgiu da minha curiosidade técnica e desejo de aprender além do básico. Não se trata de algo pronto para produção, mas de um exercício consciente de **experimentação, superação de erros reais e consolidação de conhecimento**.

Minha intenção foi praticar habilidades relevantes como:

- Criação de contrato OpenAPI manualmente
- Integração com ferramentas modernas (Kiota, Mockoon)
- Leitura e adaptação de código gerado automaticamente
- Estruturação de pequenos projetos reutilizáveis em .NET
- Uso do Git via terminal e organização de repositório

Sinta-se à vontade para explorar o repositório e entrar em contato caso queira conversar sobre meu processo de aprendizagem.

---

Feito com 🧠, café ☕ e requisições falsas ✉️ — mas com propósito real.
