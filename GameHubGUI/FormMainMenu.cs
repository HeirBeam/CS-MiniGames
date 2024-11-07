using System;
using System.Windows.Forms;

namespace GameHubGUI
{
    public partial class FormMainMenu : Form
    {
        public FormMainMenu()
        {
            InitializeComponent();
        }

        private void btnTicTacToe_Click(object sender, EventArgs e)
        {
            // Open the Tic-Tac-Toe game form
            FormTicTacToe ticTacToeForm = new FormTicTacToe();
            ticTacToeForm.Show();
        }

        private void btnHangman_Click(object sender, EventArgs e)
        {
            FormHangman hangmanForm = new FormHangman();
            hangmanForm.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            // Close the application
            this.Close();
        }
    }
}
