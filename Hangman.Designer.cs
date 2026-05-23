namespace WinFormsApp
{
    partial class FormHangman
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
            label1 = new Label();
            textBoxGuessCount = new TextBox();
            textBoxWord = new TextBox();
            textBoxGuess = new TextBox();
            textBox4 = new TextBox();
            pictureBoxHangman = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            buttonGuess = new Button();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxHangman).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(48, 32);
            label1.Name = "label1";
            label1.Size = new Size(202, 25);
            label1.TabIndex = 0;
            label1.Text = "Бр. оставащи опити:";
            // 
            // textBoxGuessCount
            // 
            textBoxGuessCount.Location = new Point(256, 32);
            textBoxGuessCount.Name = "textBoxGuessCount";
            textBoxGuessCount.Size = new Size(68, 31);
            textBoxGuessCount.TabIndex = 1;
            // 
            // textBoxWord
            // 
            textBoxWord.Font = new Font("Showcard Gothic", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxWord.Location = new Point(487, 94);
            textBoxWord.Name = "textBoxWord";
            textBoxWord.Size = new Size(163, 42);
            textBoxWord.TabIndex = 2;
            // 
            // textBoxGuess
            // 
            textBoxGuess.Location = new Point(460, 201);
            textBoxGuess.Name = "textBoxGuess";
            textBoxGuess.Size = new Size(222, 31);
            textBoxGuess.TabIndex = 3;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(488, 346);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(276, 31);
            textBox4.TabIndex = 4;
            // 
            // pictureBoxHangman
            // 
            pictureBoxHangman.Image = Properties.Resources.hangman1;
            pictureBoxHangman.Location = new Point(63, 94);
            pictureBoxHangman.Name = "pictureBoxHangman";
            pictureBoxHangman.Size = new Size(279, 308);
            pictureBoxHangman.TabIndex = 5;
            pictureBoxHangman.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Yu Gothic", 10F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.ForeColor = Color.Teal;
            label2.Location = new Point(487, 37);
            label2.Name = "label2";
            label2.Size = new Size(172, 26);
            label2.TabIndex = 6;
            label2.Text = "Бесеница";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(389, 151);
            label3.Name = "label3";
            label3.Size = new Size(375, 25);
            label3.TabIndex = 7;
            label3.Text = "Предположете буква или цялата дума:";
            // 
            // buttonGuess
            // 
            buttonGuess.BackColor = Color.Teal;
            buttonGuess.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonGuess.ForeColor = Color.White;
            buttonGuess.Location = new Point(511, 269);
            buttonGuess.Name = "buttonGuess";
            buttonGuess.Size = new Size(112, 34);
            buttonGuess.TabIndex = 8;
            buttonGuess.Text = "Познай";
            buttonGuess.UseVisualStyleBackColor = false;
            buttonGuess.Click += buttonGuess_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(359, 349);
            label4.Name = "label4";
            label4.Size = new Size(114, 25);
            label4.TabIndex = 9;
            label4.Text = "Използвани:";
            // 
            // FormHangman
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(buttonGuess);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBoxHangman);
            Controls.Add(textBox4);
            Controls.Add(textBoxGuess);
            Controls.Add(textBoxWord);
            Controls.Add(textBoxGuessCount);
            Controls.Add(label1);
            Name = "FormHangman";
            Text = "WordGames";
            ((System.ComponentModel.ISupportInitialize)pictureBoxHangman).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxGuessCount;
        private TextBox textBoxWord;
        private TextBox textBoxGuess;
        private TextBox textBox4;
        private PictureBox pictureBoxHangman;
        private Label label2;
        private Label label3;
        private Button buttonGuess;
        private Label label4;
    }
}