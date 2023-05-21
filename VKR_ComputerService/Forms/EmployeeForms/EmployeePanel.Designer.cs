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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            OrdersInPlanDataGridView = new DataGridView();
            OrdersAtWorkDataGridView = new DataGridView();
            OrderServicesDataGridView = new DataGridView();
            OrdersIsDoneDataGridView = new DataGridView();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)OrdersInPlanDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersAtWorkDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderServicesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrdersIsDoneDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(102, 15);
            label1.TabIndex = 2;
            label1.Text = "План заказов";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(684, 19);
            label2.Name = "label2";
            label2.Size = new Size(132, 15);
            label2.TabIndex = 3;
            label2.Text = "Активные заказы";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(12, 331);
            label3.Name = "label3";
            label3.Size = new Size(108, 15);
            label3.TabIndex = 6;
            label3.Text = "Услуги заказа";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(644, 331);
            label4.Name = "label4";
            label4.Size = new Size(101, 15);
            label4.TabIndex = 11;
            label4.Text = "Завершенные";
            label4.Click += label4_Click;
            // 
            // OrdersInPlanDataGridView
            // 
            OrdersInPlanDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            OrdersInPlanDataGridView.BackgroundColor = Color.White;
            OrdersInPlanDataGridView.ColumnHeadersHeight = 35;
            OrdersInPlanDataGridView.Location = new Point(12, 36);
            OrdersInPlanDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersInPlanDataGridView.Name = "OrdersInPlanDataGridView";
            OrdersInPlanDataGridView.RowHeadersVisible = false;
            OrdersInPlanDataGridView.RowHeadersWidth = 51;
            OrdersInPlanDataGridView.RowTemplate.Height = 35;
            OrdersInPlanDataGridView.Size = new Size(520, 250);
            OrdersInPlanDataGridView.TabIndex = 12;
            OrdersInPlanDataGridView.CellMouseClick += OrdersInPlanDataGridView_CellMouseClick;
            // 
            // OrdersAtWorkDataGridView
            // 
            OrdersAtWorkDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            OrdersAtWorkDataGridView.BackgroundColor = Color.White;
            OrdersAtWorkDataGridView.ColumnHeadersHeight = 35;
            OrdersAtWorkDataGridView.Location = new Point(644, 36);
            OrdersAtWorkDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersAtWorkDataGridView.Name = "OrdersAtWorkDataGridView";
            OrdersAtWorkDataGridView.RowHeadersVisible = false;
            OrdersAtWorkDataGridView.RowHeadersWidth = 51;
            OrdersAtWorkDataGridView.RowTemplate.Height = 35;
            OrdersAtWorkDataGridView.Size = new Size(517, 250);
            OrdersAtWorkDataGridView.TabIndex = 13;
            OrdersAtWorkDataGridView.CellMouseClick += OrdersAtWorkDataGridView_CellMouseClick;
            // 
            // OrderServicesDataGridView
            // 
            OrderServicesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            OrderServicesDataGridView.BackgroundColor = Color.White;
            OrderServicesDataGridView.ColumnHeadersHeight = 35;
            OrderServicesDataGridView.Location = new Point(12, 348);
            OrderServicesDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrderServicesDataGridView.Name = "OrderServicesDataGridView";
            OrderServicesDataGridView.RowHeadersVisible = false;
            OrderServicesDataGridView.RowHeadersWidth = 51;
            OrderServicesDataGridView.RowTemplate.Height = 35;
            OrderServicesDataGridView.Size = new Size(520, 306);
            OrderServicesDataGridView.TabIndex = 14;
            // 
            // OrdersIsDoneDataGridView
            // 
            OrdersIsDoneDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            OrdersIsDoneDataGridView.BackgroundColor = Color.White;
            OrdersIsDoneDataGridView.ColumnHeadersHeight = 35;
            OrdersIsDoneDataGridView.Location = new Point(644, 348);
            OrdersIsDoneDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersIsDoneDataGridView.Name = "OrdersIsDoneDataGridView";
            OrdersIsDoneDataGridView.RowHeadersVisible = false;
            OrdersIsDoneDataGridView.RowHeadersWidth = 51;
            OrdersIsDoneDataGridView.RowTemplate.Height = 35;
            OrdersIsDoneDataGridView.Size = new Size(520, 306);
            OrdersIsDoneDataGridView.TabIndex = 15;
            OrdersIsDoneDataGridView.CellMouseClick += OrdersIsDoneDataGridView_CellMouseClick;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(1051, 294);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(109, 36);
            materialButton1.TabIndex = 16;
            materialButton1.Text = "Завершить";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += MoveToDoneButton_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSize = false;
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.FlatStyle = FlatStyle.Popup;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(538, 49);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(99, 52);
            materialButton2.TabIndex = 17;
            materialButton2.Text = "Перевести в активные =>";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += MoveToAtWorkButton_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSize = false;
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.FlatStyle = FlatStyle.Popup;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(539, 204);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(99, 61);
            materialButton3.TabIndex = 18;
            materialButton3.Text = "<=  Перевести в план";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += MoveToPlanButton_Click;
            // 
            // EmployeePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1173, 665);
            Controls.Add(materialButton3);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(OrdersIsDoneDataGridView);
            Controls.Add(OrderServicesDataGridView);
            Controls.Add(OrdersAtWorkDataGridView);
            Controls.Add(OrdersInPlanDataGridView);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "EmployeePanel";
            Text = "EmployeePanel";
            Load += EmployeePanel_Load;
            ((System.ComponentModel.ISupportInitialize)OrdersInPlanDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersAtWorkDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderServicesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrdersIsDoneDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView OrdersInPlanDataGridView;
        private DataGridView OrdersAtWorkDataGridView;
        private DataGridView OrderServicesDataGridView;
        private DataGridView OrdersIsDoneDataGridView;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}