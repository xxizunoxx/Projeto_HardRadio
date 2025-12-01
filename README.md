
# 🎧 Hard Radio – Console Playlist Manager

O **Hard Radio** é um aplicativo de console desenvolvido em C# que simula um sistema simples de gerenciamento de playlists e músicas.  
Ele permite criar, listar e remover playlists e músicas por meio de um menu interativo no terminal.


---

## 🛡 Badges

![C#](https://img.shields.io/badge/Language-C%23-239120?style=for-the-badge)
![.NET](https://img.shields.io/badge/.NET-8.0-512BD4?style=for-the-badge)
![Status](https://img.shields.io/badge/Status-Active-brightgreen?style=for-the-badge)
![License](https://img.shields.io/badge/License-Free-blue?style=for-the-badge)
![Console App](https://img.shields.io/badge/Type-Console%20App-grey?style=for-the-badge)

---

# 📌 Sobre o Projeto (PT-BR)

O **Hard Radio** é um aplicativo de console totalmente estilizado, desenvolvido em C#, para gerenciar playlists e músicas.  
Agora ele conta com:

✔ Playlists como objetos reais  
✔ Cada playlist possui sua própria lista interna de músicas  
✔ Interface com cores  
✔ Animação "digitando" nos textos  
✔ Menus separados para playlist e músicas  
✔ Experiência fluida e profissional no console  

---

# 🚀 Funcionalidades

### 📁 **Playlists**
- Criar playlist  
- Listar playlists  
- Remover playlist  
- Selecionar playlist para gerenciar músicas  

### 🎵 **Músicas por Playlist**
Cada playlist possui sua **própria lista interna**:
- Listar músicas  
- Adicionar música  
- Remover música  

### 🎨 **Interface e Estilo**
- Cores no console (verde, azul, vermelho)  
- Animação de texto (`AnimarTexto`)  
- Menus limpos e responsivos  

---

## 💡 Estrutura do Sistema

Agora o Hard Radio possui a classe:

```csharp
public class Playlist
{
    public string Nome { get; set; }
    public List<string> Musicas { get; set; } = new List<string>();

    public Playlist(string nome)
    {
        Nome = nome;
    }
}
```

O menu principal manipula listas de objetos:

```csharp
public static List<Playlist> Playlists = new List<Playlist>();
```

E o método de gerenciamento usa menus específicos:

```csharp
GerenciarMusicas(playlist);
```

---

## ✨ Animações

O sistema usa um método de efeito digitado:

```csharp
public static void AnimarTexto(string texto, int velocidade = 15)
{
    foreach (char c in texto)
    {
        Console.Write(c);
        Thread.Sleep(velocidade);
    }
    Console.WriteLine();
}
```

---

## 🛠 Tecnologias Utilizadas

✔ C#
✔ .NET SDK (Console Application)
✔ Programação Orientada a Objetos (POO)
- Classe Playlist
- Encapsulamento
- Listas internas
- Objetos reais representando entidades

✔ Manipulação de Listas Genéricas
- List<T>
- Busca (Find, Contains, etc.)

✔ Console Avançado
- Cores (Console.ForegroundColor)
- Reset de cores (Console.ResetColor())
- Efeitos visuais no terminal

✔ Threading
- Animações com Thread.Sleep para o efeito digitando

✔ Menus Interativos em Loop
- while(true)
- navegação entre menus

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
├── MenuPrincipal.cs      # Menu principal com cores e animação
├── Playlist.cs           # Classe Playlist com lista interna de músicas
├── Program.cs            # Ponto de entrada da aplicação
├── Projeto_HardRadio.csproj
└── README.md

---

## 💻 Exemplo de Uso

Criar playlist:

```nginx
Digite o nome da nova playlist:
> Rock Clássico
Playlist 'Rock Clássico' criada com sucesso!
```

```vbnet
Selecionada: Rock Clássico
Digite o nome da música:
> Highway to Hell
Música 'Highway to Hell' adicionada!
```

```diff
🎵 Músicas da playlist 'Rock Clássico':
- Highway to Hell
- Back in Black
```

## 👤 Autor

Desenvolvido por Izuno
GitHub: https://github.com/xxizunoxx

