namespace GameHubGUI
{
    partial class FormTicTacToe
    {
        private System.ComponentModel.IContainer components = null;
        private Label instructionsLabel;  // New label for instructions

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
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Location = new System.Drawing.Point(10, 10);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(300, 30);
            this.instructionsLabel.Font = new System.Drawing.Font("Arial", 14);
            this.instructionsLabel.Text = "Current Player: X";  // Default starting player
            this.Controls.Add(this.instructionsLabel);

            // 
            // FormTicTacToe
            // 
            this.ClientSize = new System.Drawing.Size(320, 370);  // Adjust form size for instructions label
            this.Name = "FormTicTacToe";
            this.Text = "Tic Tac Toe";
            this.ResumeLayout(false);
        }
    }
}
