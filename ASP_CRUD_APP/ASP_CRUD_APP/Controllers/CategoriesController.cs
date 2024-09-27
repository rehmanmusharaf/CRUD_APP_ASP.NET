using ASP_CRUD_APP.Models.Entities;
using ASP_CRUD_APP.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ASP_CRUD_APP.Data;

namespace ASP_CRUD_APP.Controllers
{
    public class CategoriesController : Controller
    {
        private readonly ApplicationDbContext dbContext;

        public CategoriesController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        [HttpGet]
        public IActionResult Add( )
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Add(AddCategoryViewModel viewModel)
        {
            var product = new Category
            {
                CategoryName = viewModel.CategoryName,
            };
            await dbContext.Categories.AddAsync(product);
            await dbContext.SaveChangesAsync();
            return RedirectToAction("List", "Categories");
                //return View();
        }
        [HttpGet]
        public async Task<IActionResult> List()
        {
            var categories = await dbContext.Categories.ToListAsync();
            return View(categories);
        }
        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var category = await dbContext.Categories.FindAsync(id);
            return View(category);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Category viewModel)
        {
            var Category = await dbContext.Categories.FindAsync(viewModel.CategoryID);
            if (Category is not null)
            {
                Category.CategoryName = viewModel.CategoryName;
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Categories");
        }
        [HttpPost]
        public async Task<IActionResult> Delete(Category viewModel)
        {
            var category = await dbContext.Categories.AsNoTracking().FirstOrDefaultAsync(x => x.CategoryID == viewModel.CategoryID);
            //var product = await dbContext.Products.FindAsync(viewModel.ProductID);
            if (category is not null)
            {
                dbContext.Categories.Remove(viewModel);
                await dbContext.SaveChangesAsync();
            }
            return RedirectToAction("List", "Categories");
        }


    }
}
