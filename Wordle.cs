using System.IO;
using WinFormsApp.Models;

namespace WordleForm
{
    public partial class Wordle : Form
    {
        public Wordle()
        {
            InitializeComponent();
            GuessCounter = 1;
        }

        public static Player CurrentPlayer { get; set; } = new Player();

        public static WordsWordl Word { get; set; } = new WordsWordl();

        public static WordsWordl Answer { get; set; } = new WordsWordl();

        public static int GuessCounter { get; set; }


        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "я";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "в";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "е";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "р";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "т";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ъ";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "у";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "и";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "о";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "п";
        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ч";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "а";
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "с";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "д";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ф";
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "г";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "х";
        }

        private void button18_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "й";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "к";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "л";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ш";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "щ";
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "з";
        }

        private void button24_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ь";
        }

        private void button25_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ц";
        }

        private void button26_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ж";
        }

        private void button27_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "б";
        }

        private void button28_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "н";
        }

        private void button29_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "м";
        }

        private void button30_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + "ю";
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 5)
            {
                Word.Word = textBox1.Text;

                if (GuessCounter == 1)
                {
                    w1l1.Text = Word.Word[0].ToString();
                    w1l2.Text = Word.Word[1].ToString();
                    w1l3.Text = Word.Word[2].ToString();
                    w1l4.Text = Word.Word[3].ToString();
                    w1l5.Text = Word.Word[4].ToString();

                    if (w1l1.Text[0].Equals(Answer.Word[0]))
                    {
                        w1l1.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w1l1.Text))
                    {
                        w1l1.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w1l1.BackColor = Color.Gray;
                    }

                    if (w1l2.Text[0].Equals(Answer.Word[1]))
                    {
                        w1l2.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w1l2.Text))
                    {
                        w1l2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w1l2.BackColor = Color.Gray;
                    }

                    if (w1l3.Text[0].Equals(Answer.Word[2]))
                    {
                        w1l3.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w1l3.Text))
                    {
                        w1l3.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w1l3.BackColor = Color.Gray;
                    }

                    if (w1l4.Text[0].Equals(Answer.Word[3]))
                    {
                        w1l4.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w1l4.Text))
                    {
                        w1l4.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w1l4.BackColor = Color.Gray;
                    }

                    if (w1l5.Text[0].Equals(Answer.Word[4]))
                    {
                        w1l5.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w1l5.Text))
                    {
                        w1l5.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w1l5.BackColor = Color.Gray;
                    }
                }
                if (GuessCounter == 2)
                {
                    w2l1.Text = Word.Word[0].ToString();
                    w2l2.Text = Word.Word[1].ToString();
                    w2l3.Text = Word.Word[2].ToString();
                    w2l4.Text = Word.Word[3].ToString();
                    w2l5.Text = Word.Word[4].ToString();

                    if (w2l1.Text[0].Equals(Answer.Word[0]))
                    {
                        w2l1.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w2l1.Text))
                    {
                        w2l1.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w2l1.BackColor = Color.Gray;
                    }
                    if (w2l2.Text[0].Equals(Answer.Word[1]))
                    {
                        w2l2.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w2l2.Text))
                    {
                        w2l2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w2l2.BackColor = Color.Gray;
                    }

                    if (w2l3.Text[0].Equals(Answer.Word[2]))
                    {
                        w2l3.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w2l3.Text))
                    {
                        w2l3.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w2l3.BackColor = Color.Gray;
                    }

                    if (w2l4.Text[0].Equals(Answer.Word[3]))
                    {
                        w2l4.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w2l4.Text))
                    {
                        w2l4.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w2l4.BackColor = Color.Gray;
                    }

                    if (w2l5.Text[0].Equals(Answer.Word[4]))
                    {
                        w2l5.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w2l5.Text))
                    {
                        w2l5.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w2l5.BackColor = Color.Gray;
                    }
                }

                if (GuessCounter == 3)
                {
                    w3l1.Text = Word.Word[0].ToString();
                    w3l2.Text = Word.Word[1].ToString();
                    w3l3.Text = Word.Word[2].ToString();
                    w3l4.Text = Word.Word[3].ToString();
                    w3l5.Text = Word.Word[4].ToString();

                    if (w3l1.Text[0].Equals(Answer.Word[0]))
                    {
                        w3l1.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w3l1.Text))
                    {
                        w3l1.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w3l1.BackColor = Color.Gray;
                    }

                    if (w3l2.Text[0].Equals(Answer.Word[1]))
                    {
                        w3l2.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w3l2.Text))
                    {
                        w3l2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w3l2.BackColor = Color.Gray;
                    }

                    if (w3l3.Text[0].Equals(Answer.Word[2]))
                    {
                        w3l3.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w3l3.Text))
                    {
                        w3l3.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w3l3.BackColor = Color.Gray;
                    }

                    if (w3l4.Text[0].Equals(Answer.Word[3]))
                    {
                        w3l4.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w3l4.Text))
                    {
                        w3l4.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w3l4.BackColor = Color.Gray;
                    }

                    if (w3l5.Text[0].Equals(Answer.Word[4]))
                    {
                        w3l5.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w3l5.Text))
                    {
                        w3l5.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w3l5.BackColor = Color.Gray;
                    }
                }

                if (GuessCounter == 4)
                {
                    w4l1.Text = Word.Word[0].ToString();
                    w4l2.Text = Word.Word[1].ToString();
                    w4l3.Text = Word.Word[2].ToString();
                    w4l4.Text = Word.Word[3].ToString();
                    w4l5.Text = Word.Word[4].ToString();

                    if (w4l1.Text[0].Equals(Answer.Word[0]))
                    {
                        w4l1.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w4l1.Text))
                    {
                        w4l1.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w4l1.BackColor = Color.Gray;
                    }

                    if (w4l2.Text[0].Equals(Answer.Word[1]))
                    {
                        w4l2.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w4l2.Text))
                    {
                        w4l2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w4l2.BackColor = Color.Gray;
                    }

                    if (w4l3.Text[0].Equals(Answer.Word[2]))
                    {
                        w4l3.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w4l3.Text))
                    {
                        w4l3.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w4l3.BackColor = Color.Gray;
                    }

                    if (w4l4.Text[0].Equals(Answer.Word[3]))
                    {
                        w4l4.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w4l4.Text))
                    {
                        w4l4.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w4l4.BackColor = Color.Gray;
                    }

                    if (w4l5.Text[0].Equals(Answer.Word[4]))
                    {
                        w4l5.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w4l5.Text))
                    {
                        w4l5.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w4l5.BackColor = Color.Gray;
                    }
                }
                if (GuessCounter == 5)
                {
                    w5l1.Text = Word.Word[0].ToString();
                    w5l2.Text = Word.Word[1].ToString();
                    w5l3.Text = Word.Word[2].ToString();
                    w5l4.Text = Word.Word[3].ToString();
                    w5l5.Text = Word.Word[4].ToString();

                    if (w5l1.Text[0].Equals(Answer.Word[0]))
                    {
                        w5l1.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w5l1.Text))
                    {
                        w5l1.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w5l1.BackColor = Color.Gray;
                    }

                    if (w5l2.Text[0].Equals(Answer.Word[1]))
                    {
                        w5l2.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w5l2.Text))
                    {
                        w5l2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w5l2.BackColor = Color.Gray;
                    }

                    if (w5l3.Text[0].Equals(Answer.Word[2]))
                    {
                        w5l3.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w5l3.Text))
                    {
                        w5l3.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w5l3.BackColor = Color.Gray;
                    }

                    if (w5l4.Text[0].Equals(Answer.Word[3]))
                    {
                        w5l4.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w5l4.Text))
                    {
                        w5l4.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w5l4.BackColor = Color.Gray;
                    }

                    if (w5l5.Text[0].Equals(Answer.Word[4]))
                    {
                        w5l5.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w5l5.Text))
                    {
                        w5l5.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w5l5.BackColor = Color.Gray;
                    }
                }
                if (GuessCounter == 6)
                {
                    w6l1.Text = Word.Word[0].ToString();
                    w6l2.Text = Word.Word[1].ToString();
                    w6l3.Text = Word.Word[2].ToString();
                    w6l4.Text = Word.Word[3].ToString();
                    w6l5.Text = Word.Word[4].ToString();

                    if (w6l1.Text[0].Equals(Answer.Word[0]))
                    {
                        w6l1.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w6l1.Text))
                    {
                        w6l1.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w6l1.BackColor = Color.Gray;
                    }

                    if (w6l2.Text[0].Equals(Answer.Word[1]))
                    {
                        w6l2.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w6l2.Text))
                    {
                        w6l2.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w6l2.BackColor = Color.Gray;
                    }

                    if (w6l3.Text[0].Equals(Answer.Word[2]))
                    {
                        w6l3.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w6l3.Text))
                    {
                        w6l3.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w6l3.BackColor = Color.Gray;
                    }

                    if (w6l4.Text[0].Equals(Answer.Word[3]))
                    {
                        w6l4.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w6l4.Text))
                    {
                        w6l4.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w6l4.BackColor = Color.Gray;
                    }

                    if (w6l5.Text[0].Equals(Answer.Word[4]))
                    {
                        w6l5.BackColor = Color.Green;
                    }
                    else if (Answer.Word.Contains(w6l5.Text))
                    {
                        w6l5.BackColor = Color.Yellow;
                    }
                    else
                    {
                        w6l5.BackColor = Color.Gray;
                    }
                }

                GuessCounter++;

                if (textBox1.Text == Answer.Word)
                {
                    MessageBox.Show("Поздравления! Познахте думата!");

                    CurrentPlayer.PlayerWordlWins++;
                    CurrentPlayer.PlayerTotalGames++;

                    FormChooseGame form = new FormChooseGame();
                    FormChooseGame.CurrentPlayer = CurrentPlayer;  
                    form.Show();
                    this.Hide();
                }
                if (GuessCounter == 7)
                {
                    CurrentPlayer.PlayerTotalGames++;

                    MessageBox.Show($"Вие загубихте! Думата беше {Answer.Word}");

                    FormChooseGame form = new FormChooseGame();
                    FormChooseGame.CurrentPlayer = CurrentPlayer;   
                    form.Show();
                    this.Hide();
                }
            }
            else
                MessageBox.Show("Думата трябва да е 5 букви! Опитайте отново!");
        }

        private void Wordle_Load(object sender, EventArgs e)
        {
            using (DbwordGamesContext context = new DbwordGamesContext())
            {
                Random random = new Random();
                int index = random.Next(1, context.WordsHangmen.Count());

                Answer = context.WordsWordls.First(w => w.WordId == index);
            }
        }

        private void buttonExitGame_Click(object sender, EventArgs e)
        {
            FormChooseGame form = new FormChooseGame();
            form.Show();
            this.Close();
        }

        private void buttonDeleteChar_Click(object sender, EventArgs e)
        {
            if(textBox1.Text.Length > 0)
                textBox1.Text = textBox1.Text.Substring(0, Word.Word.Length - 1);
        }
    }
}
