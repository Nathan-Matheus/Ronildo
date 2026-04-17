# Instituição

Etec Vasco Antônio Venchiarutti

# Curso

Desenvolvimento de Sistemas

# Turma

2C¹

# Autores

* Matheus Theodoro de Campos Silva
* Nathan Ricardo Frajuca Nabas

# 📱 Projeto

## Título

Guerra Oriental - Jogo Desviar

## 📖 Descrição

### 🎯 Objetivo do Aplicativo

O objetivo do aplicativo é criar um jogo de sobrevivência onde o jogador controla um soldado em um cenário de guerra. O desafio é desviar de projéteis (balas/bombas) que caem continuamente na tela, sobrevivendo o máximo de tempo possível.

### ⚙️ Como o Aplicativo Funciona

* O jogador controla o personagem horizontalmente (usando botões).
* As balas caem do topo da tela em direção ao jogador.
* Cada bala possui posição e comportamento aleatórios.
* Quando uma bala atinge o jogador, o jogo termina.
* Um sistema de pontuação conta o tempo de sobrevivência.
* O jogador pode reiniciar o jogo após perder.

### 🧠 Conceitos Utilizados

O projeto utilizou diversos conceitos aprendidos na apostila e também conceitos aprendidos fora dela:

* Estrutura de interface (Canvas, Botões, Labels)
* Programação com blocos
* Uso de variáveis globais
* Estruturas condicionais (if / else)
* Eventos (Clock, Click, Collisions)
* Listas (controle de múltiplos objetos)
* Componentes genéricos (Any ImageSprite)
* Controle de estado do jogo (JogoAtivo)

### 🧩 Componentes Utilizados

* **Canvas (Pintura1)** → área principal do jogo
* **ImageSprite (Player)** → personagem controlado
* **ImageSprite (Balas 1 a 12)** → obstáculos
* **Clock1** → movimentação das balas
* **ClockTempo** → sistema de pontuação
* **Label** → exibição da pontuação
* **Botões** → controle (voltar e reiniciar)
* **Notifier** → exibição de Game Over

### 🚀 Melhorias e Ideias Próprias

O projeto não se limitou aos exemplos da apostila, incluindo melhorias como:

* Sistema de múltiplas balas (até 12 simultâneas)
* Movimentação aleatória dos obstáculos
* Sistema de dificuldade progressiva
* Uso de listas para otimização do código
* Sistema de Game Over com bloqueio do jogo
* Botão de reinício funcional
* Fundo personalizado com tema de guerra/apocalipse

# 🖥 Prints das Telas do Design

### Tela Inicial
<img width="284" height="539" alt="image" src="https://github.com/user-attachments/assets/317406f6-c1e9-47fe-b4e2-f19ad59c37b9" />

### Tela Tutorial 
<img width="297" height="543" alt="image" src="https://github.com/user-attachments/assets/268a6a87-c447-407a-92e2-141358fc69d1" />

### Tela Jogo
<img width="276" height="547" alt="image" src="https://github.com/user-attachments/assets/c13e3b75-9b1f-4d16-8eab-b4b3c971e195" />

# 🧩 Prints das Telas dos Blocos

### Screen1 
<img width="624" height="244" alt="image" src="https://github.com/user-attachments/assets/b5f11898-fff2-4b4d-831b-c8c001e7c52f" />

### Screen2
<img width="407" height="167" alt="image" src="https://github.com/user-attachments/assets/c72688ab-a153-44b4-9721-1e29b070fee2" />

### Screen3
#### Primeira Parte (Botões de movimentação, tabela de pontuação e inicialização de variaveis globais)
<img width="572" height="444" alt="image" src="https://github.com/user-attachments/assets/e3f2f710-960d-44b6-af59-dce07a965818" />

#### Segunda Parte (Sistema de colisão e GameOver)
<img width="511" height="520" alt="image" src="https://github.com/user-attachments/assets/b0f57187-ada0-4d9f-a79b-00d5168b2f13" />

#### Terceira Parte (Botão de fechar tela e Sistema do botão de inicio)
<img width="569" height="788" alt="image" src="https://github.com/user-attachments/assets/f4c12a41-f23d-489c-8138-512fbd0c759e" />

#### Quarta Parte (Sistema de queda e reinicio na queda das bombas)
<img width="1024" height="582" alt="image" src="https://github.com/user-attachments/assets/9c96b2b7-cd59-4311-9fb6-fd133e4731a2" />

# 🧠 Organização Lógica do Aplicativo

O aplicativo foi estruturado da seguinte forma:

* **Clock1** controla toda a movimentação das balas
* **ClockTempo** controla a pontuação
* **Lista de sprites** permite manipular todas as balas com um único bloco
* **Variável JogoAtivo** controla se o jogo está rodando ou parado
* **Sistema de colisão** detecta quando o jogador perde
* **Botão de reinício** reseta todas as variáveis e reinicia o jogo

# 🎮 Regras do Jogo

* O jogador deve evitar todas as balas
* Cada segundo sobrevivido vale 1 ponto
* Ao colidir com uma bala:

  * o jogo para
  * aparece mensagem de "Game Over"
* O jogador pode reiniciar a partida

# 📊 Conclusão

O projeto permitiu aplicar, na prática, diversos conceitos de desenvolvimento de aplicativos utilizando o App Inventor. Além disso, possibilitou desenvolver habilidades como lógica de programação, organização de código e resolução de problemas.

O aplicativo final apresenta um funcionamento completo, com interação do usuário, sistema de pontuação e mecânica de jogo funcional, demonstrando evolução em relação aos projetos anteriores.

