using ASP_CRUD_APP.Data;
using ASP_CRUD_APP.Models;
using ASP_CRUD_APP.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASP_CRUD_APP.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public ProductsController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddProductViewModel viewModel)
        {
            var product=new Product
            {
            ProductName=viewModel.ProductName,
            Price=viewModel.Price,
            Quantity=viewModel.Quantity,
            Tags=viewModel.Tags,
            ProductCategories=viewModel.ProductCategories,
            };
            await dbContext.Products.AddAsync(product);
            await dbContext.SaveChangesAsync();
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var products = await dbContext.Products.ToListAsync();
            return View(products);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
        var product=await dbContext.Products.FindAsync(id);
        
        return View(product);
        }
        [HttpPost]
        public async Task <IActionResult> Edit(Product viewModel)
        {
            var product = await dbContext.Products.FindAsync(viewModel.ProductID);
            if(product is not null)
            {
                product.ProductName = viewModel.ProductName;
                product.Price = viewModel.Price;
                product.Quantity = viewModel.Quantity;
                product.Tags = viewModel.Tags;
                product.ProductCategories = viewModel.ProductCategories;
               await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List","Products");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Product viewModel)
        {
            var product = await dbContext.Products.AsNoTracking().FirstOrDefaultAsync(x => x.ProductID == viewModel.ProductID);
            //var product = await dbContext.Products.FindAsync(viewModel.ProductID);
            if(product is not null)
                {
                dbContext.Products.Remove(viewModel);
                await dbContext.SaveChangesAsync();
                }
                return RedirectToAction("List", "Products");
        }
    }
}
