namespace VKR_ComputerService.Forms.AdminForms
{
	partial class UserAddPanel
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
			this.SecondnameTextBox = new System.Windows.Forms.TextBox();
			this.NameTextBox = new System.Windows.Forms.TextBox();
			this.MiddlenameTextBox = new System.Windows.Forms.TextBox();
			this.PasswordTextBox = new System.Windows.Forms.TextBox();
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.AddUserButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SecondnameTextBox
			// 
			this.SecondnameTextBox.Location = new System.Drawing.Point(80, 146);
			this.SecondnameTextBox.Name = "SecondnameTextBox";
			this.SecondnameTextBox.Size = new System.Drawing.Size(125, 27);
			this.SecondnameTextBox.TabIndex = 0;
			this.SecondnameTextBox.Text = "Фамилия";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(80, 218);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(125, 27);
			this.NameTextBox.TabIndex = 1;
			this.NameTextBox.Text = "Имя";
			// 
			// MiddlenameTextBox
			// 
			this.MiddlenameTextBox.Location = new System.Drawing.Point(80, 290);
			this.MiddlenameTextBox.Name = "MiddlenameTextBox";
			this.MiddlenameTextBox.Size = new System.Drawing.Size(125, 27);
			this.MiddlenameTextBox.TabIndex = 2;
			this.MiddlenameTextBox.Text = "Отчество";
			// 
			// PasswordTextBox
			// 
			this.PasswordTextBox.Location = new System.Drawing.Point(334, 218);
			this.PasswordTextBox.Name = "PasswordTextBox";
			this.PasswordTextBox.Size = new System.Drawing.Size(125, 27);
			this.PasswordTextBox.TabIndex = 3;
			this.PasswordTextBox.Text = "Пароль";
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(334, 146);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(125, 27);
			this.PhoneTextBox.TabIndex = 4;
			this.PhoneTextBox.Text = "Телефон";
			// 
			// AddUserButton
			// 
			this.AddUserButton.Location = new System.Drawing.Point(365, 350);
			this.AddUserButton.Name = "AddUserButton";
			this.AddUserButton.Size = new System.Drawing.Size(94, 29);
			this.AddUserButton.TabIndex = 5;
			this.AddUserButton.Text = "Добавить";
			this.AddUserButton.UseVisualStyleBackColor = true;
			this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(80, 123);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(80, 195);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(80, 267);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Отчество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(334, 123);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Телефон";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(334, 195);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(62, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Пароль";
			// 
			// UserAddPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(607, 492);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddUserButton);
			this.Controls.Add(this.PhoneTextBox);
			this.Controls.Add(this.PasswordTextBox);
			this.Controls.Add(this.MiddlenameTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.SecondnameTextBox);
			this.Name = "UserAddPanel";
			this.Text = "UserAddPanel";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox SecondnameTextBox;
		private TextBox NameTextBox;
		private TextBox MiddlenameTextBox;
		private TextBox PasswordTextBox;
		private TextBox PhoneTextBox;
		private Button AddUserButton;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
	}
}