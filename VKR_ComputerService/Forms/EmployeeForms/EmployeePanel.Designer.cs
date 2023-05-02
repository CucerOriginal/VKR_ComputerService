namespace VKR_ComputerService.Forms
{
	partial class EmployeePanel
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
			this.OrdersInPlanDataGridView = new System.Windows.Forms.DataGridView();
			this.OrdersAtWorkDataGridView = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.OrderServicesDataGridView = new System.Windows.Forms.DataGridView();
			this.label3 = new System.Windows.Forms.Label();
			this.MoveToAtWorkButton = new System.Windows.Forms.Button();
			this.MoveToPlanButton = new System.Windows.Forms.Button();
			this.MoveToDoneButton = new System.Windows.Forms.Button();
			this.OrdersIsDoneDataGridView = new System.Windows.Forms.DataGridView();
			this.label4 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.OrdersInPlanDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrdersAtWorkDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderServicesDataGridView)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.OrdersIsDoneDataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// OrdersInPlanDataGridView
			// 
			this.OrdersInPlanDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrdersInPlanDataGridView.Location = new System.Drawing.Point(24, 93);
			this.OrdersInPlanDataGridView.Name = "OrdersInPlanDataGridView";
			this.OrdersInPlanDataGridView.RowHeadersWidth = 51;
			this.OrdersInPlanDataGridView.RowTemplate.Height = 29;
			this.OrdersInPlanDataGridView.Size = new System.Drawing.Size(509, 312);
			this.OrdersInPlanDataGridView.TabIndex = 0;
			this.OrdersInPlanDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersInPlanDataGridView_CellMouseClick);
			// 
			// OrdersAtWorkDataGridView
			// 
			this.OrdersAtWorkDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrdersAtWorkDataGridView.Location = new System.Drawing.Point(802, 93);
			this.OrdersAtWorkDataGridView.Name = "OrdersAtWorkDataGridView";
			this.OrdersAtWorkDataGridView.RowHeadersWidth = 51;
			this.OrdersAtWorkDataGridView.RowTemplate.Height = 29;
			this.OrdersAtWorkDataGridView.Size = new System.Drawing.Size(509, 312);
			this.OrdersAtWorkDataGridView.TabIndex = 1;
			this.OrdersAtWorkDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersAtWorkDataGridView_CellMouseClick);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(24, 70);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(103, 20);
			this.label1.TabIndex = 2;
			this.label1.Text = "План заказов";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(802, 70);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(129, 20);
			this.label2.TabIndex = 3;
			this.label2.Text = "Активные заказы";
			// 
			// OrderServicesDataGridView
			// 
			this.OrderServicesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrderServicesDataGridView.Location = new System.Drawing.Point(24, 534);
			this.OrderServicesDataGridView.Name = "OrderServicesDataGridView";
			this.OrderServicesDataGridView.RowHeadersWidth = 51;
			this.OrderServicesDataGridView.RowTemplate.Height = 29;
			this.OrderServicesDataGridView.Size = new System.Drawing.Size(509, 312);
			this.OrderServicesDataGridView.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(24, 511);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(104, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Услуги заказа";
			// 
			// MoveToAtWorkButton
			// 
			this.MoveToAtWorkButton.Location = new System.Drawing.Point(565, 143);
			this.MoveToAtWorkButton.Name = "MoveToAtWorkButton";
			this.MoveToAtWorkButton.Size = new System.Drawing.Size(213, 29);
			this.MoveToAtWorkButton.TabIndex = 7;
			this.MoveToAtWorkButton.Text = "Перевести в активные =>";
			this.MoveToAtWorkButton.UseVisualStyleBackColor = true;
			this.MoveToAtWorkButton.Click += new System.EventHandler(this.MoveToAtWorkButton_Click);
			// 
			// MoveToPlanButton
			// 
			this.MoveToPlanButton.Location = new System.Drawing.Point(565, 290);
			this.MoveToPlanButton.Name = "MoveToPlanButton";
			this.MoveToPlanButton.Size = new System.Drawing.Size(213, 29);
			this.MoveToPlanButton.TabIndex = 8;
			this.MoveToPlanButton.Text = "<= Перевести в план";
			this.MoveToPlanButton.UseVisualStyleBackColor = true;
			this.MoveToPlanButton.Click += new System.EventHandler(this.MoveToPlanButton_Click);
			// 
			// MoveToDoneButton
			// 
			this.MoveToDoneButton.Location = new System.Drawing.Point(1217, 432);
			this.MoveToDoneButton.Name = "MoveToDoneButton";
			this.MoveToDoneButton.Size = new System.Drawing.Size(94, 29);
			this.MoveToDoneButton.TabIndex = 9;
			this.MoveToDoneButton.Text = "Завершить";
			this.MoveToDoneButton.UseVisualStyleBackColor = true;
			this.MoveToDoneButton.Click += new System.EventHandler(this.MoveToDoneButton_Click);
			// 
			// OrdersIsDoneDataGridView
			// 
			this.OrdersIsDoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.OrdersIsDoneDataGridView.Location = new System.Drawing.Point(802, 534);
			this.OrdersIsDoneDataGridView.Name = "OrdersIsDoneDataGridView";
			this.OrdersIsDoneDataGridView.RowHeadersWidth = 51;
			this.OrdersIsDoneDataGridView.RowTemplate.Height = 29;
			this.OrdersIsDoneDataGridView.Size = new System.Drawing.Size(509, 312);
			this.OrdersIsDoneDataGridView.TabIndex = 10;
			this.OrdersIsDoneDataGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.OrdersIsDoneDataGridView_CellMouseClick);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(802, 511);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(107, 20);
			this.label4.TabIndex = 11;
			this.label4.Text = "Завершенные";
			this.label4.Click += new System.EventHandler(this.label4_Click);
			// 
			// EmployeePanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1341, 887);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.OrdersIsDoneDataGridView);
			this.Controls.Add(this.MoveToDoneButton);
			this.Controls.Add(this.MoveToPlanButton);
			this.Controls.Add(this.MoveToAtWorkButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.OrderServicesDataGridView);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.OrdersAtWorkDataGridView);
			this.Controls.Add(this.OrdersInPlanDataGridView);
			this.Name = "EmployeePanel";
			this.Text = "EmployeePanel";
			this.Load += new System.EventHandler(this.EmployeePanel_Load);
			((System.ComponentModel.ISupportInitialize)(this.OrdersInPlanDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrdersAtWorkDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrderServicesDataGridView)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.OrdersIsDoneDataGridView)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private DataGridView OrdersInPlanDataGridView;
		private DataGridView OrdersAtWorkDataGridView;
		private Label label1;
		private Label label2;
		private DataGridView OrderServicesDataGridView;
		private Label label3;
		private Button MoveToAtWorkButton;
		private Button MoveToPlanButton;
		private Button MoveToDoneButton;
		private DataGridView OrdersIsDoneDataGridView;
		private Label label4;
	}
}