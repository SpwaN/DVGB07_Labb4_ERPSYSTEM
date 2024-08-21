using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace DVGB07_Labb4_ERPSYSTEM
{
    /// <summary>
    /// DVGB07 Labb 4 ERP SYSTEM
    /// Made By Kevin Berling
    /// DATE: 2024-04-15
    /// </summary>
    public class ShoppingCartItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }

    public class ShoppingCart
    {
        public List<ShoppingCartItem> Items { get; private set; }

        public ShoppingCart()
        {
            Items = new List<ShoppingCartItem>();
            LoadCartFromCSV();
        }
        private void LoadCartFromCSV()
        {
            string filePath = "tempCart.csv";
            if (File.Exists(filePath))
            {
                using (var reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var data = line.Split(',');
                        if (data.Length == 4)
                        {
                            ShoppingCartItem item = new ShoppingCartItem
                            {
                                ProductId = int.Parse(data[0]),
                                ProductName = data[1],
                                Price = decimal.Parse(data[2]),
                                Quantity = int.Parse(data[3])
                            };
                            Items.Add(item);
                        }
                    }
                }
            }
        }
        private void SaveCartToCSV()
        {
            string filePath = "tempCart.csv";
            using (var writer = new StreamWriter(filePath, false))  // false to overwrite the file
            {
                foreach (var item in Items)
                {
                    writer.WriteLine($"{item.ProductId},{item.ProductName},{item.Price},{item.Quantity}");
                }
            }
        }
        public void AddItem(ShoppingCartItem item, int maxAvailableQuantity)
        {
            var existingItem = Items.FirstOrDefault(i => i.ProductId == item.ProductId);
            if (existingItem != null)
            {
                if (existingItem.Quantity + item.Quantity > maxAvailableQuantity)
                {
                    MessageBox.Show($"Cannot add more {item.ProductName}. Only {maxAvailableQuantity - existingItem.Quantity} more are available.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                if (item.Quantity > maxAvailableQuantity)
                {
                    MessageBox.Show($"Cannot add {item.Quantity} {item.ProductName} as only {maxAvailableQuantity} are available.", "Insufficient Stock", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                Items.Add(item);
            }
            SaveCartToCSV();
        }

        public void RemoveItem(int productId)
        {
            var item = Items.FirstOrDefault(i => i.ProductId == productId);
            if (item != null)
            {
                item.Quantity -= 1;
                if (item.Quantity <= 0)
                {
                    Items.Remove(item);
                }
            }
            SaveCartToCSV();
        }

        public decimal GetTotalPrice()
        {
            return Items.Sum(i => i.Price * i.Quantity);
        }

        public void ClearCart()
        {
            Items.Clear();
            SaveCartToCSV();
        }
    }
}
