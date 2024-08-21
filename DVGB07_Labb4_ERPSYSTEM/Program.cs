namespace DVGB07_Labb4_ERPSYSTEM
{
    internal static class Program
    {
        /// <summary>
        /// DVGB07 Labb 4 ERP SYSTEM
        /// Made By Kevin Berling
        /// DATE: 2024-04-15
        /// </summary>
        /// 
        // Declare the form instances at the class level
        public static WarehouseForm warehouseForm;
        public static SellerForm sellerForm;
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationConfiguration.Initialize();
            // Create an instance of ProductManager
            ProductManager productManager = new ProductManager();
            // Instantiate the forms with the shared ProductManager
            warehouseForm = new WarehouseForm(productManager);
            sellerForm = new SellerForm(productManager);
            Application.Run(warehouseForm);
        }
        public static void ShowWarehouseForm()
        {
            sellerForm.Hide();
            warehouseForm.Show();
        }

        // Method to switch to SellerForm
        public static void ShowSellerForm()
        {
            warehouseForm.Hide();
            sellerForm.Show();
        }
    }
}