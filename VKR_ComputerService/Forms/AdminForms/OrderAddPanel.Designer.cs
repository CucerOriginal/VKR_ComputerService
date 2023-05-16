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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            materialTextBoxSearch = new MaterialSkin.Controls.MaterialTextBox2();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialMultiLineTextBoxNote = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            label5 = new Label();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            EmployeeDataGridView = new DataGridView();
            ServicesDataGridView = new DataGridView();
            AddedServicesToOrderDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ServicesDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AddedServicesToOrderDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(15, 86);
            label1.Name = "label1";
            label1.Size = new Size(97, 14);
            label1.TabIndex = 6;
            label1.Text = "Исполнители";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(372, 87);
            label2.Name = "label2";
            label2.Size = new Size(55, 14);
            label2.TabIndex = 7;
            label2.Text = "Услуги";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(802, 86);
            label3.Name = "label3";
            label3.Size = new Size(153, 14);
            label3.TabIndex = 8;
            label3.Text = "Добавленные услуги";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oldtimer", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(301, 43);
            label4.Name = "label4";
            label4.Size = new Size(41, 12);
            label4.TabIndex = 12;
            label4.Text = "Поиск";
            // 
            // materialTextBoxSearch
            // 
            materialTextBoxSearch.AnimateReadOnly = false;
            materialTextBoxSearch.BackgroundImageLayout = ImageLayout.None;
            materialTextBoxSearch.CharacterCasing = CharacterCasing.Normal;
            materialTextBoxSearch.Depth = 0;
            materialTextBoxSearch.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            materialTextBoxSearch.HideSelection = true;
            materialTextBoxSearch.LeadingIcon = null;
            materialTextBoxSearch.Location = new Point(348, 15);
            materialTextBoxSearch.MaxLength = 32767;
            materialTextBoxSearch.MouseState = MaterialSkin.MouseState.OUT;
            materialTextBoxSearch.Name = "materialTextBoxSearch";
            materialTextBoxSearch.PasswordChar = '\0';
            materialTextBoxSearch.PrefixSuffixText = null;
            materialTextBoxSearch.ReadOnly = false;
            materialTextBoxSearch.RightToLeft = RightToLeft.No;
            materialTextBoxSearch.SelectedText = "";
            materialTextBoxSearch.SelectionLength = 0;
            materialTextBoxSearch.SelectionStart = 0;
            materialTextBoxSearch.ShortcutsEnabled = true;
            materialTextBoxSearch.Size = new Size(417, 48);
            materialTextBoxSearch.TabIndex = 13;
            materialTextBoxSearch.TabStop = false;
            materialTextBoxSearch.TextAlign = HorizontalAlignment.Left;
            materialTextBoxSearch.TrailingIcon = null;
            materialTextBoxSearch.UseSystemPasswordChar = false;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.FlatStyle = FlatStyle.Flat;
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(791, 27);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(71, 36);
            materialButton1.TabIndex = 14;
            materialButton1.Text = "Найти";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += SearchButton_Click;
            // 
            // materialMultiLineTextBoxNote
            // 
            materialMultiLineTextBoxNote.AnimateReadOnly = false;
            materialMultiLineTextBoxNote.BackgroundImageLayout = ImageLayout.None;
            materialMultiLineTextBoxNote.CharacterCasing = CharacterCasing.Normal;
            materialMultiLineTextBoxNote.Depth = 0;
            materialMultiLineTextBoxNote.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            materialMultiLineTextBoxNote.HideSelection = true;
            materialMultiLineTextBoxNote.Location = new Point(15, 322);
            materialMultiLineTextBoxNote.MaxLength = 32767;
            materialMultiLineTextBoxNote.MouseState = MaterialSkin.MouseState.OUT;
            materialMultiLineTextBoxNote.Name = "materialMultiLineTextBoxNote";
            materialMultiLineTextBoxNote.PasswordChar = '\0';
            materialMultiLineTextBoxNote.ReadOnly = false;
            materialMultiLineTextBoxNote.ScrollBars = ScrollBars.None;
            materialMultiLineTextBoxNote.SelectedText = "";
            materialMultiLineTextBoxNote.SelectionLength = 0;
            materialMultiLineTextBoxNote.SelectionStart = 0;
            materialMultiLineTextBoxNote.ShortcutsEnabled = true;
            materialMultiLineTextBoxNote.Size = new Size(250, 129);
            materialMultiLineTextBoxNote.TabIndex = 15;
            materialMultiLineTextBoxNote.TabStop = false;
            materialMultiLineTextBoxNote.TextAlign = HorizontalAlignment.Left;
            materialMultiLineTextBoxNote.UseSystemPasswordChar = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(15, 305);
            label5.Name = "label5";
            label5.Size = new Size(90, 14);
            label5.TabIndex = 16;
            label5.Text = "Примечание";
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(633, 311);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(163, 36);
            materialButton2.TabIndex = 17;
            materialButton2.Text = "Добавить в заказ";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += AddServiceToOrderButton_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.FlatStyle = FlatStyle.Popup;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(907, 415);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(100, 36);
            materialButton3.TabIndex = 18;
            materialButton3.Text = "Обновить";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += UpdateButton_Click;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.FlatStyle = FlatStyle.Popup;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(1015, 415);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(100, 36);
            materialButton4.TabIndex = 19;
            materialButton4.Text = "Добавить";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += AddOrderButton_Click;
            // 
            // EmployeeDataGridView
            // 
            EmployeeDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            EmployeeDataGridView.BackgroundColor = Color.White;
            EmployeeDataGridView.ColumnHeadersHeight = 35;
            EmployeeDataGridView.Location = new Point(15, 102);
            EmployeeDataGridView.Margin = new Padding(3, 2, 3, 2);
            EmployeeDataGridView.Name = "EmployeeDataGridView";
            EmployeeDataGridView.RowHeadersVisible = false;
            EmployeeDataGridView.RowHeadersWidth = 51;
            EmployeeDataGridView.RowTemplate.Height = 35;
            EmployeeDataGridView.Size = new Size(351, 201);
            EmployeeDataGridView.TabIndex = 42;
            EmployeeDataGridView.CellMouseClick += EmployeeDataGridView_CellMouseClick;
            // 
            // ServicesDataGridView
            // 
            ServicesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            ServicesDataGridView.BackgroundColor = Color.White;
            ServicesDataGridView.ColumnHeadersHeight = 35;
            ServicesDataGridView.Location = new Point(372, 102);
            ServicesDataGridView.Margin = new Padding(3, 2, 3, 2);
            ServicesDataGridView.Name = "ServicesDataGridView";
            ServicesDataGridView.RowHeadersVisible = false;
            ServicesDataGridView.RowHeadersWidth = 51;
            ServicesDataGridView.RowTemplate.Height = 35;
            ServicesDataGridView.Size = new Size(424, 201);
            ServicesDataGridView.TabIndex = 43;
            ServicesDataGridView.CellMouseClick += ServicesDataGridView_CellMouseClick;
            // 
            // AddedServicesToOrderDataGridView
            // 
            AddedServicesToOrderDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            AddedServicesToOrderDataGridView.BackgroundColor = Color.White;
            AddedServicesToOrderDataGridView.ColumnHeadersHeight = 35;
            AddedServicesToOrderDataGridView.Location = new Point(802, 104);
            AddedServicesToOrderDataGridView.Margin = new Padding(3, 2, 3, 2);
            AddedServicesToOrderDataGridView.Name = "AddedServicesToOrderDataGridView";
            AddedServicesToOrderDataGridView.RowHeadersVisible = false;
            AddedServicesToOrderDataGridView.RowHeadersWidth = 51;
            AddedServicesToOrderDataGridView.RowTemplate.Height = 35;
            AddedServicesToOrderDataGridView.Size = new Size(314, 201);
            AddedServicesToOrderDataGridView.TabIndex = 44;
            // 
            // OrderAddPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1128, 463);
            Controls.Add(AddedServicesToOrderDataGridView);
            Controls.Add(ServicesDataGridView);
            Controls.Add(EmployeeDataGridView);
            Controls.Add(materialButton4);
            Controls.Add(materialButton3);
            Controls.Add(materialButton2);
            Controls.Add(label5);
            Controls.Add(materialMultiLineTextBoxNote);
            Controls.Add(materialButton1);
            Controls.Add(materialTextBoxSearch);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrderAddPanel";
            Text = "Добавить заказ";
            Load += OrderAddPanel_Load;
            ((System.ComponentModel.ISupportInitialize)EmployeeDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)ServicesDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)AddedServicesToOrderDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxSearch;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 materialMultiLineTextBoxNote;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private DataGridView EmployeeDataGridView;
        private DataGridView ServicesDataGridView;
        private DataGridView AddedServicesToOrderDataGridView;
    }
}