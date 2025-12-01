
# 🎧 Hard Radio – Gerenciador de Playlists no Console

O **Hard Radio** é um aplicativo de console desenvolvido em C# que simula um sistema simples de gerenciamento de playlists e músicas.  
Ele permite criar, listar e remover playlists e músicas por meio de um menu interativo no terminal.

## 🛡 Badges
![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Active-brightgreen?style=for-the-badge)
![License](https://img.shields.io/badge/License-Free-blue?style=for-the-badge)
![Console App](https://img.shields.io/badge/Type-Console%20App-grey?style=for-the-badge)

---

## 🚀 Funcionalidades

### 📁 Playlists
- Listar playlists
- Adicionar playlist
- Remover playlist

### 🎵 Músicas
- Listar músicas
- Adicionar música
- Remover música

### 🧭 Menu Interativo
- 1 - Listar Playlists
- 2 - Adicionar Playlist
- 3 - Remover Playlist
- 4 - Listar Músicas
- 5 - Adicionar Música
- 6 - Remover Música
- 0 - Sair


---

## 🛠 Tecnologias Utilizadas
- C#
- .NET SDK
- Programação Orientada a Objetos
- Console Application

---

## 📦 Como Executar o Projeto

### 1. Clone o repositório
```bash
git clone https://github.com/xxizunoxx/Projeto_HardRadio.git

cd Projeto_HardRadio

dotnet run
```
---
## 📂 Estrutura do Projeto
Projeto_HardRadio/

│

├── MenuPrincipal.cs      # Classe principal com todas as funcionalidades

├── Program.cs            # Ponto de entrada da aplicação

├── Projeto_HardRadio.csproj

└── README.md

---
## 🧠 Lógica do Sistema

### O sistema utiliza duas listas globais para armazenar dados:

```csharp
public static List<string> Playlists = new List<string>();
public static List<string> Musicas = new List<string>();
```
### Essas listas são manipuladas pelos métodos:

- AdicionarPlaylist()
- ListarPlaylists()
- RemovendoPlaylist()
- AdicionandoMusica()
- ListandoMusicas()
- RemoverMusica()

### O menu principal utiliza um loop contínuo:

``` csharp
while (true)
{
    // Exibe menu e processa opções
}
```

---

## 🔧 Melhorias Futuras

- Associar músicas a playlists específicas
- Criar classe Playlist com lista interna de músicas
- Persistência em arquivos JSON
- Adicionar cores e animações no console
- Criar interface gráfica (WinForms/WPF)

## 👤 Autor

Desenvolvido por Izuno
GitHub: https://github.com/xxizunoxx

