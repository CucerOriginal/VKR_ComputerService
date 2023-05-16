namespace VKR_ComputerService.Forms.AdminForms
{
    partial class UsersPanel
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
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxSearch = new MaterialSkin.Controls.MaterialTextBox2();
            label3 = new Label();
            UsersDataGridView = new DataGridView();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialButton3 = new MaterialSkin.Controls.MaterialButton();
            materialButton4 = new MaterialSkin.Controls.MaterialButton();
            materialButton5 = new MaterialSkin.Controls.MaterialButton();
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 67);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Пользователи";
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(472, 25);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MaximumSize = new Size(55, 25);
            materialButton1.MinimumSize = new Size(0, 5);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(55, 25);
            materialButton1.TabIndex = 27;
            materialButton1.Text = "Найти";
            materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton1.UseAccentColor = false;
            materialButton1.UseVisualStyleBackColor = true;
            materialButton1.Click += SearchButton_Click;
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
            materialTextBoxSearch.Location = new Point(169, 8);
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
            materialTextBoxSearch.Size = new Size(286, 48);
            materialTextBoxSearch.TabIndex = 28;
            materialTextBoxSearch.TabStop = false;
            materialTextBoxSearch.TextAlign = HorizontalAlignment.Left;
            materialTextBoxSearch.TrailingIcon = null;
            materialTextBoxSearch.UseSystemPasswordChar = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oldtimer", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(112, 31);
            label3.Name = "label3";
            label3.Size = new Size(41, 12);
            label3.TabIndex = 30;
            label3.Text = "Поиск";
            // 
            // UsersDataGridView
            // 
            UsersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            UsersDataGridView.BackgroundColor = Color.White;
            UsersDataGridView.ColumnHeadersHeight = 35;
            UsersDataGridView.Location = new Point(12, 84);
            UsersDataGridView.Margin = new Padding(3, 2, 3, 2);
            UsersDataGridView.Name = "UsersDataGridView";
            UsersDataGridView.RowHeadersVisible = false;
            UsersDataGridView.RowHeadersWidth = 51;
            UsersDataGridView.RowTemplate.Height = 35;
            UsersDataGridView.Size = new Size(631, 297);
            UsersDataGridView.TabIndex = 31;
            UsersDataGridView.CellMouseClick += UsersDataGridView_CellMouseClick;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.FlatStyle = FlatStyle.Popup;
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(13, 399);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(100, 36);
            materialButton2.TabIndex = 32;
            materialButton2.Text = "Добавить";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += AddUserButton_Click;
            // 
            // materialButton3
            // 
            materialButton3.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton3.Depth = 0;
            materialButton3.FlatStyle = FlatStyle.Popup;
            materialButton3.HighEmphasis = true;
            materialButton3.Icon = null;
            materialButton3.Location = new Point(121, 399);
            materialButton3.Margin = new Padding(4, 6, 4, 6);
            materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton3.Name = "materialButton3";
            materialButton3.NoAccentTextColor = Color.Empty;
            materialButton3.Size = new Size(101, 36);
            materialButton3.TabIndex = 33;
            materialButton3.Text = "Изменить";
            materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton3.UseAccentColor = false;
            materialButton3.UseVisualStyleBackColor = true;
            materialButton3.Click += DeleteUserButton_Click;
            // 
            // materialButton4
            // 
            materialButton4.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton4.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton4.Depth = 0;
            materialButton4.FlatStyle = FlatStyle.Popup;
            materialButton4.HighEmphasis = true;
            materialButton4.Icon = null;
            materialButton4.Location = new Point(230, 399);
            materialButton4.Margin = new Padding(4, 6, 4, 6);
            materialButton4.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton4.Name = "materialButton4";
            materialButton4.NoAccentTextColor = Color.Empty;
            materialButton4.Size = new Size(91, 36);
            materialButton4.TabIndex = 34;
            materialButton4.Text = "Удалить";
            materialButton4.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton4.UseAccentColor = false;
            materialButton4.UseVisualStyleBackColor = true;
            materialButton4.Click += UpdateDataButton_Click;
            // 
            // materialButton5
            // 
            materialButton5.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton5.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton5.Depth = 0;
            materialButton5.FlatStyle = FlatStyle.Popup;
            materialButton5.HighEmphasis = true;
            materialButton5.Icon = null;
            materialButton5.Location = new Point(543, 399);
            materialButton5.Margin = new Padding(4, 6, 4, 6);
            materialButton5.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton5.Name = "materialButton5";
            materialButton5.NoAccentTextColor = Color.Empty;
            materialButton5.Size = new Size(100, 36);
            materialButton5.TabIndex = 35;
            materialButton5.Text = "Обновить";
            materialButton5.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton5.UseAccentColor = false;
            materialButton5.UseVisualStyleBackColor = true;
            materialButton5.Click += UpdateButton_Click;
            // 
            // UsersPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(655, 450);
            Controls.Add(materialButton5);
            Controls.Add(materialButton4);
            Controls.Add(materialButton3);
            Controls.Add(materialButton2);
            Controls.Add(UsersDataGridView);
            Controls.Add(label3);
            Controls.Add(materialTextBoxSearch);
            Controls.Add(materialButton1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UsersPanel";
            Text = "UsersPanel";
            Load += UsersPanel_Load;
            ((System.ComponentModel.ISupportInitialize)UsersDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxSearch;
        private Label label3;
        private DataGridView UsersDataGridView;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialButton materialButton4;
        private MaterialSkin.Controls.MaterialButton materialButton5;
    }
}