namespace VKR_ComputerService.Forms.AdminForms
{
	partial class OrdersPanel
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
			this.OrdersDataGridView = new System.Windows.Forms.DataGridView();
			this.OrderServicesDataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.AtWorkCheckBox = new System.Windows.Forms.CheckBox();
			this.IsDoneCheckBox = new System.Windows.Forms.CheckBox();
			this.UpdateButton = new System.Windows.Forms.Button();
			this.SearchButton = new System.Windows.Forms.Button();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderServicesDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// OrdersDataGridView
			// 
			this.OrdersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrdersDataGridView.Location = new System.Drawing.Point(63, 123);
			this.OrdersDataGridView.Name = "OrdersDataGridView";
			this.OrdersDataGridView.RowHeadersWidth = 51;
			this.OrdersDataGridView.RowTemplate.Height = 29;
			this.OrdersDataGridView.Size = new System.Drawing.Size(522, 356);
			this.OrdersDataGridView.TabIndex = 0;
			this.OrdersDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersDataGridView_CellMouseClick);
			// 
			// OrderServicesDataGridView
			// 
			this.OrderServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrderServicesDataGridView.Location = new System.Drawing.Point(747, 123);
			this.OrderServicesDataGridView.Name = "OrderServicesDataGridView";
			this.OrderServicesDataGridView.RowHeadersWidth = 51;
			this.OrderServicesDataGridView.RowTemplate.Height = 29;
			this.OrderServicesDataGridView.Size = new System.Drawing.Size(442, 356);
			this.OrderServicesDataGridView.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(63, 100);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "Заказы";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(747, 100);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(125, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Услуги по заказу";
			// 
			// AtWorkCheckBox
			// 
			this.AtWorkCheckBox.AutoSize = true;
			this.AtWorkCheckBox.Location = new System.Drawing.Point(364, 55);
			this.AtWorkCheckBox.Name = "AtWorkCheckBox";
			this.AtWorkCheckBox.Size = new System.Drawing.Size(93, 24);
			this.AtWorkCheckBox.TabIndex = 4;
			this.AtWorkCheckBox.Text = "В работе";
			this.AtWorkCheckBox.UseVisualStyleBackColor = true;
			// 
			// IsDoneCheckBox
			// 
			this.IsDoneCheckBox.AutoSize = true;
			this.IsDoneCheckBox.Location = new System.Drawing.Point(491, 55);
			this.IsDoneCheckBox.Name = "IsDoneCheckBox";
			this.IsDoneCheckBox.Size = new System.Drawing.Size(90, 24);
			this.IsDoneCheckBox.TabIndex = 5;
			this.IsDoneCheckBox.Text = "Сделано";
			this.IsDoneCheckBox.UseVisualStyleBackColor = true;
			// 
			// UpdateButton
			// 
			this.UpdateButton.Location = new System.Drawing.Point(491, 499);
			this.UpdateButton.Name = "UpdateButton";
			this.UpdateButton.Size = new System.Drawing.Size(94, 29);
			this.UpdateButton.TabIndex = 6;
			this.UpdateButton.Text = "Обновить";
			this.UpdateButton.UseVisualStyleBackColor = true;
			this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
			// 
			// SearchButton
			// 
			this.SearchButton.Location = new System.Drawing.Point(458, 91);
			this.SearchButton.Name = "SearchButton";
			this.SearchButton.Size = new System.Drawing.Size(94, 29);
			this.SearchButton.TabIndex = 7;
			this.SearchButton.Text = "Найти";
			this.SearchButton.UseVisualStyleBackColor = true;
			this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
			// 
			// SearchTextBox
			// 
			this.SearchTextBox.Location = new System.Drawing.Point(209, 90);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(210, 27);
			this.SearchTextBox.TabIndex = 8;
			this.SearchTextBox.Text = "Поиск";
			// 
			// OrdersPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1247, 558);
			this.Controls.Add(this.SearchTextBox);
			this.Controls.Add(this.SearchButton);
			this.Controls.Add(this.UpdateButton);
			this.Controls.Add(this.IsDoneCheckBox);
			this.Controls.Add(this.AtWorkCheckBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OrderServicesDataGridView);
			this.Controls.Add(this.OrdersDataGridView);
			this.Name = "OrdersPanel";
			this.Text = "OrdersPanel";
			this.Load += new System.EventHandler(this.OrdersPanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.OrdersDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderServicesDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView OrdersDataGridView;
		private DataGridView OrderServicesDataGridView;
		private Label label1;
		private Label label2;
		private CheckBox AtWorkCheckBox;
		private CheckBox IsDoneCheckBox;
		private Button UpdateButton;
		private Button SearchButton;
		private TextBox SearchTextBox;
	}
}