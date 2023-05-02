namespace VKR_ComputerService.Forms.AdminForms
{
	partial class ClientsPanel
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
			this.ClientsDataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.AddClientButton = new System.Windows.Forms.Button();
			this.AddOrderButton = new System.Windows.Forms.Button();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			this.UpdateButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ClientsDataGridView
			// 
			this.ClientsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ClientsDataGridView.Location = new System.Drawing.Point(132, 75);
			this.ClientsDataGridView.Name = "ClientsDataGridView";
			this.ClientsDataGridView.RowHeadersWidth = 51;
			this.ClientsDataGridView.RowTemplate.Height = 29;
			this.ClientsDataGridView.Size = new System.Drawing.Size(552, 345);
			this.ClientsDataGridView.TabIndex = 0;
			this.ClientsDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ClientsDataGridView_CellMouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(132, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Клиенты";
			// 
			// AddClientButton
			// 
			this.AddClientButton.Location = new System.Drawing.Point(747, 93);
			this.AddClientButton.Name = "AddClientButton";
			this.AddClientButton.Size = new System.Drawing.Size(150, 29);
			this.AddClientButton.TabIndex = 2;
			this.AddClientButton.Text = "Добавить клиента";
			this.AddClientButton.UseVisualStyleBackColor = true;
			this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
			// 
			// AddOrderButton
			// 
			this.AddOrderButton.Location = new System.Drawing.Point(747, 172);
			this.AddOrderButton.Name = "AddOrderButton";
			this.AddOrderButton.Size = new System.Drawing.Size(150, 29);
			this.AddOrderButton.TabIndex = 3;
			this.AddOrderButton.Text = "Добавить заказ";
			this.AddOrderButton.UseVisualStyleBackColor = true;
			this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(355, 42);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(181, 27);
			this.SearchTextBox.TabIndex = 4;
			this.SearchTextBox.Text = "Поиск";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(299, 45);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Поиск";
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(574, 40);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(94, 29);
			this.SearchButton.TabIndex = 6;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(590, 456);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(94, 29);
			this.UpdateButton.TabIndex = 7;
			this.UpdateButton.Text = "Обновить";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// ClientsPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(921, 555);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.AddOrderButton);
			this.Controls.Add(this.AddClientButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.ClientsDataGridView);
			this.Name = "ClientsPanel";
			this.Text = "ClientPanel";
			this.Load += new System.EventHandler(this.ClientPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.ClientsDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView ClientsDataGridView;
		private Label label1;
		private Button AddClientButton;
		private Button AddOrderButton;
		private TextBox SearchTextBox;
		private Label label2;
		private Button SearchButton;
		private Button UpdateButton;
	}
}