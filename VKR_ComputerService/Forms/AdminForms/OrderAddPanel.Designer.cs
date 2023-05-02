namespace VKR_ComputerService.Forms.AdminForms
{
	partial class OrderAddPanel
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
			this.NoteTextBox = new System.Windows.Forms.TextBox();
			this.EmployeeDataGridView = new System.Windows.Forms.DataGridView();
			this.AddOrderButton = new System.Windows.Forms.Button();
			this.ServicesDataGridView = new System.Windows.Forms.DataGridView();
			this.AddedServicesToOrderDataGridView = new System.Windows.Forms.DataGridView();
			this.AddServiceToOrderButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.ServicesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.AddedServicesToOrderDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// NoteTextBox
			// 
			this.NoteTextBox.Location = new System.Drawing.Point(39, 411);
			this.NoteTextBox.Name = "NoteTextBox";
			this.NoteTextBox.Size = new System.Drawing.Size(125, 27);
			this.NoteTextBox.TabIndex = 0;
			this.NoteTextBox.Text = "Примечание";
			// 
			// EmployeeDataGridView
			// 
			this.EmployeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.EmployeeDataGridView.Location = new System.Drawing.Point(28, 116);
			this.EmployeeDataGridView.Name = "EmployeeDataGridView";
			this.EmployeeDataGridView.RowHeadersWidth = 51;
			this.EmployeeDataGridView.RowTemplate.Height = 29;
			this.EmployeeDataGridView.Size = new System.Drawing.Size(401, 234);
			this.EmployeeDataGridView.TabIndex = 1;
			this.EmployeeDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.EmployeeDataGridView_CellMouseClick);
			// 
			// AddOrderButton
			// 
			this.AddOrderButton.Location = new System.Drawing.Point(1063, 582);
			this.AddOrderButton.Name = "AddOrderButton";
			this.AddOrderButton.Size = new System.Drawing.Size(94, 29);
			this.AddOrderButton.TabIndex = 2;
			this.AddOrderButton.Text = "Добавить";
			this.AddOrderButton.UseVisualStyleBackColor = true;
			this.AddOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
			// 
			// ServicesDataGridView
			// 
			this.ServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ServicesDataGridView.Location = new System.Drawing.Point(457, 116);
			this.ServicesDataGridView.Name = "ServicesDataGridView";
			this.ServicesDataGridView.RowHeadersWidth = 51;
			this.ServicesDataGridView.RowTemplate.Height = 29;
			this.ServicesDataGridView.Size = new System.Drawing.Size(336, 234);
			this.ServicesDataGridView.TabIndex = 3;
			this.ServicesDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.ServicesDataGridView_CellMouseClick);
			// 
			// AddedServicesToOrderDataGridView
			// 
			this.AddedServicesToOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.AddedServicesToOrderDataGridView.Location = new System.Drawing.Point(857, 116);
			this.AddedServicesToOrderDataGridView.Name = "AddedServicesToOrderDataGridView";
			this.AddedServicesToOrderDataGridView.RowHeadersWidth = 51;
			this.AddedServicesToOrderDataGridView.RowTemplate.Height = 29;
			this.AddedServicesToOrderDataGridView.Size = new System.Drawing.Size(300, 234);
			this.AddedServicesToOrderDataGridView.TabIndex = 4;
			// 
			// AddServiceToOrderButton
			// 
			this.AddServiceToOrderButton.Location = new System.Drawing.Point(625, 372);
			this.AddServiceToOrderButton.Name = "AddServiceToOrderButton";
			this.AddServiceToOrderButton.Size = new System.Drawing.Size(168, 29);
			this.AddServiceToOrderButton.TabIndex = 5;
			this.AddServiceToOrderButton.Text = "Добавить в заказ";
			this.AddServiceToOrderButton.UseVisualStyleBackColor = true;
			this.AddServiceToOrderButton.Click += new System.EventHandler(this.AddServiceToOrderButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(28, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 20);
			this.label1.TabIndex = 6;
			this.label1.Text = "Исполнители";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(457, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(55, 20);
			this.label2.TabIndex = 7;
			this.label2.Text = "Услуги";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(857, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(154, 20);
			this.label3.TabIndex = 8;
			this.label3.Text = "Добавленные услуги";
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(298, 372);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(94, 29);
			this.UpdateButton.TabIndex = 9;
			this.UpdateButton.Text = "Обновить";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(335, 84);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(94, 29);
			this.SearchButton.TabIndex = 10;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(136, 83);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(193, 27);
			this.SearchTextBox.TabIndex = 11;
			this.SearchTextBox.Text = "Поиск";
			// 
			// OrderAddPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1231, 648);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddServiceToOrderButton);
			this.Controls.Add(this.AddedServicesToOrderDataGridView);
			this.Controls.Add(this.ServicesDataGridView);
			this.Controls.Add(this.AddOrderButton);
			this.Controls.Add(this.EmployeeDataGridView);
			this.Controls.Add(this.NoteTextBox);
			this.Name = "OrderAddPanel";
			this.Text = "OrderAddPanel";
			this.Load += new System.EventHandler(this.OrderAddPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.EmployeeDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.ServicesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.AddedServicesToOrderDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private TextBox NoteTextBox;
		private DataGridView EmployeeDataGridView;
		private Button AddOrderButton;
		private DataGridView ServicesDataGridView;
		private DataGridView AddedServicesToOrderDataGridView;
		private Button AddServiceToOrderButton;
		private Label label1;
		private Label label2;
		private Label label3;
		private Button UpdateButton;
		private Button SearchButton;
		private TextBox SearchTextBox;
	}
}