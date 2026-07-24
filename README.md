# 🏛️ Legacy Projects — Acervo Pessoal (2013 – 2019)

---

## 🇧🇷 Português

### 📜 Sobre o Repositório

Este repositório foi criado com o propósito de preservar e expor **projetos antigos desenvolvidos entre 2013 e 2019**, resgatados de um pendrive antigo.

Mais do que simples códigos legados, guardar estes projetos é uma forma de registrar e relembrar **como programávamos e pensávamos na época**. Nesses anos, cada pequeno avanço era um enorme desafio: não havia IA para gerar soluções prontas e a documentação nem sempre era direta. Resolver um único *bug* exigia abrir dezenas de abas no navegador, garimpar fóruns e passar noites em claro testando linha por linha até o código funcionar na raça.

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

More than just old code, preserving these projects is a way to record and remember **how we built software and solved problems back then**. In those days, every small breakthrough was a massive challenge: there were no AI tools to generate quick solutions, and documentation was often scarce. Fixing a single bug meant opening dozens of browser tabs, digging through forums, and spending sleepless nights testing code line by line through pure grit.

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
