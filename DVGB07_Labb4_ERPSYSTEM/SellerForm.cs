using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace DVGB07_Labb4_ERPSYSTEM
{
    public partial class SellerForm : Form
    {
        /// <summary>
        /// DVGB07 Labb 4 ERP SYSTEM
        /// Made By Kevin Berling
        /// DATE: 2024-04-15
        /// </summary>
        private ProductManager productManager;
        private ShoppingCart cart;

        public SellerForm(ProductManager sharedProductManager)
        {
            InitializeComponent();
            this.productManager = sharedProductManager;
            this.VisibleChanged += SellerForm_VisibleChanged;
            this.FormClosed += SellerForm_FormClosed;
            cart = new ShoppingCart();
        }
        private void SellerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit the application when this form is closed
            Application.Exit();
        }
        private void SellerForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                LoadProductsIntoDgv();  // Assuming SellerForm also has a method to load products into a DataGridView
                UpdateCartDisplay();
            }

        }
        private void LoadProductsIntoDgv()
        {
            dgvProducts.DataSource = null;
            dgvProducts.DataSource = productManager.Products;
            dgvProducts.AutoResizeColumns();
        }

        private void btn_SwapViewWarehouse_Click(object sender, EventArgs e)
        {
            Program.ShowWarehouseForm();
        }

        private void btn_AddToCart_Click(object sender, EventArgs e)
        {
            int productId = GetSelectedProductId(); // Implement this method based on your product selection mechanism
            var product = productManager.GetProductID(productId);
            int quantity = 1; // This could be selected by the user

            ShoppingCartItem newItem = new ShoppingCartItem
            {
                ProductId = product.ProductId,
                ProductName = product.Name,
                Price = product.Price,
                Quantity = quantity
            };

            cart.AddItem(newItem, product.Quantity);
            UpdateCartDisplay();
            LoadProductsIntoDgv();
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            var productId = GetSelectedCartProductId(); // Implement this based on your cart selection mechanism
            cart.RemoveItem(productId);
            UpdateCartDisplay();
            LoadProductsIntoDgv();
        }

        private void btn_ClearCart_Click(object sender, EventArgs e)
        {
            cart.ClearCart();
            UpdateCartDisplay();
            LoadProductsIntoDgv();
        }
        private void UpdateCartDisplay()
        {
            dgvShoppingCart.DataSource = null;
            dgvShoppingCart.DataSource = cart.Items;
            lbl_TotalPrice.Text = $"Total: ${cart.GetTotalPrice():0.00}";
        }

        private int GetSelectedProductId()
        {
            // Example of getting a selected product ID from a DataGridView or another control
            if (dgvProducts.CurrentRow != null)
            {
                return Convert.ToInt32(dgvProducts.CurrentRow.Cells["ProductId"].Value);
            }
            return -1; // or throw an exception as needed
        }

        private int GetSelectedCartProductId()
        {
            if (dgvShoppingCart.CurrentRow != null)
            {
                return Convert.ToInt32(dgvShoppingCart.CurrentRow.Cells["ProductId"].Value);
            }
            return -1; // or throw an exception as needed
        }

        private void btn_CheckOut_Click(object sender, EventArgs e)
        {
            // Check if the shopping cart has items
            if (!cart.Items.Any())
            {
                MessageBox.Show("The shopping cart is empty.", "Checkout Failed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Confirm checkout
            decimal totalCost = cart.GetTotalPrice();
            var result = MessageBox.Show($"Are you sure you want to check out? Total due: ${totalCost}", "Confirm Checkout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                // Attempt to checkout
                if (ProcessCheckout())
                {
                    MessageBox.Show($"Checkout successful. Total paid: ${totalCost}", "Checkout Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadProductsIntoDgv(); // Refresh the product list display
                    cart.ClearCart(); // Clear the cart after checkout
                    UpdateCartDisplay(); // Refresh the cart display
                }
                else
                {
                    MessageBox.Show("Failed to checkout. One or more items could not be updated due to insufficient stock.", "Checkout Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private bool ProcessCheckout()
        {
            // Check and update product quantities
            foreach (var item in cart.Items)
            {
                var product = productManager.GetProductID(item.ProductId);
                if (product == null || product.Quantity < item.Quantity)
                {
                    return false; // Cannot fulfill the order due to stock issues
                }
                product.Quantity -= item.Quantity; // Deduct the item quantity from stock
            }
            productManager.SaveProducts();
            return true;
        }
    }
}
