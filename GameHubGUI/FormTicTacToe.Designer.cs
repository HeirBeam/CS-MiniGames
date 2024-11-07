namespace GameHubGUI
{
    partial class FormTicTacToe
    {
        private System.ComponentModel.IContainer components = null;
        private Button btnPlayComputer;
        private Button btnPlayFriend;
        private Label lblScore;  // Label to show the score

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

            // FormTicTacToe properties
            this.ClientSize = new System.Drawing.Size(320, 450);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;  // Set to fixed dialog
            this.MaximizeBox = false;  // Disable maximize button
            this.Name = "FormTicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

            
            this.btnPlayComputer = new System.Windows.Forms.Button();
            this.btnPlayFriend = new System.Windows.Forms.Button();
            this.lblScore = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // 
            // btnPlayComputer
            // 
            this.btnPlayComputer.Location = new System.Drawing.Point(10, 370);  // Lower the button position
            this.btnPlayComputer.Name = "btnPlayComputer";
            this.btnPlayComputer.Size = new System.Drawing.Size(150, 50);
            this.btnPlayComputer.TabIndex = 1;
            this.btnPlayComputer.Text = "Play Against Computer";
            this.btnPlayComputer.UseVisualStyleBackColor = true;
            this.btnPlayComputer.Click += new System.EventHandler(this.btnPlayComputer_Click);

            // 
            // btnPlayFriend
            // 
            this.btnPlayFriend.Location = new System.Drawing.Point(170, 370);  // Lower the button position
            this.btnPlayFriend.Name = "btnPlayFriend";
            this.btnPlayFriend.Size = new System.Drawing.Size(150, 50);
            this.btnPlayFriend.TabIndex = 2;
            this.btnPlayFriend.Text = "Play Against Friend";
            this.btnPlayFriend.UseVisualStyleBackColor = true;
            this.btnPlayFriend.Click += new System.EventHandler(this.btnPlayFriend_Click);

            // 
            // lblScore
            // 
            this.lblScore.Location = new System.Drawing.Point(10, 10);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(300, 30);
            this.lblScore.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblScore.Text = "";  // Hide the score initially

            // FormTicTacToe
            this.ClientSize = new System.Drawing.Size(320, 450);  // Increase height to accommodate new button positions
            this.Controls.Add(this.btnPlayComputer);
            this.Controls.Add(this.btnPlayFriend);
            this.Controls.Add(this.lblScore);
            this.Name = "FormTicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);

            InitializeBoard();
        }

        private void InitializeBoard()
        {
            // Initialize a 3x3 grid of buttons for the Tic-Tac-Toe board, but keep them hidden initially
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Button button = new Button
                    {
                        Width = 100,
                        Height = 100,
                        Font = new System.Drawing.Font("Arial", 24),
                        Location = new System.Drawing.Point(100 * i, 50 + 100 * j),
                        Tag = new Tuple<int, int>(i, j),
                        Visible = false  // Hide buttons initially
                    };

                    button.Click += Button_Click;
                    this.Controls.Add(button);
                }
            }
        }
    }
}
