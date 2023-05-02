namespace VKR_ComputerService.Forms
{
	partial class AdminPanel
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
			this.OrdersPanelOpenButton = new System.Windows.Forms.Button();
			this.UserPanelOpenButton = new System.Windows.Forms.Button();
			this.CilentsPanelOpenButton = new System.Windows.Forms.Button();
			this.OrdersAtWorkDataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.UpdateOrderDataButton = new System.Windows.Forms.Button();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.SearchButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.OrdersAtWorkDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// OrdersPanelOpenButton
			// 
			this.OrdersPanelOpenButton.Location = new System.Drawing.Point(25, 172);
			this.OrdersPanelOpenButton.Name = "OrdersPanelOpenButton";
			this.OrdersPanelOpenButton.Size = new System.Drawing.Size(142, 29);
			this.OrdersPanelOpenButton.TabIndex = 0;
			this.OrdersPanelOpenButton.Text = "Заказы";
			this.OrdersPanelOpenButton.UseVisualStyleBackColor = true;
			this.OrdersPanelOpenButton.Click += new System.EventHandler(this.OrdersPanelOpenButton_Click);
			// 
			// UserPanelOpenButton
			// 
			this.UserPanelOpenButton.Location = new System.Drawing.Point(25, 259);
			this.UserPanelOpenButton.Name = "UserPanelOpenButton";
			this.UserPanelOpenButton.Size = new System.Drawing.Size(142, 29);
			this.UserPanelOpenButton.TabIndex = 1;
			this.UserPanelOpenButton.Text = "Пользователи";
			this.UserPanelOpenButton.UseVisualStyleBackColor = true;
			this.UserPanelOpenButton.Click += new System.EventHandler(this.UserPanelOpenButton_Click);
			// 
			// CilentsPanelOpenButton
			// 
			this.CilentsPanelOpenButton.Location = new System.Drawing.Point(25, 345);
			this.CilentsPanelOpenButton.Name = "CilentsPanelOpenButton";
			this.CilentsPanelOpenButton.Size = new System.Drawing.Size(142, 29);
			this.CilentsPanelOpenButton.TabIndex = 2;
			this.CilentsPanelOpenButton.Text = "Клиенты";
			this.CilentsPanelOpenButton.UseVisualStyleBackColor = true;
			this.CilentsPanelOpenButton.Click += new System.EventHandler(this.CilentsPanelOpenButton_Click);
			// 
			// OrdersAtWorkDataGridView
			// 
			this.OrdersAtWorkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrdersAtWorkDataGridView.Location = new System.Drawing.Point(404, 145);
			this.OrdersAtWorkDataGridView.Name = "OrdersAtWorkDataGridView";
			this.OrdersAtWorkDataGridView.ReadOnly = true;
			this.OrdersAtWorkDataGridView.RowHeadersWidth = 51;
			this.OrdersAtWorkDataGridView.RowTemplate.Height = 29;
			this.OrdersAtWorkDataGridView.Size = new System.Drawing.Size(565, 324);
			this.OrdersAtWorkDataGridView.TabIndex = 3;
			this.OrdersAtWorkDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(404, 122);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Заказы в работе";
			// 
			// UpdateOrderDataButton
			// 
			this.UpdateOrderDataButton.Location = new System.Drawing.Point(875, 495);
			this.UpdateOrderDataButton.Name = "UpdateOrderDataButton";
			this.UpdateOrderDataButton.Size = new System.Drawing.Size(94, 29);
			this.UpdateOrderDataButton.TabIndex = 5;
			this.UpdateOrderDataButton.Text = "Обновить";
			this.UpdateOrderDataButton.UseVisualStyleBackColor = true;
			this.UpdateOrderDataButton.Click += new System.EventHandler(this.UpdateOrderDataButton_Click);
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(648, 115);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(163, 27);
			this.SearchTextBox.TabIndex = 6;
			this.SearchTextBox.Text = "Поиск";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(592, 118);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(52, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Поиск";
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(858, 113);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(94, 29);
			this.SearchButton.TabIndex = 8;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// AdminPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1043, 605);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.UpdateOrderDataButton);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OrdersAtWorkDataGridView);
			this.Controls.Add(this.CilentsPanelOpenButton);
			this.Controls.Add(this.UserPanelOpenButton);
			this.Controls.Add(this.OrdersPanelOpenButton);
			this.Name = "AdminPanel";
			this.Text = "AdminPanel";
			this.Load += new System.EventHandler(this.AdminPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.OrdersAtWorkDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Button OrdersPanelOpenButton;
		private Button UserPanelOpenButton;
		private Button CilentsPanelOpenButton;
		private DataGridView OrdersAtWorkDataGridView;
		private Label label1;
		private Button UpdateOrderDataButton;
		private TextBox SearchTextBox;
		private Label label2;
		private Button SearchButton;
	}
}