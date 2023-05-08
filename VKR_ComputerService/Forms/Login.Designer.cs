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
			this.LogOnButton = new System.Windows.Forms.Button();
			this.LoginTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// LogOnButton
			// 
			this.LogOnButton.Location = new System.Drawing.Point(300, 343);
			this.LogOnButton.Name = "LogOnButton";
			this.LogOnButton.Size = new System.Drawing.Size(94, 29);
			this.LogOnButton.TabIndex = 0;
			this.LogOnButton.Text = "Войти";
			this.LogOnButton.UseVisualStyleBackColor = true;
			this.LogOnButton.Click += new System.EventHandler(this.LogOnButton_Click);
			// 
			// LoginTextBox
			// 
			this.LoginTextBox.Location = new System.Drawing.Point(225, 182);
			this.LoginTextBox.Name = "LoginTextBox";
			this.LoginTextBox.Size = new System.Drawing.Size(245, 27);
			this.LoginTextBox.TabIndex = 1;
			this.LoginTextBox.Text = "Логин";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(225, 248);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.PasswordChar = '*';
			this.PasswordTextBox.Size = new System.Drawing.Size(245, 27);
			this.PasswordTextBox.TabIndex = 2;
			this.PasswordTextBox.Text = "Пароль";
			// 
			// Login
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(676, 456);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.LoginTextBox);
			this.Controls.Add(this.LogOnButton);
			this.Name = "Login";
			this.Text = "Login";
			this.Load += new System.EventHandler(this.Login_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button LogOnButton;
		private TextBox LoginTextBox;
		private TextBox PasswordTextBox;
	}
}