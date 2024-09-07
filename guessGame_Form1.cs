using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace guessGame
{
    public partial class Form1 : Form
    {
        private List<string> wrongGuesses = new List<string>();
        string wordToGuess; // Declare the wordToGuess variable
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            NewGame();
        }

        private void CheckGuess()
        {
            string guess = txtGuess.Text.ToLower();

            if (guess == wordToGuess)
            {
                // User guessed the word correctly, reset the game
                NewGame();
            }
            else
            {
            }
            txtGuess.Text = "";
            txtGuess.Focus();
        }

        private void NewGame()
        {
            string[] words = { "correct", "current","comfort", "connect" };

            wordToGuess = words[random.Next(words.Length)];

            char[] wordArray = wordToGuess.ToCharArray();
            string displayedWord = "";

            for (int i = 0; i < wordArray.Length; i++)
            {
                if (i == 0 || i == wordArray.Length - 1) // show the first and last letter
                {
                    displayedWord += wordArray[i].ToString();
                }
                else
                {
                    displayedWord += "?";
                }
            }

            lblWord.Text = displayedWord;

            txtGuess.Text = "";
            lstWrongGuesses.Items.Clear();
            wrongGuesses.Clear();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            try
            {
                string guess = txtGuess.Text.ToLower();

                if (guess == wordToGuess)
                {
                    lblWord.Text = wordToGuess;
                    txtResult.Text = "Correct guess!";
                    MessageBox.Show("Correct guess!");
                    NewGame();
                }
                else
                {
                    if (!wrongGuesses.Contains(guess))
                    {
                        wrongGuesses.Add(guess);
                        lstWrongGuesses.Items.Add(guess);
                        txtResult.Text = "Wrong guess! Try again.";
                        MessageBox.Show("Wrong guess!");
                    }
                    else
                    {
                        txtResult.Text = "You already guessed that word!";
                        MessageBox.Show("You already guessed that word!");
                    }
                }

                txtGuess.Text = "";
                txtGuess.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtGuess_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
