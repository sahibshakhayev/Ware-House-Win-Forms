namespace CourseWork
{
    partial class AddProductView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductView));
            this.metroSetControlBox1 = new MetroSet_UI.Controls.MetroSetControlBox();
            this.AddProductBt = new MetroSet_UI.Controls.MetroSetButton();
            this.AddProductQuantity = new System.Windows.Forms.NumericUpDown();
            this.metroSetLabel3 = new MetroSet_UI.Controls.MetroSetLabel();
            this.AddProductName = new MetroSet_UI.Controls.MetroSetTextBox();
            this.AddProductPrice = new MetroSet_UI.Controls.MetroSetTextBox();
            this.metroSetLabel1 = new MetroSet_UI.Controls.MetroSetLabel();
            this.AddProductDescription = new MetroSet_UI.Controls.MetroSetTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.AddProductQuantity)).BeginInit();
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
            this.metroSetControlBox1.Location = new System.Drawing.Point(371, 9);
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
            // AddProductBt
            // 
            this.AddProductBt.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AddProductBt.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AddProductBt.DisabledForeColor = System.Drawing.Color.Gray;
            this.AddProductBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddProductBt.HoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.AddProductBt.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(207)))), ((int)(((byte)(255)))));
            this.AddProductBt.HoverTextColor = System.Drawing.Color.White;
            this.AddProductBt.IsDerivedStyle = true;
            this.AddProductBt.Location = new System.Drawing.Point(318, 441);
            this.AddProductBt.Name = "AddProductBt";
            this.AddProductBt.NormalBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AddProductBt.NormalColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(177)))), ((int)(((byte)(225)))));
            this.AddProductBt.NormalTextColor = System.Drawing.Color.White;
            this.AddProductBt.PressBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.AddProductBt.PressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(147)))), ((int)(((byte)(195)))));
            this.AddProductBt.PressTextColor = System.Drawing.Color.White;
            this.AddProductBt.Size = new System.Drawing.Size(129, 29);
            this.AddProductBt.Style = MetroSet_UI.Enums.Style.Light;
            this.AddProductBt.StyleManager = null;
            this.AddProductBt.TabIndex = 17;
            this.AddProductBt.Text = "Save";
            this.AddProductBt.ThemeAuthor = "Narwin";
            this.AddProductBt.ThemeName = "MetroLite";
            this.AddProductBt.Click += new System.EventHandler(this.AddProductBt_Click);
            // 
            // AddProductQuantity
            // 
            this.AddProductQuantity.Location = new System.Drawing.Point(124, 208);
            this.AddProductQuantity.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.AddProductQuantity.Name = "AddProductQuantity";
            this.AddProductQuantity.Size = new System.Drawing.Size(323, 32);
            this.AddProductQuantity.TabIndex = 14;
            // 
            // metroSetLabel3
            // 
            this.metroSetLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel3.IsDerivedStyle = true;
            this.metroSetLabel3.Location = new System.Drawing.Point(15, 211);
            this.metroSetLabel3.Name = "metroSetLabel3";
            this.metroSetLabel3.Size = new System.Drawing.Size(77, 29);
            this.metroSetLabel3.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel3.StyleManager = null;
            this.metroSetLabel3.TabIndex = 13;
            this.metroSetLabel3.Text = "Quantity:";
            this.metroSetLabel3.ThemeAuthor = "Narwin";
            this.metroSetLabel3.ThemeName = "MetroLite";
            // 
            // AddProductName
            // 
            this.AddProductName.AutoCompleteCustomSource = null;
            this.AddProductName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AddProductName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AddProductName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AddProductName.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddProductName.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AddProductName.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.AddProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddProductName.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddProductName.Image = null;
            this.AddProductName.IsDerivedStyle = true;
            this.AddProductName.Lines = null;
            this.AddProductName.Location = new System.Drawing.Point(124, 102);
            this.AddProductName.MaxLength = 32767;
            this.AddProductName.Multiline = false;
            this.AddProductName.Name = "AddProductName";
            this.AddProductName.ReadOnly = false;
            this.AddProductName.Size = new System.Drawing.Size(323, 31);
            this.AddProductName.Style = MetroSet_UI.Enums.Style.Light;
            this.AddProductName.StyleManager = null;
            this.AddProductName.TabIndex = 18;
            this.AddProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddProductName.ThemeAuthor = "Narwin";
            this.AddProductName.ThemeName = "MetroLite";
            this.AddProductName.UseSystemPasswordChar = false;
            this.AddProductName.WatermarkText = "Name";
            // 
            // AddProductPrice
            // 
            this.AddProductPrice.AutoCompleteCustomSource = null;
            this.AddProductPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AddProductPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AddProductPrice.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AddProductPrice.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddProductPrice.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AddProductPrice.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.AddProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddProductPrice.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddProductPrice.Image = null;
            this.AddProductPrice.IsDerivedStyle = true;
            this.AddProductPrice.Lines = null;
            this.AddProductPrice.Location = new System.Drawing.Point(124, 157);
            this.AddProductPrice.MaxLength = 32767;
            this.AddProductPrice.Multiline = false;
            this.AddProductPrice.Name = "AddProductPrice";
            this.AddProductPrice.ReadOnly = false;
            this.AddProductPrice.Size = new System.Drawing.Size(323, 28);
            this.AddProductPrice.Style = MetroSet_UI.Enums.Style.Light;
            this.AddProductPrice.StyleManager = null;
            this.AddProductPrice.TabIndex = 19;
            this.AddProductPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddProductPrice.ThemeAuthor = "Narwin";
            this.AddProductPrice.ThemeName = "MetroLite";
            this.AddProductPrice.UseSystemPasswordChar = false;
            this.AddProductPrice.WatermarkText = "Price";
            // 
            // metroSetLabel1
            // 
            this.metroSetLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.metroSetLabel1.IsDerivedStyle = true;
            this.metroSetLabel1.Location = new System.Drawing.Point(15, 259);
            this.metroSetLabel1.Name = "metroSetLabel1";
            this.metroSetLabel1.Size = new System.Drawing.Size(103, 29);
            this.metroSetLabel1.Style = MetroSet_UI.Enums.Style.Light;
            this.metroSetLabel1.StyleManager = null;
            this.metroSetLabel1.TabIndex = 20;
            this.metroSetLabel1.Text = "Description:";
            this.metroSetLabel1.ThemeAuthor = "Narwin";
            this.metroSetLabel1.ThemeName = "MetroLite";
            // 
            // AddProductDescription
            // 
            this.AddProductDescription.AutoCompleteCustomSource = null;
            this.AddProductDescription.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AddProductDescription.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AddProductDescription.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AddProductDescription.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddProductDescription.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.AddProductDescription.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
            this.AddProductDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddProductDescription.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.AddProductDescription.Image = null;
            this.AddProductDescription.IsDerivedStyle = true;
            this.AddProductDescription.Lines = null;
            this.AddProductDescription.Location = new System.Drawing.Point(124, 259);
            this.AddProductDescription.MaxLength = 32767;
            this.AddProductDescription.Multiline = true;
            this.AddProductDescription.Name = "AddProductDescription";
            this.AddProductDescription.ReadOnly = false;
            this.AddProductDescription.Size = new System.Drawing.Size(323, 158);
            this.AddProductDescription.Style = MetroSet_UI.Enums.Style.Light;
            this.AddProductDescription.StyleManager = null;
            this.AddProductDescription.TabIndex = 21;
            this.AddProductDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.AddProductDescription.ThemeAuthor = "Narwin";
            this.AddProductDescription.ThemeName = "MetroLite";
            this.AddProductDescription.UseSystemPasswordChar = false;
            this.AddProductDescription.WatermarkText = "";
            // 
            // AddProductView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 26F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 498);
            this.Controls.Add(this.AddProductDescription);
            this.Controls.Add(this.metroSetLabel1);
            this.Controls.Add(this.AddProductPrice);
            this.Controls.Add(this.AddProductName);
            this.Controls.Add(this.AddProductBt);
            this.Controls.Add(this.AddProductQuantity);
            this.Controls.Add(this.metroSetLabel3);
            this.Controls.Add(this.metroSetControlBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProductView";
            this.ShowBorder = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.AddProductQuantity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroSet_UI.Controls.MetroSetControlBox metroSetControlBox1;
        private MetroSet_UI.Controls.MetroSetButton AddProductBt;
        private NumericUpDown AddProductQuantity;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel3;
        private MetroSet_UI.Controls.MetroSetTextBox AddProductName;
        private MetroSet_UI.Controls.MetroSetTextBox AddProductPrice;
        private MetroSet_UI.Controls.MetroSetLabel metroSetLabel1;
        private MetroSet_UI.Controls.MetroSetTextBox AddProductDescription;
    }
}