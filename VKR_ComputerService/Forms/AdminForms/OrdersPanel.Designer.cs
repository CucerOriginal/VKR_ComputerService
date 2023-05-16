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
            label1 = new Label();
            label2 = new Label();
            OrdersDataGridView = new DataGridView();
            OrderServicesDataGridView = new DataGridView();
            materialButtonRefresh = new MaterialSkin.Controls.MaterialButton();
            Close = new MaterialSkin.Controls.MaterialButton();
            materialButton1 = new MaterialSkin.Controls.MaterialButton();
            materialTextBoxSearch = new MaterialSkin.Controls.MaterialTextBox2();
            materialCheckboxIsWork = new MaterialSkin.Controls.MaterialCheckbox();
            materialCheckboxIsDone = new MaterialSkin.Controls.MaterialCheckbox();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)OrderServicesDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 42);
            label1.Name = "label1";
            label1.Size = new Size(58, 15);
            label1.TabIndex = 2;
            label1.Text = "Заказы";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oldtimer", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(424, 43);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 3;
            label2.Text = "Услуги по заказу";
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            OrdersDataGridView.BackgroundColor = Color.White;
            OrdersDataGridView.ColumnHeadersHeight = 35;
            OrdersDataGridView.Location = new Point(12, 63);
            OrdersDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.RowHeadersVisible = false;
            OrdersDataGridView.RowHeadersWidth = 51;
            OrdersDataGridView.RowTemplate.Height = 35;
            OrdersDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrdersDataGridView.Size = new Size(406, 249);
            OrdersDataGridView.TabIndex = 22;
            OrdersDataGridView.CellMouseClick += OrdersDataGridView_CellMouseClick;
            // 
            // OrderServicesDataGridView
            // 
            OrderServicesDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            OrderServicesDataGridView.BackgroundColor = Color.White;
            OrderServicesDataGridView.ColumnHeadersHeight = 35;
            OrderServicesDataGridView.Location = new Point(424, 63);
            OrderServicesDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrderServicesDataGridView.Name = "OrderServicesDataGridView";
            OrderServicesDataGridView.RowHeadersVisible = false;
            OrderServicesDataGridView.RowHeadersWidth = 51;
            OrderServicesDataGridView.RowTemplate.Height = 35;
            OrderServicesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            OrderServicesDataGridView.Size = new Size(187, 249);
            OrderServicesDataGridView.TabIndex = 23;
            // 
            // materialButtonRefresh
            // 
            materialButtonRefresh.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonRefresh.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonRefresh.Depth = 0;
            materialButtonRefresh.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            materialButtonRefresh.HighEmphasis = true;
            materialButtonRefresh.Icon = null;
            materialButtonRefresh.Location = new Point(510, 321);
            materialButtonRefresh.Margin = new Padding(4, 6, 4, 6);
            materialButtonRefresh.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonRefresh.Name = "materialButtonRefresh";
            materialButtonRefresh.NoAccentTextColor = Color.Empty;
            materialButtonRefresh.Size = new Size(100, 36);
            materialButtonRefresh.TabIndex = 24;
            materialButtonRefresh.Text = "Обновить";
            materialButtonRefresh.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonRefresh.UseAccentColor = false;
            materialButtonRefresh.UseVisualStyleBackColor = true;
            materialButtonRefresh.Click += UpdateButton_Click;
            // 
            // Close
            // 
            Close.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            Close.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            Close.Depth = 0;
            Close.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            Close.HighEmphasis = true;
            Close.Icon = null;
            Close.Location = new Point(585, 11);
            Close.Margin = new Padding(4, 6, 4, 6);
            Close.MaximumSize = new Size(25, 36);
            Close.MinimumSize = new Size(0, 15);
            Close.MouseState = MaterialSkin.MouseState.HOVER;
            Close.Name = "Close";
            Close.NoAccentTextColor = Color.Empty;
            Close.Size = new Size(25, 36);
            Close.TabIndex = 25;
            Close.Text = "X";
            Close.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            Close.UseAccentColor = false;
            Close.UseVisualStyleBackColor = true;
            Close.Click += Close_Click;
            // 
            // materialButton1
            // 
            materialButton1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton1.Depth = 0;
            materialButton1.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            materialButton1.HighEmphasis = true;
            materialButton1.Icon = null;
            materialButton1.Location = new Point(361, 33);
            materialButton1.Margin = new Padding(4, 6, 4, 6);
            materialButton1.MaximumSize = new Size(55, 25);
            materialButton1.MinimumSize = new Size(0, 5);
            materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton1.Name = "materialButton1";
            materialButton1.NoAccentTextColor = Color.Empty;
            materialButton1.Size = new Size(55, 25);
            materialButton1.TabIndex = 26;
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
            materialTextBoxSearch.Font = new Font("Oldtimer", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextBoxSearch.HideSelection = true;
            materialTextBoxSearch.LeadingIcon = null;
            materialTextBoxSearch.Location = new Point(104, 13);
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
            materialTextBoxSearch.Size = new Size(250, 48);
            materialTextBoxSearch.TabIndex = 27;
            materialTextBoxSearch.TabStop = false;
            materialTextBoxSearch.TextAlign = HorizontalAlignment.Left;
            materialTextBoxSearch.TrailingIcon = null;
            materialTextBoxSearch.UseSystemPasswordChar = false;
            // 
            // materialCheckboxIsWork
            // 
            materialCheckboxIsWork.AutoSize = true;
            materialCheckboxIsWork.Depth = 0;
            materialCheckboxIsWork.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            materialCheckboxIsWork.Location = new Point(9, 320);
            materialCheckboxIsWork.Margin = new Padding(0);
            materialCheckboxIsWork.MouseLocation = new Point(-1, -1);
            materialCheckboxIsWork.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckboxIsWork.Name = "materialCheckboxIsWork";
            materialCheckboxIsWork.ReadOnly = false;
            materialCheckboxIsWork.Ripple = true;
            materialCheckboxIsWork.Size = new Size(101, 37);
            materialCheckboxIsWork.TabIndex = 28;
            materialCheckboxIsWork.Text = "В работе";
            materialCheckboxIsWork.UseVisualStyleBackColor = true;
            // 
            // materialCheckboxIsDone
            // 
            materialCheckboxIsDone.AutoSize = true;
            materialCheckboxIsDone.Depth = 0;
            materialCheckboxIsDone.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            materialCheckboxIsDone.Location = new Point(125, 320);
            materialCheckboxIsDone.Margin = new Padding(0);
            materialCheckboxIsDone.MouseLocation = new Point(-1, -1);
            materialCheckboxIsDone.MouseState = MaterialSkin.MouseState.HOVER;
            materialCheckboxIsDone.Name = "materialCheckboxIsDone";
            materialCheckboxIsDone.ReadOnly = false;
            materialCheckboxIsDone.Ripple = true;
            materialCheckboxIsDone.Size = new Size(99, 37);
            materialCheckboxIsDone.TabIndex = 29;
            materialCheckboxIsDone.Text = "Сделано";
            materialCheckboxIsDone.UseVisualStyleBackColor = true;
            // 
            // OrdersPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(623, 372);
            Controls.Add(materialCheckboxIsDone);
            Controls.Add(materialCheckboxIsWork);
            Controls.Add(materialTextBoxSearch);
            Controls.Add(materialButton1);
            Controls.Add(Close);
            Controls.Add(materialButtonRefresh);
            Controls.Add(OrderServicesDataGridView);
            Controls.Add(OrdersDataGridView);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "OrdersPanel";
            Text = "OrdersPanel";
            Load += OrdersPanel_Load;
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)OrderServicesDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private DataGridView OrdersDataGridView;
        private DataGridView OrderServicesDataGridView;
        private MaterialSkin.Controls.MaterialButton materialButtonRefresh;
        private MaterialSkin.Controls.MaterialButton Close;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextBoxSearch;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxIsWork;
        private MaterialSkin.Controls.MaterialCheckbox materialCheckboxIsDone;
    }
}