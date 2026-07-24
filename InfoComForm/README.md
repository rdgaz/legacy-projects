# ✉️ InfoComForm (Gerador de Assinaturas & Inventário de T.I.) — C# WinForms

> 📌 **Projeto Legado / Acervo Pessoal (2013–2019)**
> *Ferramenta utilitária desenvolvida como hobby para padronização de assinaturas de e-mail e coleta automatizada de dados de hardware/rede da máquina.*
> *Utility tool created as a hobby to standardize email signatures and automatically collect hardware/network inventory data.*

---

## 🇧🇷 Português

### 📜 Sobre o Projeto

Este aplicativo foi criado para resolver um problema recorrente no ambiente de trabalho: a dificuldade dos colaboradores em formatar e padronizar manualmente suas assinaturas de e-mail e dados corporativos.

Aproveitando a interface de formulário para coletar dados do colaborador (nome, e-mail, setor e ramal), a aplicação atuava também como um **agente de inventário silencioso de T.I.**. Ao clicar em gerar, o sistema criava e executava dinamicamente um arquivo de lote (`info_li.bat`) que coletava informações do sistema operacional, hardware e rede, salvando os logs e o trecho de código da assinatura formatado diretamente na rede corporativa.

---

### ⚙️ Como a Aplicação Funcionava

1. **Validação de Entrada:**
* Impedia caracteres não numéricos no campo de ramal (`TbRamal_KeyPress`).


* Validava visualmente o e-mail em tempo real alterando a cor do rótulo para verde quando continha o formato esperado.




2. **Coleta de Hardware e Rede:**
* Consultava a classe WMI `Win32_Processor` para obter o modelo exato do processador.


* Variava as interfaces de rede para capturar o endereço IPv4 correto da máquina local (`GetIP`).




3. **Geração Dinâmica do Batch Script (`GeraBat`):**
* O código C# escrevia um script `.bat` na pasta temporária (`%TMP%` ou `%APPDATA%`).


* O script executava comandos do Windows para identificar o tipo de gabinete/chassi (Desktop, Notebook, Máquina Virtual via WMIC SystemEnclosure).


* Coletava dados do `systeminfo`, `ipconfig` e `tasklist` gravando em um arquivo `.log`.


* Criava a estrutura HTML (`<tr>...</tr>`) com hiperlinks `mailto:` formatados para a assinatura.




4. **Envio para o Servidor e Notificação:**
* O script montava temporariamente o compartilhamento de rede (`net use`), copiava os arquivos gerados para o servidor da T.I. (`S:\Publico\T.I\`) e notificava o usuário através de uma mensagem VBScript (`msgbox`).





---

### 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET Framework)
* **Interface:** Windows Forms (WinForms)
* **WMI & APIs do Windows:** `System.Management` (`Win32_Processor`), `System.Net.Dns`

* **Automação:** Manipulação de `StreamWriter`, geração de scripts Batch (`.bat`) e VBScript (`.vbs`)



---

---

## 🇺🇸 English

### 📜 About the Project

This application was created to solve a common workplace issue: non-technical users struggling to manually set up and format their corporate email signatures.

Taking advantage of a simple WinForms GUI to gather employee details (name, email, department, and phone extension), the app doubled as a **silent IT inventory agent**. Upon confirmation, it dynamically generated and executed a batch script (`info_li.bat`) that gathered system, hardware, and network info, delivering formatted signature code snippets and system logs directly to the company's network share.

---

### ⚙️ How the Application Worked

1. **Input Validation:**
* Restricted extension fields to digits only (`TbRamal_KeyPress`).


* Applied real-time email syntax feedback, changing label colors when a valid pattern was detected.




2. **Hardware and Network Retrieval:**
* Queried `Win32_Processor` via WMI to read the exact CPU model.


* Scanned active network interfaces to capture the local IPv4 address (`GetIP`).




3. **Dynamic Batch Script Generation (`GeraBat`):**
* Generates a custom `.bat` file in the system temporary folder (`%TMP%` or `%APPDATA%`).


* Used WMIC commands (`SystemEnclosure`) to identify chassis types (Desktop, Laptop, Virtual Machine, etc.).


* Ran `systeminfo`, `ipconfig`, and `tasklist`, dumping the diagnostics into a `.log` file.


* Built HTML table row snippets (`<tr>...</tr>`) containing formatted `mailto:` signature links.




4. **Network Upload & User Notification:**
* Temporarily mapped network drives (`net use`), pushed logs and HTML code to the IT shared directory (`S:\Publico\T.I\`), and notified the user via a lightweight VBScript pop-up (`msgbox`).





---

### 🛠️ Tech Stack

* **Language:** C# (.NET Framework)
* **UI:** Windows Forms (WinForms)
* **WMI & Windows APIs:** `System.Management` (`Win32_Processor`), `System.Net.Dns`

* **Automation:** `StreamWriter`, Batch Scripting (`.bat`), and VBScript (`.vbs`)

