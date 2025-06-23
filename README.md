# 🧠 MatchGame

Um simples e divertido **jogo da memória** desenvolvido com **WPF (.NET 8)**, onde o objetivo é encontrar todos os pares de **emojis de animais** no menor tempo possível.

## ✨ Funcionalidades

- 🎨 Interface gráfica intuitiva com WPF.
- 🐾 Pares de emojis de animais embaralhados a cada partida.
- ⏱️ Cronômetro que exibe o tempo decorrido durante o jogo.
- 🔁 Reinício rápido do jogo ao clicar no tempo após completar todos os pares.

## 🕹️ Como Jogar

1. Clique em um bloco contendo um emoji.
2. Em seguida, clique em outro bloco com o par correspondente.
3. Se forem **iguais**, os blocos permanecem serão ocultados.
4. Se forem **diferentes**, os blocos se tornam visíveis novamente.
5. Encontre todos os **8 pares** para vencer!
6. Após completar o jogo, **clique no cronômetro** para iniciar uma nova rodada.

## 🧰 Requisitos

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [Visual Studio 2022 ou superior](https://visualstudio.microsoft.com/pt-br/) (recomendado)

## ▶️ Como Executar

```bash
# Clone o repositório
git clone https://github.com/seu-usuario/MatchGame.git

# Abra a solução MatchGame.sln no Visual Studio
# Certifique-se de que o projeto 'MatchGame' esteja definido como projeto de inicialização
# Pressione F5 para compilar e executar
```

## 🗂️ Estrutura do Projeto

- `MainWindow.xaml` / `MainWindow.xaml.cs` – Interface e lógica principal do jogo.
- `App.xaml` – Configurações de inicialização da aplicação.

## 📄 Licença

Este projeto está licenciado sob a [Licença MIT](LICENSE).
