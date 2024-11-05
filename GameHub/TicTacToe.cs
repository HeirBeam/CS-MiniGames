using System;

namespace GameMenu
{
    public class TicTacToe : IGame
    {
        private char[,] board = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        private char currentPlayer = 'X';

        public void Play()
        {
            int moves = 0;
            bool gameWon = false;

            Console.Clear();
            Console.WriteLine("Welcome to Tic Tac Toe!");

            while (!gameWon && moves < 9)
            {
                PrintBoard();

                Console.WriteLine($"Player {currentPlayer}, choose a position (1-9): ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out int position) && position >= 1 && position <= 9 && IsValidMove(position))
                {
                    MakeMove(position);
                    moves++;
                    gameWon = CheckWin();

                    if (!gameWon)
                        currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
                }
                else
                {
                    Console.WriteLine("Invalid input! Please try again.");
                }
            }

            PrintBoard();
            Console.WriteLine(gameWon ? $"Player {currentPlayer} wins!" : "It's a draw!");
        }

        private void PrintBoard()
        {
            Console.WriteLine("-------------");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine($"| {board[i, 0]} | {board[i, 1]} | {board[i, 2]} |");
                Console.WriteLine("-------------");
            }
        }

        private bool IsValidMove(int position)
        {
            int row = (position - 1) / 3;
            int col = (position - 1) % 3;
            return board[row, col] != 'X' && board[row, col] != 'O';
        }

        private void MakeMove(int position)
        {
            int row = (position - 1) / 3;
            int col = (position - 1) % 3;
            board[row, col] = currentPlayer;
        }

        private bool CheckWin()
        {
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == currentPlayer && board[i, 1] == currentPlayer && board[i, 2] == currentPlayer)
                    return true;
                if (board[0, i] == currentPlayer && board[1, i] == currentPlayer && board[2, i] == currentPlayer)
                    return true;
            }

            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                return true;

            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                return true;

            return false;
        }
    }
}
