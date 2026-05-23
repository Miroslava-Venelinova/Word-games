namespace WordleForm
{
    partial class FormChooseGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            buttonChooseWordl = new Button();
            buttonChooseHangman = new Button();
            labelTotalWins = new Label();
            labelHangmanWins = new Label();
            textBoxUsername = new TextBox();
            buttonLogOut = new Button();
            label9 = new Label();
            labelWinsWordl = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 11F, FontStyle.Bold);
            label2.Location = new Point(155, 68);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(163, 19);
            label2.TabIndex = 1;
            label2.Text = "Избери игра";
            // 
            // buttonChooseWordl
            // 
            buttonChooseWordl.BackColor = Color.Teal;
            buttonChooseWordl.Font = new Font("Yu Gothic", 11F, FontStyle.Bold);
            buttonChooseWordl.ForeColor = Color.White;
            buttonChooseWordl.Location = new Point(104, 109);
            buttonChooseWordl.Margin = new Padding(2);
            buttonChooseWordl.Name = "buttonChooseWordl";
            buttonChooseWordl.Size = new Size(78, 32);
            buttonChooseWordl.TabIndex = 3;
            buttonChooseWordl.Text = "Wordle";
            buttonChooseWordl.UseVisualStyleBackColor = false;
            buttonChooseWordl.Click += buttonChooseWordl_Click;
            // 
            // buttonChooseHangman
            // 
            buttonChooseHangman.BackColor = Color.Teal;
            buttonChooseHangman.Font = new Font("Yu Gothic", 11F, FontStyle.Bold);
            buttonChooseHangman.ForeColor = Color.White;
            buttonChooseHangman.Location = new Point(297, 111);
            buttonChooseHangman.Margin = new Padding(2);
            buttonChooseHangman.Name = "buttonChooseHangman";
            buttonChooseHangman.Size = new Size(90, 32);
            buttonChooseHangman.TabIndex = 4;
            buttonChooseHangman.Text = "Hangman";
            buttonChooseHangman.UseVisualStyleBackColor = false;
            buttonChooseHangman.Click += buttonChooseHangman_Click;
            // 
            // labelTotalWins
            // 
            labelTotalWins.AutoSize = true;
            labelTotalWins.Location = new Point(332, 13);
            labelTotalWins.Margin = new Padding(2, 0, 2, 0);
            labelTotalWins.Name = "labelTotalWins";
            labelTotalWins.Size = new Size(79, 15);
            labelTotalWins.TabIndex = 5;
            labelTotalWins.Text = "Брой игри : 0";
            // 
            // labelHangmanWins
            // 
            labelHangmanWins.AutoSize = true;
            labelHangmanWins.Location = new Point(297, 145);
            labelHangmanWins.Margin = new Padding(2, 0, 2, 0);
            labelHangmanWins.Name = "labelHangmanWins";
            labelHangmanWins.Size = new Size(90, 15);
            labelHangmanWins.TabIndex = 7;
            labelHangmanWins.Text = "Брой победи: 0";
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(172, 13);
            textBoxUsername.Margin = new Padding(2);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(106, 23);
            textBoxUsername.TabIndex = 13;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Teal;
            buttonLogOut.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Location = new Point(8, 39);
            buttonLogOut.Margin = new Padding(2);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(78, 28);
            buttonLogOut.TabIndex = 12;
            buttonLogOut.Text = "Изход";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label9.Location = new Point(8, 16);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(144, 15);
            label9.TabIndex = 11;
            label9.Text = "Настоящ потребител:";
            // 
            // labelWinsWordl
            // 
            labelWinsWordl.AutoSize = true;
            labelWinsWordl.Location = new Point(104, 145);
            labelWinsWordl.Margin = new Padding(2, 0, 2, 0);
            labelWinsWordl.Name = "labelWinsWordl";
            labelWinsWordl.Size = new Size(90, 15);
            labelWinsWordl.TabIndex = 14;
            labelWinsWordl.Text = "Брой победи: 0";
            // 
            // FormChooseGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 189);
            Controls.Add(labelWinsWordl);
            Controls.Add(textBoxUsername);
            Controls.Add(buttonLogOut);
            Controls.Add(label9);
            Controls.Add(labelHangmanWins);
            Controls.Add(labelTotalWins);
            Controls.Add(buttonChooseHangman);
            Controls.Add(buttonChooseWordl);
            Controls.Add(label2);
            Margin = new Padding(2);
            Name = "FormChooseGame";
            Text = "WordGames";
            Load += ChooseGame_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Button buttonChooseWordl;
        private Button buttonChooseHangman;
        private Label labelTotalWins;
        private Label labelHangmanWins;
        private TextBox textBoxUsername;
        private Button buttonLogOut;
        private Label label9;
        private Label labelWinsWordl;
    }
}