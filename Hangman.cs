using Microsoft.EntityFrameworkCore.Storage.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsApp.Models;
using WordleForm;

namespace WinFormsApp
{
    public partial class FormHangman : Form
    {
        public FormHangman()
        {
            InitializeComponent();
            GenerateWord();
            LoadWord();
            GuessCounter = 6;
            ShowGuessCount();
        }
        public static Player Player { get; set; } = new Player();

        public static WordsHangman Word { get; set; } = new WordsHangman();

        public static List<char> DisplayedWord { get; set; } = new List<char>();

        public static int GuessCounter { get; set; }

        public static List<char> UsedChars { get; set; } = new List<char>();

        public void GenerateWord()
        {
            using (DbwordGamesContext context = new DbwordGamesContext())
            {
                Random random = new Random();
                int index = random.Next(1, context.WordsHangmen.Count());

                Word = context.WordsHangmen.First(w => w.WordId == index);
            }
        }

        public void LoadWord()
        {
            List<char> word = (new string('-', Word.Word.Length)).ToList();

            DisplayedWord = word;

            Random random = new Random();
            int revealedIndex = random.Next(0, Word.Word.Length);

            word[revealedIndex] = Word.Word[revealedIndex];

            textBoxWord.Text = string.Join(' ', word).ToString();
        }

        public void ShowGuessCount()
        {
            textBoxGuessCount.Text = GuessCounter.ToString();
        }

        public bool GuessWholeWord(string word) => word == Word.Word;

        public bool GuessCharacterInWord(string ch)
        {
            bool isContained = false;

            for (int i = 0; i < Word.Word.Length; i++)
            {
                if (Word.Word[i].Equals(ch))
                {
                    isContained = true;
                    break;
                }
            }
            return isContained;
        }

        public void ChangePicture()
        {
            switch (GuessCounter)
            {
                case 5:
                    pictureBoxHangman.Image = Properties.Resources.hangman2;
                    break;
                case 4:
                    pictureBoxHangman.Image = Properties.Resources.hangman3;
                    break;
                case 3:
                    pictureBoxHangman.Image = Properties.Resources.hangman4;
                    break;
                case 2:
                    pictureBoxHangman.Image = Properties.Resources.hangman5;
                    break;
                case 1:
                    pictureBoxHangman.Image = Properties.Resources.hangman6;
                    break;
                case 0:
                    pictureBoxHangman.Image = Properties.Resources.hangman7;

                    Player.PlayerTotalGames++;
                    MessageBox.Show($"Загубихте! Думата беше {Word.Word}");

                    FormChooseGame form = new FormChooseGame();
                    form.Show();
                    this.Hide();

                    break;
            }
        }

        private void buttonGuess_Click(object sender, EventArgs e)
        {
            var guess = textBoxGuess.Text;

            if (guess.Length > 1)
            {
                if (GuessWholeWord(guess))
                {
                    textBoxWord.Text = guess;
                    Player.PlayerTotalGames++;
                    Player.PlayerHangmanWins++;
                    MessageBox.Show("Спечелихте!");

                    FormChooseGame form = new FormChooseGame();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    GuessCounter--;
                    ShowGuessCount();
                    ChangePicture();
                }
            }
            else if (guess.Length == 1)
            {
                if (GuessCharacterInWord(guess))
                {
                    DisplayedWord[Word.Word.IndexOf(guess)] = guess.ToCharArray()[0];
                    textBoxWord.Text = string.Join(' ', DisplayedWord).ToString();
                }
                else
                {
                    UsedChars.Add(guess.ToCharArray()[0]);
                    textBox4.Text = string.Join(" ", UsedChars);

                    GuessCounter--;
                    ShowGuessCount();
                    ChangePicture();
                }
            }

            if (DisplayedWord.ToString() == Word.Word)
            {
                Player.PlayerTotalGames++;
                Player.PlayerHangmanWins++;
                MessageBox.Show("Спечелихте!");

                FormChooseGame form = new FormChooseGame();
                form.Show();
                this.Hide();
            }
        }
    }
}
