using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WinFormsApp.Models;

namespace WinFormsApp
{
    public partial class FormAddNewWords : Form
    {
        public FormAddNewWords()
        {
            InitializeComponent();
        }

        public static Admin CurrentAdmin { get; set; }

        private void buttonAddWord_Click(object sender, EventArgs e)
        {
            if (comboBoxGames.SelectedItem.ToString() == "Wordl")
            {
                var items = textBoxData.Text.Split(", ").ToList();
                using (DbwordGamesContext context = new DbwordGamesContext())
                {
                    foreach (var item in items)
                    {
                        WordsWordl word = new WordsWordl() { Word = item };
                        context.WordsWordls.Add(word);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Промените бяха отразени");
                }
            }
            else if (comboBoxGames.SelectedItem.ToString() == "Бесеница")
            {
                var items = textBoxData.Text.Split(", ").ToList();
                using (DbwordGamesContext context = new DbwordGamesContext())
                {
                    foreach (var item in items)
                    {
                        WordsHangman word = new WordsHangman() { Word = item };
                        context.WordsHangmen.Add(word);
                        context.SaveChanges();
                    }
                    MessageBox.Show("Промените бяха отразени");
                }
            }
        }

        private void buttonLogOut_Click(object sender, EventArgs e)
        {
            Start form = new Start();
            form.Show();
            this.Close();
        }

        private void FormAddNewWords_Load(object sender, EventArgs e)
        {
            textBoxAdminUsername.Text = CurrentAdmin.AdminUsername.ToString();
        }
    }
}
