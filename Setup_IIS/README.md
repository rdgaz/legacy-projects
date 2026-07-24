# ⚙️ Setup IIS (Instalador / Automatizador de Deploy) — C# WinForms

> 📌 **Projeto Legado / Acervo Pessoal (2013–2019)**
> *Ferramenta para verificação, instalação automatizada do IIS no Windows e deploy simplificado de sites via pacote ZIP.*
> *Tool for environment checking, automated IIS installation on Windows, and simplified web site deployment via ZIP packages.*

---

## 🇧🇷 Português

### 📜 Sobre o Projeto

Na época do .NET Framework, publicar uma aplicação web exigia configurar o **IIS (Internet Information Services)** manualmente: ativar o recurso no Windows, verificar a presença das ferramentas de gerenciamento (`APPCMD.exe`), criar o site no IIS, apontar portas e descompactar os arquivos do sistema em `C:\inetpub\wwwroot\`.

Para **evitar processos manuais repetitivos e erros de implantação**, criei este utilitário em Windows Forms. Ele atuava como um assistente de implantação automatizada, permitindo instalar o serviço do IIS via script e publicar a aplicação a partir de um pacote `.zip`.

---

### ⚙️ Como a Aplicação Funcionava

1. **Verificação de Ambiente:**
Ao abrir a tela, o código checava se o utilitário `APPCMD.exe` existia em `%systemroot%\system32\inetsrv\`.
* Se **instalado**: Liberava os campos do formulário para publicar o site (Status em Verde).
* Se **não instalado**: Bloqueava os campos e alertava o usuário (Status em Vermelho).


2. **Automação de Instalação do IIS:**
Caso o IIS não estivesse presente no Windows, ao clicar na mensagem de status o sistema extraía e executava um arquivo de lote (`siis.bat`) no diretório temporário (`TMP`), forçando a instalação dos componentes do IIS na máquina.
3. **Validação de Entrada:**
* **Campos Numéricos:** Impedia a digitação de letras no campo de porta HTTP.
* **Sem Espaços:** Impedia espaços no nome do site para evitar falhas em caminhos de rede/IIS.
* **Filtro de Arquivo:** Aceitava apenas pacotes de deploy em formato `.zip`.


4. **Criação e Implantação Automatizada:**
Ao preencher o nome do site, a porta e selecionar o arquivo ZIP, a classe `IntegraIIS` utilizava o `APPCMD` para registrar o site e descompactar a aplicação diretamente no diretório do servidor.

---

### 🛠️ Tecnologias e Recursos Utilizados

* **Linguagem:** C#
* **Interface:** Windows Forms (WinForms)
* **Integrações do Windows:**
* Utilitário `APPCMD.exe` (Ferramenta de Gerenciamento do IIS)
* Scripts `.bat` para automação de recursos do Windows
* Leitura de Variáveis de Ambiente (`systemroot`, `TMP`)


* **Manipulação de Arquivos:** `OpenFileDialog` e descompactação de arquivos `.zip`

---

---

## 🇺🇸 English

### 📜 About the Project

During the .NET Framework era, deploying a web application required configuring **IIS (Internet Information Services)** manually: enabling the feature on Windows, checking for management tools (`APPCMD.exe`), creating the site within IIS, setting up ports, and extracting system files into `C:\inetpub\wwwroot\`.

To **avoid repetitive manual processes and deployment errors**, I created this Windows Forms utility. It acted as an automated deployment wizard, allowing users to install the IIS service via scripts and publish applications directly from a `.zip` package.

---

### ⚙️ How the Application Worked

1. **Environment Checking:**
Upon opening, the application checked if `APPCMD.exe` existed at `%systemroot%\system32\inetsrv\`.
* If **installed**: Enabled the form fields to deploy the site (Green Status).
* If **not installed**: Disabled the fields and warned the user (Red Status).


2. **Automated IIS Installation:**
If IIS was not installed on Windows, clicking the status label triggered the extraction and execution of a batch script (`siis.bat`) located in the temporary folder (`TMP`), enforcing the installation of IIS features.
3. **Input Validation:**
* **Numeric Inputs:** Restricted non-digit keypresses on the HTTP port field.
* **No Spaces:** Prevented whitespace in the site name to avoid invalid IIS pathing.
* **File Filter:** Allowed only valid `.zip` deployment archives.


4. **Automated Creation and Deployment:**
After filling in the site name, port, and selecting the ZIP file, the `IntegraIIS` class executed commands via `APPCMD` to register the site and extract the files directly to the server directory.

---

### 🛠️ Technologies & Features Used

* **Language:** C#
* **UI:** Windows Forms (WinForms)
* **Windows Integration:**
* `APPCMD.exe` utility (IIS Management CLI)
* `.bat` scripts for Windows Features automation
* Reading Environment Variables (`systemroot`, `TMP`)


* **File Handling:** `OpenFileDialog` and `.zip` archive extraction
