namespace VKR_ComputerService.Forms.AdminForms
{
	partial class UsersPanel
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
			this.UsersDataGridView = new System.Windows.Forms.DataGridView();
			this.AddUserButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// UsersDataGridView
			// 
			this.UsersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.UsersDataGridView.Location = new System.Drawing.Point(86, 112);
			this.UsersDataGridView.Name = "UsersDataGridView";
			this.UsersDataGridView.RowHeadersWidth = 51;
			this.UsersDataGridView.RowTemplate.Height = 29;
			this.UsersDataGridView.Size = new System.Drawing.Size(665, 286);
			this.UsersDataGridView.TabIndex = 0;
			// 
			// AddUserButton
			// 
			this.AddUserButton.Location = new System.Drawing.Point(765, 136);
			this.AddUserButton.Name = "AddUserButton";
			this.AddUserButton.Size = new System.Drawing.Size(185, 29);
			this.AddUserButton.TabIndex = 1;
			this.AddUserButton.Text = "Добавить пользователя";
			this.AddUserButton.UseVisualStyleBackColor = true;
			this.AddUserButton.Click += new System.EventHandler(this.AddUserButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(86, 89);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(108, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Пользователи";
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(657, 426);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(94, 29);
			this.UpdateButton.TabIndex = 3;
			this.UpdateButton.Text = "Обновить";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(641, 77);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(94, 29);
			this.SearchButton.TabIndex = 4;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(320, 77);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(242, 27);
			this.SearchTextBox.TabIndex = 5;
			this.SearchTextBox.Text = "Поиск";
			// 
			// UsersPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(962, 506);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddUserButton);
			this.Controls.Add(this.UsersDataGridView);
			this.Name = "UsersPanel";
			this.Text = "UsersPanel";
			this.Load += new System.EventHandler(this.UsersPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.UsersDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView UsersDataGridView;
		private Button AddUserButton;
		private Label label1;
		private Button UpdateButton;
		private Button SearchButton;
		private TextBox SearchTextBox;
	}
}