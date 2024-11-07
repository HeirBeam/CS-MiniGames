using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace GameHubGUI
{
    public partial class FormHangman : Form
    {
        private string wordToGuess;
        private HashSet<char> guessedLetters;
        private List<char> incorrectLetters;  // Track only incorrect letters
        private int attemptsRemaining;
        private static readonly HttpClient httpClient = new HttpClient();
        private readonly string[] fallbackWordBank = { "COMPUTER", "PROGRAM", "WINDOWS", "DEVELOPER", "SOFTWARE" };

        public FormHangman()
        {
            InitializeComponent();
            LoadWordAndStartGame();
        }

        private async void LoadWordAndStartGame()
        {
            wordToGuess = await GetRandomWord();
            guessedLetters = new HashSet<char>();
            incorrectLetters = new List<char>();
            attemptsRemaining = 6;

            // Initialize display with underscores and spaces to show the length of the word clearly
            lblWordDisplay.Text = string.Join(" ", new string('_', wordToGuess.Length).ToCharArray());

            UpdateHangmanImage();
            UpdateDisplay();
        }

        private async Task<string> GetRandomWord()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync("https://random-word-api.herokuapp.com/word?number=1");
                response.EnsureSuccessStatusCode();
                string jsonString = await response.Content.ReadAsStringAsync();
                List<string> wordList = JsonSerializer.Deserialize<List<string>>(jsonString);
                return wordList[0].ToUpper();
            }
            catch
            {
                var random = new Random();
                return fallbackWordBank[random.Next(fallbackWordBank.Length)];
            }
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            string input = txtGuess.Text.ToUpper();
            if (input.Length == 1 && char.IsLetter(input[0]))
            {
                char guessedChar = input[0];
                if (!guessedLetters.Contains(guessedChar))
                {
                    guessedLetters.Add(guessedChar);

                    if (!wordToGuess.Contains(guessedChar))
                    {
                        attemptsRemaining--;
                        incorrectLetters.Add(guessedChar);  // Add to incorrect letters
                    }

                    UpdateDisplay();

                    if (IsWordGuessed())
                    {
                        MessageBox.Show("Congratulations! You've guessed the word!");
                        LoadWordAndStartGame();
                    }
                    else if (attemptsRemaining <= 0)
                    {
                        MessageBox.Show($"Game Over! The word was: {wordToGuess}");
                        LoadWordAndStartGame();
                    }
                }
            }

            txtGuess.Clear();
        }

        private void UpdateDisplay()
        {
            // Display underscores for unguessed letters and guessed letters, with spaces in between
            lblWordDisplay.Text = string.Join(" ", wordToGuess.Select(c => guessedLetters.Contains(c) ? c : '_'));
            lblAttempts.Text = $"Attempts Remaining: {attemptsRemaining}";
            UpdateIncorrectLettersDisplay();
            UpdateHangmanImage();
        }

        private void UpdateIncorrectLettersDisplay()
        {
            lblIncorrectLetters.Text = "Incorrect Letters: " + string.Join(", ", incorrectLetters);
        }

        private void UpdateHangmanImage()
        {
            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", $"hangman{6 - attemptsRemaining}.png");

            if (File.Exists(imagePath))
            {
                picHangman.Image = Image.FromFile(imagePath);
            }
            else
            {
                MessageBox.Show($"Image not found: {imagePath}");
            }
        }

        private bool IsWordGuessed()
        {
            return wordToGuess.All(c => guessedLetters.Contains(c));
        }
    }
}
