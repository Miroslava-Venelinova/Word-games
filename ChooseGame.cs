using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp;
using WinFormsApp.Models;

namespace WordleForm
{
    public partial class FormChooseGame : Form
    {

        public FormChooseGame()
        {
            InitializeComponent();
        }

        public static Player CurrentPlayer { get; set; } = new Player();

        private void ChooseGame_Load(object sender, EventArgs e)
        {
            textBoxUsername.Text = CurrentPlayer.PlayerUsername;
            labelTotalWins.Text = $"Брой игри: {CurrentPlayer.PlayerTotalGames.ToString()}";
            labelWinsWordl.Text = $"Брой победи: {CurrentPlayer.PlayerWordlWins.ToString()}";
            labelHangmanWins.Text = $"Брой победи: {CurrentPlayer.PlayerHangmanWins.ToString()}";
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Hide();
        }

        private void buttonChooseWordl_Click(object sender, EventArgs e)
        {
            Wordle form = new Wordle();
            Wordle.CurrentPlayer = CurrentPlayer; 
            form.Show();
            this.Hide();
        }

        private void buttonChooseHangman_Click(object sender, EventArgs e)
        {
            FormHangman form = new FormHangman();
            form.Show();
            this.Hide();
        }
    }
}
