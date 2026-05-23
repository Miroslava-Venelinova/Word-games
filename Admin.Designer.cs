namespace WinFormsApp
{
    partial class FormAddNewWords
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
            comboBoxGames = new ComboBox();
            label2 = new Label();
            textBoxData = new TextBox();
            buttonAddWord = new Button();
            buttonLogOut = new Button();
            label3 = new Label();
            textBoxAdminUsername = new TextBox();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(48, 85);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(271, 15);
            label1.TabIndex = 0;
            label1.Text = "Добавете нова дума към някоя от игрите:";
            // 
            // comboBoxGames
            // 
            comboBoxGames.FormattingEnabled = true;
            comboBoxGames.Items.AddRange(new object[] { "Wordl", "Бесеница" });
            comboBoxGames.Location = new Point(184, 116);
            comboBoxGames.Margin = new Padding(2, 2, 2, 2);
            comboBoxGames.Name = "comboBoxGames";
            comboBoxGames.Size = new Size(129, 23);
            comboBoxGames.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(51, 118);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 2;
            label2.Text = "Изберете игра:";
            // 
            // textBoxData
            // 
            textBoxData.Location = new Point(184, 163);
            textBoxData.Margin = new Padding(2, 2, 2, 2);
            textBoxData.Name = "textBoxData";
            textBoxData.Size = new Size(186, 23);
            textBoxData.TabIndex = 3;
            // 
            // buttonAddWord
            // 
            buttonAddWord.BackColor = Color.Teal;
            buttonAddWord.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonAddWord.ForeColor = Color.White;
            buttonAddWord.Location = new Point(412, 134);
            buttonAddWord.Margin = new Padding(2, 2, 2, 2);
            buttonAddWord.Name = "buttonAddWord";
            buttonAddWord.Size = new Size(78, 30);
            buttonAddWord.TabIndex = 4;
            buttonAddWord.Text = "Добави";
            buttonAddWord.UseVisualStyleBackColor = false;
            buttonAddWord.Click += buttonAddWord_Click;
            // 
            // buttonLogOut
            // 
            buttonLogOut.BackColor = Color.Teal;
            buttonLogOut.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogOut.ForeColor = Color.White;
            buttonLogOut.Location = new Point(412, 58);
            buttonLogOut.Margin = new Padding(2, 2, 2, 2);
            buttonLogOut.Name = "buttonLogOut";
            buttonLogOut.Size = new Size(78, 27);
            buttonLogOut.TabIndex = 5;
            buttonLogOut.Text = "Изход";
            buttonLogOut.UseVisualStyleBackColor = false;
            buttonLogOut.Click += buttonLogOut_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(48, 30);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(177, 15);
            label3.TabIndex = 6;
            label3.Text = "Admin потребителско име:";
            // 
            // textBoxAdminUsername
            // 
            textBoxAdminUsername.Location = new Point(243, 30);
            textBoxAdminUsername.Margin = new Padding(2, 2, 2, 2);
            textBoxAdminUsername.Name = "textBoxAdminUsername";
            textBoxAdminUsername.Size = new Size(138, 23);
            textBoxAdminUsername.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label4.Location = new Point(54, 165);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 15);
            label4.TabIndex = 8;
            label4.Text = "Въведете:";
            // 
            // FormAddNewWords
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(560, 221);
            Controls.Add(label4);
            Controls.Add(textBoxAdminUsername);
            Controls.Add(label3);
            Controls.Add(buttonLogOut);
            Controls.Add(buttonAddWord);
            Controls.Add(textBoxData);
            Controls.Add(label2);
            Controls.Add(comboBoxGames);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "FormAddNewWords";
            Text = "WordGames";
            Load += FormAddNewWords_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxGames;
        private Label label2;
        private TextBox textBoxData;
        private Button buttonAddWord;
        private Button buttonLogOut;
        private Label label3;
        private TextBox textBoxAdminUsername;
        private Label label4;
    }
}