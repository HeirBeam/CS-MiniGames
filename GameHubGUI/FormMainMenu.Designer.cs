namespace GameHubGUI
{
    partial class FormMainMenu
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnTicTacToe;
        private Button btnHangman;  // New Hangman button
        private Button btnExit;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();

            // FormMainMenu properties
            this.ClientSize = new System.Drawing.Size(320, 400);  // Set form size as needed
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;  // Set to fixed dialog
            this.MaximizeBox = false;  // Disable maximize button
            this.Name = "FormMainMenu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);
            
            this.btnTicTacToe = new System.Windows.Forms.Button();
            this.btnHangman = new System.Windows.Forms.Button();  // Initialize the new button
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // 
            // btnTicTacToe
            // 
            this.btnTicTacToe.Location = new System.Drawing.Point(50, 30);
            this.btnTicTacToe.Name = "btnTicTacToe";
            this.btnTicTacToe.Size = new System.Drawing.Size(200, 50);
            this.btnTicTacToe.TabIndex = 0;
            this.btnTicTacToe.Text = "Play Tic-Tac-Toe";
            this.btnTicTacToe.UseVisualStyleBackColor = true;
            this.btnTicTacToe.Click += new System.EventHandler(this.btnTicTacToe_Click);
            
            // 
            // btnHangman
            // 
            this.btnHangman.Location = new System.Drawing.Point(50, 100);  // Position the new button below Tic-Tac-Toe
            this.btnHangman.Name = "btnHangman";
            this.btnHangman.Size = new System.Drawing.Size(200, 50);
            this.btnHangman.TabIndex = 1;
            this.btnHangman.Text = "Play Hangman";
            this.btnHangman.UseVisualStyleBackColor = true;
            this.btnHangman.Click += new System.EventHandler(this.btnHangman_Click);

            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(50, 170);  // Position the exit button below Hangman
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(200, 50);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            
            // 
            // FormMainMenu
            // 
            this.ClientSize = new System.Drawing.Size(300, 250);
            this.Controls.Add(this.btnTicTacToe);
            this.Controls.Add(this.btnHangman);  // Add Hangman button to the form
            this.Controls.Add(this.btnExit);
            this.Name = "FormMainMenu";
            this.Text = "Game Hub";
            this.ResumeLayout(false);
        }
    }
}
