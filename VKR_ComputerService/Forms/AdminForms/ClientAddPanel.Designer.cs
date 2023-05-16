namespace VKR_ComputerService.Forms.AdminForms
{
    partial class ClientAddPanel
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
            SecondnameTextBox = new TextBox();
            NameTextBox = new TextBox();
            MiddlenameTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            BirthdateTimePicker = new DateTimePicker();
            label1 = new Label();
            label6 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            materialButtonAddClient = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // SecondnameTextBox
            // 
            SecondnameTextBox.Location = new Point(12, 25);
            SecondnameTextBox.Margin = new Padding(3, 2, 3, 2);
            SecondnameTextBox.Name = "SecondnameTextBox";
            SecondnameTextBox.Size = new Size(151, 23);
            SecondnameTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 77);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(151, 23);
            NameTextBox.TabIndex = 1;
            // 
            // MiddlenameTextBox
            // 
            MiddlenameTextBox.Location = new Point(12, 128);
            MiddlenameTextBox.Margin = new Padding(3, 2, 3, 2);
            MiddlenameTextBox.Name = "MiddlenameTextBox";
            MiddlenameTextBox.Size = new Size(151, 23);
            MiddlenameTextBox.TabIndex = 2;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(12, 176);
            PhoneTextBox.Margin = new Padding(3, 2, 3, 2);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(151, 23);
            PhoneTextBox.TabIndex = 3;
            // 
            // BirthdateTimePicker
            // 
            BirthdateTimePicker.Location = new Point(12, 226);
            BirthdateTimePicker.Margin = new Padding(3, 2, 3, 2);
            BirthdateTimePicker.Name = "BirthdateTimePicker";
            BirthdateTimePicker.Size = new Size(151, 23);
            BirthdateTimePicker.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 14);
            label1.TabIndex = 6;
            label1.Text = "Фамилия";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label6.ForeColor = SystemColors.MenuHighlight;
            label6.Location = new Point(12, 61);
            label6.Name = "label6";
            label6.Size = new Size(34, 14);
            label6.TabIndex = 11;
            label6.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(12, 112);
            label2.Name = "label2";
            label2.Size = new Size(75, 14);
            label2.TabIndex = 12;
            label2.Text = "Отчество";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(13, 160);
            label3.Name = "label3";
            label3.Size = new Size(66, 14);
            label3.TabIndex = 13;
            label3.Text = "Телефон";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(12, 210);
            label4.Name = "label4";
            label4.Size = new Size(113, 14);
            label4.TabIndex = 14;
            label4.Text = "Дата рождения";
            // 
            // materialButtonAddClient
            // 
            materialButtonAddClient.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonAddClient.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonAddClient.Depth = 0;
            materialButtonAddClient.FlatStyle = FlatStyle.Popup;
            materialButtonAddClient.HighEmphasis = true;
            materialButtonAddClient.Icon = null;
            materialButtonAddClient.Location = new Point(63, 265);
            materialButtonAddClient.Margin = new Padding(4, 6, 4, 6);
            materialButtonAddClient.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonAddClient.Name = "materialButtonAddClient";
            materialButtonAddClient.NoAccentTextColor = Color.Empty;
            materialButtonAddClient.Size = new Size(100, 36);
            materialButtonAddClient.TabIndex = 15;
            materialButtonAddClient.Text = "Добавить";
            materialButtonAddClient.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonAddClient.UseAccentColor = false;
            materialButtonAddClient.UseVisualStyleBackColor = true;
            materialButtonAddClient.Click += AddClientButton_Click;
            // 
            // ClientAddPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(177, 316);
            Controls.Add(materialButtonAddClient);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(BirthdateTimePicker);
            Controls.Add(PhoneTextBox);
            Controls.Add(MiddlenameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(SecondnameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "ClientAddPanel";
            Text = "Добавить";
            Load += ClientAddPanel_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SecondnameTextBox;
        private TextBox NameTextBox;
        private TextBox MiddlenameTextBox;
        private TextBox PhoneTextBox;
        private DateTimePicker BirthdateTimePicker;
        private Label label1;
        private Label label6;
        private Label label2;
        private Label label3;
        private Label label4;
        private MaterialSkin.Controls.MaterialButton materialButtonAddClient;
    }
}