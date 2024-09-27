namespace ASP_CRUD_APP.Models.Entities
{
    public class Category
    {
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; } // Navigation property

    }
}
