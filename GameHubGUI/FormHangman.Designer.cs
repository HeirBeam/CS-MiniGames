namespace GameHubGUI
{
    partial class FormHangman
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblWordDisplay;
        private Label lblAttempts;
        private Label lblIncorrectLetters;   // Label for incorrect letters
        private TextBox txtGuess;
        private Button btnGuess;
        private PictureBox picHangman;

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
            this.lblWordDisplay = new System.Windows.Forms.Label();
            this.lblAttempts = new System.Windows.Forms.Label();
            this.lblIncorrectLetters = new System.Windows.Forms.Label();  // Initialize incorrect letters label
            this.txtGuess = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.picHangman = new System.Windows.Forms.PictureBox();

            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).BeginInit();
            this.SuspendLayout();

            // lblWordDisplay
            this.lblWordDisplay.Font = new System.Drawing.Font("Arial", 18F);
            this.lblWordDisplay.Location = new System.Drawing.Point(20, 20);
            this.lblWordDisplay.Name = "lblWordDisplay";
            this.lblWordDisplay.Size = new System.Drawing.Size(300, 40);
            this.lblWordDisplay.Text = "_ _ _ _ _ _ _";

            // lblAttempts
            this.lblAttempts.Location = new System.Drawing.Point(20, 70);
            this.lblAttempts.Name = "lblAttempts";
            this.lblAttempts.Size = new System.Drawing.Size(200, 30);
            this.lblAttempts.Text = "Attempts Remaining: 6";

            // lblIncorrectLetters
            this.lblIncorrectLetters.Location = new System.Drawing.Point(20, 110);  // Moved further down
            this.lblIncorrectLetters.Name = "lblIncorrectLetters";
            this.lblIncorrectLetters.Size = new System.Drawing.Size(300, 30);
            this.lblIncorrectLetters.Text = "Incorrect Letters: ";  // Initial text

            // txtGuess
            this.txtGuess.Location = new System.Drawing.Point(20, 150);
            this.txtGuess.Name = "txtGuess";
            this.txtGuess.Size = new System.Drawing.Size(50, 30);
            this.txtGuess.MaxLength = 1;

            // btnGuess
            this.btnGuess.Location = new System.Drawing.Point(80, 150);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(100, 30);
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = true;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);

            // picHangman
            this.picHangman.Location = new System.Drawing.Point(20, 200);  // Adjusted to have a clear separation
            this.picHangman.Name = "picHangman";
            this.picHangman.Size = new System.Drawing.Size(100, 150);
            this.picHangman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;

            // FormHangman
            this.ClientSize = new System.Drawing.Size(340, 400);  // Increased form height
            this.Controls.Add(this.lblWordDisplay);
            this.Controls.Add(this.lblAttempts);
            this.Controls.Add(this.lblIncorrectLetters);  // Add incorrect letters label to form
            this.Controls.Add(this.txtGuess);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.picHangman);
            this.Name = "FormHangman";
            this.Text = "Hangman";

            ((System.ComponentModel.ISupportInitialize)(this.picHangman)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
