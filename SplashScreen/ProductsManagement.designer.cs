﻿namespace SplashScreen
{
    partial class ProductsManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductsManagement));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.productName = new Guna.UI2.WinForms.Guna2TextBox();
            this.productPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.stock = new Guna.UI2.WinForms.Guna2TextBox();
            this.insertButton = new Guna.UI2.WinForms.Guna2Button();
            this.dataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.stockLabel = new System.Windows.Forms.Label();
            this.productPriceLabel = new System.Windows.Forms.Label();
            this.productNameLabel = new System.Windows.Forms.Label();
            this.updateButton = new Guna.UI2.WinForms.Guna2Button();
            this.deleteButton = new Guna.UI2.WinForms.Guna2Button();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.productId = new Guna.UI2.WinForms.Guna2TextBox();
            this.productIdLabel = new System.Windows.Forms.Label();
            this.categoryDropdown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.viewButton = new Guna.UI2.WinForms.Guna2Button();
            this.label5 = new System.Windows.Forms.Label();
            this.searchBox = new Guna.UI2.WinForms.Guna2TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Poppins", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(188, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 70);
            this.label1.TabIndex = 28;
            this.label1.Text = "Products Management";
            // 
            // productName
            // 
            this.productName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productName.BackColor = System.Drawing.Color.Transparent;
            this.productName.BorderColor = System.Drawing.Color.Maroon;
            this.productName.BorderRadius = 10;
            this.productName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productName.DefaultText = "";
            this.productName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productName.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productName.ForeColor = System.Drawing.Color.Firebrick;
            this.productName.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.productName.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.productName.IconLeft = ((System.Drawing.Image)(resources.GetObject("productName.IconLeft")));
            this.productName.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.productName.IconLeftSize = new System.Drawing.Size(17, 17);
            this.productName.Location = new System.Drawing.Point(39, 178);
            this.productName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productName.Name = "productName";
            this.productName.PasswordChar = '\0';
            this.productName.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.productName.PlaceholderText = "";
            this.productName.SelectedText = "";
            this.productName.Size = new System.Drawing.Size(199, 39);
            this.productName.TabIndex = 29;
            this.productName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productName_KeyPress);
            // 
            // productPrice
            // 
            this.productPrice.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productPrice.BackColor = System.Drawing.Color.Transparent;
            this.productPrice.BorderColor = System.Drawing.Color.Maroon;
            this.productPrice.BorderRadius = 10;
            this.productPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productPrice.DefaultText = "";
            this.productPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productPrice.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.productPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPrice.ForeColor = System.Drawing.Color.Firebrick;
            this.productPrice.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.productPrice.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.productPrice.IconLeft = ((System.Drawing.Image)(resources.GetObject("productPrice.IconLeft")));
            this.productPrice.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.productPrice.IconLeftSize = new System.Drawing.Size(17, 17);
            this.productPrice.Location = new System.Drawing.Point(39, 258);
            this.productPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productPrice.Name = "productPrice";
            this.productPrice.PasswordChar = '\0';
            this.productPrice.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.productPrice.PlaceholderText = "";
            this.productPrice.SelectedText = "";
            this.productPrice.Size = new System.Drawing.Size(199, 39);
            this.productPrice.TabIndex = 29;
            this.productPrice.TextChanged += new System.EventHandler(this.productPrice_TextChanged);
            this.productPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.productPrice_KeyPress);
            // 
            // stock
            // 
            this.stock.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stock.BackColor = System.Drawing.Color.Transparent;
            this.stock.BorderColor = System.Drawing.Color.Maroon;
            this.stock.BorderRadius = 10;
            this.stock.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stock.DefaultText = "";
            this.stock.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.stock.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.stock.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stock.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.stock.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock.ForeColor = System.Drawing.Color.Firebrick;
            this.stock.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.stock.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.stock.IconLeft = ((System.Drawing.Image)(resources.GetObject("stock.IconLeft")));
            this.stock.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.stock.IconLeftSize = new System.Drawing.Size(17, 17);
            this.stock.Location = new System.Drawing.Point(39, 334);
            this.stock.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.stock.Name = "stock";
            this.stock.PasswordChar = '\0';
            this.stock.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.stock.PlaceholderText = "";
            this.stock.SelectedText = "";
            this.stock.Size = new System.Drawing.Size(199, 39);
            this.stock.TabIndex = 29;
            this.stock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.stock_KeyPress);
            // 
            // insertButton
            // 
            this.insertButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.insertButton.BackColor = System.Drawing.Color.Transparent;
            this.insertButton.BorderRadius = 10;
            this.insertButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.insertButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.insertButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.insertButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.insertButton.FillColor = System.Drawing.Color.Maroon;
            this.insertButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insertButton.ForeColor = System.Drawing.Color.White;
            this.insertButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.insertButton.Location = new System.Drawing.Point(344, 463);
            this.insertButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.insertButton.Name = "insertButton";
            this.insertButton.PressedColor = System.Drawing.Color.Transparent;
            this.insertButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.insertButton.ShadowDecoration.Enabled = true;
            this.insertButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.insertButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.insertButton.Size = new System.Drawing.Size(175, 47);
            this.insertButton.TabIndex = 34;
            this.insertButton.Text = "Insert";
            this.insertButton.Click += new System.EventHandler(this.insertButton_Click);
            // 
            // dataGridview
            // 
            this.dataGridview.AllowUserToAddRows = false;
            this.dataGridview.AllowUserToDeleteRows = false;
            this.dataGridview.AllowUserToResizeColumns = false;
            this.dataGridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Firebrick;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridview.ColumnHeadersHeight = 19;
            this.dataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridview.Location = new System.Drawing.Point(264, 165);
            this.dataGridview.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridview.Name = "dataGridview";
            this.dataGridview.ReadOnly = true;
            this.dataGridview.RowHeadersVisible = false;
            this.dataGridview.RowHeadersWidth = 51;
            this.dataGridview.RowTemplate.Height = 24;
            this.dataGridview.Size = new System.Drawing.Size(535, 277);
            this.dataGridview.TabIndex = 35;
            this.dataGridview.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Alizarin;
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(201)))), ((int)(((byte)(197)))));
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dataGridview.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(192)))), ((int)(((byte)(188)))));
            this.dataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.dataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dataGridview.ThemeStyle.HeaderStyle.Height = 19;
            this.dataGridview.ThemeStyle.ReadOnly = true;
            this.dataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(219)))), ((int)(((byte)(216)))));
            this.dataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridview.ThemeStyle.RowsStyle.Height = 24;
            this.dataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(135)))), ((int)(((byte)(125)))));
            this.dataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridview_CellContentClick);
            // 
            // stockLabel
            // 
            this.stockLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stockLabel.AutoSize = true;
            this.stockLabel.BackColor = System.Drawing.Color.Transparent;
            this.stockLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stockLabel.ForeColor = System.Drawing.Color.Maroon;
            this.stockLabel.Location = new System.Drawing.Point(44, 304);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(53, 26);
            this.stockLabel.TabIndex = 37;
            this.stockLabel.Text = "Stock";
            this.stockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productPriceLabel
            // 
            this.productPriceLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productPriceLabel.AutoSize = true;
            this.productPriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.productPriceLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productPriceLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productPriceLabel.Location = new System.Drawing.Point(44, 226);
            this.productPriceLabel.Name = "productPriceLabel";
            this.productPriceLabel.Size = new System.Drawing.Size(112, 26);
            this.productPriceLabel.TabIndex = 37;
            this.productPriceLabel.Text = "Product Price";
            this.productPriceLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productNameLabel
            // 
            this.productNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.productNameLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productNameLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productNameLabel.Location = new System.Drawing.Point(44, 146);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(120, 26);
            this.productNameLabel.TabIndex = 37;
            this.productNameLabel.Text = "Product Name";
            this.productNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // updateButton
            // 
            this.updateButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.updateButton.BackColor = System.Drawing.Color.Transparent;
            this.updateButton.BorderRadius = 10;
            this.updateButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.updateButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.updateButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.updateButton.FillColor = System.Drawing.Color.Maroon;
            this.updateButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.White;
            this.updateButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.updateButton.Location = new System.Drawing.Point(546, 463);
            this.updateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.updateButton.Name = "updateButton";
            this.updateButton.PressedColor = System.Drawing.Color.Transparent;
            this.updateButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.updateButton.ShadowDecoration.Enabled = true;
            this.updateButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.updateButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.updateButton.Size = new System.Drawing.Size(175, 47);
            this.updateButton.TabIndex = 39;
            this.updateButton.Text = "Update";
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.deleteButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteButton.BorderRadius = 10;
            this.deleteButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteButton.FillColor = System.Drawing.Color.Maroon;
            this.deleteButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.White;
            this.deleteButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.deleteButton.Location = new System.Drawing.Point(546, 514);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.PressedColor = System.Drawing.Color.Transparent;
            this.deleteButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.deleteButton.ShadowDecoration.Enabled = true;
            this.deleteButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.deleteButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.deleteButton.Size = new System.Drawing.Size(175, 47);
            this.deleteButton.TabIndex = 40;
            this.deleteButton.Text = "Delete";
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // categoryLabel
            // 
            this.categoryLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.categoryLabel.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.Maroon;
            this.categoryLabel.Location = new System.Drawing.Point(47, 379);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(82, 26);
            this.categoryLabel.TabIndex = 37;
            this.categoryLabel.Text = "Category";
            this.categoryLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // productId
            // 
            this.productId.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productId.BackColor = System.Drawing.Color.Transparent;
            this.productId.BorderColor = System.Drawing.Color.Maroon;
            this.productId.BorderRadius = 10;
            this.productId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.productId.DefaultText = "";
            this.productId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.productId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.productId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.productId.Enabled = false;
            this.productId.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.productId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productId.ForeColor = System.Drawing.Color.Firebrick;
            this.productId.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.productId.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.productId.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.productId.IconLeftSize = new System.Drawing.Size(17, 17);
            this.productId.Location = new System.Drawing.Point(96, 17);
            this.productId.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.productId.Name = "productId";
            this.productId.PasswordChar = '\0';
            this.productId.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.productId.PlaceholderText = "";
            this.productId.SelectedText = "";
            this.productId.Size = new System.Drawing.Size(32, 39);
            this.productId.TabIndex = 29;
            this.productId.Visible = false;
            // 
            // productIdLabel
            // 
            this.productIdLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.productIdLabel.AutoSize = true;
            this.productIdLabel.BackColor = System.Drawing.Color.Transparent;
            this.productIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productIdLabel.ForeColor = System.Drawing.Color.Maroon;
            this.productIdLabel.Location = new System.Drawing.Point(15, 31);
            this.productIdLabel.Name = "productIdLabel";
            this.productIdLabel.Size = new System.Drawing.Size(72, 17);
            this.productIdLabel.TabIndex = 37;
            this.productIdLabel.Text = "Product Id";
            this.productIdLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.productIdLabel.Visible = false;
            // 
            // categoryDropdown
            // 
            this.categoryDropdown.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.categoryDropdown.BackColor = System.Drawing.Color.Transparent;
            this.categoryDropdown.BorderColor = System.Drawing.Color.Maroon;
            this.categoryDropdown.BorderRadius = 10;
            this.categoryDropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.categoryDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryDropdown.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryDropdown.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.categoryDropdown.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.categoryDropdown.ForeColor = System.Drawing.Color.Firebrick;
            this.categoryDropdown.ItemHeight = 30;
            this.categoryDropdown.Location = new System.Drawing.Point(39, 409);
            this.categoryDropdown.Margin = new System.Windows.Forms.Padding(4);
            this.categoryDropdown.Name = "categoryDropdown";
            this.categoryDropdown.Size = new System.Drawing.Size(197, 36);
            this.categoryDropdown.TabIndex = 41;
            this.categoryDropdown.SelectedIndexChanged += new System.EventHandler(this.categoryDropdown_SelectedIndexChanged);
            // 
            // viewButton
            // 
            this.viewButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.viewButton.BackColor = System.Drawing.Color.Transparent;
            this.viewButton.BorderRadius = 10;
            this.viewButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.viewButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.viewButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.viewButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.viewButton.FillColor = System.Drawing.Color.Maroon;
            this.viewButton.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewButton.ForeColor = System.Drawing.Color.White;
            this.viewButton.HoverState.FillColor = System.Drawing.Color.IndianRed;
            this.viewButton.Location = new System.Drawing.Point(344, 514);
            this.viewButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.viewButton.Name = "viewButton";
            this.viewButton.PressedColor = System.Drawing.Color.Transparent;
            this.viewButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.viewButton.ShadowDecoration.Enabled = true;
            this.viewButton.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.viewButton.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(10);
            this.viewButton.Size = new System.Drawing.Size(175, 47);
            this.viewButton.TabIndex = 42;
            this.viewButton.Text = "View";
            this.viewButton.Click += new System.EventHandler(this.viewButton_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Maroon;
            this.label5.Location = new System.Drawing.Point(383, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 26);
            this.label5.TabIndex = 44;
            this.label5.Text = "Search";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // searchBox
            // 
            this.searchBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.searchBox.BackColor = System.Drawing.Color.Transparent;
            this.searchBox.BorderColor = System.Drawing.Color.Maroon;
            this.searchBox.BorderRadius = 10;
            this.searchBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchBox.DefaultText = "";
            this.searchBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchBox.FocusedState.BorderColor = System.Drawing.Color.Maroon;
            this.searchBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBox.ForeColor = System.Drawing.Color.Firebrick;
            this.searchBox.HoverState.BorderColor = System.Drawing.Color.Maroon;
            this.searchBox.HoverState.FillColor = System.Drawing.Color.AntiqueWhite;
            this.searchBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("searchBox.IconLeft")));
            this.searchBox.IconLeftOffset = new System.Drawing.Point(7, 0);
            this.searchBox.IconLeftSize = new System.Drawing.Size(17, 17);
            this.searchBox.Location = new System.Drawing.Point(455, 88);
            this.searchBox.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.searchBox.Name = "searchBox";
            this.searchBox.PasswordChar = '\0';
            this.searchBox.PlaceholderForeColor = System.Drawing.Color.Maroon;
            this.searchBox.PlaceholderText = "";
            this.searchBox.SelectedText = "";
            this.searchBox.Size = new System.Drawing.Size(344, 39);
            this.searchBox.TabIndex = 43;
            this.searchBox.TextChanged += new System.EventHandler(this.searchBox_TextChanged);
            // 
            // ProductsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(835, 582);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.searchBox);
            this.Controls.Add(this.viewButton);
            this.Controls.Add(this.categoryDropdown);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.productIdLabel);
            this.Controls.Add(this.productNameLabel);
            this.Controls.Add(this.productPriceLabel);
            this.Controls.Add(this.categoryLabel);
            this.Controls.Add(this.stockLabel);
            this.Controls.Add(this.dataGridview);
            this.Controls.Add(this.insertButton);
            this.Controls.Add(this.stock);
            this.Controls.Add(this.productPrice);
            this.Controls.Add(this.productId);
            this.Controls.Add(this.productName);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ProductsManagement";
            this.Text = "ProductsManagement";
            this.Load += new System.EventHandler(this.ProductsManagement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox productName;
        private Guna.UI2.WinForms.Guna2TextBox productPrice;
        private Guna.UI2.WinForms.Guna2TextBox stock;
        private Guna.UI2.WinForms.Guna2Button insertButton;
        private Guna.UI2.WinForms.Guna2DataGridView dataGridview;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label productPriceLabel;
        private System.Windows.Forms.Label productNameLabel;
        private Guna.UI2.WinForms.Guna2Button updateButton;
        private Guna.UI2.WinForms.Guna2Button deleteButton;
        private System.Windows.Forms.Label categoryLabel;
        private Guna.UI2.WinForms.Guna2TextBox productId;
        private System.Windows.Forms.Label productIdLabel;
        private Guna.UI2.WinForms.Guna2ComboBox categoryDropdown;
        private Guna.UI2.WinForms.Guna2Button viewButton;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox searchBox;
    }
}