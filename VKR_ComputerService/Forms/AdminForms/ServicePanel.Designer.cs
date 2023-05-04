namespace VKR_ComputerService.Forms.AdminForms
{
	partial class ServicePanel
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
			this.ServicesDataGridView = new System.Windows.Forms.DataGridView();
			this.AddServiceNameTextBox = new System.Windows.Forms.TextBox();
			this.AddServiceCostTextBox = new System.Windows.Forms.TextBox();
			this.AddServiceButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.ServicesDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// ServicesDataGridView
			// 
			this.ServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.ServicesDataGridView.Location = new System.Drawing.Point(102, 80);
			this.ServicesDataGridView.Name = "ServicesDataGridView";
			this.ServicesDataGridView.RowHeadersWidth = 51;
			this.ServicesDataGridView.RowTemplate.Height = 29;
			this.ServicesDataGridView.Size = new System.Drawing.Size(681, 335);
			this.ServicesDataGridView.TabIndex = 0;
			// 
			// AddServiceNameTextBox
			// 
			this.AddServiceNameTextBox.Location = new System.Drawing.Point(197, 483);
			this.AddServiceNameTextBox.Name = "AddServiceNameTextBox";
			this.AddServiceNameTextBox.Size = new System.Drawing.Size(125, 27);
			this.AddServiceNameTextBox.TabIndex = 1;
			// 
			// AddServiceCostTextBox
			// 
			this.AddServiceCostTextBox.Location = new System.Drawing.Point(382, 483);
			this.AddServiceCostTextBox.Name = "AddServiceCostTextBox";
			this.AddServiceCostTextBox.Size = new System.Drawing.Size(125, 27);
			this.AddServiceCostTextBox.TabIndex = 2;
			// 
			// AddServiceButton
			// 
			this.AddServiceButton.Location = new System.Drawing.Point(583, 483);
			this.AddServiceButton.Name = "AddServiceButton";
			this.AddServiceButton.Size = new System.Drawing.Size(94, 29);
			this.AddServiceButton.TabIndex = 3;
			this.AddServiceButton.Text = "Добавить";
			this.AddServiceButton.UseVisualStyleBackColor = true;
			this.AddServiceButton.Click += new System.EventHandler(this.AddServiceButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(197, 460);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 20);
			this.label1.TabIndex = 4;
			this.label1.Text = "Название";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(382, 460);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Цена";
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(799, 285);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(94, 29);
			this.SaveButton.TabIndex = 7;
			this.SaveButton.Text = "Сохранить";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// ServicePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(905, 555);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.AddServiceButton);
			this.Controls.Add(this.AddServiceCostTextBox);
			this.Controls.Add(this.AddServiceNameTextBox);
			this.Controls.Add(this.ServicesDataGridView);
			this.Name = "ServicePanel";
			this.Text = "ServicePanel";
			this.Load += new System.EventHandler(this.ServicePanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.ServicesDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView ServicesDataGridView;
		private TextBox AddServiceNameTextBox;
		private TextBox AddServiceCostTextBox;
		private Button AddServiceButton;
		private Label label1;
		private Label label2;
		private Button SaveButton;
	}
}