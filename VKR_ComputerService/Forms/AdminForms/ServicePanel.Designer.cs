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
            AddServiceNameTextBox = new TextBox();
            AddServiceCostTextBox = new TextBox();
            ServicesDataGridView = new DataGridView();
            label4 = new Label();
            label3 = new Label();
            label5 = new Label();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)ServicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // AddServiceNameTextBox
            // 
            AddServiceNameTextBox.Location = new Point(153, 26);
            AddServiceNameTextBox.Margin = new Padding(3, 2, 3, 2);
            AddServiceNameTextBox.Name = "AddServiceNameTextBox";
            AddServiceNameTextBox.Size = new Size(110, 23);
            AddServiceNameTextBox.TabIndex = 1;
            // 
            // AddServiceCostTextBox
            // 
            AddServiceCostTextBox.Location = new Point(315, 26);
            AddServiceCostTextBox.Margin = new Padding(3, 2, 3, 2);
            AddServiceCostTextBox.Name = "AddServiceCostTextBox";
            AddServiceCostTextBox.Size = new Size(110, 23);
            AddServiceCostTextBox.TabIndex = 2;
            // 
            // ServicesDataGridView
            // 
            ServicesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            ServicesDataGridView.BackgroundColor = Color.White;
            ServicesDataGridView.ColumnHeadersHeight = 35;
            ServicesDataGridView.Location = new Point(12, 60);
            ServicesDataGridView.Margin = new Padding(3, 2, 3, 2);
            ServicesDataGridView.Name = "ServicesDataGridView";
            ServicesDataGridView.RowHeadersVisible = false;
            ServicesDataGridView.RowHeadersWidth = 51;
            ServicesDataGridView.RowTemplate.Height = 35;
            ServicesDataGridView.Size = new Size(615, 297);
            ServicesDataGridView.TabIndex = 42;
            ServicesDataGridView.CellMouseClick += ServicesDataGridView_CellMouseClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(23, 43);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 43;
            label4.Text = "Услуги";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(315, 9);
            label3.Name = "label3";
            label3.Size = new Size(41, 15);
            label3.TabIndex = 44;
            label3.Text = "Цена";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(153, 9);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 45;
            label5.Text = "Название";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.FlatStyle = FlatStyle.Popup;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(454, 15);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(100, 36);
            materialButton1.TabIndex = 46;
            materialButton1.Text = "Добавить";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += AddServiceButton_Click;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.FlatStyle = FlatStyle.Popup;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(535, 365);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(91, 36);
            materialButton2.TabIndex = 47;
            materialButton2.Text = "Удалить";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += DeleteButton_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.FlatStyle = FlatStyle.Popup;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(12, 365);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(109, 36);
            materialButton3.TabIndex = 48;
            materialButton3.Text = "Сохранить";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += SaveButton_Click;
            // 
            // ServicePanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 411);
            Controls.Add(materialButton3);
            Controls.Add(materialButton2);
            Controls.Add(materialButton1);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(ServicesDataGridView);
            Controls.Add(AddServiceCostTextBox);
            Controls.Add(AddServiceNameTextBox);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ServicePanel";
            Text = "ServicePanel";
            Load += ServicePanel_Load;
            ((System.ComponentModel.ISupportInitialize)ServicesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox AddServiceNameTextBox;
        private TextBox AddServiceCostTextBox;
        private DataGridView ServicesDataGridView;
        private Label label4;
        private Label label3;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
    }
}