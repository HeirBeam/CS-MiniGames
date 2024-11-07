using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GameHubGUI
{
    public partial class FormTicTacToe : Form
    {
        private char[,] board = new char[3, 3];
        private char currentPlayer = 'X';
        private bool playAgainstComputer = false;
        private Random random = new Random();

        // Separate scores for each mode
        private int playerVsComputerPlayerScore = 0;
        private int playerVsComputerComputerScore = 0;
        private int playerVsPlayerPlayerXScore = 0;
        private int playerVsPlayerPlayerOScore = 0;

        public FormTicTacToe()
        {
            InitializeComponent();
            ResetBoard();
        }

        private void btnPlayComputer_Click(object sender, EventArgs e)
        {
            playAgainstComputer = true;
            ShowBoard();
            ResetBoard();
            MessageBox.Show("You are playing against the computer. Good luck!");
            UpdateScore();
        }

        private void btnPlayFriend_Click(object sender, EventArgs e)
        {
            playAgainstComputer = false;
            ShowBoard();
            ResetBoard();
            MessageBox.Show("You are playing against a friend.");
            UpdateScore();
        }

        private void ShowBoard()
        {
            lblScore.Visible = true;

            // Show all buttons on the board
            foreach (Control control in this.Controls)
            {
                if (control is Button button && button.Tag is Tuple<int, int>)
                {
                    button.Visible = true;
                    button.Enabled = true;
                }
            }
        }

        private void Button_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            var position = (Tuple<int, int>)button.Tag;
            int row = position.Item1;
            int col = position.Item2;

            if (board[row, col] == ' ')
            {
                MakeMove(row, col);

                if (CheckWin(row, col))
                {
                    if (playAgainstComputer)
                    {
                        if (currentPlayer == 'X')
                            playerVsComputerPlayerScore++;
                        else
                            playerVsComputerComputerScore++;
                    }
                    else
                    {
                        if (currentPlayer == 'X')
                            playerVsPlayerPlayerXScore++;
                        else
                            playerVsPlayerPlayerOScore++;
                    }

                    MessageBox.Show($"Player {currentPlayer} wins!");
                    UpdateScore();
                    ResetBoard();
                }
                else if (IsBoardFull())
                {
                    MessageBox.Show("It's a draw!");
                    ResetBoard();
                }
                else
                {
                    SwitchPlayer();

                    if (playAgainstComputer && currentPlayer == 'O')
                    {
                        ComputerMove();
                    }
                }
            }
        }

        private void MakeMove(int row, int col)
        {
            board[row, col] = currentPlayer;

            foreach (Control control in this.Controls)
            {
                if (control is Button button && button.Tag is Tuple<int, int> pos && pos.Item1 == row && pos.Item2 == col)
                {
                    button.Text = currentPlayer.ToString();
                    break;
                }
            }
        }

        private void ComputerMove()
        {
            List<Tuple<int, int>> emptyPositions = new List<Tuple<int, int>>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == ' ')
                    {
                        emptyPositions.Add(new Tuple<int, int>(i, j));
                    }
                }
            }

            if (emptyPositions.Count > 0)
            {
                var move = emptyPositions[random.Next(emptyPositions.Count)];
                int row = move.Item1;
                int col = move.Item2;

                MakeMove(row, col);

                if (CheckWin(row, col))
                {
                    playerVsComputerComputerScore++;
                    MessageBox.Show("Computer wins!");
                    UpdateScore();
                    ResetBoard();
                }
                else if (IsBoardFull())
                {
                    MessageBox.Show("It's a draw!");
                    ResetBoard();
                }
                else
                {
                    SwitchPlayer();
                }
            }
        }

        private void SwitchPlayer()
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
        }

        private bool CheckWin(int row, int col)
        {
            // Check the row, column, and diagonals for a win
            return (board[row, 0] == currentPlayer && board[row, 1] == currentPlayer && board[row, 2] == currentPlayer) ||
                   (board[0, col] == currentPlayer && board[1, col] == currentPlayer && board[2, col] == currentPlayer) ||
                   (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer) ||
                   (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer);
        }

        private bool IsBoardFull()
        {
            foreach (var cell in board)
            {
                if (cell == ' ') return false;
            }
            return true;
        }

        private void ResetBoard()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button && button.Tag is Tuple<int, int>)
                {
                    button.Text = "";
                    button.Enabled = true;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            currentPlayer = 'X'; // Start with player X
        }

        private void UpdateScore()
        {
            if (playAgainstComputer)
            {
                lblScore.Text = $"Player: {playerVsComputerPlayerScore} - Computer: {playerVsComputerComputerScore}";
            }
            else
            {
                lblScore.Text = $"Player X: {playerVsPlayerPlayerXScore} - Player O: {playerVsPlayerPlayerOScore}";
            }
        }
    }
}
