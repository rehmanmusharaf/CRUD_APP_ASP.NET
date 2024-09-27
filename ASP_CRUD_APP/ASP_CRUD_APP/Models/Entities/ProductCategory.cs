namespace ASP_CRUD_APP.Models.Entities
{
    public class ProductCategory
    {
        public int ProductID { get; set; }
        public int CategoryID { get; set; }
        public Product Product { get; set; } // Navigation property
        public Category Category { get; set; } // Navigation property
    }
}
