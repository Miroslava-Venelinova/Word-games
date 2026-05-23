namespace WinFormsApp
{
    partial class Start
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonLogIn = new Button();
            label1 = new Label();
            label2 = new Label();
            textBoxUsernameInput = new TextBox();
            label3 = new Label();
            textBoxUserPassword = new TextBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // buttonLogIn
            // 
            buttonLogIn.BackColor = Color.Teal;
            buttonLogIn.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            buttonLogIn.ForeColor = Color.White;
            buttonLogIn.Location = new Point(383, 174);
            buttonLogIn.Margin = new Padding(2);
            buttonLogIn.Name = "buttonLogIn";
            buttonLogIn.Size = new Size(78, 28);
            buttonLogIn.TabIndex = 0;
            buttonLogIn.Text = "Вход";
            buttonLogIn.UseVisualStyleBackColor = false;
            buttonLogIn.Click += buttonLogIn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(356, 22);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(152, 19);
            label1.TabIndex = 2;
            label1.Text = "Игри с думи";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(328, 59);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(195, 15);
            label2.TabIndex = 3;
            label2.Text = "Въведете потребителско име:";
            // 
            // textBoxUsernameInput
            // 
            textBoxUsernameInput.Location = new Point(356, 88);
            textBoxUsernameInput.Margin = new Padding(2);
            textBoxUsernameInput.Name = "textBoxUsernameInput";
            textBoxUsernameInput.Size = new Size(139, 23);
            textBoxUsernameInput.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label3.Location = new Point(364, 118);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 5;
            label3.Text = "Въведете парола:";
            // 
            // textBoxUserPassword
            // 
            textBoxUserPassword.Location = new Point(356, 145);
            textBoxUserPassword.Margin = new Padding(2);
            textBoxUserPassword.Name = "textBoxUserPassword";
            textBoxUserPassword.Size = new Size(139, 23);
            textBoxUserPassword.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(20, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(303, 166);
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // FormStart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(560, 223);
            Controls.Add(pictureBox1);
            Controls.Add(textBoxUserPassword);
            Controls.Add(label3);
            Controls.Add(textBoxUsernameInput);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(buttonLogIn);
            Margin = new Padding(2);
            Name = "FormStart";
            Text = "WordGames";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonLogIn;
        private Label label1;
        private Label label2;
        private TextBox textBoxUsernameInput;
        private Label label3;
        private TextBox textBoxUserPassword;
        private PictureBox pictureBox1;
    }
}
