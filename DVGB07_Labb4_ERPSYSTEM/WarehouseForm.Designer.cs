namespace DVGB07_Labb4_ERPSYSTEM
{
    partial class WarehouseForm
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
            btn_AddItem = new Button();
            tbx_ProductName = new TextBox();
            tbx_ProductPrice = new TextBox();
            lbl_ProductName = new Label();
            lbl_ProductPrice = new Label();
            lbl_ProductCategory = new Label();
            lbl_DeleteProductID = new Label();
            tbx_DeleteProductID = new TextBox();
            btn_DeleteItem = new Button();
            lbl_UpdateProductID = new Label();
            tbx_UpdateItemQuantity = new TextBox();
            btn_UpdateItemQuantity = new Button();
            tbx_UpdateProductID = new TextBox();
            lbl_UpdateProductQuantity = new Label();
            cbx_ProductCategory = new ComboBox();
            label1 = new Label();
            tbx_UpdateItemPrice = new TextBox();
            dgvProducts = new DataGridView();
            btn_SwapViewSeller = new Button();
            tbx_ProductPlatform = new TextBox();
            tbx_ProductFormat = new TextBox();
            tbx_ProductPlaytime = new TextBox();
            tbx_ProductAuthor = new TextBox();
            tbx_ProductGenre = new TextBox();
            tbx_ProductLanguage = new TextBox();
            lbl_Platform = new Label();
            lbl_Format = new Label();
            lbl_Playtime = new Label();
            lbl_Author = new Label();
            lbl_Genre = new Label();
            lbl_Language = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btn_AddItem
            // 
            btn_AddItem.Location = new Point(330, 29);
            btn_AddItem.Name = "btn_AddItem";
            btn_AddItem.Size = new Size(75, 23);
            btn_AddItem.TabIndex = 0;
            btn_AddItem.Text = "Add Item";
            btn_AddItem.UseVisualStyleBackColor = true;
            btn_AddItem.Click += btn_AddItem_Click;
            // 
            // tbx_ProductName
            // 
            tbx_ProductName.Location = new Point(12, 25);
            tbx_ProductName.Name = "tbx_ProductName";
            tbx_ProductName.Size = new Size(100, 23);
            tbx_ProductName.TabIndex = 1;
            // 
            // tbx_ProductPrice
            // 
            tbx_ProductPrice.Location = new Point(118, 26);
            tbx_ProductPrice.Name = "tbx_ProductPrice";
            tbx_ProductPrice.Size = new Size(100, 23);
            tbx_ProductPrice.TabIndex = 2;
            // 
            // lbl_ProductName
            // 
            lbl_ProductName.AutoSize = true;
            lbl_ProductName.Location = new Point(12, 7);
            lbl_ProductName.Name = "lbl_ProductName";
            lbl_ProductName.Size = new Size(52, 15);
            lbl_ProductName.TabIndex = 4;
            lbl_ProductName.Text = "Name(*)";
            // 
            // lbl_ProductPrice
            // 
            lbl_ProductPrice.AutoSize = true;
            lbl_ProductPrice.Location = new Point(118, 7);
            lbl_ProductPrice.Name = "lbl_ProductPrice";
            lbl_ProductPrice.Size = new Size(46, 15);
            lbl_ProductPrice.TabIndex = 5;
            lbl_ProductPrice.Text = "Price(*)";
            // 
            // lbl_ProductCategory
            // 
            lbl_ProductCategory.AutoSize = true;
            lbl_ProductCategory.Location = new Point(224, 8);
            lbl_ProductCategory.Name = "lbl_ProductCategory";
            lbl_ProductCategory.Size = new Size(68, 15);
            lbl_ProductCategory.TabIndex = 6;
            lbl_ProductCategory.Text = "Category(*)";
            // 
            // lbl_DeleteProductID
            // 
            lbl_DeleteProductID.AutoSize = true;
            lbl_DeleteProductID.Location = new Point(12, 104);
            lbl_DeleteProductID.Name = "lbl_DeleteProductID";
            lbl_DeleteProductID.Size = new Size(63, 15);
            lbl_DeleteProductID.TabIndex = 9;
            lbl_DeleteProductID.Text = "Product ID";
            // 
            // tbx_DeleteProductID
            // 
            tbx_DeleteProductID.Location = new Point(12, 122);
            tbx_DeleteProductID.Name = "tbx_DeleteProductID";
            tbx_DeleteProductID.Size = new Size(100, 23);
            tbx_DeleteProductID.TabIndex = 8;
            // 
            // btn_DeleteItem
            // 
            btn_DeleteItem.Location = new Point(118, 122);
            btn_DeleteItem.Name = "btn_DeleteItem";
            btn_DeleteItem.Size = new Size(75, 23);
            btn_DeleteItem.TabIndex = 7;
            btn_DeleteItem.Text = "Delete Item";
            btn_DeleteItem.UseVisualStyleBackColor = true;
            btn_DeleteItem.Click += btn_DeleteItem_Click;
            // 
            // lbl_UpdateProductID
            // 
            lbl_UpdateProductID.AutoSize = true;
            lbl_UpdateProductID.Location = new Point(12, 54);
            lbl_UpdateProductID.Name = "lbl_UpdateProductID";
            lbl_UpdateProductID.Size = new Size(63, 15);
            lbl_UpdateProductID.TabIndex = 12;
            lbl_UpdateProductID.Text = "Product ID";
            // 
            // tbx_UpdateItemQuantity
            // 
            tbx_UpdateItemQuantity.Location = new Point(118, 73);
            tbx_UpdateItemQuantity.Name = "tbx_UpdateItemQuantity";
            tbx_UpdateItemQuantity.Size = new Size(100, 23);
            tbx_UpdateItemQuantity.TabIndex = 11;
            // 
            // btn_UpdateItemQuantity
            // 
            btn_UpdateItemQuantity.Location = new Point(330, 73);
            btn_UpdateItemQuantity.Name = "btn_UpdateItemQuantity";
            btn_UpdateItemQuantity.Size = new Size(75, 23);
            btn_UpdateItemQuantity.TabIndex = 10;
            btn_UpdateItemQuantity.Text = "Update Item";
            btn_UpdateItemQuantity.UseVisualStyleBackColor = true;
            btn_UpdateItemQuantity.Click += btn_UpdateItemQuantity_Click;
            // 
            // tbx_UpdateProductID
            // 
            tbx_UpdateProductID.Location = new Point(12, 73);
            tbx_UpdateProductID.Name = "tbx_UpdateProductID";
            tbx_UpdateProductID.Size = new Size(100, 23);
            tbx_UpdateProductID.TabIndex = 13;
            // 
            // lbl_UpdateProductQuantity
            // 
            lbl_UpdateProductQuantity.AutoSize = true;
            lbl_UpdateProductQuantity.Location = new Point(118, 55);
            lbl_UpdateProductQuantity.Name = "lbl_UpdateProductQuantity";
            lbl_UpdateProductQuantity.Size = new Size(53, 15);
            lbl_UpdateProductQuantity.TabIndex = 14;
            lbl_UpdateProductQuantity.Text = "Quantity";
            // 
            // cbx_ProductCategory
            // 
            cbx_ProductCategory.DropDownStyle = ComboBoxStyle.DropDownList;
            cbx_ProductCategory.FormattingEnabled = true;
            cbx_ProductCategory.Items.AddRange(new object[] { "Videogames", "Books", "Movies" });
            cbx_ProductCategory.Location = new Point(224, 27);
            cbx_ProductCategory.MaxDropDownItems = 3;
            cbx_ProductCategory.Name = "cbx_ProductCategory";
            cbx_ProductCategory.Size = new Size(100, 23);
            cbx_ProductCategory.TabIndex = 15;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 55);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 17;
            label1.Text = "Price";
            // 
            // tbx_UpdateItemPrice
            // 
            tbx_UpdateItemPrice.Location = new Point(224, 73);
            tbx_UpdateItemPrice.Name = "tbx_UpdateItemPrice";
            tbx_UpdateItemPrice.Size = new Size(100, 23);
            tbx_UpdateItemPrice.TabIndex = 16;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 151);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(845, 253);
            dgvProducts.TabIndex = 18;
            // 
            // btn_SwapViewSeller
            // 
            btn_SwapViewSeller.Location = new Point(782, 4);
            btn_SwapViewSeller.Name = "btn_SwapViewSeller";
            btn_SwapViewSeller.Size = new Size(75, 23);
            btn_SwapViewSeller.TabIndex = 19;
            btn_SwapViewSeller.Text = "Seller View";
            btn_SwapViewSeller.UseVisualStyleBackColor = true;
            btn_SwapViewSeller.Click += btn_SwapViewSeller_Click;
            // 
            // tbx_ProductPlatform
            // 
            tbx_ProductPlatform.Location = new Point(330, 28);
            tbx_ProductPlatform.Name = "tbx_ProductPlatform";
            tbx_ProductPlatform.Size = new Size(100, 23);
            tbx_ProductPlatform.TabIndex = 20;
            // 
            // tbx_ProductFormat
            // 
            tbx_ProductFormat.Location = new Point(330, 29);
            tbx_ProductFormat.Name = "tbx_ProductFormat";
            tbx_ProductFormat.Size = new Size(100, 23);
            tbx_ProductFormat.TabIndex = 21;
            // 
            // tbx_ProductPlaytime
            // 
            tbx_ProductPlaytime.Location = new Point(436, 28);
            tbx_ProductPlaytime.Name = "tbx_ProductPlaytime";
            tbx_ProductPlaytime.Size = new Size(100, 23);
            tbx_ProductPlaytime.TabIndex = 22;
            // 
            // tbx_ProductAuthor
            // 
            tbx_ProductAuthor.Location = new Point(436, 29);
            tbx_ProductAuthor.Name = "tbx_ProductAuthor";
            tbx_ProductAuthor.Size = new Size(100, 23);
            tbx_ProductAuthor.TabIndex = 23;
            // 
            // tbx_ProductGenre
            // 
            tbx_ProductGenre.Location = new Point(542, 28);
            tbx_ProductGenre.Name = "tbx_ProductGenre";
            tbx_ProductGenre.Size = new Size(100, 23);
            tbx_ProductGenre.TabIndex = 24;
            // 
            // tbx_ProductLanguage
            // 
            tbx_ProductLanguage.Location = new Point(648, 28);
            tbx_ProductLanguage.Name = "tbx_ProductLanguage";
            tbx_ProductLanguage.Size = new Size(100, 23);
            tbx_ProductLanguage.TabIndex = 25;
            // 
            // lbl_Platform
            // 
            lbl_Platform.AutoSize = true;
            lbl_Platform.Location = new Point(330, 8);
            lbl_Platform.Name = "lbl_Platform";
            lbl_Platform.Size = new Size(53, 15);
            lbl_Platform.TabIndex = 26;
            lbl_Platform.Text = "Platform";
            // 
            // lbl_Format
            // 
            lbl_Format.AutoSize = true;
            lbl_Format.Location = new Point(330, 9);
            lbl_Format.Name = "lbl_Format";
            lbl_Format.Size = new Size(45, 15);
            lbl_Format.TabIndex = 27;
            lbl_Format.Text = "Format";
            // 
            // lbl_Playtime
            // 
            lbl_Playtime.AutoSize = true;
            lbl_Playtime.Location = new Point(436, 9);
            lbl_Playtime.Name = "lbl_Playtime";
            lbl_Playtime.Size = new Size(53, 15);
            lbl_Playtime.TabIndex = 28;
            lbl_Playtime.Text = "Playtime";
            // 
            // lbl_Author
            // 
            lbl_Author.AutoSize = true;
            lbl_Author.Location = new Point(436, 9);
            lbl_Author.Name = "lbl_Author";
            lbl_Author.Size = new Size(44, 15);
            lbl_Author.TabIndex = 29;
            lbl_Author.Text = "Author";
            // 
            // lbl_Genre
            // 
            lbl_Genre.AutoSize = true;
            lbl_Genre.Location = new Point(542, 9);
            lbl_Genre.Name = "lbl_Genre";
            lbl_Genre.Size = new Size(38, 15);
            lbl_Genre.TabIndex = 30;
            lbl_Genre.Text = "Genre";
            // 
            // lbl_Language
            // 
            lbl_Language.AutoSize = true;
            lbl_Language.Location = new Point(648, 7);
            lbl_Language.Name = "lbl_Language";
            lbl_Language.Size = new Size(59, 15);
            lbl_Language.TabIndex = 31;
            lbl_Language.Text = "Language";
            // 
            // WarehouseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 416);
            Controls.Add(lbl_Language);
            Controls.Add(lbl_Genre);
            Controls.Add(lbl_Author);
            Controls.Add(lbl_Playtime);
            Controls.Add(lbl_Format);
            Controls.Add(lbl_Platform);
            Controls.Add(tbx_ProductLanguage);
            Controls.Add(tbx_ProductGenre);
            Controls.Add(tbx_ProductAuthor);
            Controls.Add(tbx_ProductPlaytime);
            Controls.Add(tbx_ProductFormat);
            Controls.Add(tbx_ProductPlatform);
            Controls.Add(btn_SwapViewSeller);
            Controls.Add(btn_DeleteItem);
            Controls.Add(btn_AddItem);
            Controls.Add(dgvProducts);
            Controls.Add(label1);
            Controls.Add(lbl_ProductName);
            Controls.Add(tbx_ProductName);
            Controls.Add(btn_UpdateItemQuantity);
            Controls.Add(tbx_UpdateItemPrice);
            Controls.Add(lbl_DeleteProductID);
            Controls.Add(tbx_ProductPrice);
            Controls.Add(tbx_UpdateItemQuantity);
            Controls.Add(cbx_ProductCategory);
            Controls.Add(tbx_DeleteProductID);
            Controls.Add(lbl_UpdateProductID);
            Controls.Add(lbl_UpdateProductQuantity);
            Controls.Add(lbl_ProductCategory);
            Controls.Add(lbl_ProductPrice);
            Controls.Add(tbx_UpdateProductID);
            Name = "WarehouseForm";
            Text = "ERP SYSTEM";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_AddItem;
        private TextBox tbx_ProductName;
        private TextBox tbx_ProductPrice;
        private Label lbl_ProductName;
        private Label lbl_ProductPrice;
        private Label lbl_ProductCategory;
        private Label lbl_DeleteProductID;
        private TextBox tbx_DeleteProductID;
        private Button btn_DeleteItem;
        private Label lbl_UpdateProductID;
        private TextBox tbx_UpdateItemQuantity;
        private Button btn_UpdateItemQuantity;
        private TextBox tbx_UpdateProductID;
        private Label lbl_UpdateProductQuantity;
        private ComboBox cbx_ProductCategory;
        private Label label1;
        private TextBox tbx_UpdateItemPrice;
        private DataGridView dgvProducts;
        private Button btn_SwapViewSeller;
        private TextBox tbx_ProductPlatform;
        private TextBox tbx_ProductFormat;
        private TextBox tbx_ProductPlaytime;
        private TextBox tbx_ProductAuthor;
        private TextBox tbx_ProductGenre;
        private TextBox tbx_ProductLanguage;
        private Label lbl_Platform;
        private Label lbl_Format;
        private Label lbl_Playtime;
        private Label lbl_Author;
        private Label lbl_Genre;
        private Label lbl_Language;
    }
}
