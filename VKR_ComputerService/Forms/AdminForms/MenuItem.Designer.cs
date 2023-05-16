namespace VKR_ComputerService.Forms
{
    partial class MenuItem
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
            panelSideMenu = new Panel();
            panelServices = new Panel();
            ShowServices = new Button();
            Services = new Button();
            panelClient = new Panel();
            ShowClients = new Button();
            Clients = new Button();
            panelUsers = new Panel();
            ShowUsers = new Button();
            Users = new Button();
            panelOrders = new Panel();
            ShowOrders = new Button();
            Orders = new Button();
            panel1 = new Panel();
            panelChildForm = new Panel();
            materialButton2 = new MaterialSkin.Controls.MaterialButton();
            materialUpdateOrderDataButton = new MaterialSkin.Controls.MaterialButton();
            materialTextSearch = new MaterialSkin.Controls.MaterialTextBox2();
            label2 = new Label();
            label1 = new Label();
            OrdersAtWorkDataGridView = new DataGridView();
            panelSideMenu.SuspendLayout();
            panelServices.SuspendLayout();
            panelClient.SuspendLayout();
            panelUsers.SuspendLayout();
            panelOrders.SuspendLayout();
            panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersAtWorkDataGridView).BeginInit();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = SystemColors.HotTrack;
            panelSideMenu.Controls.Add(panelServices);
            panelSideMenu.Controls.Add(Services);
            panelSideMenu.Controls.Add(panelClient);
            panelSideMenu.Controls.Add(Clients);
            panelSideMenu.Controls.Add(panelUsers);
            panelSideMenu.Controls.Add(Users);
            panelSideMenu.Controls.Add(panelOrders);
            panelSideMenu.Controls.Add(Orders);
            panelSideMenu.Controls.Add(panel1);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(152, 450);
            panelSideMenu.TabIndex = 11;
            // 
            // panelServices
            // 
            panelServices.BackColor = SystemColors.MenuHighlight;
            panelServices.Controls.Add(ShowServices);
            panelServices.Dock = DockStyle.Top;
            panelServices.Location = new Point(0, 407);
            panelServices.Name = "panelServices";
            panelServices.Size = new Size(135, 47);
            panelServices.TabIndex = 12;
            // 
            // ShowServices
            // 
            ShowServices.BackColor = SystemColors.MenuHighlight;
            ShowServices.Dock = DockStyle.Top;
            ShowServices.FlatAppearance.BorderSize = 0;
            ShowServices.FlatStyle = FlatStyle.Flat;
            ShowServices.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ShowServices.ForeColor = Color.Black;
            ShowServices.Location = new Point(0, 0);
            ShowServices.Name = "ShowServices";
            ShowServices.Padding = new Padding(14, 0, 0, 0);
            ShowServices.Size = new Size(135, 36);
            ShowServices.TabIndex = 17;
            ShowServices.Text = "Показать услуги";
            ShowServices.TextAlign = ContentAlignment.MiddleLeft;
            ShowServices.UseVisualStyleBackColor = false;
            ShowServices.Click += ShowServices_Click;
            // 
            // Services
            // 
            Services.BackColor = SystemColors.HotTrack;
            Services.Dock = DockStyle.Top;
            Services.FlatAppearance.BorderSize = 0;
            Services.FlatStyle = FlatStyle.Flat;
            Services.Font = new Font("Oldtimer", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Services.ForeColor = Color.Black;
            Services.Location = new Point(0, 359);
            Services.Name = "Services";
            Services.Padding = new Padding(5, 0, 0, 0);
            Services.Size = new Size(135, 48);
            Services.TabIndex = 16;
            Services.Text = "Услуги";
            Services.TextAlign = ContentAlignment.MiddleLeft;
            Services.UseVisualStyleBackColor = false;
            Services.Click += Services_Click;
            // 
            // panelClient
            // 
            panelClient.BackColor = SystemColors.MenuHighlight;
            panelClient.Controls.Add(ShowClients);
            panelClient.Dock = DockStyle.Top;
            panelClient.Location = new Point(0, 307);
            panelClient.Name = "panelClient";
            panelClient.Size = new Size(135, 52);
            panelClient.TabIndex = 12;
            // 
            // ShowClients
            // 
            ShowClients.BackColor = SystemColors.MenuHighlight;
            ShowClients.Dock = DockStyle.Top;
            ShowClients.FlatAppearance.BorderSize = 0;
            ShowClients.FlatStyle = FlatStyle.Flat;
            ShowClients.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ShowClients.ForeColor = Color.Black;
            ShowClients.Location = new Point(0, 0);
            ShowClients.Name = "ShowClients";
            ShowClients.Padding = new Padding(14, 0, 0, 0);
            ShowClients.Size = new Size(135, 36);
            ShowClients.TabIndex = 16;
            ShowClients.Text = "Показать клиентов";
            ShowClients.TextAlign = ContentAlignment.MiddleLeft;
            ShowClients.UseVisualStyleBackColor = false;
            ShowClients.Click += ShowClients_Click;
            // 
            // Clients
            // 
            Clients.BackColor = SystemColors.HotTrack;
            Clients.Dock = DockStyle.Top;
            Clients.FlatAppearance.BorderSize = 0;
            Clients.FlatStyle = FlatStyle.Flat;
            Clients.Font = new Font("Oldtimer", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Clients.ForeColor = Color.Black;
            Clients.Location = new Point(0, 259);
            Clients.Name = "Clients";
            Clients.Padding = new Padding(5, 0, 0, 0);
            Clients.Size = new Size(135, 48);
            Clients.TabIndex = 15;
            Clients.Text = "Клиенты";
            Clients.TextAlign = ContentAlignment.MiddleLeft;
            Clients.UseVisualStyleBackColor = false;
            Clients.Click += Clients_Click;
            // 
            // panelUsers
            // 
            panelUsers.BackColor = SystemColors.MenuHighlight;
            panelUsers.Controls.Add(ShowUsers);
            panelUsers.Dock = DockStyle.Top;
            panelUsers.Location = new Point(0, 216);
            panelUsers.Name = "panelUsers";
            panelUsers.Size = new Size(135, 43);
            panelUsers.TabIndex = 12;
            // 
            // ShowUsers
            // 
            ShowUsers.BackColor = SystemColors.MenuHighlight;
            ShowUsers.Dock = DockStyle.Top;
            ShowUsers.FlatAppearance.BorderSize = 0;
            ShowUsers.FlatStyle = FlatStyle.Flat;
            ShowUsers.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ShowUsers.ForeColor = Color.Black;
            ShowUsers.Location = new Point(0, 0);
            ShowUsers.Name = "ShowUsers";
            ShowUsers.Padding = new Padding(14, 0, 0, 0);
            ShowUsers.Size = new Size(135, 36);
            ShowUsers.TabIndex = 15;
            ShowUsers.Text = "Показать пользователей";
            ShowUsers.TextAlign = ContentAlignment.MiddleLeft;
            ShowUsers.UseVisualStyleBackColor = false;
            ShowUsers.Click += ShowUsers_Click;
            // 
            // Users
            // 
            Users.BackColor = SystemColors.HotTrack;
            Users.Dock = DockStyle.Top;
            Users.FlatAppearance.BorderSize = 0;
            Users.FlatStyle = FlatStyle.Flat;
            Users.Font = new Font("Oldtimer", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Users.ForeColor = Color.Black;
            Users.Location = new Point(0, 168);
            Users.Name = "Users";
            Users.Padding = new Padding(5, 0, 0, 0);
            Users.Size = new Size(135, 48);
            Users.TabIndex = 14;
            Users.Text = "Пользователи";
            Users.TextAlign = ContentAlignment.MiddleLeft;
            Users.UseVisualStyleBackColor = false;
            Users.Click += Users_Click;
            // 
            // panelOrders
            // 
            panelOrders.BackColor = SystemColors.MenuHighlight;
            panelOrders.Controls.Add(ShowOrders);
            panelOrders.Dock = DockStyle.Top;
            panelOrders.Location = new Point(0, 127);
            panelOrders.Name = "panelOrders";
            panelOrders.Size = new Size(135, 41);
            panelOrders.TabIndex = 13;
            // 
            // ShowOrders
            // 
            ShowOrders.BackColor = SystemColors.MenuHighlight;
            ShowOrders.Dock = DockStyle.Top;
            ShowOrders.FlatAppearance.BorderSize = 0;
            ShowOrders.FlatStyle = FlatStyle.Flat;
            ShowOrders.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            ShowOrders.ForeColor = Color.Black;
            ShowOrders.Location = new Point(0, 0);
            ShowOrders.Name = "ShowOrders";
            ShowOrders.Padding = new Padding(14, 0, 0, 0);
            ShowOrders.Size = new Size(135, 36);
            ShowOrders.TabIndex = 14;
            ShowOrders.Text = "Показать заказы";
            ShowOrders.TextAlign = ContentAlignment.MiddleLeft;
            ShowOrders.UseVisualStyleBackColor = false;
            ShowOrders.Click += ShowOrders_Click;
            // 
            // Orders
            // 
            Orders.BackColor = SystemColors.HotTrack;
            Orders.Dock = DockStyle.Top;
            Orders.FlatAppearance.BorderSize = 0;
            Orders.FlatStyle = FlatStyle.Flat;
            Orders.Font = new Font("Oldtimer", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Orders.ForeColor = Color.Black;
            Orders.Location = new Point(0, 79);
            Orders.Name = "Orders";
            Orders.Padding = new Padding(5, 0, 0, 0);
            Orders.Size = new Size(135, 48);
            Orders.TabIndex = 12;
            Orders.Text = "Заказы";
            Orders.TextAlign = ContentAlignment.MiddleLeft;
            Orders.UseVisualStyleBackColor = false;
            Orders.Click += Orders_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(135, 79);
            panel1.TabIndex = 12;
            // 
            // panelChildForm
            // 
            panelChildForm.Controls.Add(materialButton2);
            panelChildForm.Controls.Add(materialUpdateOrderDataButton);
            panelChildForm.Controls.Add(materialTextSearch);
            panelChildForm.Controls.Add(label2);
            panelChildForm.Controls.Add(label1);
            panelChildForm.Controls.Add(OrdersAtWorkDataGridView);
            panelChildForm.Dock = DockStyle.Right;
            panelChildForm.Location = new Point(148, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(655, 450);
            panelChildForm.TabIndex = 12;
            // 
            // materialButton2
            // 
            materialButton2.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialButton2.Depth = 0;
            materialButton2.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            materialButton2.HighEmphasis = true;
            materialButton2.Icon = null;
            materialButton2.Location = new Point(467, 32);
            materialButton2.Margin = new Padding(4, 6, 4, 6);
            materialButton2.MaximumSize = new Size(55, 25);
            materialButton2.MinimumSize = new Size(0, 5);
            materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            materialButton2.Name = "materialButton2";
            materialButton2.NoAccentTextColor = Color.Empty;
            materialButton2.Size = new Size(55, 25);
            materialButton2.TabIndex = 32;
            materialButton2.Text = "Найти";
            materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialButton2.UseAccentColor = false;
            materialButton2.UseVisualStyleBackColor = true;
            materialButton2.Click += SearchButton_Click;
            // 
            // materialUpdateOrderDataButton
            // 
            materialUpdateOrderDataButton.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            materialUpdateOrderDataButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            materialUpdateOrderDataButton.Depth = 0;
            materialUpdateOrderDataButton.HighEmphasis = true;
            materialUpdateOrderDataButton.Icon = null;
            materialUpdateOrderDataButton.Location = new Point(542, 399);
            materialUpdateOrderDataButton.Margin = new Padding(4, 6, 4, 6);
            materialUpdateOrderDataButton.MouseState = MaterialSkin.MouseState.HOVER;
            materialUpdateOrderDataButton.Name = "materialUpdateOrderDataButton";
            materialUpdateOrderDataButton.NoAccentTextColor = Color.Empty;
            materialUpdateOrderDataButton.Size = new Size(100, 36);
            materialUpdateOrderDataButton.TabIndex = 30;
            materialUpdateOrderDataButton.Text = "Обновить";
            materialUpdateOrderDataButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            materialUpdateOrderDataButton.UseAccentColor = false;
            materialUpdateOrderDataButton.UseVisualStyleBackColor = true;
            materialUpdateOrderDataButton.Click += UpdateOrderDataButton_Click;
            // 
            // materialTextSearch
            // 
            materialTextSearch.Anchor = AnchorStyles.None;
            materialTextSearch.AnimateReadOnly = false;
            materialTextSearch.BackgroundImageLayout = ImageLayout.None;
            materialTextSearch.CharacterCasing = CharacterCasing.Normal;
            materialTextSearch.Depth = 0;
            materialTextSearch.Font = new Font("Oldtimer", 12F, FontStyle.Regular, GraphicsUnit.Point);
            materialTextSearch.HideSelection = true;
            materialTextSearch.LeadingIcon = null;
            materialTextSearch.Location = new Point(192, 12);
            materialTextSearch.MaxLength = 32767;
            materialTextSearch.MouseState = MaterialSkin.MouseState.OUT;
            materialTextSearch.Name = "materialTextSearch";
            materialTextSearch.PasswordChar = '\0';
            materialTextSearch.PrefixSuffixText = null;
            materialTextSearch.ReadOnly = false;
            materialTextSearch.RightToLeft = RightToLeft.Yes;
            materialTextSearch.SelectedText = "";
            materialTextSearch.SelectionLength = 0;
            materialTextSearch.SelectionStart = 0;
            materialTextSearch.ShortcutsEnabled = true;
            materialTextSearch.Size = new Size(256, 48);
            materialTextSearch.TabIndex = 29;
            materialTextSearch.TabStop = false;
            materialTextSearch.TextAlign = HorizontalAlignment.Left;
            materialTextSearch.TrailingIcon = null;
            materialTextSearch.UseSystemPasswordChar = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Oldtimer", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.MenuHighlight;
            label2.Location = new Point(138, 37);
            label2.Name = "label2";
            label2.Size = new Size(48, 14);
            label2.TabIndex = 27;
            label2.Text = "Поиск";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Oldtimer", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.MenuHighlight;
            label1.Location = new Point(19, 61);
            label1.Name = "label1";
            label1.Size = new Size(158, 18);
            label1.TabIndex = 24;
            label1.Text = "Заказы в работе";
            // 
            // OrdersAtWorkDataGridView
            // 
            OrdersAtWorkDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            OrdersAtWorkDataGridView.BackgroundColor = Color.White;
            OrdersAtWorkDataGridView.ColumnHeadersHeight = 35;
            OrdersAtWorkDataGridView.Location = new Point(19, 81);
            OrdersAtWorkDataGridView.Margin = new Padding(3, 2, 3, 2);
            OrdersAtWorkDataGridView.Name = "OrdersAtWorkDataGridView";
            OrdersAtWorkDataGridView.RowHeadersVisible = false;
            OrdersAtWorkDataGridView.RowHeadersWidth = 51;
            OrdersAtWorkDataGridView.RowTemplate.Height = 35;
            OrdersAtWorkDataGridView.Size = new Size(623, 310);
            OrdersAtWorkDataGridView.TabIndex = 0;
            // 
            // MenuItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(803, 450);
            Controls.Add(panelSideMenu);
            Controls.Add(panelChildForm);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 2, 3, 2);
            Name = "MenuItem";
            Text = "AdminPanel";
            panelSideMenu.ResumeLayout(false);
            panelServices.ResumeLayout(false);
            panelClient.ResumeLayout(false);
            panelUsers.ResumeLayout(false);
            panelOrders.ResumeLayout(false);
            panelChildForm.ResumeLayout(false);
            panelChildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersAtWorkDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelSideMenu;
        private Panel panelServices;
        private Button ShowServices;
        private Button Services;
        private Panel panelClient;
        private Button ShowClients;
        private Button Clients;
        private Panel panelUsers;
        private Button ShowUsers;
        private Button Users;
        private Panel panelOrders;
        private Button ShowOrders;
        private Button Orders;
        private Panel panel1;
        private Panel panelChildForm;
        private Label label2;
        private Label label1;
        private DataGridView OrdersAtWorkDataGridView;
        private MaterialSkin.Controls.MaterialButton materialUpdateOrderDataButton;
        private MaterialSkin.Controls.MaterialTextBox2 materialTextSearch;
        private MaterialSkin.Controls.MaterialButton materialButton2;
    }
}