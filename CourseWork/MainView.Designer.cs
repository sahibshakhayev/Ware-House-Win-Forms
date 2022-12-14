namespace CourseWork
{
    partial class MainView
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainView));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.LoginPanel = new MetroSet_UI.Controls.MetroSetPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SignUpButton = new MetroSet_UI.Controls.MetroSetButton();
            this.LoginButton = new MetroSet_UI.Controls.MetroSetButton();
            this.PasswordLogin = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UsernameLogin = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel2 = new MetroSet_UI.Controls.MetroSetLabel();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddClient = new System.Windows.Forms.ToolStripMenuItem();
            this.ListClient = new System.Windows.Forms.ToolStripMenuItem();
            this.orderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AcceptOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.ListOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.productToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.ListProduct = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.ClientPanel = new MetroSet_UI.Controls.MetroSetPanel();
            this.ClientView = new System.Windows.Forms.DataGridView();
            this.OrderPanel = new MetroSet_UI.Controls.MetroSetPanel();
            this.OrderView = new System.Windows.Forms.DataGridView();
            this.ProductPanel = new MetroSet_UI.Controls.MetroSetPanel();
            this.ProductView = new System.Windows.Forms.DataGridView();
            this.Filter = new MetroSet_UI.Controls.MetroSetTextBox();
            this.LoginPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Menu.SuspendLayout();
            this.ClientPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).BeginInit();
            this.OrderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).BeginInit();
            this.ProductPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).BeginInit();
            this.SuspendLayout();
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(1312, 6);
            this.metroSetControlBox1.MaximizeBox = true;
            this.metroSetControlBox1.MaximizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MaximizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MaximizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeBox = true;
            this.metroSetControlBox1.MinimizeHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.metroSetControlBox1.MinimizeHoverForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.MinimizeNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.Name = "metroSetControlBox1";
            this.metroSetControlBox1.Size = new System.Drawing.Size(100, 25);
            this.metroSetControlBox1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetControlBox1.StyleManager = null;
            this.metroSetControlBox1.TabIndex = 0;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackgroundColor = System.Drawing.Color.White;
            this.LoginPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.LoginPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.LoginPanel.BorderThickness = 0;
            this.LoginPanel.Controls.Add(this.pictureBox1);
            this.LoginPanel.Controls.Add(this.SignUpButton);
            this.LoginPanel.Controls.Add(this.LoginButton);
            this.LoginPanel.Controls.Add(this.PasswordLogin);
            this.LoginPanel.Controls.Add(this.UsernameLogin);
            this.LoginPanel.Controls.Add(this.metroSetLabel2);
            this.LoginPanel.Controls.Add(this.metroSetLabel1);
            this.LoginPanel.IsDerivedStyle = true;
            this.LoginPanel.Location = new System.Drawing.Point(15, 107);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(1397, 558);
            this.LoginPanel.Style = MetroSet_UI.Enums.Style.Light;
            this.LoginPanel.StyleManager = null;
            this.LoginPanel.TabIndex = 1;
            this.LoginPanel.ThemeAuthor = "Narwin";
            this.LoginPanel.ThemeName = "MetroLite";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CourseWork.Properties.Resources.icons8_stock_70;
            this.pictureBox1.Location = new System.Drawing.Point(662, 58);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // SignUpButton
            // 
            this.SignUpButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SignUpButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SignUpButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.SignUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.SignUpButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.SignUpButton.HoverTextColor = System.Drawing.Color.White;
            this.SignUpButton.IsDerivedStyle = true;
            this.SignUpButton.Location = new System.Drawing.Point(699, 388);
            this.SignUpButton.Name = "SignUpButton";
            this.SignUpButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SignUpButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SignUpButton.NormalTextColor = System.Drawing.Color.White;
            this.SignUpButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.SignUpButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.SignUpButton.PressTextColor = System.Drawing.Color.White;
            this.SignUpButton.Size = new System.Drawing.Size(105, 36);
            this.SignUpButton.Style = MetroSet_UI.Enums.Style.Light;
            this.SignUpButton.StyleManager = null;
            this.SignUpButton.TabIndex = 5;
            this.SignUpButton.Text = "Sign Up";
            this.SignUpButton.ThemeAuthor = "Narwin";
            this.SignUpButton.ThemeName = "MetroLite";
            this.SignUpButton.Click += new System.EventHandler(this.SignUpButton_Click);
            // 
            // LoginButton
            // 
            this.LoginButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.LoginButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.LoginButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.LoginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoginButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.LoginButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.LoginButton.HoverTextColor = System.Drawing.Color.White;
            this.LoginButton.IsDerivedStyle = true;
            this.LoginButton.Location = new System.Drawing.Point(557, 388);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.LoginButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.LoginButton.NormalTextColor = System.Drawing.Color.White;
            this.LoginButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.LoginButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.LoginButton.PressTextColor = System.Drawing.Color.White;
            this.LoginButton.Size = new System.Drawing.Size(105, 36);
            this.LoginButton.Style = MetroSet_UI.Enums.Style.Light;
            this.LoginButton.StyleManager = null;
            this.LoginButton.TabIndex = 4;
            this.LoginButton.Text = "Login";
            this.LoginButton.ThemeAuthor = "Narwin";
            this.LoginButton.ThemeName = "MetroLite";
            this.LoginButton.Click += LoginButton_Click;
            // 
            // PasswordLogin
            // 
            this.PasswordLogin.AutoCompleteCustomSource = null;
            this.PasswordLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PasswordLogin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PasswordLogin.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.PasswordLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordLogin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PasswordLogin.Image = null;
            this.PasswordLogin.IsDerivedStyle = true;
            this.PasswordLogin.Lines = null;
            this.PasswordLogin.Location = new System.Drawing.Point(503, 332);
            this.PasswordLogin.MaxLength = 32767;
            this.PasswordLogin.Multiline = false;
            this.PasswordLogin.Name = "PasswordLogin";
            this.PasswordLogin.ReadOnly = false;
            this.PasswordLogin.Size = new System.Drawing.Size(365, 31);
            this.PasswordLogin.Style = MetroSet_UI.Enums.Style.Light;
            this.PasswordLogin.StyleManager = null;
            this.PasswordLogin.TabIndex = 3;
            this.PasswordLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordLogin.ThemeAuthor = "Narwin";
            this.PasswordLogin.ThemeName = "MetroLite";
            this.PasswordLogin.UseSystemPasswordChar = true;
            this.PasswordLogin.WatermarkText = "Password";
            // 
            // UsernameLogin
            // 
            this.UsernameLogin.AutoCompleteCustomSource = null;
            this.UsernameLogin.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UsernameLogin.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UsernameLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.UsernameLogin.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UsernameLogin.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.UsernameLogin.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.UsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameLogin.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.UsernameLogin.Image = null;
            this.UsernameLogin.IsDerivedStyle = true;
            this.UsernameLogin.Lines = null;
            this.UsernameLogin.Location = new System.Drawing.Point(503, 276);
            this.UsernameLogin.MaxLength = 32767;
            this.UsernameLogin.Multiline = false;
            this.UsernameLogin.Name = "UsernameLogin";
            this.UsernameLogin.ReadOnly = false;
            this.UsernameLogin.Size = new System.Drawing.Size(365, 31);
            this.UsernameLogin.Style = MetroSet_UI.Enums.Style.Light;
            this.UsernameLogin.StyleManager = null;
            this.UsernameLogin.TabIndex = 2;
            this.UsernameLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsernameLogin.ThemeAuthor = "Narwin";
            this.UsernameLogin.ThemeName = "MetroLite";
            this.UsernameLogin.UseSystemPasswordChar = false;
            this.UsernameLogin.WatermarkText = "Username";
            // 
            // metroSetLabel2
            // 
            this.metroSetLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel2.IsDerivedStyle = true;
            this.metroSetLabel2.Location = new System.Drawing.Point(0, 207);
            this.metroSetLabel2.Name = "metroSetLabel2";
            this.metroSetLabel2.Size = new System.Drawing.Size(1397, 42);
            this.metroSetLabel2.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel2.StyleManager = null;
            this.metroSetLabel2.TabIndex = 1;
            this.metroSetLabel2.Text = "Login\r\n";
            this.metroSetLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel2.ThemeAuthor = "Narwin";
            this.metroSetLabel2.ThemeName = "MetroLite";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(0, 132);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(1397, 59);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 0;
            this.metroSetLabel1.Text = "ShopZade Warehouse Management System";
            this.metroSetLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // Menu
            // 
            this.Menu.BackColor = System.Drawing.SystemColors.Window;
            this.Menu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.orderToolStripMenuItem,
            this.productToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.Menu.Location = new System.Drawing.Point(12, 70);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(1403, 28);
            this.Menu.TabIndex = 2;
            this.Menu.Text = "menuStrip1";
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddClient,
            this.ListClient});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // AddClient
            // 
            this.AddClient.BackColor = System.Drawing.SystemColors.Window;
            this.AddClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddClient.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddClient.Name = "AddClient";
            this.AddClient.Size = new System.Drawing.Size(120, 26);
            this.AddClient.Text = "Add";
            this.AddClient.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // ListClient
            // 
            this.ListClient.BackColor = System.Drawing.SystemColors.Window;
            this.ListClient.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ListClient.Name = "ListClient";
            this.ListClient.Size = new System.Drawing.Size(120, 26);
            this.ListClient.Text = "List";
            this.ListClient.Click += new System.EventHandler(this.ListClient_Click);
            // 
            // orderToolStripMenuItem
            // 
            this.orderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AcceptOrder,
            this.ListOrder});
            this.orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            this.orderToolStripMenuItem.Size = new System.Drawing.Size(61, 24);
            this.orderToolStripMenuItem.Text = "Order";
            // 
            // AcceptOrder
            // 
            this.AcceptOrder.BackColor = System.Drawing.SystemColors.Window;
            this.AcceptOrder.Name = "AcceptOrder";
            this.AcceptOrder.Size = new System.Drawing.Size(138, 26);
            this.AcceptOrder.Text = "Accept";
            this.AcceptOrder.Click += new System.EventHandler(this.AcceptOrder_Click);
            // 
            // ListOrder
            // 
            this.ListOrder.BackColor = System.Drawing.SystemColors.Window;
            this.ListOrder.Name = "ListOrder";
            this.ListOrder.Size = new System.Drawing.Size(138, 26);
            this.ListOrder.Text = "List";
            this.ListOrder.Click += new System.EventHandler(this.ListOrder_Click);
            // 
            // productToolStripMenuItem
            // 
            this.productToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddProduct,
            this.ListProduct});
            this.productToolStripMenuItem.Name = "productToolStripMenuItem";
            this.productToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.productToolStripMenuItem.Text = "Product";
            // 
            // AddProduct
            // 
            this.AddProduct.BackColor = System.Drawing.SystemColors.Window;
            this.AddProduct.Name = "AddProduct";
            this.AddProduct.Size = new System.Drawing.Size(120, 26);
            this.AddProduct.Text = "Add";
            this.AddProduct.Click += new System.EventHandler(this.AddProduct_Click);
            // 
            // ListProduct
            // 
            this.ListProduct.BackColor = System.Drawing.SystemColors.Window;
            this.ListProduct.Name = "ListProduct";
            this.ListProduct.Size = new System.Drawing.Size(120, 26);
            this.ListProduct.Text = "List";
            this.ListProduct.Click += new System.EventHandler(this.ListProduct_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Exit});
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.logOutToolStripMenuItem.Text = "Log out";
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.SystemColors.Window;
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(116, 26);
            this.Exit.Text = "Exit";
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ClientPanel
            // 
            this.ClientPanel.BackgroundColor = System.Drawing.Color.White;
            this.ClientPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ClientPanel.BorderThickness = 1;
            this.ClientPanel.Controls.Add(this.ClientView);
            this.ClientPanel.IsDerivedStyle = true;
            this.ClientPanel.Location = new System.Drawing.Point(15, 107);
            this.ClientPanel.Name = "ClientPanel";
            this.ClientPanel.Size = new System.Drawing.Size(1397, 558);
            this.ClientPanel.Style = MetroSet_UI.Enums.Style.Light;
            this.ClientPanel.StyleManager = null;
            this.ClientPanel.TabIndex = 5;
            this.ClientPanel.ThemeAuthor = "Narwin";
            this.ClientPanel.ThemeName = "MetroLite";
            // 
            // ClientView
            // 
            this.ClientView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ClientView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ClientView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientView.Location = new System.Drawing.Point(0, 3);
            this.ClientView.Name = "ClientView";
            this.ClientView.RowHeadersWidth = 51;
            this.ClientView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ClientView.RowTemplate.Height = 29;
            this.ClientView.RowTemplate.ReadOnly = true;
            this.ClientView.Size = new System.Drawing.Size(1370, 555);
            this.ClientView.TabIndex = 2;
            // 
            // OrderPanel
            // 
            this.OrderPanel.BackgroundColor = System.Drawing.Color.White;
            this.OrderPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.OrderPanel.BorderThickness = 1;
            this.OrderPanel.Controls.Add(this.OrderView);
            this.OrderPanel.IsDerivedStyle = true;
            this.OrderPanel.Location = new System.Drawing.Point(15, 107);
            this.OrderPanel.Name = "OrderPanel";
            this.OrderPanel.Size = new System.Drawing.Size(1397, 558);
            this.OrderPanel.Style = MetroSet_UI.Enums.Style.Light;
            this.OrderPanel.StyleManager = null;
            this.OrderPanel.TabIndex = 6;
            this.OrderPanel.ThemeAuthor = "Narwin";
            this.OrderPanel.ThemeName = "MetroLite";
            // 
            // OrderView
            // 
            this.OrderView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.OrderView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderView.Location = new System.Drawing.Point(0, 3);
            this.OrderView.Name = "OrderView";
            this.OrderView.RowHeadersWidth = 51;
            this.OrderView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.OrderView.RowTemplate.Height = 29;
            this.OrderView.RowTemplate.ReadOnly = true;
            this.OrderView.Size = new System.Drawing.Size(1397, 555);
            this.OrderView.TabIndex = 2;
            // 
            // ProductPanel
            // 
            this.ProductPanel.BackgroundColor = System.Drawing.Color.White;
            this.ProductPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.ProductPanel.BorderThickness = 1;
            this.ProductPanel.Controls.Add(this.ProductView);
            this.ProductPanel.IsDerivedStyle = true;
            this.ProductPanel.Location = new System.Drawing.Point(15, 107);
            this.ProductPanel.Name = "ProductPanel";
            this.ProductPanel.Size = new System.Drawing.Size(1397, 558);
            this.ProductPanel.Style = MetroSet_UI.Enums.Style.Light;
            this.ProductPanel.StyleManager = null;
            this.ProductPanel.TabIndex = 7;
            this.ProductPanel.ThemeAuthor = "Narwin";
            this.ProductPanel.ThemeName = "MetroLite";
            // 
            // ProductView
            // 
            this.ProductView.BackgroundColor = System.Drawing.SystemColors.Window;
            this.ProductView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductView.Location = new System.Drawing.Point(0, 0);
            this.ProductView.Name = "ProductView";
            this.ProductView.RowHeadersWidth = 51;
            this.ProductView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.ProductView.RowTemplate.Height = 29;
            this.ProductView.RowTemplate.ReadOnly = true;
            this.ProductView.Size = new System.Drawing.Size(1397, 558);
            this.ProductView.TabIndex = 0;
            // 
            // Filter
            // 
            this.Filter.AutoCompleteCustomSource = null;
            this.Filter.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.Filter.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.Filter.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Filter.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.Filter.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.Filter.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.Filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Filter.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.Filter.Image = null;
            this.Filter.IsDerivedStyle = true;
            this.Filter.Lines = null;
            this.Filter.Location = new System.Drawing.Point(928, 40);
            this.Filter.MaxLength = 32767;
            this.Filter.Multiline = false;
            this.Filter.Name = "Filter";
            this.Filter.ReadOnly = false;
            this.Filter.Size = new System.Drawing.Size(260, 27);
            this.Filter.Style = MetroSet_UI.Enums.Style.Light;
            this.Filter.StyleManager = null;
            this.Filter.TabIndex = 8;
            this.Filter.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Filter.ThemeAuthor = "Narwin";
            this.Filter.ThemeName = "MetroLite";
            this.Filter.UseSystemPasswordChar = false;
            this.Filter.WatermarkText = "Filter";
            this.Filter.TextChanged += new System.EventHandler(this.Filter_TextChanged);
            // 
            // MainView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1427, 680);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.ProductPanel);
            this.Controls.Add(this.ClientPanel);
            this.Controls.Add(this.OrderPanel);
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.Menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainView";
            this.ShowBorder = true;
            this.ShowLeftRect = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TextAlign = MetroSet_UI.Enums.TextAlign.Center;
            this.LoginPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ClientPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ClientView)).EndInit();
            this.OrderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrderView)).EndInit();
            this.ProductPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        internal MetroSet_UI.Controls.MetroSetPanel LoginPanel;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel2;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        internal MetroSet_UI.Controls.MetroSetTextBox UsernameLogin;
        internal MetroSet_UI.Controls.MetroSetTextBox PasswordLogin;
        private MetroSet_UI.Controls.MetroSetButton SignUpButton;
        private MetroSet_UI.Controls.MetroSetButton LoginButton;
        private PictureBox pictureBox1;
        internal MenuStrip Menu;
        private ToolStripMenuItem clientToolStripMenuItem;
        private ToolStripMenuItem AddClient;
        private ToolStripMenuItem ListClient;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem AcceptOrder;
        private ToolStripMenuItem ListOrder;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem AddProduct;
        private ToolStripMenuItem ListProduct;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem Exit;
        internal MetroSet_UI.Controls.MetroSetPanel ClientPanel;
        internal DataGridView ClientView;
        internal MetroSet_UI.Controls.MetroSetPanel OrderPanel;
        internal DataGridView OrderView;
        internal MetroSet_UI.Controls.MetroSetPanel ProductPanel;
        internal DataGridView ProductView;
        internal MetroSet_UI.Controls.MetroSetTextBox Filter;
    }
}