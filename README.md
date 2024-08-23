<p align="center">
  <a href="https://www.microsoft.com">
    <img width="200" src="https://upload.wikimedia.org/wikipedia/commons/4/44/Microsoft_logo.svg">
  </a>
</p>

<div align="center">

Web API desenvolvida em .NET Framework 4.7.2.

[![Microsoft](https://img.shields.io/badge/Microsoft-.NET_Framework_4.7.2-blue?style=flat-square&logo=microsoft)](https://dotnet.microsoft.com/download/dotnet-framework/net472)
[![Visual Studio](https://img.shields.io/badge/Visual_Studio-2019_or_later-purple?style=flat-square&logo=visual-studio)](https://visualstudio.microsoft.com/)

</div>

---

# Web API - .NET Framework 4.7.2

<p align="center">
  <a href="https://visualstudio.microsoft.com/">
    <img width="250" src="https://visualstudio.microsoft.com/wp-content/uploads/2021/10/Product-Icon.svg">
  </a>
  <a href="https://dotnet.microsoft.com/">
    <img width="200" src="https://upload.wikimedia.org/wikipedia/commons/0/0e/Microsoft_.NET_logo.png">
  </a>
</p>

## Descrição

Este projeto é uma aplicação Web API construída utilizando o .NET Framework 4.7.2. Ele serve como backend para fornecer dados e serviços para clientes frontend ou outros serviços que consomem APIs REST.

## Requisitos

Antes de começar, certifique-se de ter o seguinte software instalado:

- **[Visual Studio 2019 ou superior](https://visualstudio.microsoft.com/)**
- **.NET Framework 4.7.2 Development Tools** (Instalado via Visual Studio Installer)

## Executando o Projeto

1. Abra o Visual Studio.
2. No menu **File**, selecione **Open** e clique em **Project/Solution...**.
3. Navegue até o diretório onde o projeto está localizado e abra o arquivo `.sln`.
4. No **Solution Explorer**, selecione a configuração de compilação como **Debug** ou **Release**.
5. Clique em **Start** (ou pressione `F5`) para compilar e executar a aplicação.

A API estará disponível em `http://localhost:[PORTA]/api`, onde `[PORTA]` será a porta atribuída pelo IIS Express ou configurada no `Web.config`.
