namespace ASP_CRUD_APP.Models.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public string Tags { get; set; } // Store as a comma-separated string
        public ICollection<ProductCategory> ProductCategories { get; set; } // Navigation property

    }
}
