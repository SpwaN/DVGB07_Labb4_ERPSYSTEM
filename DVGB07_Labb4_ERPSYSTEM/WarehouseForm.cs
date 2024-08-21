namespace DVGB07_Labb4_ERPSYSTEM
{
    public partial class WarehouseForm : Form
    {
        /// <summary>
        /// DVGB07 Labb 4 ERP SYSTEM
        /// Made By Kevin Berling
        /// DATE: 2024-04-15
        /// </summary>
        public class Product
        {
            public int ProductId { get; set; }
            public string Name { get; set; }
            public decimal Price { get; set; }
            public string Category { get; set; }
            public int Quantity { get; set; }

            // Additional fields for different categories
            public string Platform { get; set; } // For Games
            public string Format { get; set; } // For Movies and Books
            public int? Playtime { get; set; } // For Movies
            public string Author { get; set; } // For Books
            public string Genre { get; set; } // For Books
            public string Language { get; set; } // For Books
        }

        private ProductManager productManager;

        public WarehouseForm(ProductManager sharedProductManager)
        {
            InitializeComponent();
            this.productManager = sharedProductManager;
            this.VisibleChanged += WarehouseForm_VisibleChanged;
            this.FormClosed += WarehouseForm_FormClosed;

            ToggleAdditionalFields(false);
            cbx_ProductCategory.SelectedIndexChanged += cbx_ProductCategory_SelectedIndexChanged;
        }
        private void WarehouseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Exit the application when this form is closed
            Application.Exit();
        }
        private void WarehouseForm_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
                LoadProductsIntoDgv();
        }
        private void ToggleAdditionalFields(bool isVisible)
        {
            lbl_Platform.Visible = isVisible;
            tbx_ProductPlatform.Visible = isVisible;
            lbl_Format.Visible = isVisible;
            tbx_ProductFormat.Visible = isVisible;
            lbl_Playtime.Visible = isVisible;
            tbx_ProductPlaytime.Visible = isVisible;
            lbl_Author.Visible = isVisible;
            tbx_ProductAuthor.Visible = isVisible;
            lbl_Genre.Visible = isVisible;
            tbx_ProductGenre.Visible = isVisible;
            lbl_Language.Visible = isVisible;
            tbx_ProductLanguage.Visible = isVisible;
        }
        private void LoadProductsIntoDgv()
        {
            dgvProducts.DataSource = null;  // Detach the data source
            dgvProducts.DataSource = productManager.Products;
            dgvProducts.AutoResizeColumns();
        }
        private void cbx_ProductCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = cbx_ProductCategory.SelectedItem.ToString().ToLower();

            // Hide all additional fields initially
            ToggleAdditionalFields(false);

                // Show relevant fields based on the selected category
                switch (selectedCategory)
            {
                case "videogames":
                    lbl_Platform.Visible = true;
                    tbx_ProductPlatform.Visible = true;
                    break;
                case "movies":
                    lbl_Format.Visible = true;
                    tbx_ProductFormat.Visible = true;
                    lbl_Playtime.Visible = true;
                    tbx_ProductPlaytime.Visible = true;
                    break;
                case "books":
                    lbl_Author.Visible = true;
                    tbx_ProductAuthor.Visible = true;
                    lbl_Genre.Visible = true;
                    tbx_ProductGenre.Visible = true;
                    lbl_Format.Visible = true;
                    tbx_ProductFormat.Visible = true;
                    lbl_Language.Visible = true;
                    tbx_ProductLanguage.Visible = true;
                    break;
            }
            AdjustAddItemButtonPosition();
        }

        private void AdjustAddItemButtonPosition()
        {
            //Control position https://learn.microsoft.com/en-us/dotnet/desktop/winforms/controls/how-to-position-controls-on-windows-forms?view=netframeworkdesktop-4.8

            Control[] controls = { tbx_ProductPlatform, tbx_ProductFormat, tbx_ProductPlaytime, tbx_ProductAuthor, tbx_ProductGenre, tbx_ProductLanguage };
            Control lastVisibleControl = null;

            foreach (var control in controls)
            {
                if (control.Visible)
                {
                    lastVisibleControl = control;
                }
            }

            if (lastVisibleControl != null)
            {
                // Move the button to the right of the last visible control
                btn_AddItem.Location = new Point(lastVisibleControl.Right + 10, lastVisibleControl.Top);
            }
            else
            {
                // Default position if no additional fields are visible
                btn_AddItem.Location = new Point(cbx_ProductCategory.Right + 10, cbx_ProductCategory.Top);
            }
        }

        private void btn_AddItem_Click(object sender, EventArgs e)
        {
            string name = tbx_ProductName.Text;
            if (!decimal.TryParse(tbx_ProductPrice.Text, out decimal price))
            {
                MessageBox.Show("Invalid price format. Please enter a valid number.");
                return;
            }
            string category = cbx_ProductCategory.Text;

            string platform = tbx_ProductPlatform.Text;
            string format = tbx_ProductFormat.Text;
            int? playtime = null;
            if (!string.IsNullOrWhiteSpace(tbx_ProductPlaytime.Text))
            {
                if (!int.TryParse(tbx_ProductPlaytime.Text, out int playtimeValue))
                {
                    MessageBox.Show("Playtime must be a valid number.");
                    return;
                }
                if (playtimeValue <= 0 || playtimeValue > 400)
                {
                    MessageBox.Show("Playtime must be a positive number and not exceed 400.");
                    return;
                }
                playtime = playtimeValue;
            }

            string author = tbx_ProductAuthor.Text;
            string genre = tbx_ProductGenre.Text;
            string language = tbx_ProductLanguage.Text;

            var (isSuccess, productId, message) = productManager.AddProduct(name, price, category, platform, format, playtime, author, genre, language);
            MessageBox.Show(message);
            LoadProductsIntoDgv();
            ClearInputFields();
        }

        private void btn_DeleteItem_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbx_DeleteProductID.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            var product = productManager.GetProductID(productId);
            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            var result = MessageBox.Show($"Are you sure you want to remove {product.Name} with {product.Quantity} items?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (productManager.RemoveProduct(productId))
                {
                    MessageBox.Show("Item removed successfully.");
                }
                else
                {
                    MessageBox.Show("Error removing item.");
                }
            }
            LoadProductsIntoDgv();
        }
        private void ClearInputFields()
        {
            tbx_ProductName.Clear();
            tbx_ProductPrice.Clear();
            tbx_ProductPlatform.Clear();
            tbx_ProductFormat.Clear();
            tbx_ProductPlaytime.Clear();
            tbx_ProductAuthor.Clear();
            tbx_ProductGenre.Clear();
            tbx_ProductLanguage.Clear();
        }

        private void btn_UpdateItemQuantity_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(tbx_UpdateProductID.Text, out int productId))
            {
                MessageBox.Show("Please enter a valid Product ID.");
                return;
            }

            decimal? newPrice = null;
            // Check if the price text box is not empty
            if (!string.IsNullOrWhiteSpace(tbx_UpdateItemPrice.Text))
            {
                // Try to parse the price, and if successful, assign it
                if (decimal.TryParse(tbx_UpdateItemPrice.Text, out decimal priceValue))
                {
                    newPrice = priceValue;
                }
                else
                {
                    MessageBox.Show("Invalid price format.");
                    return;
                }
            }

            int? newQuantity = null;
            // Check if the quantity text box is not empty
            if (!string.IsNullOrWhiteSpace(tbx_UpdateItemQuantity.Text))
            {
                // Try to parse the quantity, and if successful, assign it
                if (int.TryParse(tbx_UpdateItemQuantity.Text, out int quantityValue))
                {
                    newQuantity = quantityValue;
                }
                else
                {
                    MessageBox.Show("Invalid quantity format.");
                    return;
                }
            }

            if (!newPrice.HasValue && !newQuantity.HasValue)
            {
                MessageBox.Show("No valid price or quantity entered.");
                return;
            }

            var product = productManager.GetProductID(productId);
            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return;
            }

            if (productManager.UpdateProduct(productId, newPrice, newQuantity))
            {
                string updateMessage = $"Product {product.Name} with Product ID {productId} ";
                if (newPrice.HasValue)
                    updateMessage += $"now has a new price of {newPrice.Value}. ";
                if (newQuantity.HasValue)
                    updateMessage += $"now has a new quantity of {newQuantity.Value}. ";
                MessageBox.Show(updateMessage, "Update Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error updating product details.");
            }
            LoadProductsIntoDgv();
        }
        private void btn_SwapViewSeller_Click(object sender, EventArgs e)
        {
            Program.ShowSellerForm();
        }
    }
}
