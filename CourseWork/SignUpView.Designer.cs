namespace CourseWork
{
    partial class SignUpView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUpView));
            this.RepeatPasswordShow = new System.Windows.Forms.PictureBox();
            this.PasswordShow = new System.Windows.Forms.PictureBox();
            this.SignUpUserButton = new MetroSet_UI.Controls.MetroSetButton();
            this.SurnameSignUp = new MetroSet_UI.Controls.MetroSetTextBox();
            this.NameSignUp = new MetroSet_UI.Controls.MetroSetTextBox();
            this.RepeatPasswordSignUp = new MetroSet_UI.Controls.MetroSetTextBox();
            this.PasswordSignUp = new MetroSet_UI.Controls.MetroSetTextBox();
            this.UsernameSignUp = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.RepeatPasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordShow)).BeginInit();
            this.SuspendLayout();
            // 
            // RepeatPasswordShow
            // 
            this.RepeatPasswordShow.BackColor = System.Drawing.SystemColors.Window;
            this.RepeatPasswordShow.Image = global::CourseWork.Properties.Resources.eye_inv;
            this.RepeatPasswordShow.Location = new System.Drawing.Point(306, 220);
            this.RepeatPasswordShow.Name = "RepeatPasswordShow";
            this.RepeatPasswordShow.Size = new System.Drawing.Size(33, 29);
            this.RepeatPasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RepeatPasswordShow.TabIndex = 16;
            this.RepeatPasswordShow.TabStop = false;
            this.RepeatPasswordShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RepeatPasswordShow_MouseDown);
            this.RepeatPasswordShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.RepeatPasswordShow_MouseUp);
            // 
            // PasswordShow
            // 
            this.PasswordShow.BackColor = System.Drawing.SystemColors.Window;
            this.PasswordShow.Image = global::CourseWork.Properties.Resources.eye_inv;
            this.PasswordShow.Location = new System.Drawing.Point(306, 171);
            this.PasswordShow.Name = "PasswordShow";
            this.PasswordShow.Size = new System.Drawing.Size(33, 29);
            this.PasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PasswordShow.TabIndex = 15;
            this.PasswordShow.TabStop = false;
            this.PasswordShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PasswordShow_MouseDown);
            this.PasswordShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PasswordShow_MouseUp);
            // 
            // SignUpUserButton
            // 
            this.SignUpUserButton.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SignUpUserButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SignUpUserButton.DisabledForeColor = System.Drawing.Color.Gray;
            this.SignUpUserButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignUpUserButton.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.SignUpUserButton.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.SignUpUserButton.HoverTextColor = System.Drawing.Color.White;
            this.SignUpUserButton.IsDerivedStyle = true;
            this.SignUpUserButton.Location = new System.Drawing.Point(109, 383);
            this.SignUpUserButton.Name = "SignUpUserButton";
            this.SignUpUserButton.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SignUpUserButton.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.SignUpUserButton.NormalTextColor = System.Drawing.Color.White;
            this.SignUpUserButton.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.SignUpUserButton.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.SignUpUserButton.PressTextColor = System.Drawing.Color.White;
            this.SignUpUserButton.Size = new System.Drawing.Size(94, 29);
            this.SignUpUserButton.Style = MetroSet_UI.Enums.Style.Light;
            this.SignUpUserButton.StyleManager = null;
            this.SignUpUserButton.TabIndex = 14;
            this.SignUpUserButton.Text = "Save";
            this.SignUpUserButton.ThemeAuthor = "Narwin";
            this.SignUpUserButton.ThemeName = "MetroLite";
            this.SignUpUserButton.Click += new System.EventHandler(this.SignUpUserButton_Click);
            // 
            // SurnameSignUp
            // 
            this.SurnameSignUp.AutoCompleteCustomSource = null;
            this.SurnameSignUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SurnameSignUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SurnameSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SurnameSignUp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SurnameSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.SurnameSignUp.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.SurnameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SurnameSignUp.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.SurnameSignUp.Image = null;
            this.SurnameSignUp.IsDerivedStyle = true;
            this.SurnameSignUp.Lines = null;
            this.SurnameSignUp.Location = new System.Drawing.Point(28, 319);
            this.SurnameSignUp.Margin = new System.Windows.Forms.Padding(50);
            this.SurnameSignUp.MaxLength = 32767;
            this.SurnameSignUp.Multiline = false;
            this.SurnameSignUp.Name = "SurnameSignUp";
            this.SurnameSignUp.ReadOnly = false;
            this.SurnameSignUp.Size = new System.Drawing.Size(264, 30);
            this.SurnameSignUp.Style = MetroSet_UI.Enums.Style.Light;
            this.SurnameSignUp.StyleManager = null;
            this.SurnameSignUp.TabIndex = 13;
            this.SurnameSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SurnameSignUp.ThemeAuthor = "Narwin";
            this.SurnameSignUp.ThemeName = "MetroLite";
            this.SurnameSignUp.UseSystemPasswordChar = false;
            this.SurnameSignUp.WatermarkText = "Surname";
            // 
            // NameSignUp
            // 
            this.NameSignUp.AutoCompleteCustomSource = null;
            this.NameSignUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NameSignUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NameSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.NameSignUp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.NameSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.NameSignUp.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.NameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameSignUp.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.NameSignUp.Image = null;
            this.NameSignUp.IsDerivedStyle = true;
            this.NameSignUp.Lines = null;
            this.NameSignUp.Location = new System.Drawing.Point(28, 269);
            this.NameSignUp.Margin = new System.Windows.Forms.Padding(50);
            this.NameSignUp.MaxLength = 32767;
            this.NameSignUp.Multiline = false;
            this.NameSignUp.Name = "NameSignUp";
            this.NameSignUp.ReadOnly = false;
            this.NameSignUp.Size = new System.Drawing.Size(264, 30);
            this.NameSignUp.Style = MetroSet_UI.Enums.Style.Light;
            this.NameSignUp.StyleManager = null;
            this.NameSignUp.TabIndex = 12;
            this.NameSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NameSignUp.ThemeAuthor = "Narwin";
            this.NameSignUp.ThemeName = "MetroLite";
            this.NameSignUp.UseSystemPasswordChar = false;
            this.NameSignUp.WatermarkText = "Name";
            // 
            // RepeatPasswordSignUp
            // 
            this.RepeatPasswordSignUp.AutoCompleteCustomSource = null;
            this.RepeatPasswordSignUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RepeatPasswordSignUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RepeatPasswordSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.RepeatPasswordSignUp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RepeatPasswordSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.RepeatPasswordSignUp.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.RepeatPasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RepeatPasswordSignUp.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.RepeatPasswordSignUp.Image = null;
            this.RepeatPasswordSignUp.IsDerivedStyle = true;
            this.RepeatPasswordSignUp.Lines = null;
            this.RepeatPasswordSignUp.Location = new System.Drawing.Point(28, 219);
            this.RepeatPasswordSignUp.Margin = new System.Windows.Forms.Padding(50);
            this.RepeatPasswordSignUp.MaxLength = 32767;
            this.RepeatPasswordSignUp.Multiline = false;
            this.RepeatPasswordSignUp.Name = "RepeatPasswordSignUp";
            this.RepeatPasswordSignUp.ReadOnly = false;
            this.RepeatPasswordSignUp.Size = new System.Drawing.Size(264, 30);
            this.RepeatPasswordSignUp.Style = MetroSet_UI.Enums.Style.Light;
            this.RepeatPasswordSignUp.StyleManager = null;
            this.RepeatPasswordSignUp.TabIndex = 11;
            this.RepeatPasswordSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.RepeatPasswordSignUp.ThemeAuthor = "Narwin";
            this.RepeatPasswordSignUp.ThemeName = "MetroLite";
            this.RepeatPasswordSignUp.UseSystemPasswordChar = true;
            this.RepeatPasswordSignUp.WatermarkText = "Repeat Password";
            // 
            // PasswordSignUp
            // 
            this.PasswordSignUp.AutoCompleteCustomSource = null;
            this.PasswordSignUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordSignUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PasswordSignUp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.PasswordSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.PasswordSignUp.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.PasswordSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PasswordSignUp.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.PasswordSignUp.Image = null;
            this.PasswordSignUp.IsDerivedStyle = true;
            this.PasswordSignUp.Lines = null;
            this.PasswordSignUp.Location = new System.Drawing.Point(28, 170);
            this.PasswordSignUp.Margin = new System.Windows.Forms.Padding(50);
            this.PasswordSignUp.MaxLength = 32767;
            this.PasswordSignUp.Multiline = false;
            this.PasswordSignUp.Name = "PasswordSignUp";
            this.PasswordSignUp.ReadOnly = false;
            this.PasswordSignUp.Size = new System.Drawing.Size(264, 30);
            this.PasswordSignUp.Style = MetroSet_UI.Enums.Style.Light;
            this.PasswordSignUp.StyleManager = null;
            this.PasswordSignUp.TabIndex = 10;
            this.PasswordSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PasswordSignUp.ThemeAuthor = "Narwin";
            this.PasswordSignUp.ThemeName = "MetroLite";
            this.PasswordSignUp.UseSystemPasswordChar = true;
            this.PasswordSignUp.WatermarkText = "Password";
            // 
            // UsernameSignUp
            // 
            this.UsernameSignUp.AutoCompleteCustomSource = null;
            this.UsernameSignUp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UsernameSignUp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UsernameSignUp.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.UsernameSignUp.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UsernameSignUp.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.UsernameSignUp.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.UsernameSignUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameSignUp.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.UsernameSignUp.Image = null;
            this.UsernameSignUp.IsDerivedStyle = true;
            this.UsernameSignUp.Lines = null;
            this.UsernameSignUp.Location = new System.Drawing.Point(28, 120);
            this.UsernameSignUp.Margin = new System.Windows.Forms.Padding(50);
            this.UsernameSignUp.MaxLength = 32767;
            this.UsernameSignUp.Multiline = false;
            this.UsernameSignUp.Name = "UsernameSignUp";
            this.UsernameSignUp.ReadOnly = false;
            this.UsernameSignUp.Size = new System.Drawing.Size(264, 30);
            this.UsernameSignUp.Style = MetroSet_UI.Enums.Style.Light;
            this.UsernameSignUp.StyleManager = null;
            this.UsernameSignUp.TabIndex = 9;
            this.UsernameSignUp.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.UsernameSignUp.ThemeAuthor = "Narwin";
            this.UsernameSignUp.ThemeName = "MetroLite";
            this.UsernameSignUp.UseSystemPasswordChar = false;
            this.UsernameSignUp.WatermarkText = "Username";
            // 
            // metroSetControlBox1
            // 
            this.metroSetControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroSetControlBox1.CloseHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(183)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.metroSetControlBox1.CloseHoverForeColor = System.Drawing.Color.White;
            this.metroSetControlBox1.CloseNormalForeColor = System.Drawing.Color.Gray;
            this.metroSetControlBox1.DisabledForeColor = System.Drawing.Color.DimGray;
            this.metroSetControlBox1.IsDerivedStyle = true;
            this.metroSetControlBox1.Location = new System.Drawing.Point(239, 8);
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
            this.metroSetControlBox1.TabIndex = 17;
            this.metroSetControlBox1.Text = "metroSetControlBox1";
            this.metroSetControlBox1.ThemeAuthor = "Narwin";
            this.metroSetControlBox1.ThemeName = "MetroLite";
            // 
            // SignUpView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 431);
            this.Controls.Add(this.metroSetControlBox1);
            this.Controls.Add(this.RepeatPasswordShow);
            this.Controls.Add(this.PasswordShow);
            this.Controls.Add(this.SignUpUserButton);
            this.Controls.Add(this.SurnameSignUp);
            this.Controls.Add(this.NameSignUp);
            this.Controls.Add(this.RepeatPasswordSignUp);
            this.Controls.Add(this.PasswordSignUp);
            this.Controls.Add(this.UsernameSignUp);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SignUpView";
            this.ShowBorder = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sign Up";
            ((System.ComponentModel.ISupportInitialize)(this.RepeatPasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordShow)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox RepeatPasswordShow;
        private PictureBox PasswordShow;
        private MetroSet_UI.Controls.MetroSetButton SignUpUserButton;
        internal MetroSet_UI.Controls.MetroSetTextBox SurnameSignUp;
        internal MetroSet_UI.Controls.MetroSetTextBox NameSignUp;
        internal MetroSet_UI.Controls.MetroSetTextBox RepeatPasswordSignUp;
        internal MetroSet_UI.Controls.MetroSetTextBox PasswordSignUp;
        internal MetroSet_UI.Controls.MetroSetTextBox UsernameSignUp;
        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
    }
}