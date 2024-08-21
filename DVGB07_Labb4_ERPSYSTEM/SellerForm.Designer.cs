namespace DVGB07_Labb4_ERPSYSTEM
{
    partial class SellerForm
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
            btn_SwapViewWarehouse = new Button();
            dgvShoppingCart = new DataGridView();
            btn_AddToCart = new Button();
            btn_Remove = new Button();
            btn_ClearCart = new Button();
            lbl_TotalPrice = new Label();
            dgvProducts = new DataGridView();
            btn_CheckOut = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // btn_SwapViewWarehouse
            // 
            btn_SwapViewWarehouse.Location = new Point(549, 12);
            btn_SwapViewWarehouse.Name = "btn_SwapViewWarehouse";
            btn_SwapViewWarehouse.Size = new Size(119, 23);
            btn_SwapViewWarehouse.TabIndex = 0;
            btn_SwapViewWarehouse.Text = "Warehouse View";
            btn_SwapViewWarehouse.UseVisualStyleBackColor = true;
            btn_SwapViewWarehouse.Click += btn_SwapViewWarehouse_Click;
            // 
            // dgvShoppingCart
            // 
            dgvShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoppingCart.Location = new Point(12, 259);
            dgvShoppingCart.Name = "dgvShoppingCart";
            dgvShoppingCart.Size = new Size(520, 288);
            dgvShoppingCart.TabIndex = 1;
            // 
            // btn_AddToCart
            // 
            btn_AddToCart.Location = new Point(549, 53);
            btn_AddToCart.Name = "btn_AddToCart";
            btn_AddToCart.Size = new Size(98, 23);
            btn_AddToCart.TabIndex = 2;
            btn_AddToCart.Text = "Add to Cart";
            btn_AddToCart.UseVisualStyleBackColor = true;
            btn_AddToCart.Click += btn_AddToCart_Click;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(549, 82);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(98, 23);
            btn_Remove.TabIndex = 3;
            btn_Remove.Text = "Remove";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // btn_ClearCart
            // 
            btn_ClearCart.Location = new Point(549, 111);
            btn_ClearCart.Name = "btn_ClearCart";
            btn_ClearCart.Size = new Size(98, 23);
            btn_ClearCart.TabIndex = 4;
            btn_ClearCart.Text = "Clear Cart";
            btn_ClearCart.UseVisualStyleBackColor = true;
            btn_ClearCart.Click += btn_ClearCart_Click;
            // 
            // lbl_TotalPrice
            // 
            lbl_TotalPrice.AutoSize = true;
            lbl_TotalPrice.Location = new Point(12, 550);
            lbl_TotalPrice.Name = "lbl_TotalPrice";
            lbl_TotalPrice.Size = new Size(35, 15);
            lbl_TotalPrice.TabIndex = 5;
            lbl_TotalPrice.Text = "Total:";
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Location = new Point(12, 12);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(520, 231);
            dgvProducts.TabIndex = 6;
            // 
            // btn_CheckOut
            // 
            btn_CheckOut.Location = new Point(549, 524);
            btn_CheckOut.Name = "btn_CheckOut";
            btn_CheckOut.Size = new Size(98, 23);
            btn_CheckOut.TabIndex = 7;
            btn_CheckOut.Text = "Checkout";
            btn_CheckOut.UseVisualStyleBackColor = true;
            btn_CheckOut.Click += btn_CheckOut_Click;
            // 
            // SellerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(685, 573);
            Controls.Add(btn_CheckOut);
            Controls.Add(dgvProducts);
            Controls.Add(lbl_TotalPrice);
            Controls.Add(btn_ClearCart);
            Controls.Add(btn_Remove);
            Controls.Add(btn_AddToCart);
            Controls.Add(dgvShoppingCart);
            Controls.Add(btn_SwapViewWarehouse);
            Name = "SellerForm";
            Text = "Seller View";
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_SwapViewWarehouse;
        private DataGridView dgvShoppingCart;
        private Button btn_AddToCart;
        private Button btn_Remove;
        private Button btn_ClearCart;
        private Label lbl_TotalPrice;
        private DataGridView dgvProducts;
        private Button btn_CheckOut;
    }
}