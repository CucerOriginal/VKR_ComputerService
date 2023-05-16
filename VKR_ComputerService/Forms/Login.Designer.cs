namespace VKR_ComputerService
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            LogOnButton = new Button();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox3 = new PictureBox();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // LogOnButton
            // 
            LogOnButton.BackColor = SystemColors.MenuHighlight;
            LogOnButton.FlatAppearance.BorderColor = Color.DodgerBlue;
            LogOnButton.FlatAppearance.BorderSize = 0;
            LogOnButton.FlatStyle = FlatStyle.Flat;
            LogOnButton.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            LogOnButton.ForeColor = Color.White;
            LogOnButton.Location = new Point(55, 381);
            LogOnButton.Margin = new Padding(3, 2, 3, 2);
            LogOnButton.Name = "LogOnButton";
            LogOnButton.Size = new Size(182, 30);
            LogOnButton.TabIndex = 0;
            LogOnButton.Text = "Войти";
            LogOnButton.UseVisualStyleBackColor = false;
            LogOnButton.Click += LogOnButton_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.BorderStyle = BorderStyle.None;
            LoginTextBox.Font = new Font("Oldtimer", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.ForeColor = SystemColors.MenuHighlight;
            LoginTextBox.Location = new Point(66, 236);
            LoginTextBox.Margin = new Padding(3, 2, 3, 2);
            LoginTextBox.Multiline = true;
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(215, 27);
            LoginTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.BorderStyle = BorderStyle.None;
            PasswordTextBox.Font = new Font("Oldtimer", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.ForeColor = SystemColors.MenuHighlight;
            PasswordTextBox.Location = new Point(66, 310);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Multiline = true;
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(215, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(98, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(101, 100);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(12, 215);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(48, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.MenuHighlight;
            panel1.Location = new Point(13, 269);
            panel1.Name = "panel1";
            panel1.Size = new Size(268, 1);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.MenuHighlight;
            panel2.Location = new Point(13, 343);
            panel2.Name = "panel2";
            panel2.Size = new Size(268, 1);
            panel2.TabIndex = 7;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(12, 289);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(48, 48);
            pictureBox3.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oldtimer", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(98, 178);
            label1.Name = "label1";
            label1.Size = new Size(113, 17);
            label1.TabIndex = 8;
            label1.Text = "Авторизация";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.MenuHighlight;
            button1.FlatAppearance.BorderColor = Color.DodgerBlue;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Oldtimer", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(110, 431);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(66, 19);
            button1.TabIndex = 9;
            button1.Text = "Закрыть";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(292, 461);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            Controls.Add(panel1);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(LogOnButton);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Login";
            Text = "Login";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LogOnButton;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox3;
        private Label label1;
        private Button button1;
    }
}