namespace VKR_ComputerService.Forms.AdminForms
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
            ServicePanelOpenButton = new Button();
            SearchButton = new Button();
            label2 = new Label();
            SearchTextBox = new TextBox();
            UpdateOrderDataButton = new Button();
            label1 = new Label();
            OrdersAtWorkDataGridView = new DataGridView();
            CilentsPanelOpenButton = new Button();
            UserPanelOpenButton = new Button();
            OrdersPanelOpenButton = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)OrdersAtWorkDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ServicePanelOpenButton
            // 
            ServicePanelOpenButton.Location = new Point(9, 280);
            ServicePanelOpenButton.Margin = new Padding(3, 2, 3, 2);
            ServicePanelOpenButton.Name = "ServicePanelOpenButton";
            ServicePanelOpenButton.Size = new Size(124, 22);
            ServicePanelOpenButton.TabIndex = 19;
            ServicePanelOpenButton.Text = "Услуги";
            ServicePanelOpenButton.UseVisualStyleBackColor = true;
            // 
            // SearchButton
            // 
            SearchButton.Location = new Point(516, 33);
            SearchButton.Margin = new Padding(3, 2, 3, 2);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(82, 22);
            SearchButton.TabIndex = 18;
            SearchButton.Text = "Найти";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(318, 38);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 17;
            label2.Text = "Поиск";
            // 
            // SearchTextBox
            // 
            SearchTextBox.Location = new Point(367, 36);
            SearchTextBox.Margin = new Padding(3, 2, 3, 2);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.Size = new Size(143, 23);
            SearchTextBox.TabIndex = 16;
            SearchTextBox.Text = "Поиск";
            // 
            // UpdateOrderDataButton
            // 
            UpdateOrderDataButton.Location = new Point(499, 321);
            UpdateOrderDataButton.Margin = new Padding(3, 2, 3, 2);
            UpdateOrderDataButton.Name = "UpdateOrderDataButton";
            UpdateOrderDataButton.Size = new Size(82, 22);
            UpdateOrderDataButton.TabIndex = 15;
            UpdateOrderDataButton.Text = "Обновить";
            UpdateOrderDataButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(154, 42);
            label1.Name = "label1";
            label1.Size = new Size(96, 15);
            label1.TabIndex = 14;
            label1.Text = "Заказы в работе";
            // 
            // OrdersAtWorkDataGridView
            // 
            OrdersAtWorkDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersAtWorkDataGridView.Location = new Point(154, 59);
            OrdersAtWorkDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersAtWorkDataGridView.Name = "OrdersAtWorkDataGridView";
            OrdersAtWorkDataGridView.ReadOnly = true;
            OrdersAtWorkDataGridView.RowHeadersWidth = 51;
            OrdersAtWorkDataGridView.RowTemplate.Height = 29;
            OrdersAtWorkDataGridView.Size = new Size(427, 243);
            OrdersAtWorkDataGridView.TabIndex = 13;
            // 
            // CilentsPanelOpenButton
            // 
            CilentsPanelOpenButton.Location = new Point(9, 209);
            CilentsPanelOpenButton.Margin = new Padding(3, 2, 3, 2);
            CilentsPanelOpenButton.Name = "CilentsPanelOpenButton";
            CilentsPanelOpenButton.Size = new Size(124, 22);
            CilentsPanelOpenButton.TabIndex = 12;
            CilentsPanelOpenButton.Text = "Клиенты";
            CilentsPanelOpenButton.UseVisualStyleBackColor = true;
            // 
            // UserPanelOpenButton
            // 
            UserPanelOpenButton.Location = new Point(9, 144);
            UserPanelOpenButton.Margin = new Padding(3, 2, 3, 2);
            UserPanelOpenButton.Name = "UserPanelOpenButton";
            UserPanelOpenButton.Size = new Size(124, 22);
            UserPanelOpenButton.TabIndex = 11;
            UserPanelOpenButton.Text = "Пользователи";
            UserPanelOpenButton.UseVisualStyleBackColor = true;
            // 
            // OrdersPanelOpenButton
            // 
            OrdersPanelOpenButton.Location = new Point(9, 79);
            OrdersPanelOpenButton.Margin = new Padding(3, 2, 3, 2);
            OrdersPanelOpenButton.Name = "OrdersPanelOpenButton";
            OrdersPanelOpenButton.Size = new Size(124, 22);
            OrdersPanelOpenButton.TabIndex = 10;
            OrdersPanelOpenButton.Text = "Заказы";
            OrdersPanelOpenButton.UseVisualStyleBackColor = true;
            OrdersPanelOpenButton.Click += OrdersPanelOpenButton_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Oldtimer", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(601, 3);
            button1.Name = "button1";
            button1.Size = new Size(32, 27);
            button1.TabIndex = 20;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = true;
            // 
            // AdminPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 411);
            Controls.Add(button1);
            Controls.Add(ServicePanelOpenButton);
            Controls.Add(SearchButton);
            Controls.Add(label2);
            Controls.Add(SearchTextBox);
            Controls.Add(UpdateOrderDataButton);
            Controls.Add(label1);
            Controls.Add(OrdersAtWorkDataGridView);
            Controls.Add(CilentsPanelOpenButton);
            Controls.Add(UserPanelOpenButton);
            Controls.Add(OrdersPanelOpenButton);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AdminPanel";
            Text = "AdminPa";
            ((System.ComponentModel.ISupportInitialize)OrdersAtWorkDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ServicePanelOpenButton;
        private Button SearchButton;
        private Label label2;
        private TextBox SearchTextBox;
        private Button UpdateOrderDataButton;
        private Label label1;
        private DataGridView OrdersAtWorkDataGridView;
        private Button CilentsPanelOpenButton;
        private Button UserPanelOpenButton;
        private Button OrdersPanelOpenButton;
        private Button button1;
    }
}