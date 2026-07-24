## 🇧🇷 Português

### 📜 Sobre o Repositório

Este repositório foi criado com o propósito de preservar e expor **projetos antigos desenvolvidos entre 2013 e 2019**, resgatados de um pendrive antigo.

Sempre adorei — e ainda gosto muito — de criar ferramentas para automatizar rotinas e agilizar tarefas do dia a dia. Na época, as empresas enfrentavam muitos gargalos operacionais no suporte, na configuração de ambientes de clientes e no provisionamento de máquinas para colaboradores. Para resolver isso, desenvolvi diversos utilitários internos; uma satisfação enorme é saber que **algumas dessas ferramentas continuam em uso até hoje**.

Uma das estratégias que eu mais utilizava era a criação de **sistemas híbridos em C#**: a aplicação em C# gerava e executava arquivos `.bat` (e scripts auxiliares) em tempo de execução. Essa era uma solução muito comum e eficiente na época para manipular configurações do Windows em máquinas de clientes e da empresa com total flexibilidade, contornando gargalos de permissões, segurança e bloqueios de antivírus.

Mais do que simples códigos legados, guardar estes projetos é uma forma de registrar como pensávamos e resolvíamos problemas na raça. Nesses anos, não havia IA para gerar soluções prontas e a documentação nem sempre era direta. Resolver um único *bug* exigia abrir dezenas de abas no navegador, garimpar fóruns e passar noites em claro testando linha por linha.

Este acervo marca o início da minha jornada no desenvolvimento de software, documentando minha **iniciação e evolução no C# e no clássico VB6**, honrando as minhas origens e a lógica construída ao longo dos anos.

---

### 🏛️ A Arquitetura da Época (.NET Framework)

Nos meus primeiros projetos, a organização de aplicações desktop (WinForms) e web seguia predominantemente o padrão de **Arquitetura em Camadas (N-Tier)** para separar a interface, a lógica e o banco de dados:

* **MODEL (Domain/Entities):** Representava as entidades e regras de negócio da aplicação. Continha os objetos centrais do sistema com suas propriedades e validações.
* **DAL (Data Access Layer):** Camada responsável pelo acesso ao banco de dados, concentrando conexões via ADO.NET (`SqlConnection`, `SqlCommand`), procedimentos e mapeamentos manuais.
* **DTO (Data Transfer Object):** Classes leves usadas para transportar dados de forma segura entre a interface e o back-end, sem expor estruturas internas.
* **BLL / Business:** Centralizava a lógica de processamento, varreduras e regras complexas entre a interface e a DAL.

---

## 🇺🇸 English

### 📜 About the Repository

This repository was created to preserve and showcase **legacy projects developed between 2013 and 2019**, recently recovered from an old flash drive.

I have always loved creating internal tools to streamline daily tasks and automate workflows. Back then, companies faced significant operational bottlenecks when configuring client environments and setting up machines for employees. To solve these friction points, I built several utilities—and it brings me great satisfaction to know that **some of these tools are still in active use today**.

One of my go-to techniques was building **hybrid C# applications**: the C# application generated and executed custom `.bat` scripts on the fly. This was a very common and practical pattern at the time to interact with Windows operating systems across client and corporate environments smoothly, bypassing antivirus flags, permission hurdles, and security restrictions.

More than just old code, preserving these projects is a way to record how we built software and solved problems through pure grit. In those days, there were no AI tools to generate quick solutions, and documentation was often scarce. Fixing a single bug meant opening dozens of browser tabs, digging through forums, and spending sleepless nights testing code line by line.

This archive captures the beginning of my software development journey, documenting my **early steps and evolution in C# and classic VB6**, honoring my roots and the logic built over the years.

---

### 🏛️ Architecture of the Era (.NET Framework)

In my early projects, desktop (WinForms) and web applications were structured using the **N-Tier Architecture** pattern to separate UI, business logic, and database access:

* **MODEL (Domain/Entities):** Represented the domain entities and core business rules. Contained system objects along with properties and validation logic.
* **DAL (Data Access Layer):** Dedicated to database communication, managing connections via ADO.NET (`SqlConnection`, `SqlCommand`), stored procedures, and manual data mappings.
* **DTO (Data Transfer Object):** Lightweight objects used to transfer data safely between layers without exposing internal models.
* **BLL / Business:** Handled core processing logic, data iterations, and complex rules between the UI and the DAL.

---

> 💡 *"Para saber para onde estamos indo, é fundamental lembrar de onde viemos." / "To know where we are going, we must remember where we came from."*
