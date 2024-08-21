using System;
using System.Collections.Generic;
using System.Formats.Asn1;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static DVGB07_Labb4_ERPSYSTEM.WarehouseForm;
using static System.Windows.Forms.DataFormats;

namespace DVGB07_Labb4_ERPSYSTEM
{
    public class ProductManager
    {
        /// <summary>
        /// DVGB07 Labb 4 ERP SYSTEM
        /// Made By Kevin Berling
        /// DATE: 2024-05-17
        /// </summary>
        private List<Product> products;
        public List<Product> Products
        {
            get { return products; }
        }
        private string filePath = "products.csv";

        public ProductManager()
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            products = new List<Product>();
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    // Skip the header line
                    reader.ReadLine();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var values = line.Split(',');
                        var product = new Product
                        {
                            ProductId = int.Parse(values[0]),
                            Name = values[1],
                            Price = decimal.Parse(values[2], CultureInfo.InvariantCulture),
                            Category = values[3],
                            Quantity = int.Parse(values[4])
                        };

                        switch (product.Category.ToLower())
                        {
                            case "videogames":
                                product.Platform = values.ElementAtOrDefault(5);
                                break;
                            case "movies":
                                product.Format = values.ElementAtOrDefault(5);
                                product.Playtime = !string.IsNullOrWhiteSpace(values.ElementAtOrDefault(6)) ? int.Parse(values[6]) : (int?)null;
                                break;
                            case "books":
                                product.Author = values.ElementAtOrDefault(5);
                                product.Genre = values.ElementAtOrDefault(6);
                                product.Format = values.ElementAtOrDefault(7);
                                product.Language = values.ElementAtOrDefault(8);
                                break;
                        }

                        products.Add(product);
                    }
                }
            }
        }

        public void SaveProducts()
        {
            using (var writer = new StreamWriter(filePath))
            {
                writer.WriteLine("ProductId,Name,Price,Category,Quantity,Platform,Format,Playtime,Author,Genre,Language");
                foreach (var product in products)
                {
                    string additionalFields = string.Empty;
                    switch (product.Category.ToLower())
                    {
                        case "videogames":
                            additionalFields = $"{product.Platform},,,";
                            break;
                        case "movies":
                            additionalFields = $"{product.Format},{product.Playtime?.ToString() ?? string.Empty},,,";
                            break;
                        case "books":
                            additionalFields = $",{product.Author},{product.Genre},{product.Format},{product.Language}";
                            break;
                    }
                    writer.WriteLine($"{product.ProductId},{product.Name},{product.Price.ToString(CultureInfo.InvariantCulture)},{product.Category},{product.Quantity},{additionalFields}");
                }
            }
        }
        public (bool isSuccess, int? productId, string message) AddProduct(string name, decimal price, string category, string platform = null, string format = null, int? playtime = null, string author = null, string genre = null, string language = null)
        {
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(category))
            {
                return (false, null, "Please fill all fields.");
            }
            if (price < 0)
            {
                return (false, null, "Price cannot be below 0.");
            }

            var existingProduct = products.FirstOrDefault(p => p.Name.Equals(name, System.StringComparison.OrdinalIgnoreCase));
            if (existingProduct != null)
            {
                return (false, existingProduct.ProductId, "Product already exists.");
            }

            int newProductId = products.Any() ? products.Max(p => p.ProductId) + 1 : 0;
            var newProduct = new Product
            {
                ProductId = newProductId,
                Name = name,
                Price = price,
                Category = category,
                Quantity = 0,
                Platform = platform,
                Format = format,
                Playtime = playtime,
                Author = author,
                Genre = genre,
                Language = language
            };

            products.Add(newProduct);
            SaveProducts();
            return (true, newProductId, "Product added successfully.");
        }

        public Product GetProductID(int productId)
        {
            return products.FirstOrDefault(p => p.ProductId == productId);
        }

        public bool RemoveProduct(int productId)
        {
            var product = products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                return false; // Product not found
            }

            products.Remove(product);
            // Update the IDs of remaining products
            for (int i = productId; i < products.Count; i++)
            {
                products[i].ProductId = i;
            }
            SaveProducts();
            return true;
        }

        public bool UpdateProduct(int productId, decimal? newPrice, int? newQuantity, string newPlatform = null, string newFormat = null, int? newPlaytime = null, string newAuthor = null, string newGenre = null, string newLanguage = null)
        {
            var product = products.FirstOrDefault(p => p.ProductId == productId);
            if (product == null)
            {
                MessageBox.Show("Product not found.");
                return false;
            }

            if (newPrice.HasValue)
            {
                if (newPrice.Value < 0)
                {
                    MessageBox.Show("Price cannot be below 0.");
                    return false;
                }
                product.Price = newPrice.Value;
            }

            if (newQuantity.HasValue)
            {
                if (newQuantity.Value < 0)
                {
                    MessageBox.Show("Quantity cannot be negative.");
                    return false;
                }
                product.Quantity = newQuantity.Value;
            }

            SaveProducts();
            return true;
        }
    }
}
