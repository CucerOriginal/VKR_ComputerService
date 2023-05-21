namespace VKR_ComputerService.Forms.AdminForms
{
    partial class UserAddPanel
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
            PasswordTextBox = new TextBox();
            PhoneTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            materialButtonUserAdd = new MaterialSkin.Controls.MaterialButton();
            SuspendLayout();
            // 
            // SecondnameTextBox
            // 
            SecondnameTextBox.Location = new Point(12, 28);
            SecondnameTextBox.Margin = new Padding(3, 2, 3, 2);
            SecondnameTextBox.Name = "SecondnameTextBox";
            SecondnameTextBox.Size = new Size(110, 23);
            SecondnameTextBox.TabIndex = 0;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(12, 79);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(110, 23);
            NameTextBox.TabIndex = 1;
            // 
            // MiddlenameTextBox
            // 
            MiddlenameTextBox.Location = new Point(12, 139);
            MiddlenameTextBox.Margin = new Padding(3, 2, 3, 2);
            MiddlenameTextBox.Name = "MiddlenameTextBox";
            MiddlenameTextBox.Size = new Size(110, 23);
            MiddlenameTextBox.TabIndex = 2;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(12, 252);
            PasswordTextBox.Margin = new Padding(3, 2, 3, 2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(110, 23);
            PasswordTextBox.TabIndex = 3;
            // 
            // PhoneTextBox
            // 
            PhoneTextBox.Location = new Point(12, 199);
            PhoneTextBox.Margin = new Padding(3, 2, 3, 2);
            PhoneTextBox.Name = "PhoneTextBox";
            PhoneTextBox.Size = new Size(110, 23);
            PhoneTextBox.TabIndex = 4;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(12, 63);
            label2.Name = "label2";
            label2.Size = new Size(34, 14);
            label2.TabIndex = 7;
            label2.Text = "Имя";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.MenuHighlight;
            label3.Location = new Point(12, 114);
            label3.Name = "label3";
            label3.Size = new Size(75, 14);
            label3.TabIndex = 8;
            label3.Text = "Отчество";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.MenuHighlight;
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(66, 14);
            label4.TabIndex = 9;
            label4.Text = "Телефон";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = SystemColors.MenuHighlight;
            label5.Location = new Point(12, 236);
            label5.Name = "label5";
            label5.Size = new Size(56, 14);
            label5.TabIndex = 10;
            label5.Text = "Пароль";
            // 
            // materialButtonUserAdd
            // 
            materialButtonUserAdd.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButtonUserAdd.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButtonUserAdd.Depth = 0;
            materialButtonUserAdd.FlatStyle = FlatStyle.Flat;
            materialButtonUserAdd.HighEmphasis = true;
            materialButtonUserAdd.Icon = null;
            materialButtonUserAdd.Location = new Point(13, 293);
            materialButtonUserAdd.Margin = new Padding(4, 6, 4, 6);
            materialButtonUserAdd.MouseState = MaterialSkin.MouseState.HOVER;
            materialButtonUserAdd.Name = "materialButtonUserAdd";
            materialButtonUserAdd.NoAccentTextColor = Color.Empty;
            materialButtonUserAdd.Size = new Size(100, 36);
            materialButtonUserAdd.TabIndex = 11;
            materialButtonUserAdd.Text = "Добавить";
            materialButtonUserAdd.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButtonUserAdd.UseAccentColor = false;
            materialButtonUserAdd.UseVisualStyleBackColor = true;
            materialButtonUserAdd.Click += AddUserButton_Click;
            // 
            // UserAddPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(136, 344);
            Controls.Add(materialButtonUserAdd);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(PhoneTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(MiddlenameTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(SecondnameTextBox);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "UserAddPanel";
            Text = "Добавить пользователя";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SecondnameTextBox;
        private TextBox NameTextBox;
        private TextBox MiddlenameTextBox;
        private TextBox PasswordTextBox;
        private TextBox PhoneTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private MaterialSkin.Controls.MaterialButton materialButtonUserAdd;
    }
}