# RandomBaller

> 🇧🇷 [Português](#o-que-você-encontrará-neste-repositório) · 🇺🇸 [English](#what-will-you-find-in-this-repository)

## O que você encontrará neste repositório?

Primeiros estudos voltados à game engine Unity, feitos em **maio de 2021**.

Como resultado, obteve-se um jogo multiplayer local que é uma mistura de Pong e Head Ball 2, onde a cada rodada,
joga-se com uma forma geométrica com propriedades estéticas e físicas aleatórias (formato, cor, tamanho, força,
velocidade máxima e quique). Cada gol soma um ponto e reinicia a rodada; um goleiro automático patrulha cada gol.

Para tal, tive que relembrar os [básicos do C#](https://github.com/tofolo17/Relearning-CSharp), acompanhar um
[curso online](https://www.domestika.org/pt/courses/716-introducao-ao-unity-para-videogames-2d) e ler seções da
[documentação da Unity](https://docs.unity3d.com/Manual/index.html).

### Ferramentas

- Unity 2020.3 (2D, física com Rigidbody2D)
- C#

### Controles

| Jogador  | Mover               |
|----------|---------------------|
| Esquerda | `A` / `D`           |
| Direita  | `←` / `→`           |

### Como abrir

```bash
git clone https://github.com/tofolo17/random-baller.git
```

Abra a pasta pelo Unity Hub com a versão **2020.3.0f1** (ou outra 2020.3), carregue `Assets/Scenes/Main Scene.unity`
e clique em Play.

### Estrutura

- `Assets/Scripts/PlayerSpawner.cs` — sorteia a forma e as propriedades de cada jogador;
- `Assets/Scripts/PlayerController.cs` — movimento por força e torque, com limite de velocidade;
- `Assets/Scripts/BallSpawner.cs` — cria a bola e a solta após 1 s;
- `Assets/Scripts/GoalColliderController.cs` — placar e reinício da rodada;
- `Assets/Scripts/GoalkeeperController.cs` — goleiro que patrulha para cima e para baixo.

### Licença

[MIT](LICENSE)

---

## What will you find in this repository?

First studies focused on the Unity game engine, made in **May 2021**.

As a result, a local multiplayer game was obtained, which is a mixture of Pong and Head Ball 2, where each round is
played with a geometric shape with random aesthetic and physical properties (shape, color, size, force, top speed and
bounciness). Each goal scores a point and restarts the round; an automatic goalkeeper patrols each goal.

For that, I had to remember the [basics of C#](https://github.com/tofolo17/Relearning-CSharp), follow an
[online course](https://www.domestika.org/pt/courses/716-introducao-ao-unity-para-videogames-2d) and read sections of
the [Unity documentation](https://docs.unity3d.com/Manual/index.html).

### Tools

- Unity 2020.3 (2D, Rigidbody2D physics)
- C#

### Controls

| Player | Move        |
|--------|-------------|
| Left   | `A` / `D`   |
| Right  | `←` / `→`   |

### How to open

```bash
git clone https://github.com/tofolo17/random-baller.git
```

Open the folder in Unity Hub with version **2020.3.0f1** (or another 2020.3), load `Assets/Scenes/Main Scene.unity` and
press Play.

### Structure

- `Assets/Scripts/PlayerSpawner.cs` — randomizes each player's shape and properties;
- `Assets/Scripts/PlayerController.cs` — force- and torque-based movement, with a speed cap;
- `Assets/Scripts/BallSpawner.cs` — spawns the ball and releases it after 1 s;
- `Assets/Scripts/GoalColliderController.cs` — score and round restart;
- `Assets/Scripts/GoalkeeperController.cs` — goalkeeper that patrols up and down.

### License

[MIT](LICENSE)
