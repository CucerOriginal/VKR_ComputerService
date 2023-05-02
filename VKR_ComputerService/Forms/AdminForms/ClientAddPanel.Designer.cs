namespace VKR_ComputerService.Forms.AdminForms
{
	partial class ClientAddPanel
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
			this.PhoneTextBox = new System.Windows.Forms.TextBox();
			this.BirthdateTimePicker = new System.Windows.Forms.DateTimePicker();
			this.AddClientButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SecondnameTextBox
			// 
			this.SecondnameTextBox.Location = new System.Drawing.Point(52, 103);
			this.SecondnameTextBox.Name = "SecondnameTextBox";
			this.SecondnameTextBox.Size = new System.Drawing.Size(172, 27);
			this.SecondnameTextBox.TabIndex = 0;
			this.SecondnameTextBox.Text = "Фамилия";
			// 
			// NameTextBox
			// 
			this.NameTextBox.Location = new System.Drawing.Point(52, 186);
			this.NameTextBox.Name = "NameTextBox";
			this.NameTextBox.Size = new System.Drawing.Size(172, 27);
			this.NameTextBox.TabIndex = 1;
			this.NameTextBox.Text = "Имя";
			// 
			// MiddlenameTextBox
			// 
			this.MiddlenameTextBox.Location = new System.Drawing.Point(52, 268);
			this.MiddlenameTextBox.Name = "MiddlenameTextBox";
			this.MiddlenameTextBox.Size = new System.Drawing.Size(172, 27);
			this.MiddlenameTextBox.TabIndex = 2;
			this.MiddlenameTextBox.Text = "Отчество";
			// 
			// PhoneTextBox
			// 
			this.PhoneTextBox.Location = new System.Drawing.Point(311, 103);
			this.PhoneTextBox.Name = "PhoneTextBox";
			this.PhoneTextBox.Size = new System.Drawing.Size(165, 27);
			this.PhoneTextBox.TabIndex = 3;
			this.PhoneTextBox.Text = "Телефон";
			// 
			// BirthdateTimePicker
			// 
			this.BirthdateTimePicker.Location = new System.Drawing.Point(319, 213);
			this.BirthdateTimePicker.Name = "BirthdateTimePicker";
			this.BirthdateTimePicker.Size = new System.Drawing.Size(157, 27);
			this.BirthdateTimePicker.TabIndex = 4;
			// 
			// AddClientButton
			// 
			this.AddClientButton.Location = new System.Drawing.Point(414, 337);
			this.AddClientButton.Name = "AddClientButton";
			this.AddClientButton.Size = new System.Drawing.Size(94, 29);
			this.AddClientButton.TabIndex = 5;
			this.AddClientButton.Text = "Добавить";
			this.AddClientButton.UseVisualStyleBackColor = true;
			this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(52, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(73, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Фамилия";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(52, 163);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Имя";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(52, 245);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(72, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Отчество";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(311, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(69, 20);
			this.label4.TabIndex = 9;
			this.label4.Text = "Телефон";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(319, 193);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(116, 20);
			this.label5.TabIndex = 10;
			this.label5.Text = "Дата рождения";
			// 
			// ClientAddPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(580, 422);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddClientButton);
			this.Controls.Add(this.BirthdateTimePicker);
			this.Controls.Add(this.PhoneTextBox);
			this.Controls.Add(this.MiddlenameTextBox);
			this.Controls.Add(this.NameTextBox);
			this.Controls.Add(this.SecondnameTextBox);
			this.Name = "ClientAddPanel";
			this.Text = "ClientAddPanel";
			this.Load += new System.EventHandler(this.ClientAddPanel_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox SecondnameTextBox;
		private TextBox NameTextBox;
		private TextBox MiddlenameTextBox;
		private TextBox PhoneTextBox;
		private DateTimePicker BirthdateTimePicker;
		private Button AddClientButton;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
	}
}