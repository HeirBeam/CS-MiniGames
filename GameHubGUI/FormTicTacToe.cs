using System;
using System.Windows.Forms;

namespace GameHubGUI
{
    public partial class FormTicTacToe : Form
    {
        private char[,] board = new char[3, 3];
        private char currentPlayer = 'X';  // Start with player X

        public FormTicTacToe()
        {
            InitializeComponent();
            InitializeBoard();
            UpdateInstructions();
        }

        private void InitializeBoard()
        {
            // Initialize the board and add buttons
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';  // Empty cell

                    Button button = new Button
                    {
                        Width = 100,
                        Height = 100,
                        Font = new System.Drawing.Font("Arial", 24),
                        Location = new System.Drawing.Point(100 * i, 100 * j + 50),  // Position with space for instructions
                        Tag = new Tuple<int, int>(i, j)  // Store the position in the Tag
                    };

                    button.Click += Button_Click;  // Event handler for clicks
                    this.Controls.Add(button);  // Add button to form
                }
            }
        }

        private void Button_Click(object? sender, EventArgs e)
{
    if (sender is not Button button) return;  // Check if sender is a Button, and continue only if it’s valid
    
    var position = (Tuple<int, int>)button.Tag;
    int row = position.Item1;
    int col = position.Item2;

    if (board[row, col] == ' ')
    {
        board[row, col] = currentPlayer;
        button.Text = currentPlayer.ToString();

        if (CheckWin(row, col))
        {
            MessageBox.Show($"Player {currentPlayer} wins!");
            ResetBoard();
        }
        else if (IsBoardFull())
        {
            MessageBox.Show("It's a draw!");
            ResetBoard();
        }
        else
        {
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';  // Switch players between X and O
            UpdateInstructions();
        }
    }
}


        private void UpdateInstructions()
        {
            // Update instructions label with the current player
            instructionsLabel.Text = $"Current Player: {currentPlayer}";
        }

        private bool CheckWin(int row, int col)
        {
            if (board[row, 0] == currentPlayer && board[row, 1] == currentPlayer && board[row, 2] == currentPlayer)
                return true;
            if (board[0, col] == currentPlayer && board[1, col] == currentPlayer && board[2, col] == currentPlayer)
                return true;
            if (board[0, 0] == currentPlayer && board[1, 1] == currentPlayer && board[2, 2] == currentPlayer)
                return true;
            if (board[0, 2] == currentPlayer && board[1, 1] == currentPlayer && board[2, 0] == currentPlayer)
                return true;

            return false;
        }

        private bool IsBoardFull()
        {
            foreach (var cell in board)
            {
                if (cell == ' ')
                    return false;
            }
            return true;
        }

        private void ResetBoard()
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button)
                {
                    button.Text = "";
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    board[i, j] = ' ';
                }
            }

            currentPlayer = 'X';  // Start with player X
            UpdateInstructions();
        }
    }
}
