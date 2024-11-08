
# CS MiniGames: Tic-Tac-Toe & Hangman

Welcome to **CS MiniGames**, a C# project featuring classic games like **Tic-Tac-Toe** and **Hangman**! This project demonstrates essential C# skills, Windows Forms programming, and basic game logic. It provides an interactive and user-friendly experience with options to play against a friend or a basic AI.

---

## Table of Contents
- [Features](#features)
- [Installation](#installation)
- [How to Play](#how-to-play)
- [Future Additions](#future-additions)
- [Technologies Used](#technologies-used)

---

## Features

### Main Menu
- **Game Selection**: Choose between Tic-Tac-Toe and Hangman.
- **Play Mode Options**:
  - Play **Tic-Tac-Toe** against the computer or a friend.
  - Play **Hangman** with a randomly chosen word.

### Tic-Tac-Toe
- **Game Modes**: 
  - **Play Against Computer**: A basic AI that randomly selects moves.
  - **Play Against Friend**: Two-player mode on the same device.
- **Score Tracking**: Tracks wins for each player in both game modes.
- **Non-Resizable Window**: The game board remains fixed in size.

### Hangman
- **Random Word Selection**: Each game uses a randomly generated word.
- **Incorrect Guess Tracking**: Displays incorrect guesses and a visual hangman.
- **Non-Resizable Window**: The game board remains fixed in size.

---

## Installation

1. Clone this repository:
   ```bash
   git clone https://github.com/your-username/CS-MiniGames.git
   cd CS-MiniGames
   ```

2. Open the solution file in **Visual Studio** or **Visual Studio Code**.

3. Run the application:
   ```bash
   dotnet run
   ```

---

## How to Play

### Tic-Tac-Toe
1. From the **Main Menu**, select **Tic-Tac-Toe**.
2. Choose **Play Against Computer** or **Play Against Friend**.
   - **Play Against Computer**: The player is `X` and the computer is `O`.
   - **Play Against Friend**: `X` and `O` take turns in two-player mode.
3. Track your score at the top of the game window.

### Hangman
1. From the **Main Menu**, select **Hangman**.
2. Guess letters by entering them in the textbox and clicking **Guess**.
3. The game tracks incorrect guesses and shows a visual hangman as you play.

---

## Future Additions

### Tic-Tac-Toe
- **Improved AI**: Enhance the computer’s strategy with algorithms like Minimax for a more challenging experience.

### Hangman
- **Difficulty Levels**: Add easy, medium, and hard levels based on word length and complexity.
- **Hint System**: Introduce hints for players, allowing them to reveal a random letter.

---

## Technologies Used
- **C#** with **.NET** and **Windows Forms** for the GUI and game logic.
- **Random-Word API**: Used to fetch random words for Hangman (with fallback words in case of API issues).
  
---

Thank you for checking out CS MiniGames! 