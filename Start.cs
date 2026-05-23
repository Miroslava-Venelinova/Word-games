using System.Numerics;
using System.Text.RegularExpressions;

using WinFormsApp.Models;
using WordleForm;

namespace WinFormsApp
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void buttonLogIn_Click(object sender, EventArgs e)
        {
            using (DbwordGamesContext context = new DbwordGamesContext())
            {
                Regex regex = new Regex("#A[1-5]");

                if (regex.IsMatch(textBoxUsernameInput.Text))
                {
                    var admin = context.Admins.FirstOrDefault(
                        a => a.AdminUsername == textBoxUsernameInput.Text
                        && a.AdminPassword == textBoxUserPassword.Text);

                    if (admin != null)
                    {
                        FormAddNewWords.CurrentAdmin = admin;
                        FormAddNewWords form = new FormAddNewWords();
                        form.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Няма такъв администратор!");
                }
                else
                {
                    var player = context.Players.FirstOrDefault(
                        p => p.PlayerUsername == textBoxUsernameInput.Text
                        && p.PlayerPassword == textBoxUserPassword.Text);

                    if (player != null)
                    {
                        FormChooseGame.CurrentPlayer = player;
                        FormChooseGame form = new FormChooseGame();
                        form.Show();
                        this.Hide();
                    }
                    else
                        MessageBox.Show("Няма такъв потребител!");
                }
            }
        }
    }
}
